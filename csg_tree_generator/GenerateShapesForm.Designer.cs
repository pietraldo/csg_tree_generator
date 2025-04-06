namespace csg_tree_generator
{
	partial class GenerateShapesForm
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
		private void NumericUpDown_Enter(object sender, EventArgs e)
		{
			var nud = sender as NumericUpDown;
			if (nud != null)
			{
				nud.Select(0, nud.Text.Length);
			}
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
			txtXMin = new NumericUpDown();
			txtYMin = new NumericUpDown();
			txtZMin = new NumericUpDown();
			txtRadiusMin = new NumericUpDown();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			txtRadiusMax = new NumericUpDown();
			txtZMax = new NumericUpDown();
			txtYMax = new NumericUpDown();
			txtXMax = new NumericUpDown();
			txtRotationXMax = new NumericUpDown();
			label5 = new Label();
			txtRotationXMin = new NumericUpDown();
			txtRotationYMax = new NumericUpDown();
			label6 = new Label();
			txtRotationYMin = new NumericUpDown();
			txtRotationZMax = new NumericUpDown();
			label7 = new Label();
			txtRotationZMin = new NumericUpDown();
			txtHeightMax = new NumericUpDown();
			label8 = new Label();
			txtHeightMin = new NumericUpDown();
			txtWidthMax = new NumericUpDown();
			label9 = new Label();
			txtWidthMin = new NumericUpDown();
			chBoxReplace = new CheckBox();
			((System.ComponentModel.ISupportInitialize)txtXMin).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtYMin).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtZMin).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtRadiusMin).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtRadiusMax).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtZMax).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtYMax).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtXMax).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtRotationXMax).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtRotationXMin).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtRotationYMax).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtRotationYMin).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtRotationZMax).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtRotationZMin).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtHeightMax).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtHeightMin).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtWidthMax).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtWidthMin).BeginInit();
			SuspendLayout();
			// 
			// btnSelectColor
			// 
			btnSelectColor.Location = new Point(85, 99);
			btnSelectColor.Name = "btnSelectColor";
			btnSelectColor.Size = new Size(120, 23);
			btnSelectColor.TabIndex = 21;
			btnSelectColor.Text = "Select Color";
			btnSelectColor.UseVisualStyleBackColor = true;
			// 
			// txtXMin
			// 
			txtXMin.DecimalPlaces = 2;
			txtXMin.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
			txtXMin.Location = new Point(85, 12);
			txtXMin.Name = "txtXMin";
			txtXMin.Size = new Size(120, 23);
			txtXMin.TabIndex = 1;
			txtXMin.Enter += NumericUpDown_Enter;
			// 
			// txtYMin
			// 
			txtYMin.DecimalPlaces = 2;
			txtYMin.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
			txtYMin.Location = new Point(85, 41);
			txtYMin.Name = "txtYMin";
			txtYMin.Size = new Size(120, 23);
			txtYMin.TabIndex = 3;
			txtYMin.Enter += NumericUpDown_Enter;
			// 
			// txtZMin
			// 
			txtZMin.DecimalPlaces = 2;
			txtZMin.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
			txtZMin.Location = new Point(85, 70);
			txtZMin.Name = "txtZMin";
			txtZMin.Size = new Size(120, 23);
			txtZMin.TabIndex = 5;
			txtZMin.Enter += NumericUpDown_Enter;
			// 
			// txtRadiusMin
			// 
			txtRadiusMin.DecimalPlaces = 2;
			txtRadiusMin.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
			txtRadiusMin.Location = new Point(85, 128);
			txtRadiusMin.Name = "txtRadiusMin";
			txtRadiusMin.Size = new Size(120, 23);
			txtRadiusMin.TabIndex = 7;
			txtRadiusMin.Enter += NumericUpDown_Enter;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(39, 14);
			label1.Name = "label1";
			label1.Size = new Size(14, 15);
			label1.TabIndex = 6;
			label1.Text = "X";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(39, 49);
			label2.Name = "label2";
			label2.Size = new Size(14, 15);
			label2.TabIndex = 7;
			label2.Text = "Y";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(39, 72);
			label3.Name = "label3";
			label3.Size = new Size(14, 15);
			label3.TabIndex = 8;
			label3.Text = "Z";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(39, 130);
			label4.Name = "label4";
			label4.Size = new Size(42, 15);
			label4.TabIndex = 9;
			label4.Text = "Radius";
			// 
			// txtRadiusMax
			// 
			txtRadiusMax.DecimalPlaces = 2;
			txtRadiusMax.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
			txtRadiusMax.Location = new Point(211, 128);
			txtRadiusMax.Name = "txtRadiusMax";
			txtRadiusMax.Size = new Size(120, 23);
			txtRadiusMax.TabIndex = 8;
			txtRadiusMax.Enter += NumericUpDown_Enter;
			// 
			// txtZMax
			// 
			txtZMax.DecimalPlaces = 2;
			txtZMax.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
			txtZMax.Location = new Point(211, 70);
			txtZMax.Name = "txtZMax";
			txtZMax.Size = new Size(120, 23);
			txtZMax.TabIndex = 6;
			txtZMax.Enter += NumericUpDown_Enter;
			// 
			// txtYMax
			// 
			txtYMax.DecimalPlaces = 2;
			txtYMax.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
			txtYMax.Location = new Point(211, 41);
			txtYMax.Name = "txtYMax";
			txtYMax.Size = new Size(120, 23);
			txtYMax.TabIndex = 4;
			txtYMax.Enter += NumericUpDown_Enter;
			// 
			// txtXMax
			// 
			txtXMax.DecimalPlaces = 2;
			txtXMax.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
			txtXMax.Location = new Point(211, 12);
			txtXMax.Name = "txtXMax";
			txtXMax.Size = new Size(120, 23);
			txtXMax.TabIndex = 2;
			txtXMax.Enter += NumericUpDown_Enter;
			// 
			// txtRotationXMax
			// 
			txtRotationXMax.DecimalPlaces = 2;
			txtRotationXMax.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
			txtRotationXMax.Location = new Point(211, 157);
			txtRotationXMax.Name = "txtRotationXMax";
			txtRotationXMax.Size = new Size(120, 23);
			txtRotationXMax.TabIndex = 10;
			txtRotationXMax.Enter += NumericUpDown_Enter;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(19, 159);
			label5.Name = "label5";
			label5.Size = new Size(62, 15);
			label5.TabIndex = 15;
			label5.Text = "Rotation X";
			label5.Click += label5_Click;
			// 
			// txtRotationXMin
			// 
			txtRotationXMin.DecimalPlaces = 2;
			txtRotationXMin.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
			txtRotationXMin.Location = new Point(85, 157);
			txtRotationXMin.Name = "txtRotationXMin";
			txtRotationXMin.Size = new Size(120, 23);
			txtRotationXMin.TabIndex = 9;
			txtRotationXMin.Enter += NumericUpDown_Enter;
			// 
			// txtRotationYMax
			// 
			txtRotationYMax.DecimalPlaces = 2;
			txtRotationYMax.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
			txtRotationYMax.Location = new Point(211, 186);
			txtRotationYMax.Name = "txtRotationYMax";
			txtRotationYMax.Size = new Size(120, 23);
			txtRotationYMax.TabIndex = 12;
			txtRotationYMax.Enter += NumericUpDown_Enter;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(17, 190);
			label6.Name = "label6";
			label6.Size = new Size(62, 15);
			label6.TabIndex = 18;
			label6.Text = "Rotation Y";
			// 
			// txtRotationYMin
			// 
			txtRotationYMin.DecimalPlaces = 2;
			txtRotationYMin.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
			txtRotationYMin.Location = new Point(85, 186);
			txtRotationYMin.Name = "txtRotationYMin";
			txtRotationYMin.Size = new Size(120, 23);
			txtRotationYMin.TabIndex = 11;
			txtRotationYMin.Enter += NumericUpDown_Enter;
			// 
			// txtRotationZMax
			// 
			txtRotationZMax.DecimalPlaces = 2;
			txtRotationZMax.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
			txtRotationZMax.Location = new Point(211, 215);
			txtRotationZMax.Name = "txtRotationZMax";
			txtRotationZMax.Size = new Size(120, 23);
			txtRotationZMax.TabIndex = 14;
			txtRotationZMax.Enter += NumericUpDown_Enter;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(19, 217);
			label7.Name = "label7";
			label7.Size = new Size(62, 15);
			label7.TabIndex = 21;
			label7.Text = "Rotation Z";
			// 
			// txtRotationZMin
			// 
			txtRotationZMin.DecimalPlaces = 2;
			txtRotationZMin.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
			txtRotationZMin.Location = new Point(85, 215);
			txtRotationZMin.Name = "txtRotationZMin";
			txtRotationZMin.Size = new Size(120, 23);
			txtRotationZMin.TabIndex = 13;
			txtRotationZMin.Enter += NumericUpDown_Enter;
			// 
			// txtHeightMax
			// 
			txtHeightMax.DecimalPlaces = 2;
			txtHeightMax.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
			txtHeightMax.Location = new Point(211, 244);
			txtHeightMax.Name = "txtHeightMax";
			txtHeightMax.Size = new Size(120, 23);
			txtHeightMax.TabIndex = 16;
			txtHeightMax.Enter += NumericUpDown_Enter;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(39, 246);
			label8.Name = "label8";
			label8.Size = new Size(43, 15);
			label8.TabIndex = 24;
			label8.Text = "Height";
			// 
			// txtHeightMin
			// 
			txtHeightMin.DecimalPlaces = 2;
			txtHeightMin.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
			txtHeightMin.Location = new Point(85, 244);
			txtHeightMin.Name = "txtHeightMin";
			txtHeightMin.Size = new Size(120, 23);
			txtHeightMin.TabIndex = 15;
			txtHeightMin.Enter += NumericUpDown_Enter;
			// 
			// txtWidthMax
			// 
			txtWidthMax.DecimalPlaces = 2;
			txtWidthMax.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
			txtWidthMax.Location = new Point(211, 273);
			txtWidthMax.Name = "txtWidthMax";
			txtWidthMax.Size = new Size(120, 23);
			txtWidthMax.TabIndex = 18;
			txtWidthMax.Enter += NumericUpDown_Enter;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(39, 275);
			label9.Name = "label9";
			label9.Size = new Size(39, 15);
			label9.TabIndex = 27;
			label9.Text = "Width";
			// 
			// txtWidthMin
			// 
			txtWidthMin.DecimalPlaces = 2;
			txtWidthMin.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
			txtWidthMin.Location = new Point(85, 273);
			txtWidthMin.Name = "txtWidthMin";
			txtWidthMin.Size = new Size(120, 23);
			txtWidthMin.TabIndex = 17;
			txtWidthMin.Enter += NumericUpDown_Enter;
			// 
			// chBoxReplace
			// 
			chBoxReplace.AutoSize = true;
			chBoxReplace.Location = new Point(39, 313);
			chBoxReplace.Name = "chBoxReplace";
			chBoxReplace.Size = new Size(151, 19);
			chBoxReplace.TabIndex = 28;
			chBoxReplace.Text = "Over write existing ones";
			chBoxReplace.UseVisualStyleBackColor = true;
			// 
			// GenerateShapesForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(507, 476);
			Controls.Add(chBoxReplace);
			Controls.Add(txtWidthMax);
			Controls.Add(label9);
			Controls.Add(txtWidthMin);
			Controls.Add(txtHeightMax);
			Controls.Add(label8);
			Controls.Add(txtHeightMin);
			Controls.Add(txtRotationZMax);
			Controls.Add(label7);
			Controls.Add(txtRotationZMin);
			Controls.Add(txtRotationYMax);
			Controls.Add(label6);
			Controls.Add(txtRotationYMin);
			Controls.Add(txtRotationXMax);
			Controls.Add(label5);
			Controls.Add(txtRotationXMin);
			Controls.Add(txtRadiusMax);
			Controls.Add(txtZMax);
			Controls.Add(txtYMax);
			Controls.Add(txtXMax);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(txtRadiusMin);
			Controls.Add(txtZMin);
			Controls.Add(txtYMin);
			Controls.Add(txtXMin);
			Controls.Add(btnSelectColor);
			Name = "GenerateShapesForm";
			Text = "CreateSphere";
			((System.ComponentModel.ISupportInitialize)txtXMin).EndInit();
			((System.ComponentModel.ISupportInitialize)txtYMin).EndInit();
			((System.ComponentModel.ISupportInitialize)txtZMin).EndInit();
			((System.ComponentModel.ISupportInitialize)txtRadiusMin).EndInit();
			((System.ComponentModel.ISupportInitialize)txtRadiusMax).EndInit();
			((System.ComponentModel.ISupportInitialize)txtZMax).EndInit();
			((System.ComponentModel.ISupportInitialize)txtYMax).EndInit();
			((System.ComponentModel.ISupportInitialize)txtXMax).EndInit();
			((System.ComponentModel.ISupportInitialize)txtRotationXMax).EndInit();
			((System.ComponentModel.ISupportInitialize)txtRotationXMin).EndInit();
			((System.ComponentModel.ISupportInitialize)txtRotationYMax).EndInit();
			((System.ComponentModel.ISupportInitialize)txtRotationYMin).EndInit();
			((System.ComponentModel.ISupportInitialize)txtRotationZMax).EndInit();
			((System.ComponentModel.ISupportInitialize)txtRotationZMin).EndInit();
			((System.ComponentModel.ISupportInitialize)txtHeightMax).EndInit();
			((System.ComponentModel.ISupportInitialize)txtHeightMin).EndInit();
			((System.ComponentModel.ISupportInitialize)txtWidthMax).EndInit();
			((System.ComponentModel.ISupportInitialize)txtWidthMin).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ColorDialog colorDialog1;
		private Button btnSelectColor;
		private NumericUpDown txtXMin;
		private NumericUpDown txtYMin;
		private NumericUpDown txtZMin;
		private NumericUpDown txtRadiusMin;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private NumericUpDown txtRadiusMax;
		private NumericUpDown txtZMax;
		private NumericUpDown txtYMax;
		private NumericUpDown txtXMax;
		private NumericUpDown txtRotationXMax;
		private Label label5;
		private NumericUpDown txtRotationXMin;
		private NumericUpDown txtRotationYMax;
		private Label label6;
		private NumericUpDown txtRotationYMin;
		private NumericUpDown txtRotationZMax;
		private Label label7;
		private NumericUpDown txtRotationZMin;
		private NumericUpDown txtHeightMax;
		private Label label8;
		private NumericUpDown txtHeightMin;
		private NumericUpDown txtWidthMax;
		private Label label9;
		private NumericUpDown txtWidthMin;
		private CheckBox chBoxReplace;
	}
}