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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace TemplateSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private Templater WorkingForm = new Templater();
        public MainWindow() {
            InitializeComponent();
            currentTemplateDetails.Content = "Currently Loaded: \n" +
                                             "Nothing";
        }

        private void NewTemplate_OnClick(object sender, RoutedEventArgs e) {
            WorkingForm = new Templater();
            WorkingForm.ShowDialog();
        }

        /// <summary>
        /// To load the template xml file (a serialized xml file with an ext of .txml)
        /// Currently, nothing is being done with this.
        /// 
        /// Fairly sure the logic is correct here.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadTemplate_OnClick(object sender, RoutedEventArgs e) {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog {
                DefaultExt = ".txml",
                Filter = "Template XML file (*.txml)|*.txml"
        };
            Nullable<bool> result = dlg.ShowDialog();
            if (result.HasValue && result == true) {
                string filename = dlg.FileName;
            }
        }

        /// <summary>
        /// To save the template xml file (a serialized xml file with an ext of .txml)
        /// This method is currently impossible as we need to move the content we want to export to a list
        /// or object that we can serialize easily without interfaces interfering.
        /// 
        /// Fairly sure the logic is correct here.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveTemplate_OnClick(object sender, RoutedEventArgs e) {
            XmlSerializer serializer = new XmlSerializer(WorkingForm.GetType());
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog
            {
                FileName = "templateName",
                DefaultExt = ".txml",
                Filter = "Template XML file (*.txml)|*.txml"
            };
            Nullable<bool> result = dlg.ShowDialog();

            // Process save file dialog box results
            if (result.HasValue && result == true)
            {
                // Save document
                string filename = dlg.FileName;
                TextWriter writer = new StreamWriter(filename);
                serializer.Serialize(writer, this);
            }
            else
            {
                MessageBox.Show("Save was not complete.");
            }
        }
    }
}
