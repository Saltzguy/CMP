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
using DYMO;
using DYMO.Label.Framework;
using DYMO.Common;

namespace CMP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LabelInformation label;
        public MainWindow()
        {

            InitializeComponent();


        }

        private void MyWindow_Loaded(object sender, RoutedEventArgs e)
        {
            label = new LabelInformation(); 
            label.techID = Environment.UserName;
            label.date = System.DateTime.Now;
            DateTimeTextBox.Text = label.date.ToString();
            TechIDTextBox.Text = label.techID;

        }

        private void PrintLabelButton_Click(object sender, RoutedEventArgs e)
        {
            var incText = INCTextBox.Text;
            var nameText = AssociateNameTextBox.Text;
            var damageText = DamagedComboBox.Text;
            MessageBox.Show(incText + nameText + damageText);
            
        }
    }
            
}
