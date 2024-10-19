namespace Snake
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToPlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.canvas1 = new System.Windows.Forms.PictureBox();
            this.ScoreLable1 = new System.Windows.Forms.Label();
            this.Score1Lable = new System.Windows.Forms.Label();
            this.GameOverLable1 = new System.Windows.Forms.Label();
            this.canvas2 = new System.Windows.Forms.PictureBox();
            this.ScoreLable2 = new System.Windows.Forms.Label();
            this.Score2Lable = new System.Windows.Forms.Label();
            this.GameOverLable2 = new System.Windows.Forms.Label();
            this.GayLable1 = new System.Windows.Forms.Label();
            this.GayLable2 = new System.Windows.Forms.Label();
            this.TimeLable = new System.Windows.Forms.Label();
            this.TimePassedLable = new System.Windows.Forms.Label();
            this.GeneralTimer = new System.Windows.Forms.Timer(this.components);
            this.DrawLable = new System.Windows.Forms.Label();
            this.NoticeLable1 = new System.Windows.Forms.Label();
            this.NoticeLable2 = new System.Windows.Forms.Label();
            this.InsertCodeLable2 = new System.Windows.Forms.Label();
            this.IshurButton2 = new System.Windows.Forms.Button();
            this.shit2 = new System.Windows.Forms.TextBox();
            this.InsertCodeLable1 = new System.Windows.Forms.Label();
            this.IshurButton1 = new System.Windows.Forms.Button();
            this.shit1 = new System.Windows.Forms.TextBox();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1276, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.restartToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToPlToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToPlToolStripMenuItem
            // 
            this.howToPlToolStripMenuItem.Name = "howToPlToolStripMenuItem";
            this.howToPlToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.howToPlToolStripMenuItem.Text = "How to play";
            this.howToPlToolStripMenuItem.Click += new System.EventHandler(this.howToPlToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_1);
            // 
            // canvas1
            // 
            this.canvas1.BackColor = System.Drawing.Color.LimeGreen;
            this.canvas1.Location = new System.Drawing.Point(44, 58);
            this.canvas1.Name = "canvas1";
            this.canvas1.Size = new System.Drawing.Size(543, 288);
            this.canvas1.TabIndex = 1;
            this.canvas1.TabStop = false;
            this.canvas1.BackgroundImageChanged += new System.EventHandler(this.canvas1_BackgroundImageChanged);
            this.canvas1.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas1_Paint);
            // 
            // ScoreLable1
            // 
            this.ScoreLable1.AutoSize = true;
            this.ScoreLable1.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLable1.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ScoreLable1.Location = new System.Drawing.Point(736, 58);
            this.ScoreLable1.Name = "ScoreLable1";
            this.ScoreLable1.Size = new System.Drawing.Size(81, 32);
            this.ScoreLable1.TabIndex = 2;
            this.ScoreLable1.Text = ":ניקוד";
            // 
            // Score1Lable
            // 
            this.Score1Lable.AutoSize = true;
            this.Score1Lable.BackColor = System.Drawing.Color.Transparent;
            this.Score1Lable.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Score1Lable.Location = new System.Drawing.Point(622, 58);
            this.Score1Lable.Name = "Score1Lable";
            this.Score1Lable.Size = new System.Drawing.Size(106, 32);
            this.Score1Lable.TabIndex = 3;
            this.Score1Lable.Text = "Score1";
            // 
            // GameOverLable1
            // 
            this.GameOverLable1.AutoSize = true;
            this.GameOverLable1.BackColor = System.Drawing.Color.Transparent;
            this.GameOverLable1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.GameOverLable1.Location = new System.Drawing.Point(623, 114);
            this.GameOverLable1.Name = "GameOverLable1";
            this.GameOverLable1.Size = new System.Drawing.Size(162, 32);
            this.GameOverLable1.TabIndex = 4;
            this.GameOverLable1.Text = "Game Over";
            // 
            // canvas2
            // 
            this.canvas2.BackColor = System.Drawing.Color.LimeGreen;
            this.canvas2.Location = new System.Drawing.Point(44, 378);
            this.canvas2.Name = "canvas2";
            this.canvas2.Size = new System.Drawing.Size(543, 288);
            this.canvas2.TabIndex = 7;
            this.canvas2.TabStop = false;
            this.canvas2.BackgroundImageChanged += new System.EventHandler(this.canvas2_BackgroundImageChanged);
            this.canvas2.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas2_Paint);
            // 
            // ScoreLable2
            // 
            this.ScoreLable2.AutoSize = true;
            this.ScoreLable2.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLable2.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLable2.Location = new System.Drawing.Point(736, 409);
            this.ScoreLable2.Name = "ScoreLable2";
            this.ScoreLable2.Size = new System.Drawing.Size(81, 32);
            this.ScoreLable2.TabIndex = 8;
            this.ScoreLable2.Text = ":ניקוד";
            // 
            // Score2Lable
            // 
            this.Score2Lable.AutoSize = true;
            this.Score2Lable.BackColor = System.Drawing.Color.Transparent;
            this.Score2Lable.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Score2Lable.Location = new System.Drawing.Point(623, 409);
            this.Score2Lable.Name = "Score2Lable";
            this.Score2Lable.Size = new System.Drawing.Size(106, 32);
            this.Score2Lable.TabIndex = 9;
            this.Score2Lable.Text = "Score2";
            // 
            // GameOverLable2
            // 
            this.GameOverLable2.AutoSize = true;
            this.GameOverLable2.BackColor = System.Drawing.Color.Transparent;
            this.GameOverLable2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.GameOverLable2.Location = new System.Drawing.Point(623, 465);
            this.GameOverLable2.Name = "GameOverLable2";
            this.GameOverLable2.Size = new System.Drawing.Size(162, 32);
            this.GameOverLable2.TabIndex = 10;
            this.GameOverLable2.Text = "Game Over";
            // 
            // GayLable1
            // 
            this.GayLable1.AutoSize = true;
            this.GayLable1.BackColor = System.Drawing.Color.Transparent;
            this.GayLable1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.GayLable1.Location = new System.Drawing.Point(214, 170);
            this.GayLable1.Name = "GayLable1";
            this.GayLable1.Size = new System.Drawing.Size(195, 41);
            this.GayLable1.TabIndex = 12;
            this.GayLable1.Text = "... איזה הומו";
            this.GayLable1.Visible = false;
            // 
            // GayLable2
            // 
            this.GayLable2.AutoSize = true;
            this.GayLable2.BackColor = System.Drawing.Color.Transparent;
            this.GayLable2.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.GayLable2.Location = new System.Drawing.Point(214, 496);
            this.GayLable2.Name = "GayLable2";
            this.GayLable2.Size = new System.Drawing.Size(195, 41);
            this.GayLable2.TabIndex = 13;
            this.GayLable2.Text = "... איזה הומו";
            this.GayLable2.Visible = false;
            // 
            // TimeLable
            // 
            this.TimeLable.AutoSize = true;
            this.TimeLable.BackColor = System.Drawing.Color.Transparent;
            this.TimeLable.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TimeLable.Location = new System.Drawing.Point(622, 349);
            this.TimeLable.Name = "TimeLable";
            this.TimeLable.Size = new System.Drawing.Size(153, 32);
            this.TimeLable.TabIndex = 15;
            this.TimeLable.Text = "HH:MM:SS";
            // 
            // TimePassedLable
            // 
            this.TimePassedLable.AutoSize = true;
            this.TimePassedLable.BackColor = System.Drawing.Color.Transparent;
            this.TimePassedLable.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TimePassedLable.Location = new System.Drawing.Point(746, 348);
            this.TimePassedLable.Name = "TimePassedLable";
            this.TimePassedLable.Size = new System.Drawing.Size(135, 32);
            this.TimePassedLable.TabIndex = 14;
            this.TimePassedLable.Text = ":זמן שחלף";
            // 
            // GeneralTimer
            // 
            this.GeneralTimer.Tick += new System.EventHandler(this.GeneralTimer_Tick);
            // 
            // DrawLable
            // 
            this.DrawLable.AutoSize = true;
            this.DrawLable.BackColor = System.Drawing.Color.Transparent;
            this.DrawLable.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DrawLable.Location = new System.Drawing.Point(269, 341);
            this.DrawLable.Name = "DrawLable";
            this.DrawLable.Size = new System.Drawing.Size(113, 41);
            this.DrawLable.TabIndex = 16;
            this.DrawLable.Text = "!!!תיקו";
            this.DrawLable.Visible = false;
            // 
            // NoticeLable1
            // 
            this.NoticeLable1.AutoSize = true;
            this.NoticeLable1.BackColor = System.Drawing.Color.Transparent;
            this.NoticeLable1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.NoticeLable1.Location = new System.Drawing.Point(661, 157);
            this.NoticeLable1.Name = "NoticeLable1";
            this.NoticeLable1.Size = new System.Drawing.Size(78, 32);
            this.NoticeLable1.TabIndex = 17;
            this.NoticeLable1.Text = "הערה";
            // 
            // NoticeLable2
            // 
            this.NoticeLable2.AutoSize = true;
            this.NoticeLable2.BackColor = System.Drawing.Color.Transparent;
            this.NoticeLable2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.NoticeLable2.Location = new System.Drawing.Point(661, 505);
            this.NoticeLable2.Name = "NoticeLable2";
            this.NoticeLable2.Size = new System.Drawing.Size(78, 32);
            this.NoticeLable2.TabIndex = 18;
            this.NoticeLable2.Text = "הערה";
            // 
            // InsertCodeLable2
            // 
            this.InsertCodeLable2.AutoSize = true;
            this.InsertCodeLable2.BackColor = System.Drawing.Color.Transparent;
            this.InsertCodeLable2.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.InsertCodeLable2.Location = new System.Drawing.Point(735, 589);
            this.InsertCodeLable2.Name = "InsertCodeLable2";
            this.InsertCodeLable2.Size = new System.Drawing.Size(128, 32);
            this.InsertCodeLable2.TabIndex = 21;
            this.InsertCodeLable2.Text = ":הכנס קוד";
            // 
            // IshurButton2
            // 
            this.IshurButton2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.IshurButton2.Location = new System.Drawing.Point(629, 629);
            this.IshurButton2.Name = "IshurButton2";
            this.IshurButton2.Size = new System.Drawing.Size(90, 37);
            this.IshurButton2.TabIndex = 20;
            this.IshurButton2.Text = "אישור";
            this.IshurButton2.UseVisualStyleBackColor = true;
            this.IshurButton2.Click += new System.EventHandler(this.IshurButton2_Click);
            // 
            // shit2
            // 
            this.shit2.Location = new System.Drawing.Point(629, 591);
            this.shit2.Multiline = true;
            this.shit2.Name = "shit2";
            this.shit2.Size = new System.Drawing.Size(90, 30);
            this.shit2.TabIndex = 19;
            this.shit2.TextChanged += new System.EventHandler(this.shit2_TextChanged);
            // 
            // InsertCodeLable1
            // 
            this.InsertCodeLable1.AutoSize = true;
            this.InsertCodeLable1.BackColor = System.Drawing.Color.Transparent;
            this.InsertCodeLable1.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.InsertCodeLable1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InsertCodeLable1.Location = new System.Drawing.Point(726, 252);
            this.InsertCodeLable1.Name = "InsertCodeLable1";
            this.InsertCodeLable1.Size = new System.Drawing.Size(128, 32);
            this.InsertCodeLable1.TabIndex = 24;
            this.InsertCodeLable1.Text = ":הכנס קוד";
            // 
            // IshurButton1
            // 
            this.IshurButton1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.IshurButton1.Location = new System.Drawing.Point(620, 292);
            this.IshurButton1.Name = "IshurButton1";
            this.IshurButton1.Size = new System.Drawing.Size(90, 37);
            this.IshurButton1.TabIndex = 23;
            this.IshurButton1.Text = "אישור";
            this.IshurButton1.UseVisualStyleBackColor = true;
            this.IshurButton1.Click += new System.EventHandler(this.IshurButton1_Click);
            // 
            // shit1
            // 
            this.shit1.Location = new System.Drawing.Point(620, 254);
            this.shit1.Multiline = true;
            this.shit1.Name = "shit1";
            this.shit1.Size = new System.Drawing.Size(90, 30);
            this.shit1.TabIndex = 22;
            this.shit1.TextChanged += new System.EventHandler(this.shit1_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1276, 733);
            this.Controls.Add(this.InsertCodeLable1);
            this.Controls.Add(this.IshurButton1);
            this.Controls.Add(this.shit1);
            this.Controls.Add(this.InsertCodeLable2);
            this.Controls.Add(this.IshurButton2);
            this.Controls.Add(this.shit2);
            this.Controls.Add(this.NoticeLable2);
            this.Controls.Add(this.NoticeLable1);
            this.Controls.Add(this.DrawLable);
            this.Controls.Add(this.TimeLable);
            this.Controls.Add(this.TimePassedLable);
            this.Controls.Add(this.GayLable2);
            this.Controls.Add(this.GayLable1);
            this.Controls.Add(this.GameOverLable2);
            this.Controls.Add(this.Score2Lable);
            this.Controls.Add(this.ScoreLable2);
            this.Controls.Add(this.canvas2);
            this.Controls.Add(this.GameOverLable1);
            this.Controls.Add(this.Score1Lable);
            this.Controls.Add(this.ScoreLable1);
            this.Controls.Add(this.canvas1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Form2";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox canvas1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToPlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label ScoreLable1;
        private System.Windows.Forms.Label Score1Lable;
        private System.Windows.Forms.Label GameOverLable1;
        private System.Windows.Forms.PictureBox canvas2;
        private System.Windows.Forms.Label ScoreLable2;
        private System.Windows.Forms.Label Score2Lable;
        private System.Windows.Forms.Label GameOverLable2;
        private System.Windows.Forms.Label GayLable1;
        private System.Windows.Forms.Label GayLable2;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.Label TimeLable;
        private System.Windows.Forms.Label TimePassedLable;
        private System.Windows.Forms.Timer GeneralTimer;
        private System.Windows.Forms.Label DrawLable;
        private System.Windows.Forms.Label NoticeLable1;
        private System.Windows.Forms.Label NoticeLable2;
        private System.Windows.Forms.Label InsertCodeLable2;
        private System.Windows.Forms.Button IshurButton2;
        private System.Windows.Forms.TextBox shit2;
        private System.Windows.Forms.Label InsertCodeLable1;
        private System.Windows.Forms.Button IshurButton1;
        private System.Windows.Forms.TextBox shit1;
    }
}