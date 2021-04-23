DROP DATABASE IF EXISTS bd_celular;
CREATE DATABASE bd_celular;
USE bd_celular;

CREATE TABLE tb_cep
(
cod_cep MEDIUMINT UNSIGNED PRIMARY KEY AUTO_INCREMENT,
cep CHAR(9) NOT NULL UNIQUE, 
logra VARCHAR(60) NOT NULL,
bairro VARCHAR(30) NOT NULL,
cidade VARCHAR(30) NOT NULL,
uf CHAR(2)
);

CREATE TABLE tb_clientes
(
cod_cliente MEDIUMINT UNSIGNED PRIMARY KEY AUTO_INCREMENT,
cod_cep MEDIUMINT UNSIGNED NULL REFERENCES tb_cep(cod_cep),
nome_cliente VARCHAR(100) NOT NULL,
tel_cliente CHAR(13) NULL,
cel_cliente CHAR(14) NULL,
telcom_cliente CHAR(14) NULL,
cpf_cliente CHAR(14) NULL UNIQUE,
rg_cliente VARCHAR(20) NULL,
email_cliente VARCHAR(80) NULL,
num_cliente VARCHAR(5) NULL,
comp_cliente VARCHAR(30) NULL
);

CREATE TABLE tb_marcas
(
cod_marca SMALLINT UNSIGNED PRIMARY KEY AUTO_INCREMENT,
marca VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE tb_aparelho
(
cod_aparelho MEDIUMINT UNSIGNED PRIMARY KEY AUTO_INCREMENT,
cod_marca SMALLINT UNSIGNED NOT NULL REFERENCES tb_marcas(cod_marca),
tipo_aparelho TINYINT NOT NULL,
modelo_aparelho VARCHAR(150) NOT NULL,
CONSTRAINT UNIQUE_APARELHO UNIQUE(cod_marca, modelo_aparelho)
);

CREATE TABLE tb_cores
(
cod_cor TINYINT PRIMARY KEY AUTO_INCREMENT,
cor VARCHAR(30) NOT NULL UNIQUE
);

CREATE TABLE tb_ordemservico
(
cod_ordem MEDIUMINT UNSIGNED PRIMARY KEY AUTO_INCREMENT,
cod_cliente MEDIUMINT UNSIGNED NOT NULL REFERENCES tb_clientes(cod_cliente),
cod_aparelho MEDIUMINT UNSIGNED NOT NULL REFERENCES tb_aparelho(cod_aparelho),
cod_cor TINYINT NOT NULL REFERENCES tb_cores(cod_cor),
tampa BIT NOT NULL,
bateria BIT NOT NULL,
cartaosd BIT NOT NULL,
capa BIT NOT NULL,
cartaosim BIT NOT NULL,
imei1_aparelho CHAR(15) NULL,
imei2_aparelho CHAR(15) NULL,
rec_aparelho VARCHAR(70) NOT NULL,
obs_aparelho VARCHAR(100) NULL,
orc_descricao VARCHAR(70) NULL,
orc_preco DECIMAL(10,2) NOT NULL,
reg_entrada DATETIME NOT NULL,
reg_saida DATETIME NULL,
status_os TINYINT NOT NULL
);

CREATE TABLE tb_grupo
(
cod_grupo SMALLINT UNSIGNED PRIMARY KEY AUTO_INCREMENT,
nome_grupo VARCHAR(100) UNIQUE NOT NULL
);

CREATE TABLE tb_produtos
(
cod_produto MEDIUMINT UNSIGNED PRIMARY KEY AUTO_INCREMENT,
cod_grupo SMALLINT UNSIGNED NOT NULL REFERENCES tb_grupo(cod_grupo),
preco_produto DECIMAL(10,2) NOT NULL,
precocusto_produto DECIMAL(10,2) NOT NULL,
qtd_produto SMALLINT NOT NULL,
qtdmin_produto SMALLINT NOT NULL,
desc_produto VARCHAR(50) NOT NULL,
codigo_barras VARCHAR(100) NULL UNIQUE
);

CREATE TABLE tb_caixa
(
cod_caixa MEDIUMINT UNSIGNED PRIMARY KEY AUTO_INCREMENT,
reg_caixa DATE NOT NULL UNIQUE
);

CREATE TABLE tb_vendas
(
cod_venda MEDIUMINT UNSIGNED PRIMARY KEY AUTO_INCREMENT,
cod_caixa MEDIUMINT UNSIGNED NOT NULL REFERENCES tb_caixa(cod_caixa),
cod_cliente MEDIUMINT UNSIGNED NOT NULL REFERENCES tb_clientes(cod_cliente),
reg_venda DATETIME NOT NULL,
total_venda DECIMAL(10,2) NOT NULL,
obs_venda VARCHAR(100) NULL
);

CREATE TABLE tb_itens_venda
(
cod_venda MEDIUMINT UNSIGNED REFERENCES tb_vendas(cod_venda),
cod_produto MEDIUMINT UNSIGNED REFERENCES tb_produtos(cod_produto),
quantidade SMALLINT NOT NULL,
subtotal DECIMAL(10,2) NOT NULL,
CONSTRAINT PK_item PRIMARY KEY(cod_venda,cod_produto)
);

CREATE OR REPLACE TABLE tb_caixa_ordem
(
cod_ordem MEDIUMINT UNSIGNED REFERENCES tb_ordemservico(cod_ordem),
cod_caixa MEDIUMINT UNSIGNED NOT NULL REFERENCES tb_caixa(cod_caixa),
PRIMARY KEY(cod_ordem)
);


CREATE OR REPLACE TABLE tb_pagamento_ordem
( 
cod_ordem MEDIUMINT UNSIGNED REFERENCES tb_caixa_ordem(cod_ordem),
tipo_pagamento TINYINT,
pgto DECIMAL(10,2) NOT NULL,
credito_vezes TINYINT NULL,
PRIMARY KEY(cod_ordem,tipo_pagamento)
);


CREATE TABLE tb_pagamento_venda
(
cod_venda MEDIUMINT UNSIGNED REFERENCES tb_vendas(cod_venda),
tipo_pagamento TINYINT,
pgto DECIMAL(10,2) NOT NULL,
credito_vezes TINYINT NULL,
CONSTRAINT PK_pagamentoVenda PRIMARY KEY(cod_venda,tipo_pagamento)
);

CREATE TABLE tb_movimentacao_caixa(
cod_mov MEDIUMINT UNSIGNED PRIMARY KEY AUTO_INCREMENT,
cod_caixa MEDIUMINT UNSIGNED REFERENCES tb_caixa(cod_caixa),
razao VARCHAR(255) NOT NULL,
valor DECIMAL(10,2) NOT NULL,
subtrair BIT NOT NULL,
data_entrada DATETIME DEFAULT NOW() NOT NULL
);


DELIMITER //
CREATE FUNCTION criarcaixa()
RETURNS MEDIUMINT UNSIGNED
BEGIN
	DECLARE dataHoje DATE DEFAULT CURDATE();
	DECLARE dataRetornada DATE;
	SET dataRetornada = (SELECT MAX(reg_caixa) FROM tb_caixa);
	IF((dataHoje > dataRetornada) OR (dataRetornada IS NULL)) THEN
		INSERT INTO tb_caixa VALUES (NULL,dataHoje);
	ELSEIF(dataHoje < dataRetornada) THEN
		SIGNAL SQLSTATE '45000' SET message_text = 'Verifique a data do servidor onde esta alojado o banco de dados';
	END IF;
	RETURN (SELECT cod_caixa FROM tb_caixa WHERE reg_caixa = dataHoje);
END//

DELIMITER //
CREATE TRIGGER trg_itensVenda
AFTER INSERT ON tb_itens_venda
FOR EACH ROW
BEGIN
   DECLARE qtd SMALLINT;
   DECLARE produto MEDIUMINT UNSIGNED;
   DECLARE qtdTabela SMALLINT;
   SET produto = NEW.cod_produto;
   SET qtd = NEW.quantidade;
   SET qtdTabela = (SELECT qtd_produto FROM tb_produtos WHERE cod_produto = produto);
   IF (qtd > qtdTabela) THEN
		SIGNAL SQLSTATE '45000' SET message_text = 'Quantida a ser vendida maior que a quantidade de estoque';
   ELSE
		UPDATE tb_produtos SET qtd_produto = qtd_produto - qtd WHERE cod_produto = produto;
   END IF;
END//

DELIMITER //
CREATE PROCEDURE sp_imprimirCupomOS(IN codigo MEDIUMINT UNSIGNED)
BEGIN
	 SELECT o.cod_ordem,n.cor, o.reg_saida,o.rec_aparelho,o.orc_descricao,o.reg_entrada, c.nome_cliente,c.cpf_cliente,a.modelo_aparelho,a.tipo_aparelho,m.marca
     FROM tb_ordemservico AS o 
     INNER JOIN tb_clientes AS c ON o.cod_cliente = c.cod_cliente 
     INNER JOIN tb_aparelho AS a ON o.cod_aparelho = a.cod_aparelho 
     INNER JOIN tb_marcas AS m ON a.cod_marca = m.cod_marca 
     INNER JOIN tb_cores AS n ON o.cod_cor = n.cod_cor WHERE cod_ordem = codigo;
END//


DELIMITER //
CREATE PROCEDURE sp_pesquisarCodigoOS(IN codigo MEDIUMINT UNSIGNED)
BEGIN 
    SELECT o.cod_ordem,o.cod_cliente,o.cod_aparelho,n.cor,o.cod_cor,o.tampa,o.bateria,o.cartaosd,o.capa,o.cartaosim,
           o.imei1_aparelho,o.reg_saida,o.imei2_aparelho,o.rec_aparelho,o.obs_aparelho,o.orc_descricao,o.orc_preco,o.reg_entrada,
           o.status_os,c.nome_cliente,a.modelo_aparelho,a.tipo_aparelho,a.cod_marca,m.marca 
    FROM tb_ordemservico AS o 
    INNER JOIN tb_clientes AS c ON o.cod_cliente = c.cod_cliente 
    INNER JOIN tb_aparelho AS a ON o.cod_aparelho = a.cod_aparelho 
    INNER JOIN tb_marcas AS m ON a.cod_marca = m.cod_marca 
    INNER JOIN tb_cores AS n ON o.cod_cor = n.cod_cor 
    WHERE cod_ordem = codigo;
END//

DELIMITER //
CREATE PROCEDURE sp_folhaOS(IN codigo MEDIUMINT UNSIGNED)
BEGIN
	 SELECT o.cod_ordem,o.tampa,o.bateria,o.cartaosd,o.capa,o.cartaosim,o.imei1_aparelho,o.imei2_aparelho,o.rec_aparelho,o.obs_aparelho,o.orc_descricao,o.orc_preco,o.reg_entrada,
            n.cor,c.nome_cliente,c.cod_cep,c.tel_cliente,c.telcom_cliente,c.cel_cliente,c.cpf_cliente,c.rg_cliente,c.num_cliente,c.email_cliente,c.comp_cliente,
            b.cep,b.logra,b.cidade,b.bairro,b.uf,
            a.modelo_aparelho,a.tipo_aparelho,m.marca 
     FROM tb_ordemservico AS o 
     INNER JOIN tb_clientes AS c ON o.cod_cliente = c.cod_cliente 
     LEFT JOIN tb_cep AS b ON c.cod_cep = b.cod_cep 
     INNER JOIN tb_aparelho AS a ON o.cod_aparelho = a.cod_aparelho 
     INNER JOIN tb_marcas AS m ON a.cod_marca = m.cod_marca 
     INNER JOIN tb_cores AS n ON o.cod_cor = n.cod_cor 
     WHERE o.cod_ordem = codigo;
END//

DELIMITER //
CREATE PROCEDURE sp_pesquisarNomeOS(IN nome VARCHAR(100))
BEGIN
	 SELECT o.cod_ordem,o.cod_cliente,o.cod_aparelho,n.cor,o.cod_cor,o.tampa,o.bateria,o.cartaosd,o.capa,o.cartaosim,o.imei1_aparelho,o.reg_saida,o.imei2_aparelho,o.rec_aparelho,o.obs_aparelho,o.orc_descricao,o.orc_preco,o.reg_entrada,o.status_os,c.nome_cliente,a.modelo_aparelho,a.tipo_aparelho,a.cod_marca,m.marca 
     FROM tb_ordemservico AS o 
     INNER JOIN tb_clientes AS c ON o.cod_cliente = c.cod_cliente 
     INNER JOIN tb_aparelho AS a ON o.cod_aparelho = a.cod_aparelho 
     INNER JOIN tb_marcas AS m ON a.cod_marca = m.cod_marca 
     INNER JOIN tb_cores AS n ON o.cod_cor = n.cod_cor 
     WHERE c.nome_cliente LIKE CONCAT('%',nome,'%') ORDER BY o.reg_entrada DESC;

END//

DELIMITER //
CREATE OR REPLACE TRIGGER trg_atualizarOS
BEFORE UPDATE ON tb_ordemservico 
FOR EACH ROW
BEGIN
	IF NEW.status_os <> OLD.status_os THEN
   BEGIN
		IF NEW.status_os = 4 THEN
      BEGIN
         INSERT INTO tb_caixa_ordem 
				SET tb_caixa_ordem.cod_ordem = NEW.cod_ordem,
					 tb_caixa_ordem.cod_caixa = criarcaixa();
         SET NEW.reg_saida = NOW();
		END;
		ELSEIF NEW.status_os = 3 THEN
			SET NEW.reg_saida = NOW();	
		END IF;
    END;
    END IF;
END//


