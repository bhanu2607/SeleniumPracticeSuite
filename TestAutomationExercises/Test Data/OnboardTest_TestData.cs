using System.Security.Cryptography.X509Certificates;

namespace UI_Tests
{
    public class OnboardTest_TestData
    {
        public static string FirstName = "Bhn";
        public static string LastName = "Krishna";
        public static string Email = "bhankri@gmail.com";
        public static string PhoneNumber = "9014433233";
        public static string Dateofbirth = "26/07/2000";
        public static string Des = "Intern";
        public static string emtype = "Full-Time";
        public static string taxterm ="C2C";
        public static string start_Date = "09/03/2022";
        public static string emailid = "bhanukrishna@gmail.com";
       

       
        //similar params

        public static EmployeeDetail employeeDetail = new EmployeeDetail( fn:FirstName,  ln:LastName,    mail_id:Email,  pn:PhoneNumber , Dob:Dateofbirth,Designation:Des, employ_type:emtype , tax_term: taxterm , start_date:start_Date );
       
    }
}
