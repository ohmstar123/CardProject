namespace CardProject
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
            this.Title = new System.Windows.Forms.Label();
            this.Image_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Ivory;
            this.Title.Font = new System.Drawing.Font("Prestige Elite Std", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(726, 292);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(62, 31);
            this.Title.TabIndex = 2;
            this.Title.Text = "LEO";
            // 
            // Image_button
            // 
            this.Image_button.BackgroundImage = global::CardProject.Properties.Resources.lion_king_wd070;
            this.Image_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Image_button.CausesValidation = false;
            this.Image_button.FlatAppearance.BorderSize = 0;
            this.Image_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Image_button.Location = new System.Drawing.Point(12, -1);
            this.Image_button.Name = "Image_button";
            this.Image_button.Size = new System.Drawing.Size(699, 452);
            this.Image_button.TabIndex = 3;
            this.Image_button.UseVisualStyleBackColor = true;
            this.Image_button.Click += new System.EventHandler(this.Image_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Image_button);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Image_button;
    }
}

