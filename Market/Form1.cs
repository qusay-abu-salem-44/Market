using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            
            InitializeComponent();
             
    }
        public string username = "ahmad";
        public string password = "123";
        private void btnlogin_Click(object sender, EventArgs e) 
        {
            if (txtusername.Text == username && textBox2.Text == password)
                MessageBox.Show("Hello my frind  " + username);

            else
                MessageBox.Show("incorrect usrname or password");
          
                
            

        }
    }
}
