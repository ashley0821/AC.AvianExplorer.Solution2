namespace AC.AvianExplorer.WinApp
{
	partial class FormSpecies
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.comboBoxFamilyName = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCommonName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtSpeciesName = new System.Windows.Forms.TextBox();
			this.btnSearchSpecies = new System.Windows.Forms.Button();
			this.btnAddSpecie = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(26, 72);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(631, 250);
			this.dataGridView1.TabIndex = 0;
			// 
			// comboBoxFamilyName
			// 
			this.comboBoxFamilyName.FormattingEnabled = true;
			this.comboBoxFamilyName.Location = new System.Drawing.Point(65, 28);
			this.comboBoxFamilyName.Name = "comboBoxFamilyName";
			this.comboBoxFamilyName.Size = new System.Drawing.Size(121, 20);
			this.comboBoxFamilyName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "科名:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(211, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "中文名:";
			// 
			// txtCommonName
			// 
			this.txtCommonName.Location = new System.Drawing.Point(261, 27);
			this.txtCommonName.Name = "txtCommonName";
			this.txtCommonName.Size = new System.Drawing.Size(100, 22);
			this.txtCommonName.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(390, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 12);
			this.label3.TabIndex = 3;
			this.label3.Text = "學名:";
			// 
			// txtSpeciesName
			// 
			this.txtSpeciesName.Location = new System.Drawing.Point(428, 27);
			this.txtSpeciesName.Name = "txtSpeciesName";
			this.txtSpeciesName.Size = new System.Drawing.Size(100, 22);
			this.txtSpeciesName.TabIndex = 4;
			// 
			// btnSearchSpecies
			// 
			this.btnSearchSpecies.Location = new System.Drawing.Point(582, 26);
			this.btnSearchSpecies.Name = "btnSearchSpecies";
			this.btnSearchSpecies.Size = new System.Drawing.Size(75, 23);
			this.btnSearchSpecies.TabIndex = 5;
			this.btnSearchSpecies.Text = "搜尋";
			this.btnSearchSpecies.UseVisualStyleBackColor = true;
			this.btnSearchSpecies.Click += new System.EventHandler(this.btnSearchSpecies_Click);
			// 
			// btnAddSpecie
			// 
			this.btnAddSpecie.Location = new System.Drawing.Point(582, 341);
			this.btnAddSpecie.Name = "btnAddSpecie";
			this.btnAddSpecie.Size = new System.Drawing.Size(75, 23);
			this.btnAddSpecie.TabIndex = 6;
			this.btnAddSpecie.Text = "新增";
			this.btnAddSpecie.UseVisualStyleBackColor = true;
			// 
			// FormSpecies
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(683, 384);
			this.Controls.Add(this.btnAddSpecie);
			this.Controls.Add(this.btnSearchSpecies);
			this.Controls.Add(this.txtSpeciesName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtCommonName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBoxFamilyName);
			this.Controls.Add(this.dataGridView1);
			this.Name = "FormSpecies";
			this.Text = "FormSpecies";
			this.Load += new System.EventHandler(this.FormSpecies_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ComboBox comboBoxFamilyName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCommonName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSpeciesName;
		private System.Windows.Forms.Button btnSearchSpecies;
		private System.Windows.Forms.Button btnAddSpecie;
	}
}