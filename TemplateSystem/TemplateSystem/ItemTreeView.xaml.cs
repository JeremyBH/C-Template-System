using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TemplateSystem
{
    /// <summary>
    /// Interaction logic for ItemTreeView.xaml
    /// </summary>
    public partial class ItemTreeView : Window
    {
        public TemplateList TemplateItems; 
        public ItemTreeView()
        {
            InitializeComponent();
            TemplateItems = new TemplateList();
            ItemTree.Items.Add(new TreeViewItem {Header = "help"});
        }
    }
}
