using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class SEL_Trouble
    {
        
        public BLL_Trouble BLL_Trouble_obj = new BLL_Trouble();
        DAL_Trouble DAL_Trouble_obj = new DAL_Trouble();


        public DataTable SEL_SelectCategories ()
        {
            return DAL_Trouble_obj.SelectCate();
        }
        public void SEL_InsertData()
        {
            DAL_Trouble_obj.InsertVehcilRelation(DAL_Trouble_obj.Insert(BLL_Trouble_obj), BLL_Trouble_obj);
        }


    }
}
