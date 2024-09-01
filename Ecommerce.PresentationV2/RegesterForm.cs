using Autofac;
using Ecommerce.Application.Services;
using Ecommerce.Inftastructure;
using Ecommerce.PresentationV2.AutoFac;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce.PresentationV2
{
    public partial class RegesterForm : Form
    {
        public RegesterForm()
        {
            InitializeComponent();
            //this.FormClosed += (sender, e) =>
        }
        string name, email, address, password;
        int type = 2;bool activ=false;
        string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

        private void btnSignup_Click(object sender, EventArgs e)
        {
            //var continer = AutoFac2.Inject();
            var continer = AutoFac.AutoFac.Inject();
            name = textName.Text;
            email=textEmail.Text;
            address=textAddress.Text;
            password=textPassword.Text;
            IUserService user = continer.Resolve<IUserService>();
            var x=user.GetAllUsers().ToList();
            bool check = true;
            if (!Regex.IsMatch(email, emailPattern)||password.Length<6)
            {
                MessageBox.Show("Invaled Email or Password");
                textName.Clear(); textEmail.Clear(); textAddress.Clear();
                textPassword.Clear();
                check = false;
            }
            foreach (var item in x)
            {
                if (item.Email == email && item.Password == password)
                {
                    MessageBox.Show("email or password is alerdy exist");
                    textName.Clear(); textEmail.Clear(); textAddress.Clear();
                    textPassword.Clear();
                    check = false;
                    break;
                }
                
            }
            if (check)
            {
                user.AddUser(new DTOs.User.UserDto()
                {
                    UserName = name,
                    Email = email,
                    Address = address,
                    Password = password,
                    IsActive = activ,
                    UserTypeId = type
                });
                user.savechanges();
                this.Hide();
                LoginForm login=new LoginForm();
                login.HideregisterButton();
                login.Show();
                //wait for login form from mouhamed
                //LoginForm logn = new LoginForm();
                //logn.Show();
            }
        }
    }
}
