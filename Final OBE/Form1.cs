using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_OBE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int checker = 0;

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string albumsfilms = txtbxAF.Text;

            if (albumsfilms == "Albums")
            {
                Form5 form5 = new Form5();
                form5.ShowDialog();
                checker = 0;
            }

            else if (albumsfilms == "Films")
            {
                Form3 form3 = new Form3();
                form3.ShowDialog();
                checker = 0;


            }
            else
            {
                checker++;
                MessageBox.Show("Invalid, please choose between Albums and Films");
                if (checker == 4)
                {
                    this.Close();
                }
            }
        }
    }
}
