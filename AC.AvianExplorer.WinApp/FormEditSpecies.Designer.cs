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
			this.txtFamilyName.Location = new System.Drawing.Point(207, 175);
			this.txtFamilyName.Margin = new System.Windows.Forms.Padding(6);
			this.txtFamilyName.Name = "txtFamilyName";
			this.txtFamilyName.Size = new System.Drawing.Size(212, 36);
			this.txtFamilyName.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(125, 185);
			this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 24);
			this.label3.TabIndex = 2;
			this.label3.Text = "科名:";
			// 
			// txtSpeciesName
			// 
			this.txtSpeciesName.Location = new System.Drawing.Point(207, 119);
			this.txtSpeciesName.Margin = new System.Windows.Forms.Padding(6);
			this.txtSpeciesName.Name = "txtSpeciesName";
			this.txtSpeciesName.Size = new System.Drawing.Size(212, 36);
			this.txtSpeciesName.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(125, 129);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 24);
			this.label2.TabIndex = 3;
			this.label2.Text = "學名:";
			// 
			// txtCommonName
			// 
			this.txtCommonName.Location = new System.Drawing.Point(207, 63);
			this.txtCommonName.Margin = new System.Windows.Forms.Padding(6);
			this.txtCommonName.Name = "txtCommonName";
			this.txtCommonName.Size = new System.Drawing.Size(212, 36);
			this.txtCommonName.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(99, 73);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 24);
			this.label1.TabIndex = 4;
			this.label1.Text = "中文名:";
			// 
			// btnUpdateSpecies
			// 
			this.btnUpdateSpecies.Location = new System.Drawing.Point(266, 237);
			this.btnUpdateSpecies.Name = "btnUpdateSpecies";
			this.btnUpdateSpecies.Size = new System.Drawing.Size(153, 54);
			this.btnUpdateSpecies.TabIndex = 8;
			this.btnUpdateSpecies.Text = "更新";
			this.btnUpdateSpecies.UseVisualStyleBackColor = true;
			this.btnUpdateSpecies.Click += new System.EventHandler(this.btnUpdateSpecies_Click);
			// 
			// FormEditSpecies
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(526, 349);
			this.Controls.Add(this.btnUpdateSpecies);
			this.Controls.Add(this.txtFamilyName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtSpeciesName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtCommonName);
			this.Controls.Add(this.label1);
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