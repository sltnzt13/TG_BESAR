using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TugasBesar.Model;

namespace TugasBesar
{
    public partial class Form1 : Form
    {
        Koneksi koneksi = new Koneksi();
        M_Pemain m_Pemain = new M_Pemain();
        M_Umur m_Umur = new M_Umur();
        M_Posisi m_Posisi = new M_Posisi();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    } 
}
