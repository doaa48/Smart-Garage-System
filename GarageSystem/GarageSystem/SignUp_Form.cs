using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarageSystem
{
    public partial class SignUp_Form : Form
    {
        SEL_SignUpsForm SEL_SignUpForm_Obj= new SEL_SignUpsForm();
        public SignUp_Form()
        {
            InitializeComponent();
        }


        private void TextBox_UserName_TextChanged(object sender, EventArgs e)
        {
            TextBox_UserName.BorderColor = Color.CornflowerBlue;
            label_ErrorReporting.Text = "";
        }

        private void TextBox_Password_TextChanged(object sender, EventArgs e)
        {
            TextBox_Password.BorderColor = Color.CornflowerBlue;
            label_ErrorReporting.Text = "";
        }

        private void Label_Exit_MouseHover(object sender, EventArgs e)
        {
            Label_Exit.ForeColor = Color.LightGray;

        }

        private void Label_Exit_MouseLeave(object sender, EventArgs e)
        {
            Label_Exit.ForeColor = Color.Black;

        }

        private void Label_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_SignUp_Click(object sender, EventArgs e)
        {
            if (TextBox_UserName.Text == "" && TextBox_Password.Text == "")
            {
                label_ErrorReporting.ForeColor = Color.Red;
                TextBox_UserName.BorderColor = Color.Red;
                TextBox_Password.BorderColor = Color.Red;
                label_ErrorReporting.Text = "Please Enter Account Information";
            }
            else
            {
                if (TextBox_Password.Text == "")
                {
                    label_ErrorReporting.ForeColor = Color.Red;
                    label_ErrorReporting.Text = "Please Enter the Password";
                    TextBox_Password.BorderColor = Color.Red;

                }
                else if (TextBox_UserName.Text == "")
                {
                    label_ErrorReporting.ForeColor = Color.Red;
                    label_ErrorReporting.Text = "Please Enter the Email";
                    TextBox_UserName.BorderColor = Color.Red;
                }
                else
                {
                    if (SEL_SignUpForm_Obj.AddNewAccount(TextBox_UserName.Text, TextBox_Password.Text))
                    {
                        MessageBox.Show("The SignUp id done successfully");
                        this.Hide();
                        Home_Form home_Form = new Home_Form();
                        home_Form.Show();
                    }
                    else
                    {
                        label_ErrorReporting.ForeColor = Color.Red;
                        TextBox_UserName.BorderColor = Color.Red;
                        label_ErrorReporting.Text = "This Email / UserName is already Exist";
                    }
                }

            }



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();
            this.Hide();
            login_Form.Show();
        }
    }
}
