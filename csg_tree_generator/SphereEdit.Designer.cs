namespace csg_tree_generator
{
    partial class SphereEdit
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
            label1 = new Label();
            txtPosX = new TextBox();
            txtPosY = new TextBox();
            label2 = new Label();
            txtPosZ = new TextBox();
            label3 = new Label();
            txtRadius = new TextBox();
            label4 = new Label();
            colorDialog1 = new ColorDialog();
            btnSelectColor = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Position X";
            // 
            // txtPosX
            // 
            txtPosX.Location = new Point(115, 6);
            txtPosX.Name = "txtPosX";
            txtPosX.Size = new Size(100, 23);
            txtPosX.TabIndex = 1;
            // 
            // txtPosY
            // 
            txtPosY.Location = new Point(115, 35);
            txtPosY.Name = "txtPosY";
            txtPosY.Size = new Size(100, 23);
            txtPosY.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Position Y";
            // 
            // txtPosZ
            // 
            txtPosZ.Location = new Point(115, 64);
            txtPosZ.Name = "txtPosZ";
            txtPosZ.Size = new Size(100, 23);
            txtPosZ.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 4;
            label3.Text = "Position Z";
            // 
            // txtRadius
            // 
            txtRadius.Location = new Point(115, 93);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(100, 23);
            txtRadius.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 96);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 6;
            label4.Text = "Radius";
            // 
            // btnSelectColor
            // 
            btnSelectColor.Location = new Point(12, 125);
            btnSelectColor.Name = "btnSelectColor";
            btnSelectColor.Size = new Size(203, 23);
            btnSelectColor.TabIndex = 8;
            btnSelectColor.Text = "Select color";
            btnSelectColor.UseVisualStyleBackColor = true;
            btnSelectColor.Click += btnSelectColor_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Location = new Point(12, 172);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 192, 0);
            button3.Location = new Point(140, 172);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 10;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // SphereEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(236, 204);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnSelectColor);
            Controls.Add(txtRadius);
            Controls.Add(label4);
            Controls.Add(txtPosZ);
            Controls.Add(label3);
            Controls.Add(txtPosY);
            Controls.Add(label2);
            Controls.Add(txtPosX);
            Controls.Add(label1);
            Name = "SphereEdit";
            Text = "SphereEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPosX;
        private TextBox txtPosY;
        private Label label2;
        private TextBox txtPosZ;
        private Label label3;
        private TextBox txtRadius;
        private Label label4;
        private ColorDialog colorDialog1;
        private Button btnSelectColor;
        private Button button2;
        private Button button3;
    }
}