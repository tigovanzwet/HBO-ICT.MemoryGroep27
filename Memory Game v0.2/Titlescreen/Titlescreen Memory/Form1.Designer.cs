namespace Titlescreen_Memory
{
    partial class Titlescreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Titlescreen));
            this.menu = new System.Windows.Forms.Panel();
            this.titlememory = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.PictureBox();
            this.btn_highscores = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titlememory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_highscores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu.Controls.Add(this.btn_exit);
            this.menu.Controls.Add(this.btn_highscores);
            this.menu.Controls.Add(this.titlememory);
            this.menu.Controls.Add(this.btn_start);
            this.menu.Location = new System.Drawing.Point(42, 49);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(727, 346);
            this.menu.TabIndex = 0;
            // 
            // titlememory
            // 
            this.titlememory.BackgroundImage = global::Titlescreen_Memory.Properties.Resources.memorytitle;
            this.titlememory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.titlememory.Location = new System.Drawing.Point(33, 3);
            this.titlememory.Name = "titlememory";
            this.titlememory.Size = new System.Drawing.Size(681, 74);
            this.titlememory.TabIndex = 2;
            this.titlememory.TabStop = false;
            this.titlememory.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_start
            // 
            this.btn_start.BackgroundImage = global::Titlescreen_Memory.Properties.Resources.Play_Game_memory;
            this.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_start.Location = new System.Drawing.Point(172, 132);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(329, 53);
            this.btn_start.TabIndex = 1;
            this.btn_start.TabStop = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            this.btn_start.MouseLeave += new System.EventHandler(this.btn_start_MouseLeave);
            this.btn_start.MouseHover += new System.EventHandler(this.btn_start_MouseHover);
            // 
            // btn_highscores
            // 
            this.btn_highscores.BackgroundImage = global::Titlescreen_Memory.Properties.Resources.High_Scores_Memory;
            this.btn_highscores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_highscores.Location = new System.Drawing.Point(142, 191);
            this.btn_highscores.Name = "btn_highscores";
            this.btn_highscores.Size = new System.Drawing.Size(384, 48);
            this.btn_highscores.TabIndex = 3;
            this.btn_highscores.TabStop = false;
            this.btn_highscores.MouseLeave += new System.EventHandler(this.btn_highscores_MouseLeave);
            this.btn_highscores.MouseHover += new System.EventHandler(this.btn_highscores_MouseHover);
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = global::Titlescreen_Memory.Properties.Resources.Exit_Game_Memory;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_exit.Location = new System.Drawing.Point(172, 245);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(307, 48);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.TabStop = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click_1);
            this.btn_exit.MouseLeave += new System.EventHandler(this.btn_exit_MouseLeave);
            this.btn_exit.MouseHover += new System.EventHandler(this.btn_exit_MouseHover);
            // 
            // Titlescreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Titlescreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.titlememory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_highscores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.PictureBox btn_start;
        private System.Windows.Forms.PictureBox titlememory;
        private System.Windows.Forms.PictureBox btn_exit;
        private System.Windows.Forms.PictureBox btn_highscores;
    }
}

