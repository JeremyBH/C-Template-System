using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Xml.Serialization;
using Microsoft.Win32;

namespace TemplateSystem {
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public Templater WorkingForm = new Templater();

        public MainWindow() {
            InitializeComponent();
            CurrentTemplateDetails.Content = "Currently Loaded: \n" +
                                             "Nothing";
        }

        private void NewTemplate_OnClick(object sender, RoutedEventArgs e) {
            WorkingForm = new Templater();
            Hide();
            CurrentTemplateDetails.Content = "Currently Loaded: \n" +
                                             "New Document";
            WorkingForm.ShowDialog();
            WorkingForm.ItemTree.Close();
            Show();

        }

        /// <summary>
        ///     To load the template xml file (a serialized xml file with an ext of .txml)
        ///     Currently, nothing is being done with this.
        ///     Fairly sure the logic is correct here.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadTemplate_OnClick(object sender, RoutedEventArgs e) {
            var dlg = new OpenFileDialog {
                DefaultExt = ".txml",
                Filter = "Template XML file (*.txml)|*.txml"
            };
            bool? result = dlg.ShowDialog();
            if (result.HasValue && result == true) {
                string filename = dlg.FileName;
                XmlSerializer serializer = new XmlSerializer(typeof(TemplateList));
                StreamReader reader = new StreamReader(filename);
                TemplateList oldList = (TemplateList) serializer.Deserialize(reader);
                WorkingForm = new Templater(oldList);
                reader.Close();
                Hide();
                WorkingForm.ShowDialog();
                Show();
            }
        }

        /// <summary>
        ///     To save the template xml file (a serialized xml file with an ext of .txml)
        ///     This method is currently impossible as we need to move the content we want to export to a list
        ///     or object that we can serialize easily without interfaces interfering.
        ///     Fairly sure the logic is correct here.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveTemplate_OnClick(object sender, RoutedEventArgs e) {
            XmlSerializer serializer = new XmlSerializer(typeof(TemplateList));
            SaveFileDialog dlg = new SaveFileDialog {
                FileName = "templateName",
                DefaultExt = ".txml",
                Filter = "Template XML file (*.txml)|*.txml"
            };
            bool? result = dlg.ShowDialog();

            // Process save file dialog box results
            if (result.HasValue && result == true) {
                // Save document
                string filename = dlg.FileName;
                TextWriter writer = new StreamWriter(filename);
                serializer.Serialize(writer, WorkingForm.ItemTree.TemplateItems);
                writer.Close();
            }
            else MessageBox.Show("Save was not complete.");
        }

        private void MainWindow_OnClosing(object sender, CancelEventArgs e) {
            Application.Current.Shutdown(0);
        }
    }
}