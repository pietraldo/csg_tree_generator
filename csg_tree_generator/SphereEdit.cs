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
    public partial class SphereEdit : Form
    {
        public Sphere sphere;
        public SphereEdit(Sphere sphere)
        {
            InitializeComponent();

            this.sphere = sphere;

            txtPosX.Text = sphere.PosX.ToString();
            txtPosY.Text = sphere.PosY.ToString();
            txtPosZ.Text = sphere.PosZ.ToString();
            txtRadius.Text = sphere.Radius.ToString();
            btnSelectColor.BackColor = Color.FromArgb(sphere.Red, sphere.Green, sphere.Blue);
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

            Color color = btnSelectColor.BackColor;
            sphere.PosX = posX;
            sphere.PosY = posY;
            sphere.PosZ = posZ;
            sphere.Radius = radius;
            sphere.Red = color.R;
            sphere.Green = color.G;
            sphere.Blue = color.B;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSelectColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btnSelectColor.BackColor = colorDialog1.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
