namespace csg_tree_generator
{
	partial class mainWindow
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
			panel1 = new Panel();
			lblStatus = new Label();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.Cyan;
			panel1.Dock = DockStyle.Right;
			panel1.Location = new Point(600, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(200, 450);
			panel1.TabIndex = 0;
			// 
			// lblStatus
			// 
			lblStatus.AutoSize = true;
			lblStatus.Location = new Point(2, 9);
			lblStatus.Name = "lblStatus";
			lblStatus.Size = new Size(38, 15);
			lblStatus.TabIndex = 1;
			lblStatus.Text = "label1";
			// 
			// mainWindow
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(lblStatus);
			Controls.Add(panel1);
			Name = "mainWindow";
			Text = "Form1";
			Paint += mainWindow_Paint;
			KeyPress += mainWindow_KeyPress;
			MouseDown += mainWindow_MouseDown;
			MouseMove += mainWindow_MouseMove;
			MouseUp += mainWindow_MouseUp;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Label lblStatus;
	}
}
