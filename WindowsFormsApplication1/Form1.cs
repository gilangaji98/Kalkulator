using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Hitung_Click(object sender, EventArgs e)
        {
            Double nilaiA, nilaiB, hasil; 

            if (NamaComboBox.SelectedIndex == 0)
            {
                nilaiA = Double.Parse(NamaText1.Text);
                nilaiB = Double.Parse(NamaText2.Text);
                hasil = nilaiA + nilaiB;
                txtHasil.Text = hasil.ToString();
            }

            else if (NamaComboBox.SelectedIndex == 1)
            {
                nilaiA = Double.Parse(NamaText1.Text);
                nilaiB = Double.Parse(NamaText2.Text);
                hasil = nilaiA - nilaiB;
                txtHasil.Text = hasil.ToString();
            }

            else if (NamaComboBox.SelectedIndex == 2)
            {
                nilaiA = Double.Parse(NamaText1.Text);
                nilaiB = Double.Parse(NamaText2.Text);
                hasil = nilaiA * nilaiB;
                txtHasil.Text = hasil.ToString();
            }

            else if (NamaComboBox.SelectedIndex == 3)
            {
                nilaiA = Double.Parse(NamaText1.Text);
                nilaiB = Double.Parse(NamaText2.Text);
                hasil = nilaiA / nilaiB;
                txtHasil.Text = hasil.ToString();
            }
        }
    }
}
