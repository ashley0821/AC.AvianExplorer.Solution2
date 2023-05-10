﻿namespace AC.AvianExplorer.WinApp
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
			this.txtRecordTime = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtQuantity = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBoxLocation = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxFamilyName = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.comboBoxCommonName = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(57, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "地點:";
			// 
			// txtRecordTime
			// 
			this.txtRecordTime.Location = new System.Drawing.Point(95, 160);
			this.txtRecordTime.Name = "txtRecordTime";
			this.txtRecordTime.Size = new System.Drawing.Size(167, 22);
			this.txtRecordTime.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(57, 163);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 12);
			this.label4.TabIndex = 1;
			this.label4.Text = "日期:";
			// 
			// txtQuantity
			// 
			this.txtQuantity.Location = new System.Drawing.Point(95, 198);
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.Size = new System.Drawing.Size(167, 22);
			this.txtQuantity.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(59, 201);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 12);
			this.label5.TabIndex = 1;
			this.label5.Text = "數量";
			// 
			// comboBoxLocation
			// 
			this.comboBoxLocation.FormattingEnabled = true;
			this.comboBoxLocation.Location = new System.Drawing.Point(95, 52);
			this.comboBoxLocation.Name = "comboBoxLocation";
			this.comboBoxLocation.Size = new System.Drawing.Size(167, 20);
			this.comboBoxLocation.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(57, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 12);
			this.label2.TabIndex = 4;
			this.label2.Text = "科名:";
			// 
			// comboBoxFamilyName
			// 
			this.comboBoxFamilyName.FormattingEnabled = true;
			this.comboBoxFamilyName.Location = new System.Drawing.Point(95, 88);
			this.comboBoxFamilyName.Name = "comboBoxFamilyName";
			this.comboBoxFamilyName.Size = new System.Drawing.Size(167, 20);
			this.comboBoxFamilyName.TabIndex = 3;
			this.comboBoxFamilyName.SelectedIndexChanged += new System.EventHandler(this.comboBoxFamilyName_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(57, 127);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 12);
			this.label3.TabIndex = 6;
			this.label3.Text = "物種:";
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(187, 238);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 7;
			this.btnUpdate.Text = "更新";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// comboBoxCommonName
			// 
			this.comboBoxCommonName.FormattingEnabled = true;
			this.comboBoxCommonName.Location = new System.Drawing.Point(95, 124);
			this.comboBoxCommonName.Name = "comboBoxCommonName";
			this.comboBoxCommonName.Size = new System.Drawing.Size(167, 20);
			this.comboBoxCommonName.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(268, 163);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(73, 12);
			this.label6.TabIndex = 9;
			this.label6.Text = "(yyyy/mm/dd)";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(268, 201);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(37, 12);
			this.label7.TabIndex = 10;
			this.label7.Text = "(整數)";
			// 
			// FormEditRecord
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(401, 316);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.comboBoxCommonName);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBoxFamilyName);
			this.Controls.Add(this.comboBoxLocation);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtQuantity);
			this.Controls.Add(this.txtRecordTime);
			this.Name = "FormEditRecord";
			this.Text = "FormEditRecord";
			this.Load += new System.EventHandler(this.FormEditRecord_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtRecordTime;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtQuantity;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBoxLocation;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBoxFamilyName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.ComboBox comboBoxCommonName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
	}
}