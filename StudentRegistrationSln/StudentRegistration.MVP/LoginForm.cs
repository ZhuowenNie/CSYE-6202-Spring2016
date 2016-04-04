using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistration.MVP
{
    public partial class LoginForm : Form, ILoginForm
    {
        private Domain.User user = new Domain.User("admin", "admin");
        public LoginForm()
        {
            InitializeComponent();
        }

        

       

        private void button1_Click(object sender, EventArgs e)
        {
            if ((this.txt_user.Text.Trim() == user.UserName) && (this.txt_pass.Text.Trim() == user.PassWord))
            {
                user.resetTotal();
                IModel model = new Model();
                IView view = new StudentRegistrationForm();
                var presenter = new Presenter(model, view);
                this.Hide();
                presenter.Show();

            }
            else {

                int result = user.addTotal();
                if (result == 1)
                {
                    MessageBox.Show("Username or Password ERROR!");
                }
                else {
                    MessageBox.Show("Sorry,You have tried three times!");
                }


            }
        }
    }
}
