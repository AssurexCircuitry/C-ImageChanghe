namespace WindowsFormsApplication1
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
            this.huraForm1 = new Hura_Theme.HuraForm();
            this.label1 = new System.Windows.Forms.Label();
            this.submit = new Hura_Theme.HuraButton();
            this.image = new System.Windows.Forms.PictureBox();
            this.imgUrl = new Hura_Theme.HuraTextBox();
            this.huraForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // huraForm1
            // 
            this.huraForm1.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.huraForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.huraForm1.ColorScheme = Hura_Theme.HuraForm.ColorSchemes.Dark;
            this.huraForm1.Controls.Add(this.label1);
            this.huraForm1.Controls.Add(this.submit);
            this.huraForm1.Controls.Add(this.image);
            this.huraForm1.Controls.Add(this.imgUrl);
            this.huraForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.huraForm1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.huraForm1.ForeColor = System.Drawing.Color.White;
            this.huraForm1.Location = new System.Drawing.Point(0, 0);
            this.huraForm1.Name = "huraForm1";
            this.huraForm1.Size = new System.Drawing.Size(422, 390);
            this.huraForm1.TabIndex = 0;
            this.huraForm1.Text = "huraForm1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Image URL";
            // 
            // submit
            // 
            this.submit.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.submit.ColorScheme = Hura_Theme.HuraButton.ColorSchemes.Dark;
            this.submit.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.submit.ForeColor = System.Drawing.Color.White;
            this.submit.Location = new System.Drawing.Point(11, 300);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(399, 78);
            this.submit.TabIndex = 6;
            this.submit.Text = "Change Image";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(12, 39);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(398, 208);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image.TabIndex = 5;
            this.image.TabStop = false;
            // 
            // imgUrl
            // 
            this.imgUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.imgUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgUrl.ColorScheme = Hura_Theme.HuraTextBox.ColorSchemes.Dark;
            this.imgUrl.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.imgUrl.ForeColor = System.Drawing.Color.White;
            this.imgUrl.Location = new System.Drawing.Point(11, 270);
            this.imgUrl.Name = "imgUrl";
            this.imgUrl.Size = new System.Drawing.Size(399, 24);
            this.imgUrl.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 390);
            this.Controls.Add(this.huraForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.huraForm1.ResumeLayout(false);
            this.huraForm1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Hura_Theme.HuraForm huraForm1;
        private System.Windows.Forms.Label label1;
        private Hura_Theme.HuraButton submit;
        private System.Windows.Forms.PictureBox image;
        private Hura_Theme.HuraTextBox imgUrl;

    }
}

