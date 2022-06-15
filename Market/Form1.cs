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
    public partial class frmuser : Form
    {
        public frmuser()
        {

            InitializeComponent();

        }

        public class User
        {
            public int userId { get; set; }
            public string userName { get; set; }
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {



        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmuser_Load(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            newUser.UserName = txtUserName.Text;
            UserDAL.CreateUser(newUsert);
            dataGridviewl.DataSource = UserDAL.GetAllUser();
        }
        public class infouser
        {
            public string UserNo { get; set; }
            public string UserName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string phone { get; set; }
        }
        public infouser 
            {
            string studentName;
        DateTime dateofBirth;
        string phone;
        string UserNo;
        
    }

    
        public infouser
            (string UserNo, string UserName, DateTime dateOfBirth, string phone);
    }
}
