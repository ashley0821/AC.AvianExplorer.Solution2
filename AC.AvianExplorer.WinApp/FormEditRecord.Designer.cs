namespace AC.AvianExplorer.WinApp
{
	partial class FormEditRecord
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
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBoxLocation = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxFamilyName = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.comboBoxCommonName = new System.Windows.Forms.ComboBox();
			this.dateTimePickerRecordTime = new System.Windows.Forms.DateTimePicker();
			this.btnDelete = new System.Windows.Forms.Button();
			this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(124, 110);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "地點:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(124, 348);
			this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 24);
			this.label4.TabIndex = 1;
			this.label4.Text = "日期:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(130, 424);
			this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 24);
			this.label5.TabIndex = 1;
			this.label5.Text = "數量";
			// 
			// comboBoxLocation
			// 
			this.comboBoxLocation.FormattingEnabled = true;
			this.comboBoxLocation.Location = new System.Drawing.Point(206, 102);
			this.comboBoxLocation.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.comboBoxLocation.Name = "comboBoxLocation";
			this.comboBoxLocation.Size = new System.Drawing.Size(357, 32);
			this.comboBoxLocation.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(124, 190);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 24);
			this.label2.TabIndex = 4;
			this.label2.Text = "科名:";
			// 
			// comboBoxFamilyName
			// 
			this.comboBoxFamilyName.FormattingEnabled = true;
			this.comboBoxFamilyName.Location = new System.Drawing.Point(206, 182);
			this.comboBoxFamilyName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.comboBoxFamilyName.Name = "comboBoxFamilyName";
			this.comboBoxFamilyName.Size = new System.Drawing.Size(357, 32);
			this.comboBoxFamilyName.TabIndex = 1;
			this.comboBoxFamilyName.SelectedIndexChanged += new System.EventHandler(this.comboBoxFamilyName_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(124, 272);
			this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 24);
			this.label3.TabIndex = 6;
			this.label3.Text = "物種:";
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(405, 496);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(162, 46);
			this.btnUpdate.TabIndex = 5;
			this.btnUpdate.Text = "更新";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// comboBoxCommonName
			// 
			this.comboBoxCommonName.FormattingEnabled = true;
			this.comboBoxCommonName.Location = new System.Drawing.Point(206, 264);
			this.comboBoxCommonName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.comboBoxCommonName.Name = "comboBoxCommonName";
			this.comboBoxCommonName.Size = new System.Drawing.Size(357, 32);
			this.comboBoxCommonName.TabIndex = 2;
			// 
			// dateTimePickerRecordTime
			// 
			this.dateTimePickerRecordTime.Location = new System.Drawing.Point(206, 338);
			this.dateTimePickerRecordTime.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.dateTimePickerRecordTime.MaxDate = new System.DateTime(3046, 8, 14, 0, 0, 0, 0);
			this.dateTimePickerRecordTime.Name = "dateTimePickerRecordTime";
			this.dateTimePickerRecordTime.Size = new System.Drawing.Size(357, 36);
			this.dateTimePickerRecordTime.TabIndex = 3;
			this.dateTimePickerRecordTime.Value = new System.DateTime(2023, 5, 10, 0, 0, 0, 0);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(230, 496);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(162, 46);
			this.btnDelete.TabIndex = 6;
			this.btnDelete.Text = "刪除";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// numericUpDownQuantity
			// 
			this.numericUpDownQuantity.Location = new System.Drawing.Point(202, 418);
			this.numericUpDownQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDownQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownQuantity.Name = "numericUpDownQuantity";
			this.numericUpDownQuantity.Size = new System.Drawing.Size(361, 36);
			this.numericUpDownQuantity.TabIndex = 11;
			this.numericUpDownQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// FormEditRecord
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(763, 632);
			this.Controls.Add(this.numericUpDownQuantity);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.dateTimePickerRecordTime);
			this.Controls.Add(this.comboBoxCommonName);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBoxFamilyName);
			this.Controls.Add(this.comboBoxLocation);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.MinimumSize = new System.Drawing.Size(767, 639);
			this.Name = "FormEditRecord";
			this.Load += new System.EventHandler(this.FormEditRecord_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBoxLocation;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBoxFamilyName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.ComboBox comboBoxCommonName;
		private System.Windows.Forms.DateTimePicker dateTimePickerRecordTime;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
	}
}