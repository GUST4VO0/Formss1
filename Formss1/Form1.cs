using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formss1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmessage_Click(object sender, EventArgs e)
        {
            string name = txtnome.Text;
            string enrollment = txtprontuario.Text;

            string message = "nome: " + name + "prontuario: " + enrollment;

            MessageBox.Show("funciona", "Atenção",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
