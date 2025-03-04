﻿namespace Client
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEmailFrom = new TextBox();
            txtEmailTo = new TextBox();
            txtSubject = new TextBox();
            Information = new ListBox();
            btnSendEmail = new Button();
            txtRecevieEmail = new Button();
            label5 = new Label();
            txtBody = new RichTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label6 = new Label();
            txtPassword = new TextBox();
            notifyIcon1 = new NotifyIcon(components);
            notifyIcon2 = new NotifyIcon(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 89);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 22);
            label1.TabIndex = 0;
            label1.Text = "From :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 204);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 22);
            label2.TabIndex = 1;
            label2.Text = "To :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 264);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 22);
            label3.TabIndex = 2;
            label3.Text = "Subject :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(108, 350);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 22);
            label4.TabIndex = 3;
            label4.Text = "Body :";
            // 
            // txtEmailFrom
            // 
            txtEmailFrom.Location = new Point(224, 89);
            txtEmailFrom.Margin = new Padding(4, 3, 4, 3);
            txtEmailFrom.Name = "txtEmailFrom";
            txtEmailFrom.PlaceholderText = "Enter email from here...";
            txtEmailFrom.Size = new Size(346, 30);
            txtEmailFrom.TabIndex = 4;
            // 
            // txtEmailTo
            // 
            txtEmailTo.Location = new Point(224, 204);
            txtEmailTo.Margin = new Padding(4, 3, 4, 3);
            txtEmailTo.Name = "txtEmailTo";
            txtEmailTo.PlaceholderText = "Enter email to here...";
            txtEmailTo.Size = new Size(346, 30);
            txtEmailTo.TabIndex = 5;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(224, 264);
            txtSubject.Margin = new Padding(4, 3, 4, 3);
            txtSubject.Name = "txtSubject";
            txtSubject.PlaceholderText = "Enter email subject...";
            txtSubject.Size = new Size(346, 30);
            txtSubject.TabIndex = 6;
            // 
            // Information
            // 
            Information.FormattingEnabled = true;
            Information.ItemHeight = 22;
            Information.Items.AddRange(new object[] { "Information" });
            Information.Location = new Point(604, 89);
            Information.Margin = new Padding(4, 3, 4, 3);
            Information.Name = "Information";
            Information.Size = new Size(848, 510);
            Information.TabIndex = 8;
            // 
            // btnSendEmail
            // 
            btnSendEmail.BackColor = SystemColors.ButtonShadow;
            btnSendEmail.FlatStyle = FlatStyle.Flat;
            btnSendEmail.ForeColor = SystemColors.Control;
            btnSendEmail.Location = new Point(241, 565);
            btnSendEmail.Margin = new Padding(4, 3, 4, 3);
            btnSendEmail.Name = "btnSendEmail";
            btnSendEmail.Size = new Size(146, 37);
            btnSendEmail.TabIndex = 9;
            btnSendEmail.Text = "Send";
            btnSendEmail.UseVisualStyleBackColor = false;
            btnSendEmail.Click += btnSend_Click;
            // 
            // txtRecevieEmail
            // 
            txtRecevieEmail.BackColor = Color.GreenYellow;
            txtRecevieEmail.FlatStyle = FlatStyle.Flat;
            txtRecevieEmail.ForeColor = SystemColors.Control;
            txtRecevieEmail.Location = new Point(424, 565);
            txtRecevieEmail.Margin = new Padding(4, 3, 4, 3);
            txtRecevieEmail.Name = "txtRecevieEmail";
            txtRecevieEmail.Size = new Size(146, 37);
            txtRecevieEmail.TabIndex = 10;
            txtRecevieEmail.Text = "Recevie";
            txtRecevieEmail.UseVisualStyleBackColor = false;
            txtRecevieEmail.Click += btnReceive_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.Blue;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(0, 0);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(1465, 34);
            label5.TabIndex = 11;
            label5.Text = "Email App Client 2";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // txtBody
            // 
            txtBody.Location = new Point(224, 350);
            txtBody.Name = "txtBody";
            txtBody.Size = new Size(346, 174);
            txtBody.TabIndex = 12;
            txtBody.Text = "";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(72, 147);
            label6.Name = "label6";
            label6.Size = new Size(99, 22);
            label6.TabIndex = 13;
            label6.Text = "Password :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(224, 147);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter password here...";
            txtPassword.Size = new Size(346, 30);
            txtPassword.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1465, 674);
            Controls.Add(txtPassword);
            Controls.Add(label6);
            Controls.Add(txtBody);
            Controls.Add(label5);
            Controls.Add(txtRecevieEmail);
            Controls.Add(btnSendEmail);
            Controls.Add(Information);
            Controls.Add(txtSubject);
            Controls.Add(txtEmailTo);
            Controls.Add(txtEmailFrom);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnSendEmail_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}
        private void SetButtonHoverEffect()
        {
            // Màu nền ban đầu của nút Send và Receive
            Color originalSendColor = btnSendEmail.BackColor;
            Color originalReceiveColor = txtRecevieEmail.BackColor;

            // Sự kiện MouseEnter và MouseLeave cho nút Send
            btnSendEmail.MouseEnter += (s, e) => {
                btnSendEmail.BackColor = Color.Green; // Đổi màu nền khi hover
            };
            btnSendEmail.MouseLeave += (s, e) => {
                btnSendEmail.BackColor = originalSendColor; // Trả lại màu nền ban đầu
            };

            // Sự kiện MouseEnter và MouseLeave cho nút Receive
            txtRecevieEmail.MouseEnter += (s, e) => {
                txtRecevieEmail.BackColor = Color.Red; // Đổi màu nền khi hover
            };
            txtRecevieEmail.MouseLeave += (s, e) => {
                txtRecevieEmail.BackColor = Color.GreenYellow; // Trả lại màu nền ban đầu
            };
        }


        #endregion

        private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private TextBox txtEmailFrom;
		private TextBox txtEmailTo;
		private TextBox txtSubject;
		private ListBox Information;
		private Button btnSendEmail;
		private Button txtRecevieEmail;
		private Label label5;
		private RichTextBox txtBody;
		private ContextMenuStrip contextMenuStrip1;
		private Label label6;
		private TextBox txtPassword;
		private NotifyIcon notifyIcon1;
		private NotifyIcon notifyIcon2;
	}
}
