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
            this.canvas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.labelGameOver = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelHighScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.LimeGreen;
            this.canvas.Location = new System.Drawing.Point(12, 65);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(661, 504);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(683, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score:";
            // 
            // labelGameOver
            // 
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.BackColor = System.Drawing.Color.Transparent;
            this.labelGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelGameOver.Location = new System.Drawing.Point(683, 229);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(190, 37);
            this.labelGameOver.TabIndex = 3;
            this.labelGameOver.Text = "Game Over";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelScore.Location = new System.Drawing.Point(683, 166);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(194, 37);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "count score";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(979, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            this.howToPlayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.howToPlayToolStripMenuItem.Text = "How to play";
            this.howToPlayToolStripMenuItem.Click += new System.EventHandler(this.howToPlayToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // labelHighScore
            // 
            this.labelHighScore.AutoSize = true;
            this.labelHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelHighScore.Location = new System.Drawing.Point(690, 386);
            this.labelHighScore.Name = "labelHighScore";
            this.labelHighScore.Size = new System.Drawing.Size(195, 37);
            this.labelHighScore.TabIndex = 5;
            this.labelHighScore.Text = "High Score:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(979, 581);
            this.Controls.Add(this.labelHighScore);
            this.Controls.Add(this.labelGameOver);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Snake";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label labelGameOver;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label labelHighScore;
    }
}

