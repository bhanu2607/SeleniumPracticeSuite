using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace UI_Tests
{
    public class CandidateDetails
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Designation { get; set; }
        public string PhoneNumber { get; set; }
        public string EmploymentType { get; set; }
        public string TaxTerm { get; set; }
        public string DOB { get; set; }

        public CandidateDetails(string firstName, string lastName, string designation, string email, string phoneNumber, string employmentType, string taxTerm, [Optional] string dob)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Designation = designation;
            PhoneNumber = phoneNumber;
            EmploymentType = employmentType;
            TaxTerm = taxTerm;
            DOB = dob;
        }


    }
}