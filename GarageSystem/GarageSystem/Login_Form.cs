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
    public partial class Login_Form : Form
    {
        SEL_LoginForm SEL_LoginForm_Obj = new SEL_LoginForm();

        public Login_Form()
        {
            InitializeComponent();
        }

        private void Button_Login_Click(object sender, EventArgs e)
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
                     int Var = SEL_LoginForm_Obj.SearchOnAccount(TextBox_UserName.Text, TextBox_Password.Text);
                     if (Var == -1)
                     {
                         label_ErrorReporting.ForeColor = Color.Red;
                         label_ErrorReporting.Text = "the Account is not found";
                     }
                     else if (Var == 0)
                     {
                         label_ErrorReporting.ForeColor = Color.Red;
                         label_ErrorReporting.Text = "the Password is not Correct";
                     }
                     else if (Var == 1)
                     {
                         MessageBox.Show("the Login to System is done Successfully");
                         this.Hide();
                         Home_Form home_Form = new Home_Form();  
                         home_Form.Show();
                     }
                     else if (Var == -2)
                     {
                         MessageBox.Show("the Login to System is Failed due to Account is not found  ");
                     }
                 }

             }
            
        }

        private void Label_SignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp_Form signUpForm_Obj = new SignUp_Form();
            signUpForm_Obj.Show();

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


       

       


    }
}
