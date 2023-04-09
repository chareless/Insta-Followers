namespace InstagramFollowersDesktop
{
    partial class Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.durumLabel = new System.Windows.Forms.Label();
            this.mevcutLabel = new System.Windows.Forms.Label();
            this.guncelLabel = new System.Windows.Forms.Label();
            this.indirButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mevcut Sürüm :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(40, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Güncel Sürüm :";
            // 
            // durumLabel
            // 
            this.durumLabel.AutoSize = true;
            this.durumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.durumLabel.Location = new System.Drawing.Point(40, 165);
            this.durumLabel.Name = "durumLabel";
            this.durumLabel.Size = new System.Drawing.Size(114, 20);
            this.durumLabel.TabIndex = 2;
            this.durumLabel.Text = "Sürüm durumu";
            // 
            // mevcutLabel
            // 
            this.mevcutLabel.AutoSize = true;
            this.mevcutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mevcutLabel.Location = new System.Drawing.Point(200, 50);
            this.mevcutLabel.Name = "mevcutLabel";
            this.mevcutLabel.Size = new System.Drawing.Size(60, 20);
            this.mevcutLabel.TabIndex = 3;
            this.mevcutLabel.Text = "Mevcut";
            // 
            // guncelLabel
            // 
            this.guncelLabel.AutoSize = true;
            this.guncelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelLabel.Location = new System.Drawing.Point(200, 100);
            this.guncelLabel.Name = "guncelLabel";
            this.guncelLabel.Size = new System.Drawing.Size(60, 20);
            this.guncelLabel.TabIndex = 4;
            this.guncelLabel.Text = "Güncel";
            // 
            // indirButton
            // 
            this.indirButton.BackColor = System.Drawing.Color.CadetBlue;
            this.indirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.indirButton.ForeColor = System.Drawing.Color.Indigo;
            this.indirButton.Location = new System.Drawing.Point(368, 153);
            this.indirButton.Name = "indirButton";
            this.indirButton.Size = new System.Drawing.Size(107, 46);
            this.indirButton.TabIndex = 9;
            this.indirButton.Text = "İndir";
            this.indirButton.UseVisualStyleBackColor = false;
            this.indirButton.Click += new System.EventHandler(this.indirButton_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(530, 286);
            this.Controls.Add(this.indirButton);
            this.Controls.Add(this.guncelLabel);
            this.Controls.Add(this.mevcutLabel);
            this.Controls.Add(this.durumLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Güncellemeleri Denetle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label durumLabel;
        private System.Windows.Forms.Label mevcutLabel;
        private System.Windows.Forms.Label guncelLabel;
        private System.Windows.Forms.Button indirButton;
    }
}