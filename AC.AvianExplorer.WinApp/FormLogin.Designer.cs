namespace AC.AvianExplorer.WinApp
{
	partial class FormLogin
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPwd = new System.Windows.Forms.TextBox();
			this.btnSignup = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 34);
			this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "名稱:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(82, 29);
			this.txtName.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(110, 22);
			this.txtName.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(36, 60);
			this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "密碼:";
			// 
			// txtPwd
			// 
			this.txtPwd.Location = new System.Drawing.Point(82, 55);
			this.txtPwd.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
			this.txtPwd.Name = "txtPwd";
			this.txtPwd.Size = new System.Drawing.Size(110, 22);
			this.txtPwd.TabIndex = 1;
			// 
			// btnSignup
			// 
			this.btnSignup.Location = new System.Drawing.Point(67, 88);
			this.btnSignup.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
			this.btnSignup.Name = "btnSignup";
			this.btnSignup.Size = new System.Drawing.Size(71, 25);
			this.btnSignup.TabIndex = 2;
			this.btnSignup.Text = "註冊會員";
			this.btnSignup.UseVisualStyleBackColor = true;
			this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(141, 88);
			this.btnLogin.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(49, 25);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "登入";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(254, 147);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.btnSignup);
			this.Controls.Add(this.txtPwd);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
			this.Name = "FormLogin";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPwd;
		private System.Windows.Forms.Button btnSignup;
		private System.Windows.Forms.Button btnLogin;
	}
}

