using MetroFramework.Controls;
using System;
using System.ComponentModel;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace Apresentacao.Controles
{
    public partial class CurrencyTextBox : MetroTextBox, INotifyPropertyChanged
    {
        decimal numero;
        const int maxLength = 8;
        event PropertyChangedEventHandler PropertyChanged;

        public CurrencyTextBox()
        {
            InitializeComponent();
            Text = null;
            Numero = decimal.Zero;
        }

        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        {
            add
            {
                PropertyChanged += value;
            }

            remove
            {
                PropertyChanged -= value;
            }
        }

        [Bindable(true,BindingDirection.TwoWay)]
        public decimal Numero
        {
            get
            {
                return numero;
            }
            set
            {
                if (value.ToString().Replace(".","").Replace(",","").Count() <= maxLength)
                {
                    Text = value.ToString("C2");
                    Select(Text.Length, 0);
                    numero = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Numero"));
                }
            }
        }

        decimal PegarNumero()
        {
            string somenteNumeros = Text.Replace(",", "").Replace("R$", "").Replace(".", "").Trim();
            decimal numeroConvertido = decimal.Zero;
            if (decimal.TryParse(somenteNumeros, out numeroConvertido))
            {
                numeroConvertido = numeroConvertido / 100;
                if (numeroConvertido.ToString().Replace(".", "").Replace(",", "").Count() >= maxLength)
                {
                    SystemSounds.Beep.Play();
                    return numero;
                }
            }
            return numeroConvertido;
        }

        void CurrencyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                SystemSounds.Beep.Play();
                e.Handled = true;
            }
        }
        void CurrencyTextBox_TextChanged(object sender, EventArgs e)
        {
            Numero = PegarNumero();
        }
    }
}

