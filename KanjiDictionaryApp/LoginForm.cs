using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanjiDictionaryApp
{
    public partial class LoginForm : Form
    {
        public UserPool user_pool = new UserPool();
        public string DB_str = string.Empty;

        public LoginForm()
        {
            InitializeComponent();

            // read from DB
            DB_str = File.ReadAllText(user_pool.path);
            user_pool = JsonConvert.DeserializeObject<UserPool>(DB_str);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PlaceholderDisappearance(object sender, EventArgs e)
        {
            // Enter event

            if ((TextBox)sender == txtMail)
            {
                Placeholder.enter_event_placeholder(txtMail, "example@mail.com");
            }
            else if((TextBox)sender == txtPassword)
            {
                Placeholder.enter_event_placeholder(txtPassword, "●●●●●●");
            }
        }

        private void PlaceholderApperance(object sender, EventArgs e)
        {
            // Leave event

            if (sender == txtMail)
            {
                Placeholder.leave_event_placeholder(txtMail, "example@mail.com");
            }
            else if (sender == txtPassword)
            {
                Placeholder.leave_event_placeholder(txtPassword, "●●●●●●");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User(txtMail.Text, txtPassword.Text);

            if (txtMail.Text != "example@mail.com" && txtPassword.Text != "●●●●●●")
            {
                // check user
                if (user_pool.CheckUserExistence(user))
                {
                    using (SearchForm form = new SearchForm(user, user_pool))
                    {
                        form.ShowDialog();
                    }
                    this.Close();
                }
                else { MessageBox.Show("Check your info please"); }
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            User user = new User(txtMail.Text, txtPassword.Text);

            if  (txtMail.Text != "example@mail.com" && txtPassword.Text != "●●●●●●")
            {
                // check user
                if (!user_pool.CheckUserExistence(user) && !user_pool.CheckUsedMail(user))
                {
                    user_pool.AddUser(user);

                    // save
                    DB_str = JsonConvert.SerializeObject(user_pool);
                    File.WriteAllText(user_pool.path, DB_str);

                    //message
                    MessageBox.Show("Successfully signed up. Now it's time for log in!");
                }
                else { MessageBox.Show("You have already signed up with this mail"); }
            }
            else { MessageBox.Show("Please make sure to fill all info"); }
            
            txtMail.Text = "";
            Placeholder.leave_event_placeholder(txtMail, "example@mail.com");
            txtPassword.Text = "";
            Placeholder.leave_event_placeholder(txtPassword, "●●●●●●");
        }
    }
}
