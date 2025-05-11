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
    public partial class CubeEdit : Form
    {
        public Cube cube;
        public CubeEdit(Cube cube)
        {
            InitializeComponent();

            this.cube = cube;

            txtPosX.Text = cube.PosX.ToString();
            txtPosY.Text = cube.PosY.ToString();
            txtPosZ.Text = cube.PosZ.ToString();
            txtRadius.Text = cube.EdgeLength.ToString();
            btnSelectColor.BackColor = Color.FromArgb(cube.Red, cube.Green, cube.Blue);
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
            success = float.TryParse(txtRadius.Text, out float edgeLength);
            if (!success)
            {
                MessageBox.Show("Invalid radius");
                return;
            }

            Color color = btnSelectColor.BackColor;
            cube.PosX = posX;
            cube.PosY = posY;
            cube.PosZ = posZ;
            cube.EdgeLength = edgeLength;
            cube.Red = color.R;
            cube.Green = color.G;
            cube.Blue = color.B;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRadius_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSelectColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btnSelectColor.BackColor = colorDialog1.Color;
        }
    }
}
