namespace QLBanHangApp
{
	partial class FrmTimKiemHoaDon
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
			timKiemHoaDonUserControl1 = new TimKiemHoaDonUserControl();
			SuspendLayout();
			// 
			// timKiemHoaDonUserControl1
			// 
			timKiemHoaDonUserControl1.Location = new Point(12, 27);
			timKiemHoaDonUserControl1.Name = "timKiemHoaDonUserControl1";
			timKiemHoaDonUserControl1.Size = new Size(4985, 3475);
			timKiemHoaDonUserControl1.TabIndex = 0;
			// 
			// FrmTimKiemHoaDon
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(2033, 1461);
			Controls.Add(timKiemHoaDonUserControl1);
			Name = "FrmTimKiemHoaDon";
			Text = "FrmTimKiemHoaDon";
			Load += FrmTimKiemHoaDon_Load;
			ResumeLayout(false);
		}

		#endregion

		private TimKiemHoaDonUserControl timKiemHoaDonUserControl1;
	}
}