using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloSourceControl {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            tbxHelloWorld.Text = "Hello World";
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void cbxHelloThere_CheckedChanged(object sender, EventArgs e) {
            if(cbxHelloThere.Checked == true) {
                tbxHelloWorld.Text = "Hello There";
            }
            else {
                tbxHelloWorld.Text = "Goodbye";
            }
        }
    }
}
