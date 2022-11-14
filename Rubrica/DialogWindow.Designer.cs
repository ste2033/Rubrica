namespace Rubrica
{
    partial class DialogWindow
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
            this.confermaLabel = new System.Windows.Forms.Label();
            this.siButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // confermaLabel
            // 
            this.confermaLabel.AutoSize = true;
            this.confermaLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confermaLabel.Location = new System.Drawing.Point(73, 9);
            this.confermaLabel.Name = "confermaLabel";
            this.confermaLabel.Size = new System.Drawing.Size(138, 38);
            this.confermaLabel.TabIndex = 0;
            this.confermaLabel.Text = "Conferma";
            this.confermaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siButton
            // 
            this.siButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siButton.Location = new System.Drawing.Point(12, 105);
            this.siButton.Name = "siButton";
            this.siButton.Size = new System.Drawing.Size(98, 46);
            this.siButton.TabIndex = 1;
            this.siButton.Text = "Si";
            this.siButton.UseVisualStyleBackColor = true;
            this.siButton.Click += new System.EventHandler(this.siButton_Click);
            // 
            // noButton
            // 
            this.noButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noButton.Location = new System.Drawing.Point(172, 105);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(98, 46);
            this.noButton.TabIndex = 2;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // DialogWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 175);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.siButton);
            this.Controls.Add(this.confermaLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DialogWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label confermaLabel;
        private System.Windows.Forms.Button siButton;
        private System.Windows.Forms.Button noButton;
    }
}