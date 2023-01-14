using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                lbOutput.Items.Clear();
                int BrojClanova = Convert.ToInt32(txtInput.Text);
                clsMath math = new clsMath();
                long[] rez = math.GenFibonacci(BrojClanova);

                for(int i = 0; i < BrojClanova; i++)
                {
                    lbOutput.Items.Add(rez[i]);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInput.Clear();
            }
        }
    }
}
