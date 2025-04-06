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
			txtGenerate = new Button();
			chBoxSphere = new CheckBox();
			chBoxCube = new CheckBox();
			chBoxCylinder = new CheckBox();
			label10 = new Label();
			label11 = new Label();
			label12 = new Label();
			label13 = new Label();
			label14 = new Label();
			label15 = new Label();
			label16 = new Label();
			label17 = new Label();
			label18 = new Label();
			label19 = new Label();
			label20 = new Label();
			label21 = new Label();
			label22 = new Label();
			label23 = new Label();
			label24 = new Label();
			label25 = new Label();
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
			btnSelectColor.Click += btnSelectColor_Click;
			// 
			// txtXMin
			// 
			txtXMin.DecimalPlaces = 2;
			txtXMin.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
			txtXMin.Location = new Point(85, 12);
			txtXMin.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
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
			txtYMin.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
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
			txtZMin.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
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
			txtRadiusMin.Value = new decimal(new int[] { 1, 0, 0, 65536 });
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
			txtRadiusMax.Value = new decimal(new int[] { 4, 0, 0, 65536 });
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
			txtZMax.Value = new decimal(new int[] { 2, 0, 0, 0 });
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
			txtYMax.Value = new decimal(new int[] { 2, 0, 0, 0 });
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
			txtXMax.Value = new decimal(new int[] { 2, 0, 0, 0 });
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
			txtRotationXMax.Value = new decimal(new int[] { 30, 0, 0, 0 });
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
			txtRotationYMax.Value = new decimal(new int[] { 30, 0, 0, 0 });
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
			txtRotationZMax.Value = new decimal(new int[] { 30, 0, 0, 0 });
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
			txtHeightMax.Value = new decimal(new int[] { 2, 0, 0, 0 });
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
			txtWidthMax.Value = new decimal(new int[] { 2, 0, 0, 0 });
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
			// txtGenerate
			// 
			txtGenerate.Location = new Point(39, 416);
			txtGenerate.Name = "txtGenerate";
			txtGenerate.Size = new Size(109, 48);
			txtGenerate.TabIndex = 29;
			txtGenerate.Text = "Generate";
			txtGenerate.UseVisualStyleBackColor = true;
			txtGenerate.Click += txtGenerate_Click;
			// 
			// chBoxSphere
			// 
			chBoxSphere.AutoSize = true;
			chBoxSphere.Location = new Point(39, 338);
			chBoxSphere.Name = "chBoxSphere";
			chBoxSphere.Size = new Size(62, 19);
			chBoxSphere.TabIndex = 30;
			chBoxSphere.Text = "Sphere";
			chBoxSphere.UseVisualStyleBackColor = true;
			// 
			// chBoxCube
			// 
			chBoxCube.AutoSize = true;
			chBoxCube.Location = new Point(39, 363);
			chBoxCube.Name = "chBoxCube";
			chBoxCube.Size = new Size(54, 19);
			chBoxCube.TabIndex = 31;
			chBoxCube.Text = "Cube";
			chBoxCube.UseVisualStyleBackColor = true;
			// 
			// chBoxCylinder
			// 
			chBoxCylinder.AutoSize = true;
			chBoxCylinder.Location = new Point(39, 388);
			chBoxCylinder.Name = "chBoxCylinder";
			chBoxCylinder.Size = new Size(70, 19);
			chBoxCylinder.TabIndex = 32;
			chBoxCylinder.Text = "Cylinder";
			chBoxCylinder.UseVisualStyleBackColor = true;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(473, 43);
			label10.Name = "label10";
			label10.Size = new Size(51, 15);
			label10.TabIndex = 33;
			label10.Text = "Cylinder";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(473, 136);
			label11.Name = "label11";
			label11.Size = new Size(51, 15);
			label11.TabIndex = 34;
			label11.Text = "Cylinder";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(473, 72);
			label12.Name = "label12";
			label12.Size = new Size(51, 15);
			label12.TabIndex = 35;
			label12.Text = "Cylinder";
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new Point(473, 20);
			label13.Name = "label13";
			label13.Size = new Size(51, 15);
			label13.TabIndex = 36;
			label13.Text = "Cylinder";
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Location = new Point(473, 246);
			label14.Name = "label14";
			label14.Size = new Size(51, 15);
			label14.TabIndex = 37;
			label14.Text = "Cylinder";
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Location = new Point(337, 20);
			label15.Name = "label15";
			label15.Size = new Size(43, 15);
			label15.TabIndex = 38;
			label15.Text = "Sphere";
			// 
			// label16
			// 
			label16.AutoSize = true;
			label16.Location = new Point(337, 43);
			label16.Name = "label16";
			label16.Size = new Size(43, 15);
			label16.TabIndex = 39;
			label16.Text = "Sphere";
			// 
			// label17
			// 
			label17.AutoSize = true;
			label17.Location = new Point(337, 72);
			label17.Name = "label17";
			label17.Size = new Size(43, 15);
			label17.TabIndex = 40;
			label17.Text = "Sphere";
			// 
			// label18
			// 
			label18.AutoSize = true;
			label18.Location = new Point(337, 136);
			label18.Name = "label18";
			label18.Size = new Size(43, 15);
			label18.TabIndex = 41;
			label18.Text = "Sphere";
			// 
			// label19
			// 
			label19.AutoSize = true;
			label19.Location = new Point(473, 159);
			label19.Name = "label19";
			label19.Size = new Size(51, 15);
			label19.TabIndex = 42;
			label19.Text = "Cylinder";
			// 
			// label20
			// 
			label20.AutoSize = true;
			label20.Location = new Point(473, 186);
			label20.Name = "label20";
			label20.Size = new Size(51, 15);
			label20.TabIndex = 43;
			label20.Text = "Cylinder";
			// 
			// label21
			// 
			label21.AutoSize = true;
			label21.Location = new Point(473, 215);
			label21.Name = "label21";
			label21.Size = new Size(51, 15);
			label21.TabIndex = 44;
			label21.Text = "Cylinder";
			// 
			// label22
			// 
			label22.AutoSize = true;
			label22.Location = new Point(403, 20);
			label22.Name = "label22";
			label22.Size = new Size(35, 15);
			label22.TabIndex = 45;
			label22.Text = "Cube";
			// 
			// label23
			// 
			label23.AutoSize = true;
			label23.Location = new Point(403, 43);
			label23.Name = "label23";
			label23.Size = new Size(35, 15);
			label23.TabIndex = 46;
			label23.Text = "Cube";
			// 
			// label24
			// 
			label24.AutoSize = true;
			label24.Location = new Point(403, 72);
			label24.Name = "label24";
			label24.Size = new Size(35, 15);
			label24.TabIndex = 47;
			label24.Text = "Cube";
			// 
			// label25
			// 
			label25.AutoSize = true;
			label25.Location = new Point(421, 275);
			label25.Name = "label25";
			label25.Size = new Size(35, 15);
			label25.TabIndex = 48;
			label25.Text = "Cube";
			// 
			// GenerateShapesForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(574, 476);
			Controls.Add(label25);
			Controls.Add(label24);
			Controls.Add(label23);
			Controls.Add(label22);
			Controls.Add(label21);
			Controls.Add(label20);
			Controls.Add(label19);
			Controls.Add(label18);
			Controls.Add(label17);
			Controls.Add(label16);
			Controls.Add(label15);
			Controls.Add(label14);
			Controls.Add(label13);
			Controls.Add(label12);
			Controls.Add(label11);
			Controls.Add(label10);
			Controls.Add(chBoxCylinder);
			Controls.Add(chBoxCube);
			Controls.Add(chBoxSphere);
			Controls.Add(txtGenerate);
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
			Text = "Generate shapes";
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
		private Button txtGenerate;
		private CheckBox chBoxSphere;
		private CheckBox chBoxCube;
		private CheckBox chBoxCylinder;
		private Label label10;
		private Label label11;
		private Label label12;
		private Label label13;
		private Label label14;
		private Label label15;
		private Label label16;
		private Label label17;
		private Label label18;
		private Label label19;
		private Label label20;
		private Label label21;
		private Label label22;
		private Label label23;
		private Label label24;
		private Label label25;
	}
}