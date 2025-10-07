using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageSystem
{
    public class SEL_LoginForm
    {
        DAL_LoginForm DAL_LoginForm_Obj= new DAL_LoginForm();   

        public int SearchOnAccount(string UserName, string Password)
        {
           int FoundOrNot= DAL_LoginForm_Obj.Search(UserName, Password);
            return FoundOrNot; 
        } 
    }
}
