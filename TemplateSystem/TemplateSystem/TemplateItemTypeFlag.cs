using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace TemplateSystem
{
    public static class TemplateItemTypeFlag {
        public static readonly Type Window = typeof(Window);
        public static readonly Type Label = typeof(Label);
        public static readonly Type TextBlock = typeof(TextBlock);
        public static readonly Type Image = typeof(Image);
    }
}
