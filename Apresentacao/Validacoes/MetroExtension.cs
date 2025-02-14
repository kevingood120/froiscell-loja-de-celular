﻿using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apresentacao.Validacoes
{
    public static class MetroExtension
    {
        private const MetroColorStyle FormStyle = MetroColorStyle.Green;
        public static void SetStyle(this IContainer container, MetroForm ownerForm)
        {
            var manager = new MetroStyleManager(container ?? (container = new Container()));
            manager.Owner = ownerForm;
            container.SetDefaultStyle(ownerForm, FormStyle);
        }
        public static void SetDefaultStyle(this IContainer contr, MetroForm owner, MetroColorStyle style)
        {
            MetroStyleManager manager = FindManager(contr, owner);
            manager.Style = style;
            owner.Style = style;
        }
        public static void SetDefaultTheme(this IContainer contr, MetroForm owner, MetroThemeStyle thme)
        {
            MetroStyleManager manager = FindManager(contr, owner);
            manager.Theme = thme;
        }
        private static MetroStyleManager FindManager(IContainer contr, MetroForm owner)
        {
            MetroStyleManager manager = null;
            foreach (IComponent item in contr.Components)
                if (item is MetroStyleManager)
                    manager = item as MetroStyleManager;
            return manager;
        }
    }
}
