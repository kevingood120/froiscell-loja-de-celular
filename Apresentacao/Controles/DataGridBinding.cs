using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao.Controles
{
    public partial class DataGridBinding : MetroGrid
    {
        public DataGridBinding()
        {
            InitializeComponent();
            AutoGenerateColumns = false;
        }

        protected override void OnCellFormatting(DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                if ((Rows[e.RowIndex].DataBoundItem != null) && (Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                    e.Value = BindProperty(Rows[e.RowIndex].DataBoundItem, Columns[e.ColumnIndex].DataPropertyName);
            }
            base.OnCellFormatting(e);
        }

        private object BindProperty(object property, string propertyName)
        {
            object retValue = null;

            if (propertyName.Contains("."))
            {
                PropertyInfo[] arrayProperties;
                string leftPropertyName;

                leftPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));
                arrayProperties = property.GetType().GetProperties();

                foreach (PropertyInfo propertyInfo in arrayProperties)
                {
                    if (propertyInfo.Name == leftPropertyName)
                    {
                        retValue = BindProperty(
                          propertyInfo.GetValue(property, null),
                          propertyName.Substring(propertyName.IndexOf(".") + 1));
                        break;
                    }
                }
            }
            else
            {
                Type propertyType;
                PropertyInfo propertyInfo;
                propertyType = property.GetType();
                propertyInfo = propertyType.GetProperty(propertyName);
                retValue = propertyInfo.GetValue(property, null);
            }
            return retValue;
        }
    }
}
