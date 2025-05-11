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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btnCreateTree = new Button();
            chBoxCameraUse = new CheckBox();
            txtGenerateShapes = new Button();
            btnResult = new Button();
            btnSave = new Button();
            txtEdit = new TextBox();
            btnCreateCube = new Button();
            btnCreateCylinder = new Button();
            btnCreatSphere = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            selectedTreeToolStripMenuItem = new ToolStripMenuItem();
            importToolStripMenuItem = new ToolStripMenuItem();
            csgProgramViewerToolStripMenuItem = new ToolStripMenuItem();
            selectToolStripMenuItem = new ToolStripMenuItem();
            ctxNodeMenu = new ContextMenuStrip(components);
            detachTreeToolStripMenuItem = new ToolStripMenuItem();
            adjustTreeToolStripMenuItem = new ToolStripMenuItem();
            makeIntersectionToolStripMenuItem = new ToolStripMenuItem();
            makeDifferenceToolStripMenuItem = new ToolStripMenuItem();
            makeUnionToolStripMenuItem = new ToolStripMenuItem();
            editShapeToolStripMenuItem = new ToolStripMenuItem();
            deleteTreeToolStripMenuItem = new ToolStripMenuItem();
            copyTreeToolStripMenuItem = new ToolStripMenuItem();
            hideUnHideTreeToolStripMenuItem = new ToolStripMenuItem();
            ctxSceneMenu = new ContextMenuStrip(components);
            createNodeToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ctxNodeMenu.SuspendLayout();
            ctxSceneMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cyan;
            panel1.Controls.Add(btnCreateTree);
            panel1.Controls.Add(chBoxCameraUse);
            panel1.Controls.Add(txtGenerateShapes);
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
            // btnCreateTree
            // 
            btnCreateTree.Location = new Point(35, 211);
            btnCreateTree.Name = "btnCreateTree";
            btnCreateTree.Size = new Size(103, 23);
            btnCreateTree.TabIndex = 8;
            btnCreateTree.Text = "Create tree";
            btnCreateTree.UseVisualStyleBackColor = true;
            btnCreateTree.Click += btnCreateTree_Click;
            // 
            // chBoxCameraUse
            // 
            chBoxCameraUse.AutoSize = true;
            chBoxCameraUse.Location = new Point(28, 399);
            chBoxCameraUse.Name = "chBoxCameraUse";
            chBoxCameraUse.Size = new Size(127, 19);
            chBoxCameraUse.TabIndex = 7;
            chBoxCameraUse.Text = "Use default camera";
            chBoxCameraUse.UseVisualStyleBackColor = true;
            chBoxCameraUse.CheckedChanged += chBoxCameraUse_CheckedChanged;
            // 
            // txtGenerateShapes
            // 
            txtGenerateShapes.Location = new Point(35, 182);
            txtGenerateShapes.Name = "txtGenerateShapes";
            txtGenerateShapes.Size = new Size(103, 23);
            txtGenerateShapes.TabIndex = 6;
            txtGenerateShapes.Text = "Generate shapes";
            txtGenerateShapes.UseVisualStyleBackColor = true;
            txtGenerateShapes.Click += txtGenerateShapes_Click;
            // 
            // btnResult
            // 
            btnResult.Location = new Point(35, 370);
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
            exportToolStripMenuItem.Size = new Size(110, 22);
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
            importToolStripMenuItem.Size = new Size(110, 22);
            importToolStripMenuItem.Text = "Import";
            importToolStripMenuItem.Click += importToolStripMenuItem_Click;
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
            selectToolStripMenuItem.Size = new Size(105, 22);
            selectToolStripMenuItem.Text = "Select";
            selectToolStripMenuItem.Click += selectToolStripMenuItem_Click;
            // 
            // ctxNodeMenu
            // 
            ctxNodeMenu.Items.AddRange(new ToolStripItem[] { detachTreeToolStripMenuItem, adjustTreeToolStripMenuItem, makeIntersectionToolStripMenuItem, makeDifferenceToolStripMenuItem, makeUnionToolStripMenuItem, editShapeToolStripMenuItem, deleteTreeToolStripMenuItem, copyTreeToolStripMenuItem, hideUnHideTreeToolStripMenuItem });
            ctxNodeMenu.Name = "ctxNodeMenu";
            ctxNodeMenu.Size = new Size(169, 202);
            // 
            // detachTreeToolStripMenuItem
            // 
            detachTreeToolStripMenuItem.Name = "detachTreeToolStripMenuItem";
            detachTreeToolStripMenuItem.Size = new Size(168, 22);
            detachTreeToolStripMenuItem.Text = "Detach tree";
            detachTreeToolStripMenuItem.Click += detachTreeToolStripMenuItem_Click;
            // 
            // adjustTreeToolStripMenuItem
            // 
            adjustTreeToolStripMenuItem.Name = "adjustTreeToolStripMenuItem";
            adjustTreeToolStripMenuItem.Size = new Size(168, 22);
            adjustTreeToolStripMenuItem.Text = "Adjust tree";
            adjustTreeToolStripMenuItem.Click += adjustTreeToolStripMenuItem_Click;
            // 
            // makeIntersectionToolStripMenuItem
            // 
            makeIntersectionToolStripMenuItem.Name = "makeIntersectionToolStripMenuItem";
            makeIntersectionToolStripMenuItem.Size = new Size(168, 22);
            makeIntersectionToolStripMenuItem.Text = "Make intersection";
            makeIntersectionToolStripMenuItem.Click += makeIntersectionToolStripMenuItem_Click;
            // 
            // makeDifferenceToolStripMenuItem
            // 
            makeDifferenceToolStripMenuItem.Name = "makeDifferenceToolStripMenuItem";
            makeDifferenceToolStripMenuItem.Size = new Size(168, 22);
            makeDifferenceToolStripMenuItem.Text = "Make difference";
            makeDifferenceToolStripMenuItem.Click += makeDifferenceToolStripMenuItem_Click;
            // 
            // makeUnionToolStripMenuItem
            // 
            makeUnionToolStripMenuItem.Name = "makeUnionToolStripMenuItem";
            makeUnionToolStripMenuItem.Size = new Size(168, 22);
            makeUnionToolStripMenuItem.Text = "Make union";
            makeUnionToolStripMenuItem.Click += makeUnionToolStripMenuItem_Click;
            // 
            // editShapeToolStripMenuItem
            // 
            editShapeToolStripMenuItem.Enabled = false;
            editShapeToolStripMenuItem.Name = "editShapeToolStripMenuItem";
            editShapeToolStripMenuItem.Size = new Size(168, 22);
            editShapeToolStripMenuItem.Text = "Edit shape";
            editShapeToolStripMenuItem.Click += editShapeToolStripMenuItem_Click;
            // 
            // deleteTreeToolStripMenuItem
            // 
            deleteTreeToolStripMenuItem.Name = "deleteTreeToolStripMenuItem";
            deleteTreeToolStripMenuItem.Size = new Size(168, 22);
            deleteTreeToolStripMenuItem.Text = "Delete tree";
            deleteTreeToolStripMenuItem.Click += deleteTreeToolStripMenuItem_Click;
            // 
            // copyTreeToolStripMenuItem
            // 
            copyTreeToolStripMenuItem.Name = "copyTreeToolStripMenuItem";
            copyTreeToolStripMenuItem.Size = new Size(168, 22);
            copyTreeToolStripMenuItem.Text = "Copy tree";
            copyTreeToolStripMenuItem.Click += copyTreeToolStripMenuItem_Click;
            // 
            // hideUnHideTreeToolStripMenuItem
            // 
            hideUnHideTreeToolStripMenuItem.Name = "hideUnHideTreeToolStripMenuItem";
            hideUnHideTreeToolStripMenuItem.Size = new Size(168, 22);
            hideUnHideTreeToolStripMenuItem.Text = "Hide/UnHide tree";
            hideUnHideTreeToolStripMenuItem.Click += hideUnHideTreeToolStripMenuItem_Click;
            // 
            // ctxSceneMenu
            // 
            ctxSceneMenu.Items.AddRange(new ToolStripItem[] { createNodeToolStripMenuItem });
            ctxSceneMenu.Name = "ctxSceneMenu";
            ctxSceneMenu.Size = new Size(139, 26);
            // 
            // createNodeToolStripMenuItem
            // 
            createNodeToolStripMenuItem.Name = "createNodeToolStripMenuItem";
            createNodeToolStripMenuItem.Size = new Size(138, 22);
            createNodeToolStripMenuItem.Text = "Create node";
            createNodeToolStripMenuItem.Click += createNodeToolStripMenuItem_Click;
            // 
            // mainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            ctxNodeMenu.ResumeLayout(false);
            ctxSceneMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
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
		private Button txtGenerateShapes;
		private CheckBox chBoxCameraUse;
		private Button btnCreateTree;
        private ContextMenuStrip ctxNodeMenu;
        private ToolStripMenuItem detachTreeToolStripMenuItem;
        private ToolStripMenuItem adjustTreeToolStripMenuItem;
        private ToolStripMenuItem makeIntersectionToolStripMenuItem;
        private ToolStripMenuItem makeDifferenceToolStripMenuItem;
        private ToolStripMenuItem makeUnionToolStripMenuItem;
        private ToolStripMenuItem editShapeToolStripMenuItem;
        private ToolStripMenuItem deleteTreeToolStripMenuItem;
        private ToolStripMenuItem copyTreeToolStripMenuItem;
        private ToolStripMenuItem hideUnHideTreeToolStripMenuItem;
        private ContextMenuStrip ctxSceneMenu;
        private ToolStripMenuItem createNodeToolStripMenuItem;
    }
}
