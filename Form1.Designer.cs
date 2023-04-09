namespace InstagramFollowersDesktop
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.takipciTextBox = new System.Windows.Forms.TextBox();
            this.takipEdilenTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listeleButton = new System.Windows.Forms.Button();
            this.kaydetButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.durumLabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.aboutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.updateToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.versionsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.reportToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // takipciTextBox
            // 
            this.takipciTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.takipciTextBox.Location = new System.Drawing.Point(213, 62);
            this.takipciTextBox.MaxLength = 7;
            this.takipciTextBox.Name = "takipciTextBox";
            this.takipciTextBox.Size = new System.Drawing.Size(62, 22);
            this.takipciTextBox.TabIndex = 0;
            this.takipciTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // takipEdilenTextBox
            // 
            this.takipEdilenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.takipEdilenTextBox.Location = new System.Drawing.Point(213, 105);
            this.takipEdilenTextBox.MaxLength = 7;
            this.takipEdilenTextBox.Name = "takipEdilenTextBox";
            this.takipEdilenTextBox.Size = new System.Drawing.Size(62, 22);
            this.takipEdilenTextBox.TabIndex = 1;
            this.takipEdilenTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(49, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Takipçi Sayısı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(49, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Takip Edilen Sayısı :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(327, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(320, 245);
            this.dataGridView1.TabIndex = 7;
            // 
            // listeleButton
            // 
            this.listeleButton.BackColor = System.Drawing.Color.CadetBlue;
            this.listeleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listeleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listeleButton.ForeColor = System.Drawing.Color.Indigo;
            this.listeleButton.Location = new System.Drawing.Point(53, 153);
            this.listeleButton.Name = "listeleButton";
            this.listeleButton.Size = new System.Drawing.Size(107, 46);
            this.listeleButton.TabIndex = 8;
            this.listeleButton.Text = "LİSTELE";
            this.listeleButton.UseVisualStyleBackColor = false;
            this.listeleButton.Click += new System.EventHandler(this.listeleButton_Click);
            // 
            // kaydetButton
            // 
            this.kaydetButton.BackColor = System.Drawing.Color.CadetBlue;
            this.kaydetButton.Enabled = false;
            this.kaydetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kaydetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydetButton.ForeColor = System.Drawing.Color.Indigo;
            this.kaydetButton.Location = new System.Drawing.Point(168, 153);
            this.kaydetButton.Name = "kaydetButton";
            this.kaydetButton.Size = new System.Drawing.Size(107, 46);
            this.kaydetButton.TabIndex = 9;
            this.kaydetButton.Text = "KAYDET";
            this.kaydetButton.UseVisualStyleBackColor = false;
            this.kaydetButton.Click += new System.EventHandler(this.kaydetButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(49, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Durum : ";
            // 
            // durumLabel
            // 
            this.durumLabel.AutoSize = true;
            this.durumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.durumLabel.Location = new System.Drawing.Point(124, 223);
            this.durumLabel.Name = "durumLabel";
            this.durumLabel.Size = new System.Drawing.Size(89, 20);
            this.durumLabel.TabIndex = 11;
            this.durumLabel.Text = "Beklemede";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightSlateGray;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripButton,
            this.updateToolStripButton,
            this.versionsToolStripButton,
            this.reportToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(692, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // aboutToolStripButton
            // 
            this.aboutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aboutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripButton.Image")));
            this.aboutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutToolStripButton.Name = "aboutToolStripButton";
            this.aboutToolStripButton.Size = new System.Drawing.Size(61, 22);
            this.aboutToolStripButton.Text = "Hakkında";
            this.aboutToolStripButton.ToolTipText = "Hakkında";
            this.aboutToolStripButton.Click += new System.EventHandler(this.aboutToolStripButton_Click);
            // 
            // updateToolStripButton
            // 
            this.updateToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.updateToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("updateToolStripButton.Image")));
            this.updateToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.updateToolStripButton.Name = "updateToolStripButton";
            this.updateToolStripButton.Size = new System.Drawing.Size(133, 22);
            this.updateToolStripButton.Text = "Güncellemeleri Denetle";
            this.updateToolStripButton.Click += new System.EventHandler(this.updateToolStripButton_Click);
            // 
            // versionsToolStripButton
            // 
            this.versionsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.versionsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("versionsToolStripButton.Image")));
            this.versionsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.versionsToolStripButton.Name = "versionsToolStripButton";
            this.versionsToolStripButton.Size = new System.Drawing.Size(85, 22);
            this.versionsToolStripButton.Text = "Sürüm Notları";
            this.versionsToolStripButton.Click += new System.EventHandler(this.versionsToolStripButton_Click);
            // 
            // reportToolStripButton
            // 
            this.reportToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.reportToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("reportToolStripButton.Image")));
            this.reportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reportToolStripButton.Name = "reportToolStripButton";
            this.reportToolStripButton.Size = new System.Drawing.Size(72, 22);
            this.reportToolStripButton.Text = "Sorun Bildir";
            this.reportToolStripButton.Click += new System.EventHandler(this.reportToolStripButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(692, 358);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.durumLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kaydetButton);
            this.Controls.Add(this.listeleButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.takipEdilenTextBox);
            this.Controls.Add(this.takipciTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insta-Followers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox takipciTextBox;
        private System.Windows.Forms.TextBox takipEdilenTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button listeleButton;
        private System.Windows.Forms.Button kaydetButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label durumLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton aboutToolStripButton;
        private System.Windows.Forms.ToolStripButton updateToolStripButton;
        private System.Windows.Forms.ToolStripButton versionsToolStripButton;
        private System.Windows.Forms.ToolStripButton reportToolStripButton;
    }
}

