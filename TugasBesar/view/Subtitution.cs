using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasBesar
{
    public partial class Subsitution : Form
    {
         
        public Subsitution()
        {
            InitializeComponent();
            this.Size = new Size (1064, 654);
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {

        }

        private void dataPemainMenuItem_Click(object sender, EventArgs e)
        {
            Form1 FormMhs = new Form1();
            FormMhs.MdiParent = this;
            FormMhs.Show();
        }
    }
}
