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
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column3,
            this.Column1,
            this.Column2});
			this.dataGridView1.Location = new System.Drawing.Point(26, 72);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 82;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(631, 250);
			this.dataGridView1.TabIndex = 4;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "SpeciesId";
			this.Column4.HeaderText = "編號";
			this.Column4.MinimumWidth = 10;
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Visible = false;
			this.Column4.Width = 200;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "FamilyName";
			this.Column3.HeaderText = "科名";
			this.Column3.MinimumWidth = 10;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 150;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "CommonName";
			this.Column1.HeaderText = "中文名";
			this.Column1.MinimumWidth = 10;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 150;
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column2.DataPropertyName = "SpeciesName";
			this.Column2.HeaderText = "學名";
			this.Column2.MinimumWidth = 10;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// comboBoxFamilyName
			// 
			this.comboBoxFamilyName.FormattingEnabled = true;
			this.comboBoxFamilyName.Location = new System.Drawing.Point(65, 28);
			this.comboBoxFamilyName.Name = "comboBoxFamilyName";
			this.comboBoxFamilyName.Size = new System.Drawing.Size(121, 20);
			this.comboBoxFamilyName.TabIndex = 0;
			this.comboBoxFamilyName.SelectedIndexChanged += new System.EventHandler(this.comboBoxFamilyName_SelectedIndexChanged);
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
			this.txtCommonName.TabIndex = 1;
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
			this.txtSpeciesName.TabIndex = 2;
			// 
			// btnSearchSpecies
			// 
			this.btnSearchSpecies.Location = new System.Drawing.Point(582, 26);
			this.btnSearchSpecies.Name = "btnSearchSpecies";
			this.btnSearchSpecies.Size = new System.Drawing.Size(75, 23);
			this.btnSearchSpecies.TabIndex = 3;
			this.btnSearchSpecies.Text = "搜尋";
			this.btnSearchSpecies.UseVisualStyleBackColor = true;
			this.btnSearchSpecies.Click += new System.EventHandler(this.btnSearchSpecies_Click);
			// 
			// btnAddSpecie
			// 
			this.btnAddSpecie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddSpecie.Location = new System.Drawing.Point(582, 341);
			this.btnAddSpecie.Name = "btnAddSpecie";
			this.btnAddSpecie.Size = new System.Drawing.Size(75, 23);
			this.btnAddSpecie.TabIndex = 5;
			this.btnAddSpecie.Text = "新增";
			this.btnAddSpecie.UseVisualStyleBackColor = true;
			this.btnAddSpecie.Click += new System.EventHandler(this.btnAddSpecie_Click);
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
			this.MinimumSize = new System.Drawing.Size(699, 423);
			this.Name = "FormSpecies";
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
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
	}
}