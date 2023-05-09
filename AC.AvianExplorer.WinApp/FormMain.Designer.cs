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
			this.SuspendLayout();
			// 
			// btmLocation
			// 
			this.btmLocation.Location = new System.Drawing.Point(136, 72);
			this.btmLocation.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.btmLocation.Name = "btmLocation";
			this.btmLocation.Size = new System.Drawing.Size(162, 46);
			this.btmLocation.TabIndex = 0;
			this.btmLocation.Text = "管理地點";
			this.btmLocation.UseVisualStyleBackColor = true;
			this.btmLocation.Click += new System.EventHandler(this.btmLocation_Click);
			// 
			// btnSpecies
			// 
			this.btnSpecies.Location = new System.Drawing.Point(136, 150);
			this.btnSpecies.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.btnSpecies.Name = "btnSpecies";
			this.btnSpecies.Size = new System.Drawing.Size(162, 46);
			this.btnSpecies.TabIndex = 1;
			this.btnSpecies.Text = "管理名錄";
			this.btnSpecies.UseVisualStyleBackColor = true;
			this.btnSpecies.Click += new System.EventHandler(this.btnSpecies_Click);
			// 
			// btnRecord
			// 
			this.btnRecord.Location = new System.Drawing.Point(136, 234);
			this.btnRecord.Name = "btnRecord";
			this.btnRecord.Size = new System.Drawing.Size(162, 46);
			this.btnRecord.TabIndex = 2;
			this.btnRecord.Text = "管理紀錄";
			this.btnRecord.UseVisualStyleBackColor = true;
			this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(520, 516);
			this.Controls.Add(this.btnRecord);
			this.Controls.Add(this.btnSpecies);
			this.Controls.Add(this.btmLocation);
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "FormMain";
			this.Text = "FormMain";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btmLocation;
		private System.Windows.Forms.Button btnSpecies;
		private System.Windows.Forms.Button btnRecord;
	}
}