using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_pos
{
    internal class Global
    {
        public static string Id;
        public static string Name;
        public static string EmpLavel;

        public static string ProSell;
        public static decimal ProSell2;



        public static string SellPrdId;
        public static string SellPrdName;
        public static float SellPrdPrice;
        public static string SellPrdCatID;

        public static int SellPrdQty;
        public static string SellPrdLev;
        public static float SellPrdPriceTotal;


        public static DataTable dtprd = new DataTable();

        public static float SellPriceTotal;






    }
}
