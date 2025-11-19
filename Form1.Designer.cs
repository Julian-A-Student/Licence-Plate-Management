namespace Licence_Plate_Management
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
            pbLogo = new PictureBox();
            lblTitle = new Label();
            lblLicenceManagement = new Label();
            lblLicence = new Label();
            lblTagged = new Label();
            lbLicPlates = new ListBox();
            lbTagPlates = new ListBox();
            btnLeft = new Button();
            btnRight = new Button();
            stsOutput = new StatusStrip();
            tstlOutput = new ToolStripStatusLabel();
            tsslOutput = new ToolStripStatusLabel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txtInput = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSearchLin = new Button();
            btnSearchBin = new Button();
            lblSearch = new Label();
            rtbRegistrationInfo = new RichTextBox();
            lblRegistration = new Label();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            stsOutput.SuspendLayout();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.logo;
            pbLogo.Location = new Point(422, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(145, 105);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 30F);
            lblTitle.Location = new Point(25, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(361, 54);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Active Systems PTY";
            // 
            // lblLicenceManagement
            // 
            lblLicenceManagement.AutoSize = true;
            lblLicenceManagement.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLicenceManagement.Location = new Point(45, 85);
            lblLicenceManagement.Name = "lblLicenceManagement";
            lblLicenceManagement.Size = new Size(302, 32);
            lblLicenceManagement.TabIndex = 2;
            lblLicenceManagement.Text = "Licence Plate Management";
            // 
            // lblLicence
            // 
            lblLicence.AutoSize = true;
            lblLicence.Font = new Font("Segoe UI", 10F);
            lblLicence.Location = new Point(25, 156);
            lblLicence.Name = "lblLicence";
            lblLicence.Size = new Size(93, 19);
            lblLicence.TabIndex = 3;
            lblLicence.Text = "Licence Plates";
            // 
            // lblTagged
            // 
            lblTagged.AutoSize = true;
            lblTagged.Font = new Font("Segoe UI", 10F);
            lblTagged.Location = new Point(209, 156);
            lblTagged.Name = "lblTagged";
            lblTagged.Size = new Size(52, 19);
            lblTagged.TabIndex = 4;
            lblTagged.Text = "Tagged";
            // 
            // lbLicPlates
            // 
            lbLicPlates.FormattingEnabled = true;
            lbLicPlates.Location = new Point(12, 178);
            lbLicPlates.Name = "lbLicPlates";
            lbLicPlates.Size = new Size(128, 349);
            lbLicPlates.TabIndex = 5;
            lbLicPlates.SelectedIndexChanged += lbLicPlates_SelectedIndexChanged;
            lbLicPlates.MouseDoubleClick += lbLicPlates_MouseDoubleClick;
            // 
            // lbTagPlates
            // 
            lbTagPlates.FormattingEnabled = true;
            lbTagPlates.Location = new Point(176, 178);
            lbTagPlates.Name = "lbTagPlates";
            lbTagPlates.Size = new Size(120, 349);
            lbTagPlates.TabIndex = 6;
            lbTagPlates.SelectedIndexChanged += lbTagPlates_SelectedIndexChanged;
            lbTagPlates.MouseDoubleClick += lbTagPlates_MouseDoubleClick;
            // 
            // btnLeft
            // 
            btnLeft.Image = Properties.Resources.left;
            btnLeft.Location = new Point(145, 307);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(24, 24);
            btnLeft.TabIndex = 7;
            btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            btnRight.Image = Properties.Resources.right;
            btnRight.Location = new Point(144, 337);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(24, 24);
            btnRight.TabIndex = 8;
            btnRight.UseVisualStyleBackColor = true;
            // 
            // stsOutput
            // 
            stsOutput.BackColor = SystemColors.ButtonFace;
            stsOutput.Items.AddRange(new ToolStripItem[] { tstlOutput, tsslOutput });
            stsOutput.Location = new Point(0, 536);
            stsOutput.Name = "stsOutput";
            stsOutput.Size = new Size(579, 22);
            stsOutput.TabIndex = 9;
            // 
            // tstlOutput
            // 
            tstlOutput.Name = "tstlOutput";
            tstlOutput.Size = new Size(0, 17);
            // 
            // tsslOutput
            // 
            tsslOutput.Name = "tsslOutput";
            tsslOutput.Size = new Size(0, 17);
            // 
            // button1
            // 
            button1.Location = new Point(311, 178);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(392, 178);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Load";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(473, 178);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 12;
            button3.Text = "Save As";
            button3.UseVisualStyleBackColor = true;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(311, 237);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(75, 23);
            txtInput.TabIndex = 13;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(392, 237);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(473, 237);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Image = Properties.Resources.redx;
            btnDelete.Location = new Point(144, 366);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(24, 24);
            btnDelete.TabIndex = 16;
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSearchLin
            // 
            btnSearchLin.Location = new Point(392, 266);
            btnSearchLin.Name = "btnSearchLin";
            btnSearchLin.Size = new Size(75, 23);
            btnSearchLin.TabIndex = 17;
            btnSearchLin.Text = "Linear";
            btnSearchLin.UseVisualStyleBackColor = true;
            btnSearchLin.Click += btnSearchLin_Click;
            // 
            // btnSearchBin
            // 
            btnSearchBin.Location = new Point(473, 266);
            btnSearchBin.Name = "btnSearchBin";
            btnSearchBin.Size = new Size(75, 23);
            btnSearchBin.TabIndex = 18;
            btnSearchBin.Text = "Binary";
            btnSearchBin.UseVisualStyleBackColor = true;
            btnSearchBin.Click += btnSearchBin_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F);
            lblSearch.Location = new Point(330, 268);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(56, 19);
            lblSearch.TabIndex = 19;
            lblSearch.Text = "Search: ";
            // 
            // rtbRegistrationInfo
            // 
            rtbRegistrationInfo.Location = new Point(311, 337);
            rtbRegistrationInfo.Name = "rtbRegistrationInfo";
            rtbRegistrationInfo.Size = new Size(237, 161);
            rtbRegistrationInfo.TabIndex = 20;
            rtbRegistrationInfo.Text = "";
            // 
            // lblRegistration
            // 
            lblRegistration.AutoSize = true;
            lblRegistration.Font = new Font("Segoe UI", 11F, FontStyle.Underline);
            lblRegistration.Location = new Point(346, 314);
            lblRegistration.Name = "lblRegistration";
            lblRegistration.Size = new Size(171, 20);
            lblRegistration.TabIndex = 21;
            lblRegistration.Text = "Registration Information";
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 9F);
            btnReset.Image = Properties.Resources.caution1;
            btnReset.ImageAlign = ContentAlignment.MiddleLeft;
            btnReset.Location = new Point(392, 504);
            btnReset.Name = "btnReset";
            btnReset.RightToLeft = RightToLeft.No;
            btnReset.Size = new Size(75, 29);
            btnReset.TabIndex = 22;
            btnReset.Text = "RESET";
            btnReset.TextAlign = ContentAlignment.MiddleRight;
            btnReset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(579, 558);
            Controls.Add(btnReset);
            Controls.Add(lblRegistration);
            Controls.Add(rtbRegistrationInfo);
            Controls.Add(lblSearch);
            Controls.Add(btnSearchBin);
            Controls.Add(btnSearchLin);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtInput);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(stsOutput);
            Controls.Add(btnRight);
            Controls.Add(btnLeft);
            Controls.Add(lbTagPlates);
            Controls.Add(lbLicPlates);
            Controls.Add(lblTagged);
            Controls.Add(lblLicence);
            Controls.Add(lblLicenceManagement);
            Controls.Add(lblTitle);
            Controls.Add(pbLogo);
            Name = "Form1";
            Text = "Active Systems PTY";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            stsOutput.ResumeLayout(false);
            stsOutput.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private Label lblTitle;
        private Label lblLicenceManagement;
        private Label lblLicence;
        private Label lblTagged;
        private ListBox lbLicPlates;
        private ListBox lbTagPlates;
        private Button btnLeft;
        private Button btnRight;
        private StatusStrip stsOutput;
        private ToolStripStatusLabel tstlOutput;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txtInput;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSearchLin;
        private Button btnSearchBin;
        private Label lblSearch;
        private RichTextBox rtbRegistrationInfo;
        private Label lblRegistration;
        private Button btnReset;
        private ToolStripStatusLabel tsslOutput;
    }
}
