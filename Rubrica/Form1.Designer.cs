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
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.confermaButton = new System.Windows.Forms.Button();
            this.annullaButton = new System.Windows.Forms.Button();
            this.eliminaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // codiceTextBox
            // 
            this.codiceTextBox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.codiceTextBox.Location = new System.Drawing.Point(189, 23);
            this.codiceTextBox.Name = "codiceTextBox";
            this.codiceTextBox.PlaceholderText = "Codice";
            this.codiceTextBox.Size = new System.Drawing.Size(239, 43);
            this.codiceTextBox.TabIndex = 1;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nomeTextBox.Location = new System.Drawing.Point(189, 72);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.PlaceholderText = "Nome/Cognome";
            this.nomeTextBox.Size = new System.Drawing.Size(239, 43);
            this.nomeTextBox.TabIndex = 2;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.telefonoTextBox.Location = new System.Drawing.Point(189, 121);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.PlaceholderText = "N° telefono";
            this.telefonoTextBox.Size = new System.Drawing.Size(239, 47);
            this.telefonoTextBox.TabIndex = 4;
            // 
            // noteTextBox
            // 
            this.noteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteTextBox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noteTextBox.Location = new System.Drawing.Point(446, 12);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.PlaceholderText = "Note";
            this.noteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.noteTextBox.Size = new System.Drawing.Size(517, 326);
            this.noteTextBox.TabIndex = 5;
            this.noteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noteTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codice:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(39, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(9, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 38);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefono:";
            // 
            // confermaButton
            // 
            this.confermaButton.BackColor = System.Drawing.Color.PaleGreen;
            this.confermaButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confermaButton.Location = new System.Drawing.Point(16, 271);
            this.confermaButton.Name = "confermaButton";
            this.confermaButton.Size = new System.Drawing.Size(154, 70);
            this.confermaButton.TabIndex = 6;
            this.confermaButton.Text = "SALVA";
            this.confermaButton.UseVisualStyleBackColor = false;
            this.confermaButton.Click += new System.EventHandler(this.confermaButton_Click);
            // 
            // annullaButton
            // 
            this.annullaButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.annullaButton.Location = new System.Drawing.Point(176, 271);
            this.annullaButton.Name = "annullaButton";
            this.annullaButton.Size = new System.Drawing.Size(123, 70);
            this.annullaButton.TabIndex = 7;
            this.annullaButton.Text = "INDIETRO";
            this.annullaButton.UseVisualStyleBackColor = true;
            this.annullaButton.Click += new System.EventHandler(this.annullaButton_Click);
            // 
            // eliminaButton
            // 
            this.eliminaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.eliminaButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eliminaButton.ForeColor = System.Drawing.Color.Black;
            this.eliminaButton.Location = new System.Drawing.Point(305, 271);
            this.eliminaButton.Name = "eliminaButton";
            this.eliminaButton.Size = new System.Drawing.Size(123, 70);
            this.eliminaButton.TabIndex = 9;
            this.eliminaButton.Text = "CANC";
            this.eliminaButton.UseVisualStyleBackColor = false;
            this.eliminaButton.Click += new System.EventHandler(this.eliminaButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(982, 353);
            this.Controls.Add(this.eliminaButton);
            this.Controls.Add(this.annullaButton);
            this.Controls.Add(this.confermaButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.codiceTextBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AddRecord";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codiceTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button confermaButton;
        private System.Windows.Forms.Button annullaButton;
        private System.Windows.Forms.Button eliminaButton;
    }
}
