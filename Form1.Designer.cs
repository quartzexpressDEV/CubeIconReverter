
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
            this.apptitle = new System.Windows.Forms.LinkLabel();
            this.credits = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Panel();
            this.removeCCTitle_label = new System.Windows.Forms.Label();
            this.customHealthBar_label = new System.Windows.Forms.Label();
            this.customHealthBar = new CubeIconReverter.Toggle();
            this.removecubeTitle = new CubeIconReverter.Toggle();
            this.hbSelectBtn = new System.Windows.Forms.Button();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // disclaimer
            // 
            this.disclaimer.AutoSize = true;
            this.disclaimer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.disclaimer.Location = new System.Drawing.Point(40, 178);
            this.disclaimer.Name = "disclaimer";
            this.disclaimer.Size = new System.Drawing.Size(650, 42);
            this.disclaimer.TabIndex = 0;
            this.disclaimer.Text = "• By clicking START, the normal rp will be replaced by the modified one\r\n• By cli" +
    "cking CLEAR, the server rp cache will be cleared, effectively deleting the modif" +
    "ied pack\r\n";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.status.ForeColor = System.Drawing.Color.White;
            this.status.Location = new System.Drawing.Point(40, 446);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 21);
            this.status.TabIndex = 2;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.LimeGreen;
            this.start.FlatAppearance.BorderSize = 0;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.start.ForeColor = System.Drawing.Color.White;
            this.start.Location = new System.Drawing.Point(50, 380);
            this.start.Margin = new System.Windows.Forms.Padding(0);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(250, 50);
            this.start.TabIndex = 3;
            this.start.Text = "START";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Location = new System.Drawing.Point(500, 380);
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
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.close.Location = new System.Drawing.Point(759, 1);
            this.close.Margin = new System.Windows.Forms.Padding(0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(38, 38);
            this.close.TabIndex = 5;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // apptitle
            // 
            this.apptitle.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.apptitle.AutoSize = true;
            this.apptitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apptitle.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptitle.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.apptitle.LinkColor = System.Drawing.Color.Transparent;
            this.apptitle.Location = new System.Drawing.Point(185, 70);
            this.apptitle.Name = "apptitle";
            this.apptitle.Size = new System.Drawing.Size(369, 55);
            this.apptitle.TabIndex = 6;
            this.apptitle.TabStop = true;
            this.apptitle.Text = "CubeIconReverter";
            this.apptitle.VisitedLinkColor = System.Drawing.Color.Transparent;
            this.apptitle.Click += new System.EventHandler(this.appTitle_Click);
            // 
            // credits
            // 
            this.credits.AutoSize = true;
            this.credits.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.credits.Location = new System.Drawing.Point(520, 125);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(174, 21);
            this.credits.TabIndex = 7;
            this.credits.Text = "By quartz, BoredSathvik";
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.Header.Controls.Add(this.close);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(800, 40);
            this.Header.TabIndex = 8;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            this.Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Header_MouseUp);
            // 
            // removeCCTitle_label
            // 
            this.removeCCTitle_label.AutoSize = true;
            this.removeCCTitle_label.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.removeCCTitle_label.Location = new System.Drawing.Point(40, 263);
            this.removeCCTitle_label.Name = "removeCCTitle_label";
            this.removeCCTitle_label.Size = new System.Drawing.Size(160, 19);
            this.removeCCTitle_label.TabIndex = 9;
            this.removeCCTitle_label.Text = "Remove \"Cubecraft\" Title";
            // 
            // customHealthBar_label
            // 
            this.customHealthBar_label.AutoSize = true;
            this.customHealthBar_label.Location = new System.Drawing.Point(40, 300);
            this.customHealthBar_label.Name = "customHealthBar_label";
            this.customHealthBar_label.Size = new System.Drawing.Size(125, 19);
            this.customHealthBar_label.TabIndex = 12;
            this.customHealthBar_label.Text = "Custom Health Bar";
            // 
            // customHealthBar
            // 
            this.customHealthBar.AutoSize = true;
            this.customHealthBar.Location = new System.Drawing.Point(206, 298);
            this.customHealthBar.MinimumSize = new System.Drawing.Size(45, 22);
            this.customHealthBar.Name = "customHealthBar";
            this.customHealthBar.OffBackColor = System.Drawing.Color.Gray;
            this.customHealthBar.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.customHealthBar.OnBackColor = System.Drawing.Color.MediumTurquoise;
            this.customHealthBar.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.customHealthBar.Size = new System.Drawing.Size(45, 22);
            this.customHealthBar.TabIndex = 11;
            this.customHealthBar.UseVisualStyleBackColor = true;
            this.customHealthBar.CheckedChanged += new System.EventHandler(this.customHealthBar_CheckedChanged);
            // 
            // removecubeTitle
            // 
            this.removecubeTitle.AutoSize = true;
            this.removecubeTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removecubeTitle.Location = new System.Drawing.Point(206, 260);
            this.removecubeTitle.MinimumSize = new System.Drawing.Size(45, 22);
            this.removecubeTitle.Name = "removecubeTitle";
            this.removecubeTitle.OffBackColor = System.Drawing.Color.Gray;
            this.removecubeTitle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.removecubeTitle.OnBackColor = System.Drawing.Color.MediumTurquoise;
            this.removecubeTitle.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.removecubeTitle.Size = new System.Drawing.Size(45, 22);
            this.removecubeTitle.TabIndex = 10;
            this.removecubeTitle.UseVisualStyleBackColor = true;
            // 
            // hbSelectBtn
            // 
            this.hbSelectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.hbSelectBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.hbSelectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hbSelectBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.hbSelectBtn.Location = new System.Drawing.Point(279, 293);
            this.hbSelectBtn.Name = "hbSelectBtn";
            this.hbSelectBtn.Size = new System.Drawing.Size(200, 30);
            this.hbSelectBtn.TabIndex = 14;
            this.hbSelectBtn.Text = "Select HealthBar";
            this.hbSelectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hbSelectBtn.UseVisualStyleBackColor = false;
            this.hbSelectBtn.Click += new System.EventHandler(this.hbSelectBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.hbSelectBtn);
            this.Controls.Add(this.customHealthBar_label);
            this.Controls.Add(this.customHealthBar);
            this.Controls.Add(this.removecubeTitle);
            this.Controls.Add(this.removeCCTitle_label);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.apptitle);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.start);
            this.Controls.Add(this.status);
            this.Controls.Add(this.disclaimer);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CubeIconReverter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label disclaimer;
        private Label status;
        private Button start;
        private Button clear;
        private Button close;
        private LinkLabel apptitle;
        private Label credits;
        private bool drag = false;
        private Point startPoint = new Point(0, 0);
        private Panel Header;
        private Label removeCCTitle_label;
        private Toggle removecubeTitle;
        private Toggle customHealthBar;
        private Label customHealthBar_label;
        private Button hbSelectBtn;
    }
}

