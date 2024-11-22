namespace Zodiac
{
    partial class IdolZodiacManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdolZodiacManager));
            lblWelcome = new Label();
            btnShowImage = new Button();
            picImage = new PictureBox();
            pnImage = new Panel();
            btnQuit = new Button();
            btnCheck = new Button();
            lblDay = new Label();
            lblMonth = new Label();
            lblResult = new Label();
            txtDay = new TextBox();
            txtMonth = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            pnImage.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = SystemColors.ButtonShadow;
            lblWelcome.Font = new Font("Tahoma", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.Purple;
            lblWelcome.Location = new Point(13, 7);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(920, 97);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Idol Zodiac Calculator";
            // 
            // btnShowImage
            // 
            btnShowImage.BackColor = SystemColors.ControlText;
            btnShowImage.FlatStyle = FlatStyle.Flat;
            btnShowImage.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowImage.ForeColor = Color.Cyan;
            btnShowImage.Location = new Point(242, 306);
            btnShowImage.Margin = new Padding(4);
            btnShowImage.Name = "btnShowImage";
            btnShowImage.Size = new Size(166, 41);
            btnShowImage.TabIndex = 3;
            btnShowImage.Text = "Show image";
            btnShowImage.UseVisualStyleBackColor = false;
            btnShowImage.Click += btnShowImage_Click;
            // 
            // picImage
            // 
            picImage.BackColor = Color.FromArgb(0, 192, 0);
            picImage.Location = new Point(18, 15);
            picImage.Name = "picImage";
            picImage.Size = new Size(450, 450);
            picImage.SizeMode = PictureBoxSizeMode.AutoSize;
            picImage.TabIndex = 2;
            picImage.TabStop = false;
            // 
            // pnImage
            // 
            pnImage.AutoScroll = true;
            pnImage.BackColor = Color.FromArgb(255, 192, 255);
            pnImage.Controls.Add(picImage);
            pnImage.Location = new Point(676, 107);
            pnImage.Name = "pnImage";
            pnImage.Size = new Size(484, 477);
            pnImage.TabIndex = 3;
            // 
            // btnQuit
            // 
            btnQuit.BackColor = SystemColors.ControlText;
            btnQuit.FlatStyle = FlatStyle.Flat;
            btnQuit.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuit.ForeColor = Color.Cyan;
            btnQuit.Location = new Point(441, 306);
            btnQuit.Margin = new Padding(4);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(166, 41);
            btnQuit.TabIndex = 4;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = false;
            btnQuit.Click += btnQuit_Click;
            // 
            // btnCheck
            // 
            btnCheck.BackColor = SystemColors.ControlText;
            btnCheck.FlatStyle = FlatStyle.Flat;
            btnCheck.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheck.ForeColor = Color.Cyan;
            btnCheck.Location = new Point(33, 306);
            btnCheck.Margin = new Padding(4);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(166, 41);
            btnCheck.TabIndex = 2;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += btnCheck_Click;
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.BackColor = SystemColors.ControlDark;
            lblDay.FlatStyle = FlatStyle.Popup;
            lblDay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDay.ForeColor = Color.GhostWhite;
            lblDay.Location = new Point(38, 166);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(130, 28);
            lblDay.TabIndex = 6;
            lblDay.Text = "Your birthday";
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.BackColor = SystemColors.ControlDark;
            lblMonth.FlatStyle = FlatStyle.Popup;
            lblMonth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMonth.ForeColor = Color.GhostWhite;
            lblMonth.Location = new Point(38, 239);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(161, 28);
            lblMonth.TabIndex = 7;
            lblMonth.Text = "Your birth month";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = SystemColors.ControlDark;
            lblResult.FlatStyle = FlatStyle.Popup;
            lblResult.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.MediumSpringGreen;
            lblResult.Location = new Point(99, 382);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(416, 46);
            lblResult.TabIndex = 8;
            lblResult.Text = "Your idol zodiac sign is...";
            // 
            // txtDay
            // 
            txtDay.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDay.Location = new Point(242, 161);
            txtDay.Name = "txtDay";
            txtDay.Size = new Size(240, 38);
            txtDay.TabIndex = 0;
            txtDay.Text = "1";
            txtDay.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMonth
            // 
            txtMonth.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMonth.Location = new Point(242, 234);
            txtMonth.Name = "txtMonth";
            txtMonth.Size = new Size(240, 38);
            txtMonth.TabIndex = 1;
            txtMonth.Text = "1";
            txtMonth.TextAlign = HorizontalAlignment.Center;
            // 
            // IdolZodiacManager
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1193, 596);
            Controls.Add(txtMonth);
            Controls.Add(txtDay);
            Controls.Add(lblResult);
            Controls.Add(lblMonth);
            Controls.Add(lblDay);
            Controls.Add(btnCheck);
            Controls.Add(btnQuit);
            Controls.Add(pnImage);
            Controls.Add(btnShowImage);
            Controls.Add(lblWelcome);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "IdolZodiacManager";
            Text = "Idol Zodiac ";
            Load += ZodiacManager_Load;
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            pnImage.ResumeLayout(false);
            pnImage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnShowImage;
        private PictureBox picImage;
        private Panel pnImage;
        private Button btnQuit;
        private Button btnCheck;
        private Label lblDay;
        private Label lblMonth;
        private Label lblResult;
        private TextBox txtDay;
        private TextBox txtMonth;
    }
}
