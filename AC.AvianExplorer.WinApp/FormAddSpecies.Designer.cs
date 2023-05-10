namespace AC.AvianExplorer.WinApp
{
	partial class FormAddSpecies
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtCommonName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSpeciesName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtFamilyName = new System.Windows.Forms.TextBox();
			this.btnAddSpecies = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "中文名:";
			// 
			// txtCommonName
			// 
			this.txtCommonName.Location = new System.Drawing.Point(79, 24);
			this.txtCommonName.Name = "txtCommonName";
			this.txtCommonName.Size = new System.Drawing.Size(100, 22);
			this.txtCommonName.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(41, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "學名:";
			// 
			// txtSpeciesName
			// 
			this.txtSpeciesName.Location = new System.Drawing.Point(79, 52);
			this.txtSpeciesName.Name = "txtSpeciesName";
			this.txtSpeciesName.Size = new System.Drawing.Size(100, 22);
			this.txtSpeciesName.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(41, 85);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 12);
			this.label3.TabIndex = 0;
			this.label3.Text = "科名:";
			// 
			// txtFamilyName
			// 
			this.txtFamilyName.Location = new System.Drawing.Point(79, 80);
			this.txtFamilyName.Name = "txtFamilyName";
			this.txtFamilyName.Size = new System.Drawing.Size(100, 22);
			this.txtFamilyName.TabIndex = 1;
			// 
			// btnAddSpecies
			// 
			this.btnAddSpecies.Location = new System.Drawing.Point(103, 109);
			this.btnAddSpecies.Name = "btnAddSpecies";
			this.btnAddSpecies.Size = new System.Drawing.Size(75, 23);
			this.btnAddSpecies.TabIndex = 2;
			this.btnAddSpecies.Text = "新增";
			this.btnAddSpecies.UseVisualStyleBackColor = true;
			this.btnAddSpecies.Click += new System.EventHandler(this.btnAddSpecies_Click);
			// 
			// FormAddSpecies
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(225, 167);
			this.Controls.Add(this.btnAddSpecies);
			this.Controls.Add(this.txtFamilyName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtSpeciesName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtCommonName);
			this.Controls.Add(this.label1);
			this.MinimumSize = new System.Drawing.Size(241, 206);
			this.Name = "FormAddSpecies";
			this.Text = "FormAddSpecies";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCommonName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSpeciesName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtFamilyName;
		private System.Windows.Forms.Button btnAddSpecies;
	}
}