namespace TestDriver
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            barcodeButtonEdit1 = new ScanAndScale.Driver.BarcodeButtonEdit();
            rfidButtonEdit1 = new ScanAndScale.Driver.RFIDButtonEdit();
            scaleButtonEdit1 = new ScanAndScale.Driver.ScaleButtonEdit();
            ((System.ComponentModel.ISupportInitialize)barcodeButtonEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rfidButtonEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scaleButtonEdit1.Properties).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 47);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 3;
            label1.Text = "Barcode";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 90);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 4;
            label2.Text = "Rfid";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 135);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 5;
            label3.Text = "Cân";
            // 
            // barcodeButtonEdit1
            // 
            barcodeButtonEdit1.Config = null;
            barcodeButtonEdit1.Location = new Point(118, 42);
            barcodeButtonEdit1.Name = "barcodeButtonEdit1";
            barcodeButtonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton() });
            barcodeButtonEdit1.Size = new Size(100, 20);
            barcodeButtonEdit1.TabIndex = 6;
            // 
            // rfidButtonEdit1
            // 
            rfidButtonEdit1.Config = null;
            rfidButtonEdit1.Location = new Point(118, 85);
            rfidButtonEdit1.Name = "rfidButtonEdit1";
            rfidButtonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete) });
            rfidButtonEdit1.Properties.NullValuePrompt = "Vui lòng quét thẻ nhân viên";
            rfidButtonEdit1.Size = new Size(100, 20);
            rfidButtonEdit1.TabIndex = 7;
            // 
            // scaleButtonEdit1
            // 
            scaleButtonEdit1.AutoDetectUnit = false;
            scaleButtonEdit1.Config = null;
            scaleButtonEdit1.Location = new Point(118, 130);
            scaleButtonEdit1.Name = "scaleButtonEdit1";
            scaleButtonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton() });
            scaleButtonEdit1.Size = new Size(100, 20);
            scaleButtonEdit1.Stable = true;
            scaleButtonEdit1.TabIndex = 8;
            scaleButtonEdit1.Tare = false;
            scaleButtonEdit1.UnitType = ScanAndScale.Driver.EmnumUnitType.Kg;
            scaleButtonEdit1.ValueGram = 0D;
            scaleButtonEdit1.ValueKg = 0D;
            scaleButtonEdit1.ValueTon = 0D;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(scaleButtonEdit1);
            Controls.Add(rfidButtonEdit1);
            Controls.Add(barcodeButtonEdit1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)barcodeButtonEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)rfidButtonEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)scaleButtonEdit1.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private ScanAndScale.Driver.BarcodeButtonEdit barcodeButtonEdit1;
        private ScanAndScale.Driver.RFIDButtonEdit rfidButtonEdit1;
        private ScanAndScale.Driver.ScaleButtonEdit scaleButtonEdit1;
    }
}
