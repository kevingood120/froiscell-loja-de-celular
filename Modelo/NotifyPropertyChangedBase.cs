using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [Serializable]
    public class ModelBase : INotifyPropertyChanged
    {
        PropertyChangedEventHandler propertyChanged;
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        {
            add
            {
                propertyChanged += value;
            }

            remove
            {
                propertyChanged -= value;
            }
        }

        protected void firePropertyChanged(string propriedade)
        {
            propertyChanged?.Invoke(this, new PropertyChangedEventArgs(propriedade));
        }

        protected void Set<T>(ref T antigoValor, T novoValor,[CallerMemberName]string propriedade = null)
        {
            if(!EqualityComparer<T>.Default.Equals(antigoValor,novoValor))
            {
                antigoValor = novoValor;
                firePropertyChanged(propriedade);
            }
        }
    }
}
