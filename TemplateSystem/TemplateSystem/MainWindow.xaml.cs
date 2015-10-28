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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TemplateSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() {
            Button hello = new Button {
                Content = "Hello",
                Width = 20,
                Height = 40
            };
                InitializeComponent();
            MainGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength() });
            MainGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength() });
            MainGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength() });
            MainGrid.Children.Add(hello);
            Grid.SetColumn(hello,2);
            
        }
    }
}
