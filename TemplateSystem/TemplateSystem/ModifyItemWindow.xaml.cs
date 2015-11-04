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
    /// Interaction logic for ModifyItem.xaml
    /// 
    /// Modify Item will be used for adding and modifying individual items within Templater. We should pass the information from TemplateItemList
    /// To here if we need to make references for the objects.
    /// </summary>
    public partial class ModifyItem : Window
    {
        string Content = "";
        public ModifyItem()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            HelloCB.FontFamily = new FontFamily(HelloCB.SelectedItem.ToString());
            MessageBox.Show("moo");
        }

        private void ContentButton_OnClick(object sender, RoutedEventArgs e)
        {
            StringInputWindow newString = new StringInputWindow(Content);
            newString.ShowDialog();
            Content = newString.ContentEditor.Text;
        }
    }
}
