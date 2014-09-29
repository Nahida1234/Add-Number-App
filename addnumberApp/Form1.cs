using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addnumberApp
{
    public partial class AddNumberForm : Form
    {
        public AddNumberForm()
        {
            InitializeComponent();
        }
        int itemnumber;
        int i;
        private void button1_Click(object sender, EventArgs e)
        {
            itemnumber = Convert.ToInt32(itemnumberTextBox.Text);
            for (i = 0; i <= itemnumber; i++)
            {
                int j = i + itemnumber;
                itemnumber--;
                resultListBox.Text = j.ToString();

            }
        }
    }
}
