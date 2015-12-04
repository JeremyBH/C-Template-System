using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Serialization;

namespace TemplateSystem
{
    /// <summary>
    /// Interaction logic for Templater.xaml
    /// 
    /// Templater is the main view for the template system to hold a visual design.
    /// Most of the code will just interact with a list system.
    /// 
    /// TODO: Add side features first, then work on features that will effect the system.
    /// </summary>
    public partial class Templater : Window
    {
        public ItemTreeView ItemTree;
        public Templater()
        {
            InitializeComponent();
            ItemTree = new ItemTreeView();
        }

        /// <summary>
        /// Start the template item list based off of a serialized object.
        /// </summary>
        /// <param name="newList"></param>
        public Templater(TemplateList newList) {
            InitializeComponent();
            ItemTree.TemplateItems = newList;
        }

        private void ContextMenu_AddItem_OnClick(object sender, RoutedEventArgs e) {
            ModifyItem newItem = new ModifyItem();
            newItem.ShowDialog();
            
        }

        private void ContextMenu_EditForm_OnClick(object sender, RoutedEventArgs e) {
            
        }

        private void Templater_OnActivated(object sender, EventArgs e)
        {
            ItemTree.Show();
        }
    }
}
