namespace ReadFromVideoCamera
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.lblFoundBarcodes = new System.Windows.Forms.Label();
			this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
			this.btnStop = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.rtbFoundBarcodes = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbCamera = new System.Windows.Forms.ComboBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbBarcodeType = new System.Windows.Forms.ComboBox();
			this.lblScanning = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbCameraWidth = new System.Windows.Forms.TextBox();
			this.tbCameraHeight = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cbStopOnFirstBarcode = new System.Windows.Forms.CheckBox();
			this.btnUpdateCameraImageDimensions = new System.Windows.Forms.Button();
			this.btnCameraProperties = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
			this.SuspendLayout();
			// 
			// lblFoundBarcodes
			// 
			this.lblFoundBarcodes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblFoundBarcodes.AutoSize = true;
			this.lblFoundBarcodes.Location = new System.Drawing.Point(12, 600);
			this.lblFoundBarcodes.Name = "lblFoundBarcodes";
			this.lblFoundBarcodes.Size = new System.Drawing.Size(93, 13);
			this.lblFoundBarcodes.TabIndex = 5;
			this.lblFoundBarcodes.Text = "Found 0 barcodes";
			// 
			// pictureBoxPreview
			// 
			this.pictureBoxPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxPreview.BackColor = System.Drawing.Color.White;
			this.pictureBoxPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBoxPreview.Location = new System.Drawing.Point(12, 117);
			this.pictureBoxPreview.Name = "pictureBoxPreview";
			this.pictureBoxPreview.Size = new System.Drawing.Size(640, 480);
			this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBoxPreview.TabIndex = 8;
			this.pictureBoxPreview.TabStop = false;
			// 
			// btnStop
			// 
			this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnStop.Enabled = false;
			this.btnStop.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnStop.Location = new System.Drawing.Point(98, 690);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(80, 26);
			this.btnStop.TabIndex = 7;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnStart
			// 
			this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnStart.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnStart.Location = new System.Drawing.Point(12, 690);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(80, 26);
			this.btnStart.TabIndex = 6;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// rtbFoundBarcodes
			// 
			this.rtbFoundBarcodes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbFoundBarcodes.Location = new System.Drawing.Point(12, 616);
			this.rtbFoundBarcodes.Name = "rtbFoundBarcodes";
			this.rtbFoundBarcodes.Size = new System.Drawing.Size(640, 68);
			this.rtbFoundBarcodes.TabIndex = 5;
			this.rtbFoundBarcodes.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 13);
			this.label1.TabIndex = 20;
			this.label1.Text = "Camera Device";
			// 
			// cmbCamera
			// 
			this.cmbCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCamera.FormattingEnabled = true;
			this.cmbCamera.Location = new System.Drawing.Point(163, 39);
			this.cmbCamera.Name = "cmbCamera";
			this.cmbCamera.Size = new System.Drawing.Size(245, 21);
			this.cmbCamera.TabIndex = 1;
			this.cmbCamera.SelectedIndexChanged += new System.EventHandler(this.cmbCamera_SelectedIndexChanged);
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnExit.Location = new System.Drawing.Point(562, 690);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(90, 26);
			this.btnExit.TabIndex = 8;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(9, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(131, 13);
			this.label3.TabIndex = 23;
			this.label3.Text = "Barcode Type To Scan";
			// 
			// cmbBarcodeType
			// 
			this.cmbBarcodeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBarcodeType.FormattingEnabled = true;
			this.cmbBarcodeType.Location = new System.Drawing.Point(163, 12);
			this.cmbBarcodeType.Name = "cmbBarcodeType";
			this.cmbBarcodeType.Size = new System.Drawing.Size(245, 21);
			this.cmbBarcodeType.Sorted = true;
			this.cmbBarcodeType.TabIndex = 0;
			// 
			// lblScanning
			// 
			this.lblScanning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblScanning.AutoSize = true;
			this.lblScanning.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblScanning.Location = new System.Drawing.Point(580, 600);
			this.lblScanning.Name = "lblScanning";
			this.lblScanning.Size = new System.Drawing.Size(67, 13);
			this.lblScanning.TabIndex = 24;
			this.lblScanning.Text = "Scanning...";
			this.lblScanning.Visible = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 13);
			this.label2.TabIndex = 26;
			this.label2.Text = "Camera Image Dimensions";
			// 
			// tbCameraWidth
			// 
			this.tbCameraWidth.Location = new System.Drawing.Point(163, 66);
			this.tbCameraWidth.Name = "tbCameraWidth";
			this.tbCameraWidth.Size = new System.Drawing.Size(35, 20);
			this.tbCameraWidth.TabIndex = 2;
			this.tbCameraWidth.Text = "640";
			// 
			// tbCameraHeight
			// 
			this.tbCameraHeight.Location = new System.Drawing.Point(222, 66);
			this.tbCameraHeight.Name = "tbCameraHeight";
			this.tbCameraHeight.Size = new System.Drawing.Size(35, 20);
			this.tbCameraHeight.TabIndex = 3;
			this.tbCameraHeight.Text = "480";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(204, 69);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(12, 13);
			this.label4.TabIndex = 29;
			this.label4.Text = "x";
			// 
			// cbStopOnFirstBarcode
			// 
			this.cbStopOnFirstBarcode.AutoSize = true;
			this.cbStopOnFirstBarcode.Location = new System.Drawing.Point(12, 94);
			this.cbStopOnFirstBarcode.Name = "cbStopOnFirstBarcode";
			this.cbStopOnFirstBarcode.Size = new System.Drawing.Size(154, 17);
			this.cbStopOnFirstBarcode.TabIndex = 30;
			this.cbStopOnFirstBarcode.Text = "Stop on first barcode found";
			this.cbStopOnFirstBarcode.UseVisualStyleBackColor = true;
			// 
			// btnUpdateCameraImageDimensions
			// 
			this.btnUpdateCameraImageDimensions.Location = new System.Drawing.Point(263, 64);
			this.btnUpdateCameraImageDimensions.Name = "btnUpdateCameraImageDimensions";
			this.btnUpdateCameraImageDimensions.Size = new System.Drawing.Size(71, 24);
			this.btnUpdateCameraImageDimensions.TabIndex = 4;
			this.btnUpdateCameraImageDimensions.Text = "Update";
			this.btnUpdateCameraImageDimensions.UseVisualStyleBackColor = true;
			this.btnUpdateCameraImageDimensions.Click += new System.EventHandler(this.btnUpdateCameraImageDimensions_Click);
			// 
			// btnCameraProperties
			// 
			this.btnCameraProperties.Location = new System.Drawing.Point(414, 38);
			this.btnCameraProperties.Name = "btnCameraProperties";
			this.btnCameraProperties.Size = new System.Drawing.Size(131, 23);
			this.btnCameraProperties.TabIndex = 31;
			this.btnCameraProperties.Text = "Camera Properties";
			this.btnCameraProperties.UseVisualStyleBackColor = true;
			this.btnCameraProperties.Click += new System.EventHandler(this.btnCameraProperties_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(664, 728);
			this.Controls.Add(this.btnCameraProperties);
			this.Controls.Add(this.btnUpdateCameraImageDimensions);
			this.Controls.Add(this.cbStopOnFirstBarcode);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbCameraHeight);
			this.Controls.Add(this.tbCameraWidth);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblScanning);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cmbBarcodeType);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbCamera);
			this.Controls.Add(this.rtbFoundBarcodes);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.pictureBoxPreview);
			this.Controls.Add(this.lblFoundBarcodes);
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Barcode Scanner";
			this.Load += new System.EventHandler(this.Form_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFoundBarcodes;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox rtbFoundBarcodes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCamera;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBarcodeType;
        private System.Windows.Forms.Label lblScanning;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCameraWidth;
        private System.Windows.Forms.TextBox tbCameraHeight;
        private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox cbStopOnFirstBarcode;
        private System.Windows.Forms.Button btnUpdateCameraImageDimensions;
		private System.Windows.Forms.Button btnCameraProperties;
	}
}

