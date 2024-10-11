namespace CurrencyConverter
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			cbPairs = new ComboBox();
			lblPairs = new Label();
			txtValue = new TextBox();
			label1 = new Label();
			txtResult = new TextBox();
			label2 = new Label();
			btnConvert = new Button();
			label3 = new Label();
			lblError = new Label();
			SuspendLayout();
			// 
			// cbPairs
			// 
			cbPairs.FormattingEnabled = true;
			cbPairs.Location = new Point(85, 85);
			cbPairs.Name = "cbPairs";
			cbPairs.Size = new Size(167, 23);
			cbPairs.TabIndex = 0;
			// 
			// lblPairs
			// 
			lblPairs.AutoSize = true;
			lblPairs.Location = new Point(47, 88);
			lblPairs.Name = "lblPairs";
			lblPairs.Size = new Size(32, 15);
			lblPairs.TabIndex = 1;
			lblPairs.Text = "Pairs";
			// 
			// txtValue
			// 
			txtValue.Location = new Point(47, 137);
			txtValue.Name = "txtValue";
			txtValue.Size = new Size(89, 23);
			txtValue.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(142, 140);
			label1.Name = "label1";
			label1.Size = new Size(15, 15);
			label1.TabIndex = 3;
			label1.Text = "=";
			// 
			// txtResult
			// 
			txtResult.Enabled = false;
			txtResult.Location = new Point(163, 137);
			txtResult.Name = "txtResult";
			txtResult.Size = new Size(89, 23);
			txtResult.TabIndex = 4;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(47, 119);
			label2.Name = "label2";
			label2.Size = new Size(79, 15);
			label2.TabIndex = 5;
			label2.Text = "Insert a value:";
			// 
			// btnConvert
			// 
			btnConvert.BackColor = Color.CornflowerBlue;
			btnConvert.Location = new Point(47, 188);
			btnConvert.Name = "btnConvert";
			btnConvert.Size = new Size(205, 43);
			btnConvert.TabIndex = 6;
			btnConvert.Text = "Convert";
			btnConvert.UseVisualStyleBackColor = false;
			btnConvert.Click += btnConvert_Click;
			// 
			// label3
			// 
			label3.BackColor = SystemColors.ControlText;
			label3.Font = new Font("Segoe UI", 15F);
			label3.ForeColor = Color.White;
			label3.Location = new Point(12, 9);
			label3.Name = "label3";
			label3.Size = new Size(282, 37);
			label3.TabIndex = 7;
			label3.Text = "Currency Converter";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblError
			// 
			lblError.AutoSize = true;
			lblError.ForeColor = Color.Red;
			lblError.Location = new Point(47, 163);
			lblError.Name = "lblError";
			lblError.Size = new Size(32, 15);
			lblError.TabIndex = 8;
			lblError.Text = "Error";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(306, 263);
			Controls.Add(lblError);
			Controls.Add(label3);
			Controls.Add(btnConvert);
			Controls.Add(label2);
			Controls.Add(txtResult);
			Controls.Add(label1);
			Controls.Add(txtValue);
			Controls.Add(lblPairs);
			Controls.Add(cbPairs);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox cbPairs;
		private Label lblPairs;
		private TextBox txtValue;
		private Label label1;
		private TextBox txtResult;
		private Label label2;
		private Button btnConvert;
		private Label label3;
		private Label lblError;
	}
}
