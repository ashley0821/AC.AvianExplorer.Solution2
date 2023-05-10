namespace AC.AvianExplorer.WinApp
{
	partial class FormEditSpecies
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
			this.txtFamilyName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtSpeciesName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCommonName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnUpdateSpecies = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtFamilyName
			// 
			this.txtFamilyName.Location = new System.Drawing.Point(96, 88);
			this.txtFamilyName.Name = "txtFamilyName";
			this.txtFamilyName.Size = new System.Drawing.Size(100, 22);
			this.txtFamilyName.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(58, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 12);
			this.label3.TabIndex = 2;
			this.label3.Text = "科名:";
			// 
			// txtSpeciesName
			// 
			this.txtSpeciesName.Location = new System.Drawing.Point(96, 60);
			this.txtSpeciesName.Name = "txtSpeciesName";
			this.txtSpeciesName.Size = new System.Drawing.Size(100, 22);
			this.txtSpeciesName.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(58, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "學名:";
			// 
			// txtCommonName
			// 
			this.txtCommonName.Location = new System.Drawing.Point(96, 32);
			this.txtCommonName.Name = "txtCommonName";
			this.txtCommonName.Size = new System.Drawing.Size(100, 22);
			this.txtCommonName.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(46, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 12);
			this.label1.TabIndex = 4;
			this.label1.Text = "中文名:";
			// 
			// btnUpdateSpecies
			// 
			this.btnUpdateSpecies.Location = new System.Drawing.Point(123, 118);
			this.btnUpdateSpecies.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
			this.btnUpdateSpecies.Name = "btnUpdateSpecies";
			this.btnUpdateSpecies.Size = new System.Drawing.Size(71, 27);
			this.btnUpdateSpecies.TabIndex = 3;
			this.btnUpdateSpecies.Text = "更新";
			this.btnUpdateSpecies.UseVisualStyleBackColor = true;
			this.btnUpdateSpecies.Click += new System.EventHandler(this.btnUpdateSpecies_Click);
			// 
			// FormEditSpecies
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(243, 174);
			this.Controls.Add(this.btnUpdateSpecies);
			this.Controls.Add(this.txtFamilyName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtSpeciesName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtCommonName);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
			this.MinimumSize = new System.Drawing.Size(259, 213);
			this.Name = "FormEditSpecies";
			this.Text = "FormEditSpecies";
			this.Load += new System.EventHandler(this.FormEditSpecies_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtFamilyName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSpeciesName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCommonName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnUpdateSpecies;
	}
}