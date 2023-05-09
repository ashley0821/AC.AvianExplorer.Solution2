namespace AC.AvianExplorer.WinApp
{
	partial class FormSignup
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
			this.txtPwd = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSignup = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtPwd
			// 
			this.txtPwd.Location = new System.Drawing.Point(76, 51);
			this.txtPwd.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
			this.txtPwd.Name = "txtPwd";
			this.txtPwd.Size = new System.Drawing.Size(110, 22);
			this.txtPwd.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(30, 56);
			this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "密碼:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(76, 25);
			this.txtName.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(110, 22);
			this.txtName.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(30, 30);
			this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "名稱:";
			// 
			// btnSignup
			// 
			this.btnSignup.Location = new System.Drawing.Point(111, 87);
			this.btnSignup.Name = "btnSignup";
			this.btnSignup.Size = new System.Drawing.Size(75, 23);
			this.btnSignup.TabIndex = 6;
			this.btnSignup.Text = "註冊";
			this.btnSignup.UseVisualStyleBackColor = true;
			this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
			// 
			// FormSignup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(223, 141);
			this.Controls.Add(this.btnSignup);
			this.Controls.Add(this.txtPwd);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label1);
			this.Name = "FormSignup";
			this.Text = "FormSignup";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtPwd;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSignup;
	}
}