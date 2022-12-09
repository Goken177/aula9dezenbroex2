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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botao1_Click(object sender, EventArgs e)
        {
            mensagemfinal.Text = "o nome digitado foi: " + input.Text;
        }

        private void botao2_Click(object sender, EventArgs e)
        {
            mensagemfinal.Text = "o nome digitado e diferente: " + input.Text;
        }
    }
}
