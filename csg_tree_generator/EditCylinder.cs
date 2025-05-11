using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csg_tree_generator
{
    public partial class EditCylinder : Form
    {
        public Cylinder cylinder;
        public EditCylinder(Cylinder cylinder)
        {
            InitializeComponent();

            this.cylinder = cylinder;
            txtPosX.Text = cylinder.PosX.ToString();
            txtPosY.Text = cylinder.PosY.ToString();
            txtPosZ.Text = cylinder.PosZ.ToString();
            txtRadius.Text = cylinder.Radius.ToString();
            txtHeight.Text = cylinder.Height.ToString();
            btnSelectColor.BackColor = Color.FromArgb(cylinder.Red, cylinder.Green, cylinder.Blue);
            txtRotatioinX.Text = cylinder.RotationX.ToString();
            txtRotationY.Text = cylinder.RotationY.ToString();
            txtRotationZ.Text = cylinder.RotationZ.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool success;
            success = float.TryParse(txtPosX.Text, out float posX);
            if (!success)
            {
                MessageBox.Show("Invalid position X");
                return;
            }
            success = float.TryParse(txtPosY.Text, out float posY);
            if (!success)
            {
                MessageBox.Show("Invalid position Y");
                return;
            }
            success = float.TryParse(txtPosZ.Text, out float posZ);
            if (!success)
            {
                MessageBox.Show("Invalid position Z");
                return;
            }
            success = float.TryParse(txtRadius.Text, out float radius);
            if (!success)
            {
                MessageBox.Show("Invalid radius");
                return;
            }
            success = float.TryParse(txtHeight.Text, out float height);
            if (!success)
            {
                MessageBox.Show("Invalid height");
                return;
            }
            success = float.TryParse(txtRotatioinX.Text, out float rotationX);
            if (!success)
            {
                MessageBox.Show("Invalid rotation X");
                return;
            }
            success = float.TryParse(txtRotationY.Text, out float rotationY);
            if (!success)
            {
                MessageBox.Show("Invalid rotation Y");
                return;
            }
            success = float.TryParse(txtRotationZ.Text, out float rotationZ);
            if (!success)
            {
                MessageBox.Show("Invalid rotation Z");
                return;
            }
            Color color = btnSelectColor.BackColor;
            cylinder.PosX = posX;
            cylinder.PosY = posY;
            cylinder.PosZ = posZ;
            cylinder.Radius = radius;
            cylinder.Height = height;
            cylinder.Red = color.R;
            cylinder.Green = color.G;
            cylinder.Blue = color.B;
            cylinder.RotationX = rotationX;
            cylinder.RotationY = rotationY;
            cylinder.RotationZ = rotationZ;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btnSelectColor.BackColor = colorDialog1.Color;
        }
    }
}
