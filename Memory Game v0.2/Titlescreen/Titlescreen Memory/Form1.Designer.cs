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
            this.start_btn = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.title1 = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Gainsboro;
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu.Controls.Add(this.title1);
            this.menu.Controls.Add(this.btn_exit);
            this.menu.Controls.Add(this.start_btn);
            this.menu.Location = new System.Drawing.Point(191, 46);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(402, 346);
            this.menu.TabIndex = 0;
            // 
            // start_btn
            // 
            this.start_btn.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.ForeColor = System.Drawing.Color.DarkRed;
            this.start_btn.Location = new System.Drawing.Point(117, 137);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(183, 64);
            this.start_btn.TabIndex = 0;
            this.start_btn.Text = "START GAME";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_exit.Location = new System.Drawing.Point(117, 220);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(183, 61);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "EXIT GAME";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // title1
            // 
            this.title1.AutoSize = true;
            this.title1.Font = new System.Drawing.Font("ROG Fonts", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title1.Location = new System.Drawing.Point(36, 52);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(332, 40);
            this.title1.TabIndex = 2;
            this.title1.Text = "MEMORY GAME";
            // 
            // Titlescreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Titlescreen";
            this.Text = "Memory game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.Button btn_exit;
    }
}

