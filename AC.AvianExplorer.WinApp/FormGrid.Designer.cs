namespace AC.AvianExplorer.WinApp
{
	partial class FormGrid
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
			this.label3 = new System.Windows.Forms.Label();
			this.txtCommonName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxFamilyName = new System.Windows.Forms.ComboBox();
			this.comboBoxLocation = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnSearch = new System.Windows.Forms.Button();
			this.labelDescription = new System.Windows.Forms.Label();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(39, 46);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 12);
			this.label3.TabIndex = 17;
			this.label3.Text = "地點:";
			// 
			// txtCommonName
			// 
			this.txtCommonName.Location = new System.Drawing.Point(463, 41);
			this.txtCommonName.Name = "txtCommonName";
			this.txtCommonName.Size = new System.Drawing.Size(100, 22);
			this.txtCommonName.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(413, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 12);
			this.label2.TabIndex = 15;
			this.label2.Text = "中文名:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(229, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 12);
			this.label1.TabIndex = 14;
			this.label1.Text = "科名:";
			// 
			// comboBoxFamilyName
			// 
			this.comboBoxFamilyName.FormattingEnabled = true;
			this.comboBoxFamilyName.Location = new System.Drawing.Point(267, 42);
			this.comboBoxFamilyName.Name = "comboBoxFamilyName";
			this.comboBoxFamilyName.Size = new System.Drawing.Size(121, 20);
			this.comboBoxFamilyName.TabIndex = 1;
			this.comboBoxFamilyName.SelectedIndexChanged += new System.EventHandler(this.comboBoxFamilyName_SelectedIndexChanged);
			// 
			// comboBoxLocation
			// 
			this.comboBoxLocation.FormattingEnabled = true;
			this.comboBoxLocation.Location = new System.Drawing.Point(77, 42);
			this.comboBoxLocation.Name = "comboBoxLocation";
			this.comboBoxLocation.Size = new System.Drawing.Size(121, 20);
			this.comboBoxLocation.TabIndex = 0;
			this.comboBoxLocation.SelectedIndexChanged += new System.EventHandler(this.comboBoxLocation_SelectedIndexChanged);
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
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
			this.dataGridView1.Location = new System.Drawing.Point(37, 293);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(726, 316);
			this.dataGridView1.TabIndex = 4;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "UserId";
			this.Column1.HeaderText = "使用者Id";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Visible = false;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "LocationName";
			this.Column2.HeaderText = "地點";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Visible = false;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "FamilyName";
			this.Column3.HeaderText = "科名";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column4.DataPropertyName = "CommonName";
			this.Column4.HeaderText = "中文名";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "Total";
			this.Column5.HeaderText = "數量";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(688, 41);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 3;
			this.btnSearch.Text = "搜尋";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// labelDescription
			// 
			this.labelDescription.AutoSize = true;
			this.labelDescription.Location = new System.Drawing.Point(41, 82);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(33, 12);
			this.labelDescription.TabIndex = 19;
			this.labelDescription.Text = "label4";
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
			this.dataGridView2.Location = new System.Drawing.Point(37, 144);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.RowTemplate.Height = 24;
			this.dataGridView2.Size = new System.Drawing.Size(726, 126);
			this.dataGridView2.TabIndex = 20;
			// 
			// Column6
			// 
			this.Column6.DataPropertyName = "UserId";
			this.Column6.HeaderText = "使用者ID";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.Visible = false;
			// 
			// Column7
			// 
			this.Column7.DataPropertyName = "LocationName";
			this.Column7.HeaderText = "地點";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			this.Column7.Visible = false;
			// 
			// Column8
			// 
			this.Column8.DataPropertyName = "FamilyName";
			this.Column8.HeaderText = "科名";
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			// 
			// Column9
			// 
			this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column9.DataPropertyName = "CommonName";
			this.Column9.HeaderText = "中文名";
			this.Column9.Name = "Column9";
			this.Column9.ReadOnly = true;
			// 
			// Column10
			// 
			this.Column10.DataPropertyName = "Total";
			this.Column10.HeaderText = "數量";
			this.Column10.Name = "Column10";
			this.Column10.ReadOnly = true;
			// 
			// FormGrid
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 653);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.labelDescription);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtCommonName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBoxFamilyName);
			this.Controls.Add(this.comboBoxLocation);
			this.Controls.Add(this.dataGridView1);
			this.MinimumSize = new System.Drawing.Size(816, 480);
			this.Name = "FormGrid";
			this.Text = "FormGrid";
			this.Load += new System.EventHandler(this.FormGrid_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCommonName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxFamilyName;
		private System.Windows.Forms.ComboBox comboBoxLocation;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
	}
}