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
            btnSelectFiles.Location = new Point(6, 6);
            btnSelectFiles.Margin = new Padding(2, 1, 2, 1);
            btnSelectFiles.Name = "btnSelectFiles";
            btnSelectFiles.Size = new Size(75, 22);
            btnSelectFiles.TabIndex = 0;
            btnSelectFiles.Text = "Select Files";
            btnSelectFiles.UseVisualStyleBackColor = false;
            btnSelectFiles.Click += btnSelectFiles_Click;
            // 
            // lstSelectedFiles
            // 
            lstSelectedFiles.FormattingEnabled = true;
            lstSelectedFiles.HorizontalScrollbar = true;
            lstSelectedFiles.ItemHeight = 15;
            lstSelectedFiles.Location = new Point(6, 30);
            lstSelectedFiles.Margin = new Padding(2, 1, 2, 1);
            lstSelectedFiles.Name = "lstSelectedFiles";
            lstSelectedFiles.Size = new Size(421, 64);
            lstSelectedFiles.TabIndex = 1;
            // 
            // txtFilterString
            // 
            txtFilterString.AcceptsReturn = true;
            txtFilterString.Location = new Point(98, 115);
            txtFilterString.Margin = new Padding(2, 1, 2, 1);
            txtFilterString.Multiline = true;
            txtFilterString.Name = "txtFilterString";
            txtFilterString.ScrollBars = ScrollBars.Vertical;
            txtFilterString.Size = new Size(330, 65);
            txtFilterString.TabIndex = 2;
            // 
            // btnExecute
            // 
            btnExecute.BackColor = Color.LightSteelBlue;
            btnExecute.ForeColor = Color.DimGray;
            btnExecute.Location = new Point(6, 241);
            btnExecute.Margin = new Padding(2, 1, 2, 1);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(75, 22);
            btnExecute.TabIndex = 4;
            btnExecute.Text = "Execute";
            btnExecute.UseVisualStyleBackColor = false;
            btnExecute.Click += btnExecute_Click;
            // 
            // txtLog
            // 
            txtLog.BackColor = SystemColors.Window;
            txtLog.BorderStyle = BorderStyle.FixedSingle;
            txtLog.Location = new Point(6, 289);
            txtLog.Margin = new Padding(2, 1, 2, 1);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.ScrollBars = ScrollBars.Vertical;
            txtLog.Size = new Size(420, 97);
            txtLog.TabIndex = 5;
            // 
            // labelFilterString
            // 
            labelFilterString.AutoSize = true;
            labelFilterString.Location = new Point(6, 117);
            labelFilterString.Margin = new Padding(2, 0, 2, 0);
            labelFilterString.Name = "labelFilterString";
            labelFilterString.Size = new Size(72, 15);
            labelFilterString.TabIndex = 7;
            labelFilterString.Text = "Filter String:";
            // 
            // labelLog
            // 
            labelLog.AutoSize = true;
            labelLog.Location = new Point(6, 273);
            labelLog.Margin = new Padding(2, 0, 2, 0);
            labelLog.Name = "labelLog";
            labelLog.Size = new Size(27, 15);
            labelLog.TabIndex = 9;
            labelLog.Text = "Log";
            // 
            // btnSelectSavePath
            // 
            btnSelectSavePath.BackColor = Color.LightSteelBlue;
            btnSelectSavePath.ForeColor = Color.DimGray;
            btnSelectSavePath.Location = new Point(6, 182);
            btnSelectSavePath.Margin = new Padding(2, 1, 2, 1);
            btnSelectSavePath.Name = "btnSelectSavePath";
            btnSelectSavePath.Size = new Size(111, 22);
            btnSelectSavePath.TabIndex = 10;
            btnSelectSavePath.Text = "Select Save Path";
            btnSelectSavePath.UseVisualStyleBackColor = false;
            btnSelectSavePath.Click += btnSelectSavePath_Click;
            // 
            // labelSaveTo
            // 
            labelSaveTo.AutoSize = true;
            labelSaveTo.Location = new Point(6, 215);
            labelSaveTo.Margin = new Padding(2, 0, 2, 0);
            labelSaveTo.Name = "labelSaveTo";
            labelSaveTo.Size = new Size(52, 15);
            labelSaveTo.TabIndex = 11;
            labelSaveTo.Text = "Save To:";
            // 
            // txtSavePath
            // 
            txtSavePath.BackColor = SystemColors.Window;
            txtSavePath.Location = new Point(98, 212);
            txtSavePath.Margin = new Padding(2, 1, 2, 1);
            txtSavePath.Name = "txtSavePath";
            txtSavePath.ReadOnly = true;
            txtSavePath.ScrollBars = ScrollBars.Horizontal;
            txtSavePath.Size = new Size(329, 23);
            txtSavePath.TabIndex = 12;
            // 
            // btnOpenSavePath
            // 
            btnOpenSavePath.BackColor = Color.LightSteelBlue;
            btnOpenSavePath.ForeColor = Color.DimGray;
            btnOpenSavePath.Location = new Point(120, 182);
            btnOpenSavePath.Margin = new Padding(2, 1, 2, 1);
            btnOpenSavePath.Name = "btnOpenSavePath";
            btnOpenSavePath.Size = new Size(111, 22);
            btnOpenSavePath.TabIndex = 13;
            btnOpenSavePath.Text = "Open Save Path";
            btnOpenSavePath.UseVisualStyleBackColor = false;
            btnOpenSavePath.Click += btnOpenSavePath_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(437, 396);
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
            Icon = Properties.Resources.pick_list;
            Margin = new Padding(2, 1, 2, 1);
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
