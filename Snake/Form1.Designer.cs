//namespace Snake
//{
//    partial class Form1
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.components = new System.ComponentModel.Container();
//            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
//            this.canvas = new System.Windows.Forms.PictureBox();
//            this.label1 = new System.Windows.Forms.Label();
//            this.GameTimer = new System.Windows.Forms.Timer(this.components);
//            this.labelGameOver = new System.Windows.Forms.Label();
//            this.labelScore = new System.Windows.Forms.Label();
//            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
//            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.howToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
//            this.menuStrip1.SuspendLayout();
//            this.SuspendLayout();
//            // 
//            // canvas
//            // 
//            this.canvas.BackColor = System.Drawing.Color.LimeGreen;
//            this.canvas.Location = new System.Drawing.Point(12, 65);
//            this.canvas.Name = "canvas";
//            this.canvas.Size = new System.Drawing.Size(661, 504);
//            this.canvas.TabIndex = 0;
//            this.canvas.TabStop = false;
//            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
//            // 
//            // label1
//            // 
//            this.label1.AutoSize = true;
//            this.label1.BackColor = System.Drawing.Color.Transparent;
//            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
//            this.label1.Location = new System.Drawing.Point(683, 107);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(115, 37);
//            this.label1.TabIndex = 1;
//            this.label1.Text = "Score:";
//            // 
//            // labelGameOver
//            // 
//            this.labelGameOver.AutoSize = true;
//            this.labelGameOver.BackColor = System.Drawing.Color.Transparent;
//            this.labelGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
//            this.labelGameOver.Location = new System.Drawing.Point(683, 229);
//            this.labelGameOver.Name = "labelGameOver";
//            this.labelGameOver.Size = new System.Drawing.Size(190, 37);
//            this.labelGameOver.TabIndex = 3;
//            this.labelGameOver.Text = "Game Over";
//            // 
//            // labelScore
//            // 
//            this.labelScore.AutoSize = true;
//            this.labelScore.BackColor = System.Drawing.Color.Transparent;
//            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
//            this.labelScore.Location = new System.Drawing.Point(683, 166);
//            this.labelScore.Name = "labelScore";
//            this.labelScore.Size = new System.Drawing.Size(194, 37);
//            this.labelScore.TabIndex = 2;
//            this.labelScore.Text = "count score";
//            // 
//            // menuStrip1
//            // 
//            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.fileToolStripMenuItem,
//            this.helpToolStripMenuItem});
//            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
//            this.menuStrip1.Name = "menuStrip1";
//            this.menuStrip1.Size = new System.Drawing.Size(979, 24);
//            this.menuStrip1.TabIndex = 4;
//            this.menuStrip1.Text = "menuStrip1";
//            // 
//            // fileToolStripMenuItem
//            // 
//            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.exitToolStripMenuItem});
//            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
//            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
//            this.fileToolStripMenuItem.Text = "File";
//            // 
//            // exitToolStripMenuItem
//            // 
//            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
//            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
//            this.exitToolStripMenuItem.Text = "Exit";
//            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
//            // 
//            // helpToolStripMenuItem
//            // 
//            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.howToPlayToolStripMenuItem,
//            this.aboutToolStripMenuItem});
//            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
//            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
//            this.helpToolStripMenuItem.Text = "Help";
//            // 
//            // howToPlayToolStripMenuItem
//            // 
//            this.howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
//            this.howToPlayToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
//            this.howToPlayToolStripMenuItem.Text = "How to play";
//            this.howToPlayToolStripMenuItem.Click += new System.EventHandler(this.howToPlayToolStripMenuItem_Click);
//            // 
//            // aboutToolStripMenuItem
//            // 
//            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
//            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
//            this.aboutToolStripMenuItem.Text = "About";
//            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
//            // 
//            // Form1
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.BackColor = System.Drawing.Color.LimeGreen;
//            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
//            this.ClientSize = new System.Drawing.Size(979, 581);
//            this.Controls.Add(this.labelGameOver);
//            this.Controls.Add(this.labelScore);
//            this.Controls.Add(this.label1);
//            this.Controls.Add(this.canvas);
//            this.Controls.Add(this.menuStrip1);
//            this.MainMenuStrip = this.menuStrip1;
//            this.Name = "Form1";
//            this.Text = "Snake";
//            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
//            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
//            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
//            this.menuStrip1.ResumeLayout(false);
//            this.menuStrip1.PerformLayout();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.PictureBox canvas;
//        private System.Windows.Forms.Label label1;
//        private System.Windows.Forms.Timer GameTimer;
//        private System.Windows.Forms.Label labelGameOver;
//        private System.Windows.Forms.Label labelScore;
//        private System.Windows.Forms.MenuStrip menuStrip1;
//        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
//    }
//}


namespace Snake
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NikudLable = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.GameOverLable = new System.Windows.Forms.Label();
            this.ScoreLable = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GeneralTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.TimeLable1 = new System.Windows.Forms.Label();
            this.NoticeLable = new System.Windows.Forms.Label();
            this.shit = new System.Windows.Forms.TextBox();
            this.IshurButton = new System.Windows.Forms.Button();
            this.InsertCodeLable = new System.Windows.Forms.Label();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.GayLable = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // NikudLable
            // 
            this.NikudLable.AutoSize = true;
            this.NikudLable.BackColor = System.Drawing.Color.Transparent;
            this.NikudLable.Font = new System.Drawing.Font("Arial", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.NikudLable.Location = new System.Drawing.Point(749, 226);
            this.NikudLable.Name = "NikudLable";
            this.NikudLable.Size = new System.Drawing.Size(85, 34);
            this.NikudLable.TabIndex = 1;
            this.NikudLable.Text = ":ניקוד";
            // 
            // GameOverLable
            // 
            this.GameOverLable.AutoSize = true;
            this.GameOverLable.BackColor = System.Drawing.Color.Transparent;
            this.GameOverLable.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.GameOverLable.Location = new System.Drawing.Point(589, 277);
            this.GameOverLable.Name = "GameOverLable";
            this.GameOverLable.Size = new System.Drawing.Size(171, 34);
            this.GameOverLable.TabIndex = 3;
            this.GameOverLable.Text = "המשחק נגמר";
            // 
            // ScoreLable
            // 
            this.ScoreLable.AutoSize = true;
            this.ScoreLable.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLable.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ScoreLable.Location = new System.Drawing.Point(609, 226);
            this.ScoreLable.Name = "ScoreLable";
            this.ScoreLable.Size = new System.Drawing.Size(166, 34);
            this.ScoreLable.TabIndex = 2;
            this.ScoreLable.Text = "ניקוד מצטבר";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1276, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            this.howToPlayToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToPlayToolStripMenuItem
            // 
            this.howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
            this.howToPlayToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.howToPlayToolStripMenuItem.Text = "How to play";
            this.howToPlayToolStripMenuItem.Click += new System.EventHandler(this.howToPlayToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // GeneralTimer
            // 
            this.GeneralTimer.Tick += new System.EventHandler(this.GeneralTimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(748, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = ":זמן שחלף";
            // 
            // TimeLable1
            // 
            this.TimeLable1.AutoSize = true;
            this.TimeLable1.BackColor = System.Drawing.Color.Transparent;
            this.TimeLable1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TimeLable1.Location = new System.Drawing.Point(588, 173);
            this.TimeLable1.Name = "TimeLable1";
            this.TimeLable1.Size = new System.Drawing.Size(165, 34);
            this.TimeLable1.TabIndex = 7;
            this.TimeLable1.Text = "HH:MM:SS";
            // 
            // NoticeLable
            // 
            this.NoticeLable.AutoSize = true;
            this.NoticeLable.BackColor = System.Drawing.Color.Transparent;
            this.NoticeLable.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.NoticeLable.Location = new System.Drawing.Point(241, 505);
            this.NoticeLable.Name = "NoticeLable";
            this.NoticeLable.Size = new System.Drawing.Size(105, 44);
            this.NoticeLable.TabIndex = 8;
            this.NoticeLable.Text = "הערה";
            // 
            // shit
            // 
            this.shit.Location = new System.Drawing.Point(606, 46);
            this.shit.Multiline = true;
            this.shit.Name = "shit";
            this.shit.Size = new System.Drawing.Size(90, 30);
            this.shit.TabIndex = 9;
            //this.shit.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // IshurButton
            // 
            this.IshurButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.IshurButton.Location = new System.Drawing.Point(606, 84);
            this.IshurButton.Name = "IshurButton";
            this.IshurButton.Size = new System.Drawing.Size(90, 37);
            this.IshurButton.TabIndex = 10;
            this.IshurButton.Text = "אישור";
            this.IshurButton.UseVisualStyleBackColor = true;
            this.IshurButton.Click += new System.EventHandler(this.IshurButton_Click_1);
            // 
            // InsertCodeLable
            // 
            this.InsertCodeLable.AutoSize = true;
            this.InsertCodeLable.BackColor = System.Drawing.Color.Transparent;
            this.InsertCodeLable.Font = new System.Drawing.Font("Arial", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.InsertCodeLable.Location = new System.Drawing.Point(712, 44);
            this.InsertCodeLable.Name = "InsertCodeLable";
            this.InsertCodeLable.Size = new System.Drawing.Size(135, 34);
            this.InsertCodeLable.TabIndex = 11;
            this.InsertCodeLable.Text = ":הכנס קוד";
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.LimeGreen;
            this.canvas.Location = new System.Drawing.Point(16, 46);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(560, 458);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.BackgroundImageChanged += new System.EventHandler(this.canvas_BackgroundImageChanged);
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // GayLable
            // 
            this.GayLable.AutoSize = true;
            this.GayLable.BackColor = System.Drawing.Color.Transparent;
            this.GayLable.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.GayLable.Location = new System.Drawing.Point(190, 549);
            this.GayLable.Name = "GayLable";
            this.GayLable.Size = new System.Drawing.Size(193, 44);
            this.GayLable.TabIndex = 12;
            this.GayLable.Text = "...איזה הומו";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1276, 881);
            this.Controls.Add(this.GayLable);
            this.Controls.Add(this.InsertCodeLable);
            this.Controls.Add(this.IshurButton);
            this.Controls.Add(this.shit);
            this.Controls.Add(this.NoticeLable);
            this.Controls.Add(this.TimeLable1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GameOverLable);
            this.Controls.Add(this.ScoreLable);
            this.Controls.Add(this.NikudLable);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = " ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NikudLable;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label GameOverLable;
        private System.Windows.Forms.Label ScoreLable;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.Timer GeneralTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TimeLable1;
        private System.Windows.Forms.Label NoticeLable;
        private System.Windows.Forms.TextBox shit;
        private System.Windows.Forms.Button IshurButton;
        private System.Windows.Forms.Label InsertCodeLable;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Label GayLable;
    }
}

