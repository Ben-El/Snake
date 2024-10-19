namespace Snake
{
    partial class ChooseOption
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
            this.SinglePlayerButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TwoPlayesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SinglePlayerButton
            // 
            this.SinglePlayerButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.SinglePlayerButton.Location = new System.Drawing.Point(129, 12);
            this.SinglePlayerButton.Name = "SinglePlayerButton";
            this.SinglePlayerButton.Size = new System.Drawing.Size(255, 65);
            this.SinglePlayerButton.TabIndex = 1;
            this.SinglePlayerButton.Text = "Single Player";
            this.SinglePlayerButton.UseVisualStyleBackColor = false;
            this.SinglePlayerButton.Click += new System.EventHandler(this.SinglePlayerButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BackButton.Location = new System.Drawing.Point(129, 195);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(255, 67);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.CadetBlue;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox2.Location = new System.Drawing.Point(176, 313);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(178, 32);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "By Ben-El, 2015 © ";
            // 
            // TwoPlayesButton
            // 
            this.TwoPlayesButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.TwoPlayesButton.Location = new System.Drawing.Point(129, 103);
            this.TwoPlayesButton.Name = "TwoPlayesButton";
            this.TwoPlayesButton.Size = new System.Drawing.Size(255, 66);
            this.TwoPlayesButton.TabIndex = 6;
            this.TwoPlayesButton.Text = "2 Players";
            this.TwoPlayesButton.UseVisualStyleBackColor = false;
            this.TwoPlayesButton.Click += new System.EventHandler(this.TwoPlayesButton_Click);
            // 
            // ChooseOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(532, 387);
            this.Controls.Add(this.TwoPlayesButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SinglePlayerButton);
            this.Name = "ChooseOption";
            this.Text = "ChooseOption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SinglePlayerButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button TwoPlayesButton;

    }
}