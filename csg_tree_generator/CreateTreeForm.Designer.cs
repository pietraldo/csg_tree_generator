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
            txtHeight = new NumericUpDown();
            btnGenerate = new Button();
            label1 = new Label();
            trLeft = new TrackBar();
            label2 = new Label();
            label3 = new Label();
            trRight = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)txtHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trRight).BeginInit();
            SuspendLayout();
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(9, 102);
            txtHeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(120, 23);
            txtHeight.TabIndex = 3;
            txtHeight.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(9, 131);
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
            label1.Location = new Point(135, 104);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 5;
            label1.Text = "Tree height";
            // 
            // trLeft
            // 
            trLeft.Location = new Point(56, 12);
            trLeft.Maximum = 100;
            trLeft.Name = "trLeft";
            trLeft.Size = new Size(165, 45);
            trLeft.TabIndex = 10;
            trLeft.Value = 100;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 21);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 11;
            label2.Text = "Left";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 51);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 12;
            label3.Text = "Right";
            // 
            // trRight
            // 
            trRight.Location = new Point(56, 51);
            trRight.Maximum = 100;
            trRight.Name = "trRight";
            trRight.Size = new Size(165, 45);
            trRight.TabIndex = 13;
            trRight.Value = 100;
            // 
            // CreateTreeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 212);
            Controls.Add(trRight);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(trLeft);
            Controls.Add(label1);
            Controls.Add(btnGenerate);
            Controls.Add(txtHeight);
            Name = "CreateTreeForm";
            Text = "CreateTreeForm";
            ((System.ComponentModel.ISupportInitialize)txtHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)trLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)trRight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown txtHeight;
		private Button btnGenerate;
		private Label label1;
        private TrackBar trLeft;
        private Label label2;
        private Label label3;
        private TrackBar trRight;
    }
}