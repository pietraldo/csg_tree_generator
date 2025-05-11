namespace csg_tree_generator
{
    partial class CubeEdit
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
            txtRadius = new TextBox();
            label4 = new Label();
            txtPosZ = new TextBox();
            label3 = new Label();
            txtPosY = new TextBox();
            label2 = new Label();
            txtPosX = new TextBox();
            label1 = new Label();
            colorDialog1 = new ColorDialog();
            button3 = new Button();
            btnCancel = new Button();
            btnSelectColor = new Button();
            SuspendLayout();
            // 
            // txtRadius
            // 
            txtRadius.Location = new Point(115, 93);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(100, 23);
            txtRadius.TabIndex = 18;
            txtRadius.TextChanged += txtRadius_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 96);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 17;
            label4.Text = "Edge length";
            // 
            // txtPosZ
            // 
            txtPosZ.Location = new Point(115, 64);
            txtPosZ.Name = "txtPosZ";
            txtPosZ.Size = new Size(100, 23);
            txtPosZ.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 15;
            label3.Text = "Position Z";
            // 
            // txtPosY
            // 
            txtPosY.Location = new Point(115, 35);
            txtPosY.Name = "txtPosY";
            txtPosY.Size = new Size(100, 23);
            txtPosY.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 13;
            label2.Text = "Position Y";
            // 
            // txtPosX
            // 
            txtPosX.Location = new Point(115, 6);
            txtPosX.Name = "txtPosX";
            txtPosX.Size = new Size(100, 23);
            txtPosX.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 11;
            label1.Text = "Position X";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 192, 0);
            button3.Location = new Point(140, 172);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 21;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Yellow;
            btnCancel.Location = new Point(12, 172);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSelectColor
            // 
            btnSelectColor.Location = new Point(12, 125);
            btnSelectColor.Name = "btnSelectColor";
            btnSelectColor.Size = new Size(203, 23);
            btnSelectColor.TabIndex = 19;
            btnSelectColor.Text = "Select color";
            btnSelectColor.UseVisualStyleBackColor = true;
            btnSelectColor.Click += btnSelectColor_Click;
            // 
            // CubeEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(229, 202);
            Controls.Add(txtRadius);
            Controls.Add(label4);
            Controls.Add(txtPosZ);
            Controls.Add(label3);
            Controls.Add(txtPosY);
            Controls.Add(label2);
            Controls.Add(txtPosX);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(btnCancel);
            Controls.Add(btnSelectColor);
            Name = "CubeEdit";
            Text = "CubeEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRadius;
        private Label label4;
        private TextBox txtPosZ;
        private Label label3;
        private TextBox txtPosY;
        private Label label2;
        private TextBox txtPosX;
        private Label label1;
        private ColorDialog colorDialog1;
        private Button button3;
        private Button btnCancel;
        private Button btnSelectColor;
    }
}