namespace QLBanHangApp
{
	partial class FrmLogin
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
			label1 = new Label();
			label2 = new Label();
			TxtTenDN = new TextBox();
			TxtMatKhau = new TextBox();
			BtnDangNhap = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Tahoma", 12F);
			label1.Location = new Point(33, 58);
			label1.Name = "label1";
			label1.Size = new Size(287, 48);
			label1.TabIndex = 0;
			label1.Text = "Tên đăng nhập";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Tahoma", 12F);
			label2.Location = new Point(31, 143);
			label2.Name = "label2";
			label2.Size = new Size(183, 48);
			label2.TabIndex = 1;
			label2.Text = "Mật khẩu";
			// 
			// TxtTenDN
			// 
			TxtTenDN.Font = new Font("Tahoma", 12F);
			TxtTenDN.Location = new Point(336, 57);
			TxtTenDN.Name = "TxtTenDN";
			TxtTenDN.Size = new Size(452, 56);
			TxtTenDN.TabIndex = 2;
			// 
			// TxtMatKhau
			// 
			TxtMatKhau.Font = new Font("Tahoma", 12F);
			TxtMatKhau.Location = new Point(336, 140);
			TxtMatKhau.Name = "TxtMatKhau";
			TxtMatKhau.PasswordChar = '$';
			TxtMatKhau.Size = new Size(452, 56);
			TxtMatKhau.TabIndex = 3;
			// 
			// BtnDangNhap
			// 
			BtnDangNhap.Font = new Font("Tahoma", 12F);
			BtnDangNhap.Location = new Point(336, 246);
			BtnDangNhap.Name = "BtnDangNhap";
			BtnDangNhap.Size = new Size(341, 118);
			BtnDangNhap.TabIndex = 4;
			BtnDangNhap.Text = "Đăng nhập";
			BtnDangNhap.UseVisualStyleBackColor = true;
			BtnDangNhap.Click += BtnDangNhap_Click;
			// 
			// FrmLogin
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 400);
			Controls.Add(BtnDangNhap);
			Controls.Add(TxtMatKhau);
			Controls.Add(TxtTenDN);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "FrmLogin";
			Text = "ĐĂNG NHẬP HỆ THỐNG";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox TxtTenDN;
		private TextBox TxtMatKhau;
		private Button BtnDangNhap;
	}
}