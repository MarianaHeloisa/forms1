using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmessage_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            string enrollment = txbEnrollment.Text;

            string message = "nome: " + name +
                             "\nMatricula: " + enrollment;

            MessageBox.Show(
                " sua mae ",
                "Atenção",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information

                );
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
