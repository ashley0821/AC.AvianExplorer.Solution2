namespace AC.AvianExplorer.WinApp
{
	partial class FormMain
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
			this.btmLocation = new System.Windows.Forms.Button();
			this.btnSpecies = new System.Windows.Forms.Button();
			this.btnRecord = new System.Windows.Forms.Button();
			this.btnUser = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btmLocation
			// 
			this.btmLocation.Location = new System.Drawing.Point(63, 36);
			this.btmLocation.Name = "btmLocation";
			this.btmLocation.Size = new System.Drawing.Size(75, 23);
			this.btmLocation.TabIndex = 0;
			this.btmLocation.Text = "管理地點";
			this.btmLocation.UseVisualStyleBackColor = true;
			this.btmLocation.Click += new System.EventHandler(this.btmLocation_Click);
			// 
			// btnSpecies
			// 
			this.btnSpecies.Location = new System.Drawing.Point(63, 78);
			this.btnSpecies.Name = "btnSpecies";
			this.btnSpecies.Size = new System.Drawing.Size(75, 23);
			this.btnSpecies.TabIndex = 1;
			this.btnSpecies.Text = "管理名錄";
			this.btnSpecies.UseVisualStyleBackColor = true;
			this.btnSpecies.Click += new System.EventHandler(this.btnSpecies_Click);
			// 
			// btnRecord
			// 
			this.btnRecord.Location = new System.Drawing.Point(63, 120);
			this.btnRecord.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
			this.btnRecord.Name = "btnRecord";
			this.btnRecord.Size = new System.Drawing.Size(75, 23);
			this.btnRecord.TabIndex = 2;
			this.btnRecord.Text = "管理紀錄";
			this.btnRecord.UseVisualStyleBackColor = true;
			this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
			// 
			// btnUser
			// 
			this.btnUser.Location = new System.Drawing.Point(63, 162);
			this.btnUser.Name = "btnUser";
			this.btnUser.Size = new System.Drawing.Size(75, 23);
			this.btnUser.TabIndex = 3;
			this.btnUser.Text = "管理帳號";
			this.btnUser.UseVisualStyleBackColor = true;
			this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(209, 219);
			this.Controls.Add(this.btnUser);
			this.Controls.Add(this.btnRecord);
			this.Controls.Add(this.btnSpecies);
			this.Controls.Add(this.btmLocation);
			this.MinimumSize = new System.Drawing.Size(225, 258);
			this.Name = "FormMain";
			this.Text = "FormMain";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btmLocation;
		private System.Windows.Forms.Button btnSpecies;
		private System.Windows.Forms.Button btnRecord;
		private System.Windows.Forms.Button btnUser;
	}
}