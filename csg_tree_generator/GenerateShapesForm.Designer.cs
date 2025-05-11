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
            chBoxReplace = new CheckBox();
            txtGenerate = new Button();
            chBoxSphere = new CheckBox();
            chBoxCube = new CheckBox();
            chBoxCylinder = new CheckBox();
            txtMaxWidthMaxCu = new NumericUpDown();
            label10 = new Label();
            txtMinWidthCu = new NumericUpDown();
            txtMaxZCu = new NumericUpDown();
            txtMaxYCu = new NumericUpDown();
            txtMaxXCu = new NumericUpDown();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            txtMinZCu = new NumericUpDown();
            txtMinYCu = new NumericUpDown();
            txtMinXCu = new NumericUpDown();
            btnSelectColorCu = new Button();
            txtMaxWiCy = new NumericUpDown();
            label19 = new Label();
            txtMinWiCy = new NumericUpDown();
            txtMaxHCy = new NumericUpDown();
            label20 = new Label();
            txtMinHCy = new NumericUpDown();
            txtMaxRotZ = new NumericUpDown();
            label21 = new Label();
            txtMinRotZ = new NumericUpDown();
            txtMaxRotY = new NumericUpDown();
            label22 = new Label();
            txtMinRotY = new NumericUpDown();
            txtMaxRotX = new NumericUpDown();
            label23 = new Label();
            txtMinRotX = new NumericUpDown();
            txtMaxZCy = new NumericUpDown();
            txtMaxYCy = new NumericUpDown();
            txtMaxXCy = new NumericUpDown();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            txtMinZCy = new NumericUpDown();
            txtMinYCy = new NumericUpDown();
            txtMinXCy = new NumericUpDown();
            btnSelectColorCy = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            txtChanceSphere = new NumericUpDown();
            txtChanceCube = new NumericUpDown();
            txtChanceCylinder = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)txtXMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtYMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtZMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtRadiusMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtRadiusMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtZMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtYMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtXMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMaxWidthMaxCu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMinWidthCu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMaxZCu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMaxYCu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMaxXCu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMinZCu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMinYCu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMinXCu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMaxWiCy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMinWiCy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMaxHCy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMinHCy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMaxRotZ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMinRotZ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMaxRotY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMinRotY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMaxRotX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMinRotX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMaxZCy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMaxYCy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMaxXCy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMinZCy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMinYCy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMinXCy).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtChanceSphere).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtChanceCube).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtChanceCylinder).BeginInit();
            SuspendLayout();
            // 
            // btnSelectColor
            // 
            btnSelectColor.Location = new Point(63, 122);
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
            txtXMin.Location = new Point(63, 35);
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
            txtYMin.Location = new Point(63, 64);
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
            txtZMin.Location = new Point(63, 93);
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
            txtRadiusMin.Location = new Point(63, 151);
            txtRadiusMin.Name = "txtRadiusMin";
            txtRadiusMin.Size = new Size(120, 23);
            txtRadiusMin.TabIndex = 7;
            txtRadiusMin.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            txtRadiusMin.Enter += NumericUpDown_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 37);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 6;
            label1.Text = "X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 72);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 7;
            label2.Text = "Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 95);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 8;
            label3.Text = "Z";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 153);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 9;
            label4.Text = "Radius";
            // 
            // txtRadiusMax
            // 
            txtRadiusMax.DecimalPlaces = 2;
            txtRadiusMax.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            txtRadiusMax.Location = new Point(189, 151);
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
            txtZMax.Location = new Point(189, 93);
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
            txtYMax.Location = new Point(189, 64);
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
            txtXMax.Location = new Point(189, 35);
            txtXMax.Name = "txtXMax";
            txtXMax.Size = new Size(120, 23);
            txtXMax.TabIndex = 2;
            txtXMax.Value = new decimal(new int[] { 2, 0, 0, 0 });
            txtXMax.Enter += NumericUpDown_Enter;
            // 
            // chBoxReplace
            // 
            chBoxReplace.AutoSize = true;
            chBoxReplace.Location = new Point(39, 391);
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
            chBoxSphere.Location = new Point(143, 290);
            chBoxSphere.Name = "chBoxSphere";
            chBoxSphere.Size = new Size(62, 19);
            chBoxSphere.TabIndex = 30;
            chBoxSphere.Text = "Sphere";
            chBoxSphere.UseVisualStyleBackColor = true;
            // 
            // chBoxCube
            // 
            chBoxCube.AutoSize = true;
            chBoxCube.Location = new Point(543, 290);
            chBoxCube.Name = "chBoxCube";
            chBoxCube.Size = new Size(54, 19);
            chBoxCube.TabIndex = 31;
            chBoxCube.Text = "Cube";
            chBoxCube.UseVisualStyleBackColor = true;
            // 
            // chBoxCylinder
            // 
            chBoxCylinder.AutoSize = true;
            chBoxCylinder.Location = new Point(972, 326);
            chBoxCylinder.Name = "chBoxCylinder";
            chBoxCylinder.Size = new Size(70, 19);
            chBoxCylinder.TabIndex = 32;
            chBoxCylinder.Text = "Cylinder";
            chBoxCylinder.UseVisualStyleBackColor = true;
            // 
            // txtMaxWidthMaxCu
            // 
            txtMaxWidthMaxCu.DecimalPlaces = 2;
            txtMaxWidthMaxCu.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            txtMaxWidthMaxCu.Location = new Point(190, 141);
            txtMaxWidthMaxCu.Name = "txtMaxWidthMaxCu";
            txtMaxWidthMaxCu.Size = new Size(120, 23);
            txtMaxWidthMaxCu.TabIndex = 55;
            txtMaxWidthMaxCu.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 143);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 60;
            label10.Text = "Width";
            // 
            // txtMinWidthCu
            // 
            txtMinWidthCu.DecimalPlaces = 2;
            txtMinWidthCu.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            txtMinWidthCu.Location = new Point(64, 141);
            txtMinWidthCu.Name = "txtMinWidthCu";
            txtMinWidthCu.Size = new Size(120, 23);
            txtMinWidthCu.TabIndex = 54;
            // 
            // txtMaxZCu
            // 
            txtMaxZCu.DecimalPlaces = 2;
            txtMaxZCu.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            txtMaxZCu.Location = new Point(190, 83);
            txtMaxZCu.Name = "txtMaxZCu";
            txtMaxZCu.Size = new Size(120, 23);
            txtMaxZCu.TabIndex = 39;
            txtMaxZCu.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // txtMaxYCu
            // 
            txtMaxYCu.DecimalPlaces = 2;
            txtMaxYCu.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            txtMaxYCu.Location = new Point(190, 54);
            txtMaxYCu.Name = "txtMaxYCu";
            txtMaxYCu.Size = new Size(120, 23);
            txtMaxYCu.TabIndex = 36;
            txtMaxYCu.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // txtMaxXCu
            // 
            txtMaxXCu.DecimalPlaces = 2;
            txtMaxXCu.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            txtMaxXCu.Location = new Point(190, 25);
            txtMaxXCu.Name = "txtMaxXCu";
            txtMaxXCu.Size = new Size(120, 23);
            txtMaxXCu.TabIndex = 34;
            txtMaxXCu.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(18, 85);
            label16.Name = "label16";
            label16.Size = new Size(14, 15);
            label16.TabIndex = 42;
            label16.Text = "Z";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(18, 62);
            label17.Name = "label17";
            label17.Size = new Size(14, 15);
            label17.TabIndex = 40;
            label17.Text = "Y";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(18, 27);
            label18.Name = "label18";
            label18.Size = new Size(14, 15);
            label18.TabIndex = 38;
            label18.Text = "X";
            // 
            // txtMinZCu
            // 
            txtMinZCu.DecimalPlaces = 2;
            txtMinZCu.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            txtMinZCu.Location = new Point(64, 83);
            txtMinZCu.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            txtMinZCu.Name = "txtMinZCu";
            txtMinZCu.Size = new Size(120, 23);
            txtMinZCu.TabIndex = 37;
            // 
            // txtMinYCu
            // 
            txtMinYCu.DecimalPlaces = 2;
            txtMinYCu.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            txtMinYCu.Location = new Point(64, 54);
            txtMinYCu.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            txtMinYCu.Name = "txtMinYCu";
            txtMinYCu.Size = new Size(120, 23);
            txtMinYCu.TabIndex = 35;
            // 
            // txtMinXCu
            // 
            txtMinXCu.DecimalPlaces = 2;
            txtMinXCu.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            txtMinXCu.Location = new Point(64, 25);
            txtMinXCu.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            txtMinXCu.Name = "txtMinXCu";
            txtMinXCu.Size = new Size(120, 23);
            txtMinXCu.TabIndex = 33;
            // 
            // btnSelectColorCu
            // 
            btnSelectColorCu.Location = new Point(64, 112);
            btnSelectColorCu.Name = "btnSelectColorCu";
            btnSelectColorCu.Size = new Size(120, 23);
            btnSelectColorCu.TabIndex = 58;
            btnSelectColorCu.Text = "Select Color";
            btnSelectColorCu.UseVisualStyleBackColor = true;
            // 
            // txtMaxWiCy
            // 
            txtMaxWiCy.DecimalPlaces = 2;
            txtMaxWiCy.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            txtMaxWiCy.Location = new Point(194, 255);
            txtMaxWiCy.Name = "txtMaxWiCy";
            txtMaxWiCy.Size = new Size(120, 23);
            txtMaxWiCy.TabIndex = 83;
            txtMaxWiCy.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(22, 257);
            label19.Name = "label19";
            label19.Size = new Size(39, 15);
            label19.TabIndex = 88;
            label19.Text = "Width";
            // 
            // txtMinWiCy
            // 
            txtMinWiCy.DecimalPlaces = 2;
            txtMinWiCy.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            txtMinWiCy.Location = new Point(68, 255);
            txtMinWiCy.Name = "txtMinWiCy";
            txtMinWiCy.Size = new Size(120, 23);
            txtMinWiCy.TabIndex = 82;
            // 
            // txtMaxHCy
            // 
            txtMaxHCy.DecimalPlaces = 2;
            txtMaxHCy.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            txtMaxHCy.Location = new Point(194, 226);
            txtMaxHCy.Name = "txtMaxHCy";
            txtMaxHCy.Size = new Size(120, 23);
            txtMaxHCy.TabIndex = 81;
            txtMaxHCy.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(22, 228);
            label20.Name = "label20";
            label20.Size = new Size(43, 15);
            label20.TabIndex = 87;
            label20.Text = "Height";
            // 
            // txtMinHCy
            // 
            txtMinHCy.DecimalPlaces = 2;
            txtMinHCy.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            txtMinHCy.Location = new Point(68, 226);
            txtMinHCy.Name = "txtMinHCy";
            txtMinHCy.Size = new Size(120, 23);
            txtMinHCy.TabIndex = 79;
            // 
            // txtMaxRotZ
            // 
            txtMaxRotZ.DecimalPlaces = 2;
            txtMaxRotZ.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            txtMaxRotZ.Location = new Point(194, 197);
            txtMaxRotZ.Name = "txtMaxRotZ";
            txtMaxRotZ.Size = new Size(120, 23);
            txtMaxRotZ.TabIndex = 78;
            txtMaxRotZ.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(2, 199);
            label21.Name = "label21";
            label21.Size = new Size(62, 15);
            label21.TabIndex = 85;
            label21.Text = "Rotation Z";
            // 
            // txtMinRotZ
            // 
            txtMinRotZ.DecimalPlaces = 2;
            txtMinRotZ.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            txtMinRotZ.Location = new Point(68, 197);
            txtMinRotZ.Name = "txtMinRotZ";
            txtMinRotZ.Size = new Size(120, 23);
            txtMinRotZ.TabIndex = 77;
            // 
            // txtMaxRotY
            // 
            txtMaxRotY.DecimalPlaces = 2;
            txtMaxRotY.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            txtMaxRotY.Location = new Point(194, 168);
            txtMaxRotY.Name = "txtMaxRotY";
            txtMaxRotY.Size = new Size(120, 23);
            txtMaxRotY.TabIndex = 76;
            txtMaxRotY.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(0, 172);
            label22.Name = "label22";
            label22.Size = new Size(62, 15);
            label22.TabIndex = 84;
            label22.Text = "Rotation Y";
            // 
            // txtMinRotY
            // 
            txtMinRotY.DecimalPlaces = 2;
            txtMinRotY.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            txtMinRotY.Location = new Point(68, 168);
            txtMinRotY.Name = "txtMinRotY";
            txtMinRotY.Size = new Size(120, 23);
            txtMinRotY.TabIndex = 75;
            // 
            // txtMaxRotX
            // 
            txtMaxRotX.DecimalPlaces = 2;
            txtMaxRotX.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            txtMaxRotX.Location = new Point(194, 139);
            txtMaxRotX.Name = "txtMaxRotX";
            txtMaxRotX.Size = new Size(120, 23);
            txtMaxRotX.TabIndex = 74;
            txtMaxRotX.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(2, 141);
            label23.Name = "label23";
            label23.Size = new Size(62, 15);
            label23.TabIndex = 80;
            label23.Text = "Rotation X";
            // 
            // txtMinRotX
            // 
            txtMinRotX.DecimalPlaces = 2;
            txtMinRotX.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            txtMinRotX.Location = new Point(68, 139);
            txtMinRotX.Name = "txtMinRotX";
            txtMinRotX.Size = new Size(120, 23);
            txtMinRotX.TabIndex = 72;
            // 
            // txtMaxZCy
            // 
            txtMaxZCy.DecimalPlaces = 2;
            txtMaxZCy.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            txtMaxZCy.Location = new Point(194, 81);
            txtMaxZCy.Name = "txtMaxZCy";
            txtMaxZCy.Size = new Size(120, 23);
            txtMaxZCy.TabIndex = 67;
            txtMaxZCy.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // txtMaxYCy
            // 
            txtMaxYCy.DecimalPlaces = 2;
            txtMaxYCy.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            txtMaxYCy.Location = new Point(194, 52);
            txtMaxYCy.Name = "txtMaxYCy";
            txtMaxYCy.Size = new Size(120, 23);
            txtMaxYCy.TabIndex = 64;
            txtMaxYCy.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // txtMaxXCy
            // 
            txtMaxXCy.DecimalPlaces = 2;
            txtMaxXCy.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            txtMaxXCy.Location = new Point(194, 23);
            txtMaxXCy.Name = "txtMaxXCy";
            txtMaxXCy.Size = new Size(120, 23);
            txtMaxXCy.TabIndex = 62;
            txtMaxXCy.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(22, 83);
            label25.Name = "label25";
            label25.Size = new Size(14, 15);
            label25.TabIndex = 70;
            label25.Text = "Z";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(22, 60);
            label26.Name = "label26";
            label26.Size = new Size(14, 15);
            label26.TabIndex = 68;
            label26.Text = "Y";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(22, 25);
            label27.Name = "label27";
            label27.Size = new Size(14, 15);
            label27.TabIndex = 66;
            label27.Text = "X";
            // 
            // txtMinZCy
            // 
            txtMinZCy.DecimalPlaces = 2;
            txtMinZCy.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            txtMinZCy.Location = new Point(68, 81);
            txtMinZCy.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            txtMinZCy.Name = "txtMinZCy";
            txtMinZCy.Size = new Size(120, 23);
            txtMinZCy.TabIndex = 65;
            // 
            // txtMinYCy
            // 
            txtMinYCy.DecimalPlaces = 2;
            txtMinYCy.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            txtMinYCy.Location = new Point(68, 52);
            txtMinYCy.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            txtMinYCy.Name = "txtMinYCy";
            txtMinYCy.Size = new Size(120, 23);
            txtMinYCy.TabIndex = 63;
            // 
            // txtMinXCy
            // 
            txtMinXCy.DecimalPlaces = 2;
            txtMinXCy.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            txtMinXCy.Location = new Point(68, 23);
            txtMinXCy.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            txtMinXCy.Name = "txtMinXCy";
            txtMinXCy.Size = new Size(120, 23);
            txtMinXCy.TabIndex = 61;
            // 
            // btnSelectColorCy
            // 
            btnSelectColorCy.Location = new Point(68, 110);
            btnSelectColorCy.Name = "btnSelectColorCy";
            btnSelectColorCy.Size = new Size(120, 23);
            btnSelectColorCy.TabIndex = 86;
            btnSelectColorCy.Text = "Select Color";
            btnSelectColorCy.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label27);
            groupBox1.Controls.Add(txtMaxWiCy);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(btnSelectColorCy);
            groupBox1.Controls.Add(txtMinWiCy);
            groupBox1.Controls.Add(txtMinXCy);
            groupBox1.Controls.Add(txtMaxHCy);
            groupBox1.Controls.Add(txtMinYCy);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(txtMinZCy);
            groupBox1.Controls.Add(txtMinHCy);
            groupBox1.Controls.Add(label26);
            groupBox1.Controls.Add(txtMaxRotZ);
            groupBox1.Controls.Add(label25);
            groupBox1.Controls.Add(label21);
            groupBox1.Controls.Add(txtMaxXCy);
            groupBox1.Controls.Add(txtMinRotZ);
            groupBox1.Controls.Add(txtMaxYCy);
            groupBox1.Controls.Add(txtMaxRotY);
            groupBox1.Controls.Add(txtMaxZCy);
            groupBox1.Controls.Add(label22);
            groupBox1.Controls.Add(txtMinRotX);
            groupBox1.Controls.Add(txtMinRotY);
            groupBox1.Controls.Add(label23);
            groupBox1.Controls.Add(txtMaxRotX);
            groupBox1.Location = new Point(802, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(376, 308);
            groupBox1.TabIndex = 89;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(btnSelectColorCu);
            groupBox2.Controls.Add(txtMaxWidthMaxCu);
            groupBox2.Controls.Add(txtMinXCu);
            groupBox2.Controls.Add(txtMinYCu);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtMinZCu);
            groupBox2.Controls.Add(txtMinWidthCu);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(txtMaxZCu);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(txtMaxYCu);
            groupBox2.Controls.Add(txtMaxXCu);
            groupBox2.Location = new Point(372, 14);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(396, 270);
            groupBox2.TabIndex = 90;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(btnSelectColor);
            groupBox3.Controls.Add(txtXMin);
            groupBox3.Controls.Add(txtYMin);
            groupBox3.Controls.Add(txtZMin);
            groupBox3.Controls.Add(txtRadiusMin);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtRadiusMax);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(txtZMax);
            groupBox3.Controls.Add(txtXMax);
            groupBox3.Controls.Add(txtYMax);
            groupBox3.Location = new Point(22, 14);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(344, 270);
            groupBox3.TabIndex = 91;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // txtChanceSphere
            // 
            txtChanceSphere.Location = new Point(135, 323);
            txtChanceSphere.Name = "txtChanceSphere";
            txtChanceSphere.Size = new Size(120, 23);
            txtChanceSphere.TabIndex = 92;
            // 
            // txtChanceCube
            // 
            txtChanceCube.Location = new Point(549, 326);
            txtChanceCube.Name = "txtChanceCube";
            txtChanceCube.Size = new Size(120, 23);
            txtChanceCube.TabIndex = 93;
            // 
            // txtChanceCylinder
            // 
            txtChanceCylinder.Location = new Point(1001, 365);
            txtChanceCylinder.Name = "txtChanceCylinder";
            txtChanceCylinder.Size = new Size(120, 23);
            txtChanceCylinder.TabIndex = 94;
            // 
            // GenerateShapesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 539);
            Controls.Add(txtChanceCylinder);
            Controls.Add(txtChanceCube);
            Controls.Add(txtChanceSphere);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(chBoxCylinder);
            Controls.Add(chBoxCube);
            Controls.Add(chBoxSphere);
            Controls.Add(txtGenerate);
            Controls.Add(chBoxReplace);
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
            ((System.ComponentModel.ISupportInitialize)txtMaxWidthMaxCu).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMinWidthCu).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMaxZCu).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMaxYCu).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMaxXCu).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMinZCu).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMinYCu).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMinXCu).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMaxWiCy).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMinWiCy).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMaxHCy).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMinHCy).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMaxRotZ).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMinRotZ).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMaxRotY).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMinRotY).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMaxRotX).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMinRotX).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMaxZCy).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMaxYCy).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMaxXCy).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMinZCy).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMinYCy).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMinXCy).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtChanceSphere).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtChanceCube).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtChanceCylinder).EndInit();
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
		private CheckBox chBoxReplace;
		private Button txtGenerate;
		private CheckBox chBoxSphere;
		private CheckBox chBoxCube;
		private CheckBox chBoxCylinder;
        private NumericUpDown txtMaxWidthMaxCu;
        private Label label10;
        private NumericUpDown txtMinWidthCu;
        private NumericUpDown txtMaxZCu;
        private NumericUpDown txtMaxYCu;
        private NumericUpDown txtMaxXCu;
        private Label label16;
        private Label label17;
        private Label label18;
        private NumericUpDown txtMinZCu;
        private NumericUpDown txtMinYCu;
        private NumericUpDown txtMinXCu;
        private Button btnSelectColorCu;
        private NumericUpDown txtMaxWiCy;
        private Label label19;
        private NumericUpDown txtMinWiCy;
        private NumericUpDown txtMaxHCy;
        private Label label20;
        private NumericUpDown txtMinHCy;
        private NumericUpDown txtMaxRotZ;
        private Label label21;
        private NumericUpDown txtMinRotZ;
        private NumericUpDown txtMaxRotY;
        private Label label22;
        private NumericUpDown txtMinRotY;
        private NumericUpDown txtMaxRotX;
        private Label label23;
        private NumericUpDown txtMinRotX;
        private NumericUpDown txtMaxZCy;
        private NumericUpDown txtMaxYCy;
        private NumericUpDown txtMaxXCy;
        private Label label25;
        private Label label26;
        private Label label27;
        private NumericUpDown txtMinZCy;
        private NumericUpDown txtMinYCy;
        private NumericUpDown txtMinXCy;
        private Button btnSelectColorCy;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private NumericUpDown txtChanceSphere;
        private NumericUpDown txtChanceCube;
        private NumericUpDown txtChanceCylinder;
    }
}