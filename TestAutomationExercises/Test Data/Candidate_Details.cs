using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Tests
{
    public class Candidate_Details

    {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Designation { get; set; }
    public string PhoneNumber { get; set; }  
    public string EmploymentType { get; set; } 
    public string TaxTerm { get; set; } 
    public string DOB {get ; set;}
  
  	public Candidate_Details(string firstName,string lastName,string designation,  string email, string phoneNumber , string employmentType , string taxTerm , string dob = "" )
    {
        FirstName = firstName;
        LastName = lastName ;
        Email = email;
        Designation = designation;
        PhoneNumber = phoneNumber;
        EmploymentType = employmentType ;
        TaxTerm = taxTerm ;
        DOB = dob;
    }
    }
}
