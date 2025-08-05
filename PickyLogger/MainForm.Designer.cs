namespace PickyLogger
{
    partial class MainForm
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
            this.Icon = Properties.Resources.pick_list;
            btnSelectFiles = new Button();
            lstSelectedFiles = new ListBox();
            txtFilterString = new TextBox();
            btnExecute = new Button();
            txtLog = new TextBox();
            labelFilterString = new Label();
            labelLog = new Label();
            btnSelectSavePath = new Button();
            labelSaveTo = new Label();
            txtSavePath = new TextBox();
            btnOpenSavePath = new Button();
            SuspendLayout();
            // 
            // btnSelectFiles
            // 
            btnSelectFiles.BackColor = Color.LightSteelBlue;
            btnSelectFiles.ForeColor = Color.DimGray;
            btnSelectFiles.Location = new Point(12, 12);
            btnSelectFiles.Name = "btnSelectFiles";
            btnSelectFiles.Size = new Size(150, 46);
            btnSelectFiles.TabIndex = 0;
            btnSelectFiles.Text = "Select Files";
            btnSelectFiles.UseVisualStyleBackColor = false;
            btnSelectFiles.Click += btnSelectFiles_Click;
            // 
            // lstSelectedFiles
            // 
            lstSelectedFiles.FormattingEnabled = true;
            lstSelectedFiles.HorizontalScrollbar = true;
            lstSelectedFiles.Location = new Point(12, 64);
            lstSelectedFiles.Name = "lstSelectedFiles";
            lstSelectedFiles.Size = new Size(838, 132);
            lstSelectedFiles.TabIndex = 1;
            // 
            // txtFilterString
            // 
            txtFilterString.Location = new Point(195, 245);
            txtFilterString.Name = "txtFilterString";
            txtFilterString.Size = new Size(655, 39);
            txtFilterString.TabIndex = 2;
            // 
            // btnExecute
            // 
            btnExecute.BackColor = Color.LightSteelBlue;
            btnExecute.ForeColor = Color.DimGray;
            btnExecute.Location = new Point(13, 452);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(150, 46);
            btnExecute.TabIndex = 4;
            btnExecute.Text = "Execute";
            btnExecute.UseVisualStyleBackColor = false;
            btnExecute.Click += btnExecute_Click;
            // 
            // txtLog
            // 
            txtLog.BackColor = SystemColors.Window;
            txtLog.BorderStyle = BorderStyle.FixedSingle;
            txtLog.Location = new Point(11, 536);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.ScrollBars = ScrollBars.Vertical;
            txtLog.Size = new Size(839, 165);
            txtLog.TabIndex = 5;
            // 
            // labelFilterString
            // 
            labelFilterString.AutoSize = true;
            labelFilterString.Location = new Point(13, 249);
            labelFilterString.Name = "labelFilterString";
            labelFilterString.Size = new Size(143, 32);
            labelFilterString.TabIndex = 7;
            labelFilterString.Text = "Filter String:";
            // 
            // labelLog
            // 
            labelLog.AutoSize = true;
            labelLog.Location = new Point(12, 501);
            labelLog.Name = "labelLog";
            labelLog.Size = new Size(54, 32);
            labelLog.TabIndex = 9;
            labelLog.Text = "Log";
            // 
            // btnSelectSavePath
            // 
            btnSelectSavePath.BackColor = Color.LightSteelBlue;
            btnSelectSavePath.ForeColor = Color.DimGray;
            btnSelectSavePath.Location = new Point(12, 320);
            btnSelectSavePath.Name = "btnSelectSavePath";
            btnSelectSavePath.Size = new Size(222, 46);
            btnSelectSavePath.TabIndex = 10;
            btnSelectSavePath.Text = "Select Save Path";
            btnSelectSavePath.UseVisualStyleBackColor = false;
            btnSelectSavePath.Click += btnSelectSavePath_Click;
            // 
            // labelSaveTo
            // 
            labelSaveTo.AutoSize = true;
            labelSaveTo.Location = new Point(13, 390);
            labelSaveTo.Name = "labelSaveTo";
            labelSaveTo.Size = new Size(104, 32);
            labelSaveTo.TabIndex = 11;
            labelSaveTo.Text = "Save To:";
            // 
            // txtSavePath
            // 
            txtSavePath.BackColor = SystemColors.Window;
            txtSavePath.Location = new Point(196, 383);
            txtSavePath.Name = "txtSavePath";
            txtSavePath.ReadOnly = true;
            txtSavePath.ScrollBars = ScrollBars.Horizontal;
            txtSavePath.Size = new Size(654, 39);
            txtSavePath.TabIndex = 12;
            // 
            // btnOpenSavePath
            // 
            btnOpenSavePath.BackColor = Color.LightSteelBlue;
            btnOpenSavePath.ForeColor = Color.DimGray;
            btnOpenSavePath.Location = new Point(240, 320);
            btnOpenSavePath.Name = "btnOpenSavePath";
            btnOpenSavePath.Size = new Size(222, 46);
            btnOpenSavePath.TabIndex = 13;
            btnOpenSavePath.Text = "Open Save Path";
            btnOpenSavePath.UseVisualStyleBackColor = false;
            btnOpenSavePath.Click += btnOpenSavePath_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(874, 721);
            Controls.Add(btnOpenSavePath);
            Controls.Add(txtSavePath);
            Controls.Add(labelSaveTo);
            Controls.Add(btnSelectSavePath);
            Controls.Add(labelLog);
            Controls.Add(labelFilterString);
            Controls.Add(txtLog);
            Controls.Add(btnExecute);
            Controls.Add(txtFilterString);
            Controls.Add(lstSelectedFiles);
            Controls.Add(btnSelectFiles);
            Name = "MainForm";
            Text = "PickyLogger";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Button btnSelectFiles;
        private ListBox lstSelectedFiles;
        private TextBox txtFilterString;
        private Button btnExecute;
        private TextBox txtLog;
        private Label labelFilterString;
        private Label labelLog;
        private Button btnSelectSavePath;
        private Label labelSaveTo;
        private TextBox txtSavePath;
        private Button btnOpenSavePath;
    }
}
