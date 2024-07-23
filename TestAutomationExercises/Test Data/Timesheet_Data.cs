using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Tests.Common_Modules;

namespace UI_Tests.Test_Data
{
    public class Timesheet_Data
    {
        public static string Emp_name = "Bhn";
        public static string Date_from = "23/07/2024";
        public static string Date_to = "23/07/2024";
        public static string Enter_hrs = "23/07/2024";

        public static Timesheet_Detail timesheet_Detail = new Timesheet_Detail(emp_name:Emp_name,date_from:Date_from, date_to:Date_to, enter_hrs:Enter_hrs);
    }
}
