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
            codiceTextBox = new System.Windows.Forms.TextBox();
            nomeTextBox = new System.Windows.Forms.TextBox();
            telefonoTextBox = new System.Windows.Forms.TextBox();
            noteTextBox = new System.Windows.Forms.TextBox();
            codiceLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            confermaButton = new System.Windows.Forms.Button();
            annullaButton = new System.Windows.Forms.Button();
            eliminaButton = new System.Windows.Forms.Button();
            noteLabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // codiceTextBox
            // 
            codiceTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            codiceTextBox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            codiceTextBox.Location = new System.Drawing.Point(397, 23);
            codiceTextBox.Name = "codiceTextBox";
            codiceTextBox.PlaceholderText = "Codice";
            codiceTextBox.Size = new System.Drawing.Size(785, 43);
            codiceTextBox.TabIndex = 1;
            // 
            // nomeTextBox
            // 
            nomeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            nomeTextBox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            nomeTextBox.Location = new System.Drawing.Point(397, 72);
            nomeTextBox.Name = "nomeTextBox";
            nomeTextBox.PlaceholderText = "Nome/Cognome";
            nomeTextBox.Size = new System.Drawing.Size(785, 43);
            nomeTextBox.TabIndex = 2;
            // 
            // telefonoTextBox
            // 
            telefonoTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            telefonoTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            telefonoTextBox.Location = new System.Drawing.Point(397, 121);
            telefonoTextBox.Name = "telefonoTextBox";
            telefonoTextBox.PlaceholderText = "N° telefono";
            telefonoTextBox.Size = new System.Drawing.Size(785, 47);
            telefonoTextBox.TabIndex = 4;
            // 
            // noteTextBox
            // 
            noteTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            noteTextBox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            noteTextBox.Location = new System.Drawing.Point(397, 174);
            noteTextBox.Multiline = true;
            noteTextBox.Name = "noteTextBox";
            noteTextBox.PlaceholderText = "Note";
            noteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            noteTextBox.Size = new System.Drawing.Size(785, 191);
            noteTextBox.TabIndex = 5;
            noteTextBox.KeyPress += noteTextBox_KeyPress;
            // 
            // codiceLabel
            // 
            codiceLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            codiceLabel.AutoSize = true;
            codiceLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            codiceLabel.Location = new System.Drawing.Point(266, 26);
            codiceLabel.Name = "codiceLabel";
            codiceLabel.Size = new System.Drawing.Size(107, 38);
            codiceLabel.TabIndex = 0;
            codiceLabel.Text = "Codice:";
            // 
            // nomeLabel
            // 
            nomeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            nomeLabel.Location = new System.Drawing.Point(274, 75);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(99, 38);
            nomeLabel.TabIndex = 6;
            nomeLabel.Text = "Nome:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            telefonoLabel.AutoSize = true;
            telefonoLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            telefonoLabel.Location = new System.Drawing.Point(244, 127);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(129, 38);
            telefonoLabel.TabIndex = 8;
            telefonoLabel.Text = "Telefono:";
            // 
            // confermaButton
            // 
            confermaButton.BackColor = System.Drawing.Color.PaleGreen;
            confermaButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            confermaButton.Location = new System.Drawing.Point(12, 26);
            confermaButton.Name = "confermaButton";
            confermaButton.Size = new System.Drawing.Size(204, 70);
            confermaButton.TabIndex = 6;
            confermaButton.Text = "SALVA";
            confermaButton.UseVisualStyleBackColor = false;
            confermaButton.Click += confermaButton_Click;
            // 
            // annullaButton
            // 
            annullaButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            annullaButton.Location = new System.Drawing.Point(12, 160);
            annullaButton.Name = "annullaButton";
            annullaButton.Size = new System.Drawing.Size(204, 70);
            annullaButton.TabIndex = 7;
            annullaButton.Text = "INDIETRO";
            annullaButton.UseVisualStyleBackColor = false;
            annullaButton.Click += annullaButton_Click;
            // 
            // eliminaButton
            // 
            eliminaButton.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            eliminaButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            eliminaButton.ForeColor = System.Drawing.Color.Black;
            eliminaButton.Location = new System.Drawing.Point(12, 295);
            eliminaButton.Name = "eliminaButton";
            eliminaButton.Size = new System.Drawing.Size(204, 70);
            eliminaButton.TabIndex = 9;
            eliminaButton.Text = "CANCELLA";
            eliminaButton.UseVisualStyleBackColor = false;
            eliminaButton.Click += eliminaButton_Click;
            // 
            // noteLabel
            // 
            noteLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            noteLabel.AutoSize = true;
            noteLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            noteLabel.Location = new System.Drawing.Point(289, 177);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new System.Drawing.Size(84, 38);
            noteLabel.TabIndex = 10;
            noteLabel.Text = "Note:";
            // 
            // Form1
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            ClientSize = new System.Drawing.Size(1195, 391);
            Controls.Add(noteLabel);
            Controls.Add(eliminaButton);
            Controls.Add(annullaButton);
            Controls.Add(confermaButton);
            Controls.Add(telefonoLabel);
            Controls.Add(nomeLabel);
            Controls.Add(codiceLabel);
            Controls.Add(noteTextBox);
            Controls.Add(telefonoTextBox);
            Controls.Add(nomeTextBox);
            Controls.Add(codiceTextBox);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Text = "AddRecord";
            FormClosing += Form1_FormClosing;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox codiceTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.Label codiceLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label telefonoLabel;
        private System.Windows.Forms.Button confermaButton;
        private System.Windows.Forms.Button annullaButton;
        private System.Windows.Forms.Button eliminaButton;
        private System.Windows.Forms.Label noteLabel;
    }
}
