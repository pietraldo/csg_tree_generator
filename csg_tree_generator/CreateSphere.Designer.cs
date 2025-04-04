namespace csg_tree_generator
{
	partial class CreateSphere
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
			colorDialog1 = new ColorDialog();
			btnSelectColor = new Button();
			txtX = new NumericUpDown();
			txtY = new NumericUpDown();
			txtZ = new NumericUpDown();
			txtRadius = new NumericUpDown();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			((System.ComponentModel.ISupportInitialize)txtX).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtY).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtZ).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtRadius).BeginInit();
			SuspendLayout();
			// 
			// btnSelectColor
			// 
			btnSelectColor.Location = new Point(12, 99);
			btnSelectColor.Name = "btnSelectColor";
			btnSelectColor.Size = new Size(75, 23);
			btnSelectColor.TabIndex = 0;
			btnSelectColor.Text = "Select Color";
			btnSelectColor.UseVisualStyleBackColor = true;
			// 
			// txtX
			// 
			txtX.DecimalPlaces = 2;
			txtX.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
			txtX.Location = new Point(12, 12);
			txtX.Name = "txtX";
			txtX.Size = new Size(120, 23);
			txtX.TabIndex = 2;
			// 
			// txtY
			// 
			txtY.DecimalPlaces = 2;
			txtY.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
			txtY.Location = new Point(12, 41);
			txtY.Name = "txtY";
			txtY.Size = new Size(120, 23);
			txtY.TabIndex = 3;
			// 
			// txtZ
			// 
			txtZ.DecimalPlaces = 2;
			txtZ.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
			txtZ.Location = new Point(12, 70);
			txtZ.Name = "txtZ";
			txtZ.Size = new Size(120, 23);
			txtZ.TabIndex = 4;
			// 
			// txtRadius
			// 
			txtRadius.DecimalPlaces = 2;
			txtRadius.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
			txtRadius.Location = new Point(12, 128);
			txtRadius.Name = "txtRadius";
			txtRadius.Size = new Size(120, 23);
			txtRadius.TabIndex = 5;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(138, 14);
			label1.Name = "label1";
			label1.Size = new Size(14, 15);
			label1.TabIndex = 6;
			label1.Text = "X";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(138, 49);
			label2.Name = "label2";
			label2.Size = new Size(14, 15);
			label2.TabIndex = 7;
			label2.Text = "Y";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(138, 72);
			label3.Name = "label3";
			label3.Size = new Size(14, 15);
			label3.TabIndex = 8;
			label3.Text = "Z";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(138, 130);
			label4.Name = "label4";
			label4.Size = new Size(42, 15);
			label4.TabIndex = 9;
			label4.Text = "Radius";
			// 
			// CreateSphere
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(372, 272);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(txtRadius);
			Controls.Add(txtZ);
			Controls.Add(txtY);
			Controls.Add(txtX);
			Controls.Add(btnSelectColor);
			Name = "CreateSphere";
			Text = "CreateSphere";
			((System.ComponentModel.ISupportInitialize)txtX).EndInit();
			((System.ComponentModel.ISupportInitialize)txtY).EndInit();
			((System.ComponentModel.ISupportInitialize)txtZ).EndInit();
			((System.ComponentModel.ISupportInitialize)txtRadius).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ColorDialog colorDialog1;
		private Button btnSelectColor;
		private NumericUpDown txtX;
		private NumericUpDown txtY;
		private NumericUpDown txtZ;
		private NumericUpDown txtRadius;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
	}
}