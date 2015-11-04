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
    /// Interaction logic for StringInputWindow.xaml
    /// 
    /// This will be the input window for the name of templates (which we can send to the file save to set as the 
    /// default file name), and will also be the text editor for any sort of content that the user wants to put into the templates.
    /// </summary>
    public partial class StringInputWindow : Window
    {
        public StringInputWindow()
        {
            InitializeComponent();
        }

        public StringInputWindow(string content)
        {
            InitializeComponent();
            ContentEditor.Text = content;
        }
    }
}
