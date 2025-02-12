using ScanAndScale.Driver;
using ScanAndScale.Helper;
using System.Diagnostics;

namespace TestDriver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            barcodeButtonEdit1.Config = GolobalTag.barcodeConfig;
            rfidButtonEdit1.Config = GolobalTag.rfidConfig;
            scaleButtonEdit1.Config = GolobalTag.scaleConfig;

            barcodeButtonEdit1.DataValueChanged += BarcodeButtonEdit1_DataValueChanged;
            rfidButtonEdit1.DataValueChanged += RfidButtonEdit1_DataValueChanged;
            scaleButtonEdit1.DataValueChanged += ScaleButtonEdit1_DataValueChanged;


            //barcodeButtonEdit1.Config = new BarcodeConfig()
            //{
            //    Enable = true,
            //    ReadOnly = false
            //};

            //rfidButtonEdit1.Config = new RfidConfig()
            //{
            //    Enable = true,
            //    ReadOnly = false,
            //    Rfid_AutoFindCom = true,
            //    Rfid_Caption = "Pongee",
            //    Rfid_Manufact = "Prolific",
            //    Rfid_Com = "COM1"
            //};

            //scaleButtonEdit1.Config = new ScaleConfig()
            //{
            //    Enable = true,
            //    ReadOnly = false,
            //    IP = "0.0.0.0",//    "192.168.0.15",
            //    Port = 23,
            //    ModelName = "Scale_DIGI"
            //};

        }

        private void ScaleButtonEdit1_DataValueChanged(object? sender, DataValueChangedEventArgs e)
        {
            Debug.WriteLine($"Đã nhận được tín hiệu thay đổi Cân: '{e.NewValue.Value}'");
        }

        private void RfidButtonEdit1_DataValueChanged(object? sender, DataValueChangedEventArgs e)
        {
            MessageBox.Show($"Đã nhận được tín hiệu thay đổi RFID: '{e.NewValue.Value}'");
        }

        private void BarcodeButtonEdit1_DataValueChanged(object? sender, DataValueChangedEventArgs e)
        {
            MessageBox.Show($"Đã nhận được tín hiệu thay đổi barcode: '{e.NewValue.Value}'");
        }
    }
}
