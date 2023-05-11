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
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btmLocation
			// 
			this.btmLocation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btmLocation.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btmLocation.Location = new System.Drawing.Point(346, 100);
			this.btmLocation.Name = "btmLocation";
			this.btmLocation.Size = new System.Drawing.Size(75, 23);
			this.btmLocation.TabIndex = 0;
			this.btmLocation.Text = "管理地點";
			this.btmLocation.UseVisualStyleBackColor = true;
			this.btmLocation.Click += new System.EventHandler(this.btmLocation_Click);
			// 
			// btnSpecies
			// 
			this.btnSpecies.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSpecies.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnSpecies.Location = new System.Drawing.Point(346, 142);
			this.btnSpecies.Name = "btnSpecies";
			this.btnSpecies.Size = new System.Drawing.Size(75, 23);
			this.btnSpecies.TabIndex = 1;
			this.btnSpecies.Text = "管理名錄";
			this.btnSpecies.UseVisualStyleBackColor = true;
			this.btnSpecies.Click += new System.EventHandler(this.btnSpecies_Click);
			// 
			// btnRecord
			// 
			this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnRecord.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnRecord.Location = new System.Drawing.Point(346, 184);
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
			this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnUser.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnUser.Location = new System.Drawing.Point(346, 226);
			this.btnUser.Name = "btnUser";
			this.btnUser.Size = new System.Drawing.Size(75, 23);
			this.btnUser.TabIndex = 3;
			this.btnUser.Text = "管理帳號";
			this.btnUser.UseVisualStyleBackColor = true;
			this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(0, 341);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(315, 61);
			this.label1.TabIndex = 5;
			this.label1.Text = "台灣野鳥觀察";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::AC.AvianExplorer.WinApp.Properties.Resources.螢幕擷取畫面_2023_05_11_150753;
			this.pictureBox1.Location = new System.Drawing.Point(-97, -2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(695, 431);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(240, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 26);
			this.label2.TabIndex = 6;
			this.label2.Text = "label2";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(503, 423);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnUser);
			this.Controls.Add(this.btnRecord);
			this.Controls.Add(this.btnSpecies);
			this.Controls.Add(this.btmLocation);
			this.Controls.Add(this.pictureBox1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(519, 462);
			this.MinimumSize = new System.Drawing.Size(519, 462);
			this.Name = "FormMain";
			this.Text = "FormMain";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.Load += new System.EventHandler(this.FormMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btmLocation;
		private System.Windows.Forms.Button btnSpecies;
		private System.Windows.Forms.Button btnRecord;
		private System.Windows.Forms.Button btnUser;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}