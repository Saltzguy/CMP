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
using System.Drawing;
using QRCoder;

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
            label.date = DateTime.Now;
            
            DateTimeTextBox.Text = label.date.ToString();
            TechIDTextBox.Text = label.techID;

        }
        //This method will look up the associate's id and add the assocate Name in the text box
        private void IDTextChangeHandler(object sender, TextChangedEventArgs e)
        {

        }

        private void PrintLabelButton_Click(object sender, RoutedEventArgs e)
        {
           
            
            label.inc = INCTextBox.Text;
            label.wiped = (bool)WipedCheckBox.IsChecked ? "Yes" : "No";
            label.returnToUser = (bool)ReturnToUserCheckBox.IsChecked ? "Yes" : "No";
            label.assocaiteName = AssociateNameTextBox.Text;
            label.deviceType = DeviceTypeTextBox.Text;
            label.associateID = AssociateIDTextBox.Text;
            label.damage = DamagedComboBox.Text;
            
            //QR test code will work on making this better
            var qrCodeGenerator = new QRCodeGenerator();
            var qrCodeData = qrCodeGenerator.CreateQrCode(label.inc, QRCodeGenerator.ECCLevel.H);
            var qrCode = new QRCode(qrCodeData);
            Bitmap bmp = qrCode.GetGraphic(20);
            bmp.Save("Test");



        }

      
    }
            
}
