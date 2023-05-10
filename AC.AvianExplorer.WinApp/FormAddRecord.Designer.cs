namespace AC.AvianExplorer.WinApp
{
	partial class FormAddRecord
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
			this.dateTimePickerRecordTime = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.comboBoxCommonName = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxFamilyName = new System.Windows.Forms.ComboBox();
			this.comboBoxLocation = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtQuantity = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// dateTimePickerRecordTime
			// 
			this.dateTimePickerRecordTime.Location = new System.Drawing.Point(89, 155);
			this.dateTimePickerRecordTime.MaxDate = new System.DateTime(2023, 5, 10, 14, 47, 47, 0);
			this.dateTimePickerRecordTime.Name = "dateTimePickerRecordTime";
			this.dateTimePickerRecordTime.Size = new System.Drawing.Size(167, 22);
			this.dateTimePickerRecordTime.TabIndex = 3;
			this.dateTimePickerRecordTime.Value = new System.DateTime(2023, 5, 10, 0, 0, 0, 0);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(262, 201);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(37, 12);
			this.label7.TabIndex = 21;
			this.label7.Text = "(整數)";
			// 
			// comboBoxCommonName
			// 
			this.comboBoxCommonName.FormattingEnabled = true;
			this.comboBoxCommonName.Location = new System.Drawing.Point(89, 118);
			this.comboBoxCommonName.Name = "comboBoxCommonName";
			this.comboBoxCommonName.Size = new System.Drawing.Size(167, 20);
			this.comboBoxCommonName.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(51, 122);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 12);
			this.label3.TabIndex = 19;
			this.label3.Text = "物種:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(51, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 12);
			this.label2.TabIndex = 18;
			this.label2.Text = "科名:";
			// 
			// comboBoxFamilyName
			// 
			this.comboBoxFamilyName.FormattingEnabled = true;
			this.comboBoxFamilyName.Location = new System.Drawing.Point(89, 77);
			this.comboBoxFamilyName.Name = "comboBoxFamilyName";
			this.comboBoxFamilyName.Size = new System.Drawing.Size(167, 20);
			this.comboBoxFamilyName.TabIndex = 1;
			this.comboBoxFamilyName.SelectedIndexChanged += new System.EventHandler(this.comboBoxFamilyName_SelectedIndexChanged);
			// 
			// comboBoxLocation
			// 
			this.comboBoxLocation.FormattingEnabled = true;
			this.comboBoxLocation.Location = new System.Drawing.Point(89, 37);
			this.comboBoxLocation.Name = "comboBoxLocation";
			this.comboBoxLocation.Size = new System.Drawing.Size(167, 20);
			this.comboBoxLocation.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(54, 201);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 12);
			this.label5.TabIndex = 13;
			this.label5.Text = "數量";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(51, 160);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 12);
			this.label4.TabIndex = 14;
			this.label4.Text = "日期:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(51, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 12);
			this.label1.TabIndex = 15;
			this.label1.Text = "地點:";
			// 
			// txtQuantity
			// 
			this.txtQuantity.Location = new System.Drawing.Point(89, 196);
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.Size = new System.Drawing.Size(167, 22);
			this.txtQuantity.TabIndex = 4;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(180, 241);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 5;
			this.btnAdd.Text = "新增";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// FormAddRecord
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(339, 298);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.dateTimePickerRecordTime);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.comboBoxCommonName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBoxFamilyName);
			this.Controls.Add(this.comboBoxLocation);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtQuantity);
			this.MinimumSize = new System.Drawing.Size(355, 337);
			this.Name = "FormAddRecord";
			this.Text = "FormAddRecord";
			this.Load += new System.EventHandler(this.FormAddRecord_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dateTimePickerRecordTime;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox comboBoxCommonName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBoxFamilyName;
		private System.Windows.Forms.ComboBox comboBoxLocation;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtQuantity;
		private System.Windows.Forms.Button btnAdd;
	}
}