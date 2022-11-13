namespace Rubrica
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
            this.codiceTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.cognomeTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // codiceTextBox
            // 
            this.codiceTextBox.Location = new System.Drawing.Point(100, 22);
            this.codiceTextBox.Name = "codiceTextBox";
            this.codiceTextBox.PlaceholderText = "Codice";
            this.codiceTextBox.Size = new System.Drawing.Size(125, 27);
            this.codiceTextBox.TabIndex = 0;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(100, 55);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.PlaceholderText = "Nome";
            this.nomeTextBox.Size = new System.Drawing.Size(125, 27);
            this.nomeTextBox.TabIndex = 1;
            // 
            // cognomeTextBox
            // 
            this.cognomeTextBox.Location = new System.Drawing.Point(100, 88);
            this.cognomeTextBox.Name = "cognomeTextBox";
            this.cognomeTextBox.PlaceholderText = "Cognome";
            this.cognomeTextBox.Size = new System.Drawing.Size(125, 27);
            this.cognomeTextBox.TabIndex = 2;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.Location = new System.Drawing.Point(100, 121);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.PlaceholderText = "N° telefono";
            this.telefonoTextBox.Size = new System.Drawing.Size(125, 27);
            this.telefonoTextBox.TabIndex = 3;
            // 
            // noteTextBox
            // 
            this.noteTextBox.AcceptsReturn = true;
            this.noteTextBox.AcceptsTab = true;
            this.noteTextBox.Location = new System.Drawing.Point(295, 12);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.PlaceholderText = "Note";
            this.noteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.noteTextBox.Size = new System.Drawing.Size(493, 319);
            this.noteTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(this.cognomeTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.codiceTextBox);
            this.Name = "Form1";
            this.Text = "AddRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codiceTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox cognomeTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
