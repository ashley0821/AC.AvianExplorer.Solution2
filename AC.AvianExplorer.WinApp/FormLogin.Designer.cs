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
			this.label1.Location = new System.Drawing.Point(78, 68);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "名稱:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(178, 58);
			this.txtName.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(234, 36);
			this.txtName.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(78, 120);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 24);
			this.label2.TabIndex = 0;
			this.label2.Text = "密碼:";
			// 
			// txtPwd
			// 
			this.txtPwd.Location = new System.Drawing.Point(178, 110);
			this.txtPwd.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
			this.txtPwd.Name = "txtPwd";
			this.txtPwd.PasswordChar = '*';
			this.txtPwd.Size = new System.Drawing.Size(234, 36);
			this.txtPwd.TabIndex = 1;
			// 
			// btnSignup
			// 
			this.btnSignup.Location = new System.Drawing.Point(145, 176);
			this.btnSignup.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
			this.btnSignup.Name = "btnSignup";
			this.btnSignup.Size = new System.Drawing.Size(154, 50);
			this.btnSignup.TabIndex = 3;
			this.btnSignup.Text = "註冊會員";
			this.btnSignup.UseVisualStyleBackColor = true;
			this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(306, 176);
			this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(106, 50);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "登入";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(550, 294);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.btnSignup);
			this.Controls.Add(this.txtPwd);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
			this.MinimumSize = new System.Drawing.Size(555, 301);
			this.Name = "FormLogin";
			this.Text = "FormLogin";
			this.Load += new System.EventHandler(this.FormLogin_Load);
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

