using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using static System.Drawing.Printing.PrinterSettings;

namespace Apresentacao.Validacoes
{
    public static class Validacoes
    {
        public static bool ValidarCPF(string cpf)
        {
            int[] multiplicador1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string cpfString = cpf.Replace(".", "").Replace("-", "").Replace("_", "").Trim();
            char[] cpfCaracteres = cpfString.ToCharArray();
            int digito1 = 0, digito2 = 0;
            int digito1Cpf = (int)char.GetNumericValue(cpfCaracteres[9]), digito2Cpf = (int)char.GetNumericValue(cpfCaracteres[10]);
            for (int i = 0; i < 10; i++)
            {
                string acum = string.Empty;
                for (int k = 0; k < 11; k++)
                    acum = acum + i;
                if (cpfString.Equals(acum))
                    return false;
            }
            for (int i = 0; i < 9; i++)
                digito1 = digito1 + (int)(char.GetNumericValue(cpfCaracteres[i]) * multiplicador1[i]);
            digito1 = (digito1 % 11 < 2) ? 0 : 11 - (digito1 % 11);
            if (digito1Cpf == digito1)
            {
                for (int i = 0; i < 10; i++)
                    digito2 = digito2 + (int)(char.GetNumericValue(cpfCaracteres[i]) * multiplicador2[i]);
                digito2 = (digito2 % 11 < 2) ? 0 : 11 - (digito2 % 11);
                return (digito2Cpf == digito2);
            }
            return false;
        }

        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute),
                false);

            if (attributes != null &&
                attributes.Length > 0)
                return attributes[0].Description;
            else
                return Convert.ToString(value);
        }

        public static ImpressoraStatus VerificarImpressora(string value)
        {
            LocalPrintServer printServer = new LocalPrintServer();
            PrintQueue printAtual = null;
            foreach (PrintQueue printQueue in printServer.GetPrintQueues())
                if (printQueue.FullName == value)
                    printAtual = printQueue;
            if (printAtual == null)
                return ImpressoraStatus.Desconectada;
            else
            {
                if (printAtual.IsBusy)
                    return ImpressoraStatus.Ocupada;
                else if (printAtual.IsOffline)
                    return ImpressoraStatus.Offline;
                else
                    return ImpressoraStatus.Online;
            }

        }

        public static bool ValidarIMEI(string imei)
        {
            List<int> imeiInteiro = new List<int>();
            int total = 0;

            foreach (char digito in imei)
                imeiInteiro.Add((int)char.GetNumericValue(digito));

            for (int i = 0; i < 14; i++)
            {
                int digito = imeiInteiro[i];
                if (i % 2 != 0)
                    imeiInteiro[i] = digito + digito;
            }

            for(int i= 0;i < 10; i++)
            {
                string temp = null;
                for (int k = 0; k < 15; k++)
                    temp = temp + i;
                if (imei.Equals(temp))
                    return false;
            }

            for (int i = 0; i < 14; i++)
            {
                int digito = imeiInteiro[i];
                string digitoString = digito.ToString();
                if (digitoString.Length == 2)
                    total = total + (int)(char.GetNumericValue(digitoString[0]) + char.GetNumericValue(digitoString[1]));
                else
                    total = total + digito;
            }
            int verificador = imeiInteiro[14];
            int resultado = total % 10;
            return resultado == verificador || (10 - resultado) == verificador;
        }
    }

    public enum ImpressoraStatus
    {
        Ocupada,
        Desconectada,
        Offline,
        Online
    }
}
