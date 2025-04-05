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
			btnResult = new Button();
			btnSave = new Button();
			txtEdit = new TextBox();
			btnCreateCube = new Button();
			btnCreateCylinder = new Button();
			btnCreatSphere = new Button();
			lblStatus = new Label();
			menuStrip1 = new MenuStrip();
			fileToolStripMenuItem = new ToolStripMenuItem();
			exportToolStripMenuItem = new ToolStripMenuItem();
			selectedTreeToolStripMenuItem = new ToolStripMenuItem();
			importToolStripMenuItem = new ToolStripMenuItem();
			csgProgramViewerToolStripMenuItem = new ToolStripMenuItem();
			selectToolStripMenuItem = new ToolStripMenuItem();
			panel1.SuspendLayout();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.Cyan;
			panel1.Controls.Add(btnResult);
			panel1.Controls.Add(btnSave);
			panel1.Controls.Add(txtEdit);
			panel1.Controls.Add(btnCreateCube);
			panel1.Controls.Add(btnCreateCylinder);
			panel1.Controls.Add(btnCreatSphere);
			panel1.Dock = DockStyle.Right;
			panel1.Location = new Point(600, 24);
			panel1.Name = "panel1";
			panel1.Size = new Size(200, 426);
			panel1.TabIndex = 0;
			// 
			// btnResult
			// 
			btnResult.Location = new Point(51, 182);
			btnResult.Name = "btnResult";
			btnResult.Size = new Size(75, 23);
			btnResult.TabIndex = 5;
			btnResult.Text = "See Result";
			btnResult.UseVisualStyleBackColor = true;
			btnResult.Click += btnResult_Click;
			// 
			// btnSave
			// 
			btnSave.Location = new Point(51, 55);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(75, 23);
			btnSave.TabIndex = 4;
			btnSave.Text = "Save";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// txtEdit
			// 
			txtEdit.Location = new Point(3, 26);
			txtEdit.Name = "txtEdit";
			txtEdit.Size = new Size(194, 23);
			txtEdit.TabIndex = 3;
			// 
			// btnCreateCube
			// 
			btnCreateCube.Location = new Point(35, 153);
			btnCreateCube.Name = "btnCreateCube";
			btnCreateCube.Size = new Size(103, 23);
			btnCreateCube.TabIndex = 2;
			btnCreateCube.Text = "Create Cube";
			btnCreateCube.UseVisualStyleBackColor = true;
			btnCreateCube.Click += btnCreateCube_Click;
			// 
			// btnCreateCylinder
			// 
			btnCreateCylinder.Location = new Point(35, 124);
			btnCreateCylinder.Name = "btnCreateCylinder";
			btnCreateCylinder.Size = new Size(103, 23);
			btnCreateCylinder.TabIndex = 1;
			btnCreateCylinder.Text = "Create Cylinder";
			btnCreateCylinder.UseVisualStyleBackColor = true;
			btnCreateCylinder.Click += btnCreateCylinder_Click;
			// 
			// btnCreatSphere
			// 
			btnCreatSphere.Location = new Point(35, 95);
			btnCreatSphere.Name = "btnCreatSphere";
			btnCreatSphere.Size = new Size(103, 23);
			btnCreatSphere.TabIndex = 0;
			btnCreatSphere.Text = "Create Sphere";
			btnCreatSphere.UseVisualStyleBackColor = true;
			btnCreatSphere.Click += btnCreatSphere_Click;
			// 
			// lblStatus
			// 
			lblStatus.AutoSize = true;
			lblStatus.Location = new Point(0, 24);
			lblStatus.Name = "lblStatus";
			lblStatus.Size = new Size(38, 15);
			lblStatus.TabIndex = 1;
			lblStatus.Text = "label1";
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, csgProgramViewerToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(800, 24);
			menuStrip1.TabIndex = 2;
			menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportToolStripMenuItem, importToolStripMenuItem });
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new Size(37, 20);
			fileToolStripMenuItem.Text = "File";
			// 
			// exportToolStripMenuItem
			// 
			exportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { selectedTreeToolStripMenuItem });
			exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			exportToolStripMenuItem.Size = new Size(180, 22);
			exportToolStripMenuItem.Text = "Export";
			// 
			// selectedTreeToolStripMenuItem
			// 
			selectedTreeToolStripMenuItem.Name = "selectedTreeToolStripMenuItem";
			selectedTreeToolStripMenuItem.Size = new Size(141, 22);
			selectedTreeToolStripMenuItem.Text = "Selected tree";
			selectedTreeToolStripMenuItem.Click += selectedTreeToolStripMenuItem_Click;
			// 
			// importToolStripMenuItem
			// 
			importToolStripMenuItem.Name = "importToolStripMenuItem";
			importToolStripMenuItem.Size = new Size(180, 22);
			importToolStripMenuItem.Text = "Import";
			// 
			// csgProgramViewerToolStripMenuItem
			// 
			csgProgramViewerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { selectToolStripMenuItem });
			csgProgramViewerToolStripMenuItem.Name = "csgProgramViewerToolStripMenuItem";
			csgProgramViewerToolStripMenuItem.Size = new Size(125, 20);
			csgProgramViewerToolStripMenuItem.Text = "Csg program viewer";
			// 
			// selectToolStripMenuItem
			// 
			selectToolStripMenuItem.Name = "selectToolStripMenuItem";
			selectToolStripMenuItem.Size = new Size(180, 22);
			selectToolStripMenuItem.Text = "Select";
			selectToolStripMenuItem.Click += selectToolStripMenuItem_Click;
			// 
			// mainWindow
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(lblStatus);
			Controls.Add(panel1);
			Controls.Add(menuStrip1);
			KeyPreview = true;
			MainMenuStrip = menuStrip1;
			Name = "mainWindow";
			Text = "Form1";
			FormClosed += mainWindow_FormClosed;
			Paint += mainWindow_Paint;
			KeyPress += mainWindow_KeyPress;
			MouseDown += mainWindow_MouseDown;
			MouseMove += mainWindow_MouseMove;
			MouseUp += mainWindow_MouseUp;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Label lblStatus;
		private Button btnCreateCube;
		private Button btnCreateCylinder;
		private Button btnCreatSphere;
		private TextBox txtEdit;
		private Button btnSave;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem exportToolStripMenuItem;
		private ToolStripMenuItem importToolStripMenuItem;
		private ToolStripMenuItem selectedTreeToolStripMenuItem;
		private Button btnResult;
		private ToolStripMenuItem csgProgramViewerToolStripMenuItem;
		private ToolStripMenuItem selectToolStripMenuItem;
	}
}
