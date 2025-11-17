namespace HuisArtsApp
{
    partial class mainForm
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
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchTB = new System.Windows.Forms.TextBox();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.secondaryPhoneLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.cityLbl = new System.Windows.Forms.Label();
            this.streetLbl = new System.Windows.Forms.Label();
            this.birthdateLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.SearchBtn.Location = new System.Drawing.Point(389, 12);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(100, 36);
            this.SearchBtn.TabIndex = 1;
            this.SearchBtn.Text = "Zoeken";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchTB
            // 
            this.SearchTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.SearchTB.Location = new System.Drawing.Point(182, 13);
            this.SearchTB.Name = "SearchTB";
            this.SearchTB.Size = new System.Drawing.Size(201, 32);
            this.SearchTB.TabIndex = 2;
            this.SearchTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTB_KeyDown);
            // 
            // infoPanel
            // 
            this.infoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoPanel.Controls.Add(this.secondaryPhoneLbl);
            this.infoPanel.Controls.Add(this.phoneLbl);
            this.infoPanel.Controls.Add(this.cityLbl);
            this.infoPanel.Controls.Add(this.streetLbl);
            this.infoPanel.Controls.Add(this.birthdateLbl);
            this.infoPanel.Controls.Add(this.NameLbl);
            this.infoPanel.Location = new System.Drawing.Point(693, 51);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(448, 381);
            this.infoPanel.TabIndex = 3;
            // 
            // secondaryPhoneLbl
            // 
            this.secondaryPhoneLbl.AutoSize = true;
            this.secondaryPhoneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.secondaryPhoneLbl.Location = new System.Drawing.Point(-5, 191);
            this.secondaryPhoneLbl.Name = "secondaryPhoneLbl";
            this.secondaryPhoneLbl.Size = new System.Drawing.Size(322, 26);
            this.secondaryPhoneLbl.TabIndex = 5;
            this.secondaryPhoneLbl.Text = "Tweede telefoon nummer: None";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.phoneLbl.Location = new System.Drawing.Point(-5, 154);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(309, 26);
            this.phoneLbl.TabIndex = 4;
            this.phoneLbl.Text = "Eerste telefoon nummer: None";
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cityLbl.Location = new System.Drawing.Point(-5, 119);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(191, 26);
            this.cityLbl.TabIndex = 3;
            this.cityLbl.Text = "Woonplaats: None";
            // 
            // streetLbl
            // 
            this.streetLbl.AutoSize = true;
            this.streetLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.streetLbl.Location = new System.Drawing.Point(-5, 78);
            this.streetLbl.Name = "streetLbl";
            this.streetLbl.Size = new System.Drawing.Size(134, 26);
            this.streetLbl.TabIndex = 2;
            this.streetLbl.Text = "Straat: None";
            // 
            // birthdateLbl
            // 
            this.birthdateLbl.AutoSize = true;
            this.birthdateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.birthdateLbl.Location = new System.Drawing.Point(-5, 40);
            this.birthdateLbl.Name = "birthdateLbl";
            this.birthdateLbl.Size = new System.Drawing.Size(227, 26);
            this.birthdateLbl.TabIndex = 1;
            this.birthdateLbl.Text = "Geboortedatum: None";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.NameLbl.Location = new System.Drawing.Point(-1, 0);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(135, 26);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Naam: None";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(675, 381);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Zoek Patiënten:";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.SearchTB);
            this.Controls.Add(this.SearchBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SearchTB;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label streetLbl;
        private System.Windows.Forms.Label birthdateLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label cityLbl;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Label secondaryPhoneLbl;
        private System.Windows.Forms.Label label1;
    }
}

