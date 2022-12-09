using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace excer9dezenbro8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            labelfrase.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelfrase.Visible = true;
            labelfrase.Text = "hoje é dia 9";
            
                
        }

        private void botaomes_Click(object sender, EventArgs e)
        {
            labelfrase.Visible = true;
            labelfrase.Text = "o mês atual é dezenbro";

        }

        private void botaoano_Click(object sender, EventArgs e)
        {
            labelfrase.Visible = true;
            labelfrase.Text = "estamos no ano de 2022";

        }
    }
}
