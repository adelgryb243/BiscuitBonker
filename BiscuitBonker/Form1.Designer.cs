namespace BiscuitBonker
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
            this.cookieButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cookieButton
            // 
            this.cookieButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cookieButton.BackgroundImage")));
            this.cookieButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cookieButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cookieButton.Location = new System.Drawing.Point(274, 129);
            this.cookieButton.Name = "cookieButton";
            this.cookieButton.Size = new System.Drawing.Size(379, 350);
            this.cookieButton.TabIndex = 0;
            this.cookieButton.UseVisualStyleBackColor = true;
            this.cookieButton.Click += new System.EventHandler(this.cookieButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(689, 144);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(241, 311);
            this.outputLabel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 649);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.cookieButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Biscuit Bonker!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cookieButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

