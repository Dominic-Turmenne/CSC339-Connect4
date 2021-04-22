
namespace CSC339_Connect4
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameBox1 = new System.Windows.Forms.TextBox();
            this.nameBox2 = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.welcomeMessageBox = new System.Windows.Forms.Label();
            this.playerTextLabel = new System.Windows.Forms.Label();
            this.column1 = new System.Windows.Forms.Button();
            this.column2 = new System.Windows.Forms.Button();
            this.column3 = new System.Windows.Forms.Button();
            this.column4 = new System.Windows.Forms.Button();
            this.column5 = new System.Windows.Forms.Button();
            this.column6 = new System.Windows.Forms.Button();
            this.column7 = new System.Windows.Forms.Button();
            this.rulesLabel = new System.Windows.Forms.Label();
            this.rulesTitleLabel = new System.Windows.Forms.Label();
            this.currentPlayerLabel = new System.Windows.Forms.Label();
            this.columnFullLabel = new System.Windows.Forms.Label();
            this.confettiPictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confettiPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameMenuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1253, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameMenuToolStripMenuItem
            // 
            this.gameMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.gameMenuToolStripMenuItem.Name = "gameMenuToolStripMenuItem";
            this.gameMenuToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.gameMenuToolStripMenuItem.Text = "Game Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.NewGameToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 21);
            this.helpToolStripMenuItem.Text = "Rules";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // nameBox1
            // 
            this.nameBox1.Location = new System.Drawing.Point(840, 176);
            this.nameBox1.Name = "nameBox1";
            this.nameBox1.Size = new System.Drawing.Size(187, 20);
            this.nameBox1.TabIndex = 3;
            this.nameBox1.TextChanged += new System.EventHandler(this.NameBox1_TextChanged);
            // 
            // nameBox2
            // 
            this.nameBox2.Location = new System.Drawing.Point(840, 223);
            this.nameBox2.Name = "nameBox2";
            this.nameBox2.Size = new System.Drawing.Size(187, 20);
            this.nameBox2.TabIndex = 4;
            this.nameBox2.TextChanged += new System.EventHandler(this.NameBox2_TextChanged);
            // 
            // startButton
            // 
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.Location = new System.Drawing.Point(1072, 171);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(156, 80);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // welcomeMessageBox
            // 
            this.welcomeMessageBox.AutoSize = true;
            this.welcomeMessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeMessageBox.Location = new System.Drawing.Point(858, 53);
            this.welcomeMessageBox.Name = "welcomeMessageBox";
            this.welcomeMessageBox.Size = new System.Drawing.Size(321, 72);
            this.welcomeMessageBox.TabIndex = 6;
            this.welcomeMessageBox.Text = "Welcome to Connect-4!\r\n\r\nEnter both player\'s names below:";
            this.welcomeMessageBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.welcomeMessageBox.Click += new System.EventHandler(this.WelcomeMessageBox_Click);
            // 
            // playerTextLabel
            // 
            this.playerTextLabel.AutoSize = true;
            this.playerTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTextLabel.Location = new System.Drawing.Point(752, 171);
            this.playerTextLabel.Name = "playerTextLabel";
            this.playerTextLabel.Size = new System.Drawing.Size(82, 72);
            this.playerTextLabel.TabIndex = 7;
            this.playerTextLabel.Text = "Player 1:\r\n\r\nPlayer 2:";
            // 
            // column1
            // 
            this.column1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.column1.Location = new System.Drawing.Point(64, 28);
            this.column1.Name = "column1";
            this.column1.Size = new System.Drawing.Size(75, 23);
            this.column1.TabIndex = 8;
            this.column1.Text = "1";
            this.column1.UseVisualStyleBackColor = true;
            this.column1.Click += new System.EventHandler(this.Column1_Click);
            // 
            // column2
            // 
            this.column2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.column2.Location = new System.Drawing.Point(165, 28);
            this.column2.Name = "column2";
            this.column2.Size = new System.Drawing.Size(75, 23);
            this.column2.TabIndex = 9;
            this.column2.Text = "2";
            this.column2.UseVisualStyleBackColor = true;
            this.column2.Click += new System.EventHandler(this.Column2_Click);
            // 
            // column3
            // 
            this.column3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.column3.Location = new System.Drawing.Point(265, 28);
            this.column3.Name = "column3";
            this.column3.Size = new System.Drawing.Size(75, 23);
            this.column3.TabIndex = 10;
            this.column3.Text = "3";
            this.column3.UseVisualStyleBackColor = true;
            this.column3.Click += new System.EventHandler(this.Column3_Click);
            // 
            // column4
            // 
            this.column4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.column4.Location = new System.Drawing.Point(364, 28);
            this.column4.Name = "column4";
            this.column4.Size = new System.Drawing.Size(75, 23);
            this.column4.TabIndex = 11;
            this.column4.Text = "4";
            this.column4.UseVisualStyleBackColor = true;
            this.column4.Click += new System.EventHandler(this.Column4_Click);
            // 
            // column5
            // 
            this.column5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.column5.Location = new System.Drawing.Point(463, 28);
            this.column5.Name = "column5";
            this.column5.Size = new System.Drawing.Size(75, 23);
            this.column5.TabIndex = 12;
            this.column5.Text = "5";
            this.column5.UseVisualStyleBackColor = true;
            this.column5.Click += new System.EventHandler(this.Column5_Click);
            // 
            // column6
            // 
            this.column6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.column6.Location = new System.Drawing.Point(561, 28);
            this.column6.Name = "column6";
            this.column6.Size = new System.Drawing.Size(75, 23);
            this.column6.TabIndex = 13;
            this.column6.Text = "6";
            this.column6.UseVisualStyleBackColor = true;
            this.column6.Click += new System.EventHandler(this.Column6_Click);
            // 
            // column7
            // 
            this.column7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.column7.Location = new System.Drawing.Point(658, 28);
            this.column7.Name = "column7";
            this.column7.Size = new System.Drawing.Size(75, 23);
            this.column7.TabIndex = 14;
            this.column7.Text = "7";
            this.column7.UseVisualStyleBackColor = true;
            this.column7.Click += new System.EventHandler(this.Column7_Click);
            // 
            // rulesLabel
            // 
            this.rulesLabel.AutoSize = true;
            this.rulesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rulesLabel.Location = new System.Drawing.Point(778, 436);
            this.rulesLabel.Name = "rulesLabel";
            this.rulesLabel.Size = new System.Drawing.Size(450, 160);
            this.rulesLabel.TabIndex = 15;
            this.rulesLabel.Text = resources.GetString("rulesLabel.Text");
            this.rulesLabel.Visible = false;
            // 
            // rulesTitleLabel
            // 
            this.rulesTitleLabel.AutoSize = true;
            this.rulesTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rulesTitleLabel.Location = new System.Drawing.Point(948, 391);
            this.rulesTitleLabel.Name = "rulesTitleLabel";
            this.rulesTitleLabel.Size = new System.Drawing.Size(79, 25);
            this.rulesTitleLabel.TabIndex = 16;
            this.rulesTitleLabel.Text = "Rules:";
            this.rulesTitleLabel.Visible = false;
            // 
            // currentPlayerLabel
            // 
            this.currentPlayerLabel.AutoSize = true;
            this.currentPlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPlayerLabel.Location = new System.Drawing.Point(919, 144);
            this.currentPlayerLabel.Name = "currentPlayerLabel";
            this.currentPlayerLabel.Size = new System.Drawing.Size(0, 24);
            this.currentPlayerLabel.TabIndex = 17;
            this.currentPlayerLabel.Visible = false;
            // 
            // columnFullLabel
            // 
            this.columnFullLabel.AutoSize = true;
            this.columnFullLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnFullLabel.Location = new System.Drawing.Point(883, 196);
            this.columnFullLabel.Name = "columnFullLabel";
            this.columnFullLabel.Size = new System.Drawing.Size(280, 24);
            this.columnFullLabel.TabIndex = 18;
            this.columnFullLabel.Text = "Column is full, try a different one!";
            this.columnFullLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.columnFullLabel.Visible = false;
            this.columnFullLabel.Click += new System.EventHandler(this.ColumnFullLabel_Click);
            // 
            // confettiPictureBox
            // 
            this.confettiPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confettiPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confettiPictureBox.BackgroundImage")));
            this.confettiPictureBox.Location = new System.Drawing.Point(757, 112);
            this.confettiPictureBox.Name = "confettiPictureBox";
            this.confettiPictureBox.Size = new System.Drawing.Size(471, 183);
            this.confettiPictureBox.TabIndex = 19;
            this.confettiPictureBox.TabStop = false;
            this.confettiPictureBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1253, 680);
            this.Controls.Add(this.columnFullLabel);
            this.Controls.Add(this.currentPlayerLabel);
            this.Controls.Add(this.rulesTitleLabel);
            this.Controls.Add(this.rulesLabel);
            this.Controls.Add(this.column7);
            this.Controls.Add(this.column6);
            this.Controls.Add(this.column5);
            this.Controls.Add(this.column4);
            this.Controls.Add(this.column3);
            this.Controls.Add(this.column2);
            this.Controls.Add(this.column1);
            this.Controls.Add(this.playerTextLabel);
            this.Controls.Add(this.welcomeMessageBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.nameBox2);
            this.Controls.Add(this.nameBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.confettiPictureBox);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Connect-4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confettiPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox nameBox1;
        private System.Windows.Forms.TextBox nameBox2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label welcomeMessageBox;
        private System.Windows.Forms.Label playerTextLabel;
        private System.Windows.Forms.Button column1;
        private System.Windows.Forms.Button column2;
        private System.Windows.Forms.Button column3;
        private System.Windows.Forms.Button column4;
        private System.Windows.Forms.Button column5;
        private System.Windows.Forms.Button column6;
        private System.Windows.Forms.Button column7;
        private System.Windows.Forms.Label rulesLabel;
        private System.Windows.Forms.Label rulesTitleLabel;
        private System.Windows.Forms.Label currentPlayerLabel;
        private System.Windows.Forms.Label columnFullLabel;
        private System.Windows.Forms.PictureBox confettiPictureBox;
    }
}

