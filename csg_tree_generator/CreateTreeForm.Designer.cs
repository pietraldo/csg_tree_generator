namespace csg_tree_generator
{
	partial class CreateTreeForm
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
			rdLeft = new RadioButton();
			rdRight = new RadioButton();
			rdBalanced = new RadioButton();
			txtHeight = new NumericUpDown();
			btnGenerate = new Button();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)txtHeight).BeginInit();
			SuspendLayout();
			// 
			// rdLeft
			// 
			rdLeft.AutoSize = true;
			rdLeft.Location = new Point(12, 12);
			rdLeft.Name = "rdLeft";
			rdLeft.Size = new Size(68, 19);
			rdLeft.TabIndex = 0;
			rdLeft.Text = "Left tree";
			rdLeft.UseVisualStyleBackColor = true;
			// 
			// rdRight
			// 
			rdRight.AutoSize = true;
			rdRight.Location = new Point(12, 37);
			rdRight.Name = "rdRight";
			rdRight.Size = new Size(76, 19);
			rdRight.TabIndex = 1;
			rdRight.Text = "Right tree";
			rdRight.UseVisualStyleBackColor = true;
			// 
			// rdBalanced
			// 
			rdBalanced.AutoSize = true;
			rdBalanced.Checked = true;
			rdBalanced.Location = new Point(12, 62);
			rdBalanced.Name = "rdBalanced";
			rdBalanced.Size = new Size(96, 19);
			rdBalanced.TabIndex = 2;
			rdBalanced.TabStop = true;
			rdBalanced.Text = "Balanced tree";
			rdBalanced.UseVisualStyleBackColor = true;
			// 
			// txtHeight
			// 
			txtHeight.Location = new Point(12, 87);
			txtHeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			txtHeight.Name = "txtHeight";
			txtHeight.Size = new Size(96, 23);
			txtHeight.TabIndex = 3;
			txtHeight.Value = new decimal(new int[] { 3, 0, 0, 0 });
			// 
			// btnGenerate
			// 
			btnGenerate.Location = new Point(12, 116);
			btnGenerate.Name = "btnGenerate";
			btnGenerate.Size = new Size(75, 23);
			btnGenerate.TabIndex = 4;
			btnGenerate.Text = "Generate";
			btnGenerate.UseVisualStyleBackColor = true;
			btnGenerate.Click += btnGenerate_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(114, 89);
			label1.Name = "label1";
			label1.Size = new Size(66, 15);
			label1.TabIndex = 5;
			label1.Text = "Tree height";
			// 
			// CreateTreeForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(244, 168);
			Controls.Add(label1);
			Controls.Add(btnGenerate);
			Controls.Add(txtHeight);
			Controls.Add(rdBalanced);
			Controls.Add(rdRight);
			Controls.Add(rdLeft);
			Name = "CreateTreeForm";
			Text = "CreateTreeForm";
			((System.ComponentModel.ISupportInitialize)txtHeight).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private RadioButton rdLeft;
		private RadioButton rdRight;
		private RadioButton rdBalanced;
		private NumericUpDown txtHeight;
		private Button btnGenerate;
		private Label label1;
	}
}