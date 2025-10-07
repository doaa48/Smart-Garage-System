using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GarageSystem
{
    public class SEL_SignUpsForm
    {
        DAL_SignUpForm DAL_SignUpForm_Obj= new DAL_SignUpForm();   

        public bool AddNewAccount(string UserName, string Password)
        {
            bool InsertedOrNot = false;
           int FoundOrNot= DAL_SignUpForm_Obj.Search(UserName, Password);
            
            if (FoundOrNot == -2 || FoundOrNot == -1)
            {
                DAL_SignUpForm_Obj.Insert(UserName, Password);
                InsertedOrNot = true;
            }
           
            return InsertedOrNot; 
        } 


    }
}
