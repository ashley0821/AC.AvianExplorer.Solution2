namespace AC.AvianExplorer.WinApp
{
	partial class FormUser
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
			this.btnUpdateUser = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtPwd
			// 
			this.txtPwd.Location = new System.Drawing.Point(86, 55);
			this.txtPwd.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
			this.txtPwd.Name = "txtPwd";
			this.txtPwd.Size = new System.Drawing.Size(110, 22);
			this.txtPwd.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(40, 60);
			this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "密碼:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(86, 29);
			this.txtName.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(110, 22);
			this.txtName.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(40, 34);
			this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 12);
			this.label1.TabIndex = 4;
			this.label1.Text = "名稱:";
			// 
			// btnUpdateUser
			// 
			this.btnUpdateUser.Location = new System.Drawing.Point(120, 83);
			this.btnUpdateUser.Name = "btnUpdateUser";
			this.btnUpdateUser.Size = new System.Drawing.Size(75, 23);
			this.btnUpdateUser.TabIndex = 2;
			this.btnUpdateUser.Text = "更新";
			this.btnUpdateUser.UseVisualStyleBackColor = true;
			this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
			// 
			// FormUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(236, 136);
			this.Controls.Add(this.btnUpdateUser);
			this.Controls.Add(this.txtPwd);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(252, 175);
			this.Name = "FormUser";
			this.Text = "FormUser";
			this.Load += new System.EventHandler(this.FormUser_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtPwd;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnUpdateUser;
	}
}