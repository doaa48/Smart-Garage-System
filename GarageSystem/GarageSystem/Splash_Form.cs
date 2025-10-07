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
    public partial class Splash_Form : Form
    {
        public Splash_Form()
        {
            InitializeComponent();
        }


        int Counter = 0;

        private void timer_Splash_Tick(object sender, EventArgs e)
        {

                Counter++;
                ProgressBar1.Value = Counter;

                if (Counter == 100)
                {

                    ProgressBar1.Value = 0;
                    Login_Form loginForm_Obj = new Login_Form();
                    this.Hide();
                    loginForm_Obj.Show();
                    timer_Splash.Stop();
                }
            
        }

        private void Splash_Form_Load(object sender, EventArgs e)
        {
            timer_Splash.Start();

        }

        private void Label_Exit_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}
