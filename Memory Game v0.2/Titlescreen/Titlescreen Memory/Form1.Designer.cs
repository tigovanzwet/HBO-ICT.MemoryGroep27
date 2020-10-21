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
            this.titletext = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titletext
            // 
            this.titletext.AutoSize = true;
            this.titletext.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.titletext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titletext.Font = new System.Drawing.Font("Poor Richard", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titletext.Location = new System.Drawing.Point(94, 29);
            this.titletext.Name = "titletext";
            this.titletext.Size = new System.Drawing.Size(589, 92);
            this.titletext.TabIndex = 0;
            this.titletext.Text = "MEMORY GAME";
            this.titletext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titletext.Click += new System.EventHandler(this.label1_Click);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.startBtn.Font = new System.Drawing.Font("OCR A Extended", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(300, 187);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(163, 55);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "START GAME";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Font = new System.Drawing.Font("OCR A Extended", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(300, 301);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(163, 55);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "EXIT GAME";
            this.exitBtn.UseVisualStyleBackColor = false;
            // 
            // Titlescreen
            // 
            this.AcceptButton = this.startBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.titletext);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Titlescreen";
            this.Text = "Memory game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titletext;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

