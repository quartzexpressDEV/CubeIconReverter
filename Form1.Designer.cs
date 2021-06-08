
using System.Drawing;
using System.Windows.Forms;

namespace CubeIconReverter
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
            this.disclaimer = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.apptitle = new System.Windows.Forms.Label();
            this.credits = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Panel();
            this.cubeTitleRemove = new System.Windows.Forms.CheckBox();
            this.healthBarYes = new System.Windows.Forms.CheckBox();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // disclaimer
            // 
            this.disclaimer.AutoSize = true;
            this.disclaimer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.disclaimer.Location = new System.Drawing.Point(40, 203);
            this.disclaimer.Name = "disclaimer";
            this.disclaimer.Size = new System.Drawing.Size(562, 42);
            this.disclaimer.TabIndex = 0;
            this.disclaimer.Text = "• By clicking START, the server rp cache will be cleared so use this at ur own ri" +
    "sk \r\n• By clicking CLEAR, the server rp cache will also be cleared";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.status.ForeColor = System.Drawing.Color.White;
            this.status.Location = new System.Drawing.Point(40, 411);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(14, 21);
            this.status.TabIndex = 2;
            this.status.Text = " ";
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.start.FlatAppearance.BorderSize = 0;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.start.ForeColor = System.Drawing.Color.White;
            this.start.Location = new System.Drawing.Point(50, 350);
            this.start.Margin = new System.Windows.Forms.Padding(0);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(250, 50);
            this.start.TabIndex = 3;
            this.start.Text = "START";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Location = new System.Drawing.Point(400, 350);
            this.clear.Margin = new System.Windows.Forms.Padding(0);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(250, 50);
            this.clear.TabIndex = 4;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.close.Dock = System.Windows.Forms.DockStyle.Right;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.close.Location = new System.Drawing.Point(660, 0);
            this.close.Margin = new System.Windows.Forms.Padding(0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(40, 40);
            this.close.TabIndex = 5;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // apptitle
            // 
            this.apptitle.AutoSize = true;
            this.apptitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apptitle.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.apptitle.Location = new System.Drawing.Point(40, 81);
            this.apptitle.Name = "apptitle";
            this.apptitle.Size = new System.Drawing.Size(369, 55);
            this.apptitle.TabIndex = 6;
            this.apptitle.Text = "CubeIconReverter";
            this.apptitle.Click += new System.EventHandler(this.label2_Click);
            // 
            // credits
            // 
            this.credits.AutoSize = true;
            this.credits.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.credits.Location = new System.Drawing.Point(374, 136);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(75, 21);
            this.credits.TabIndex = 7;
            this.credits.Text = "By quartz";
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.Header.Controls.Add(this.close);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(700, 40);
            this.Header.TabIndex = 8;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            this.Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Header_MouseUp);
            // 
            // cubeTitleRemove
            // 
            this.cubeTitleRemove.AutoSize = true;
            this.cubeTitleRemove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cubeTitleRemove.Location = new System.Drawing.Point(50, 291);
            this.cubeTitleRemove.Name = "cubeTitleRemove";
            this.cubeTitleRemove.Size = new System.Drawing.Size(202, 25);
            this.cubeTitleRemove.TabIndex = 9;
            this.cubeTitleRemove.Text = "Remove \"Cubecraft\" Title";
            this.cubeTitleRemove.UseVisualStyleBackColor = true;
            // 
            // healthBarYes
            // 
            this.healthBarYes.AutoSize = true;
            this.healthBarYes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.healthBarYes.Location = new System.Drawing.Point(400, 280);
            this.healthBarYes.Name = "healthBarYes";
            this.healthBarYes.Size = new System.Drawing.Size(248, 46);
            this.healthBarYes.TabIndex = 10;
            this.healthBarYes.Text = "Health Bars instead of hearts in \r\nhealth indicator\r\n";
            this.healthBarYes.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.healthBarYes);
            this.Controls.Add(this.cubeTitleRemove);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.apptitle);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.start);
            this.Controls.Add(this.status);
            this.Controls.Add(this.disclaimer);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 450);
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CubeIconReverter";
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label disclaimer;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label apptitle;
        private System.Windows.Forms.Label credits;
        
        private bool drag = false;
        private Point startPoint = new Point(0, 0);
        private System.Windows.Forms.Panel Header;
        private CheckBox cubeTitleRemove;
        private CheckBox healthBarYes;
    }
}

