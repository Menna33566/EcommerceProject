using Autofac;
using Ecommerce.Application.Services;
using Ecommerce.PresentationV2.AutoFac;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce.PresentationV2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            RegesterForm register = new RegesterForm();
            this.Hide();
            register.Show();
        }
        string email,password;
        IUserService userservice;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //var continer = AutoFac2.Inject();
            var continer = AutoFac.AutoFac.Inject();
            email =textEmail.Text;
            password=textpassword.Text;
            userservice=continer.Resolve<IUserService>();
            userservice.changeuserActive();
            if(userservice.CheckLogin(email, password))
            {
                var type = userservice.CheckUserType(email, password);
                if (type == 1)
                {
                    this.Hide();
                    AdminDashBord adminDashBord = new AdminDashBord();
                    adminDashBord.Show();
                }
                else if (type == 2)
                {
                    this.Hide();
                    //ShowProduct customer = new ShowProduct();
                    //customer.Show();
                }
            }
            else
            {
                textEmail.Clear();
                textpassword.Clear();
                MessageBox.Show($"Invaled Email Or Pasword");
            }
        }
        public void HideregisterButton()
        {
            this.btnregister.Visible = false;
        }
    }
}
