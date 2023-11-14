using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

/// <summary>
/// This class defines the datatype Name with name and gender
/// </summary>
public class Name
{
    public string name { get; set; }
    public string gender { get; set; }
}

/// <summary>
/// This class is used to generate a random employee details(FirstName, LastName, Mail, Gender, TaxTerms, Designation, Phone, DOB, Address1, Address2, City, EmploymentType, EmploymentStartDate, WorkAuthType)
/// </summary>
public class RandomEmployeeDetailsGenerator
{
    private static readonly Random random = new Random();
    public static List<Name> FirstNames { get; private set; }
    public static List<string> LastNames { get; private set; }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Mail { get; private set; }
    public string Gender { get; private set; }
    public string FullName { get; private set; }
    public string TaxTerms { get; private set; }
    public string Designation { get; private set; }
    public string Phone { get; private set; }
    public string DOB { get; private set; }
    public string Address1 { get; private set; }
    public string Address2 { get; private set; }
    public string City { get; private set; }
    public string EmploymentType { get; private set; }
    public string EmploymentStartDate { get; private set; }
    public string WorkAuthType { get; private set; }

    public RandomEmployeeDetailsGenerator()
    {
        var currentDirectory = Directory.GetCurrentDirectory();
        var filePath = Path.GetFullPath(Path.Combine(currentDirectory, "..", "..", "..", "Test Data", "RandomNameGenerator", "names.json"));

        string json = File.ReadAllText(filePath);

        // Deserialize the JSON data into a dictionary
        var data = JsonConvert.DeserializeObject<Dictionary<string, List<object>>>(json);

        // Store the first names and last names in separate lists
        var firstNamesArray = JArray.FromObject(data["FIRSTNAMES"]);
        FirstNames = firstNamesArray.ToObject<List<Name>>();

        var lastNamesArray = JArray.FromObject(data["LASTNAMES"]);
        LastNames = lastNamesArray.ToObject<List<string>>();

        // Initialize the first and last name properties
        var firstNameIndex = random.Next(FirstNames.Count);
        FirstName = FirstNames[firstNameIndex].name;
        LastName = LastNames[random.Next(LastNames.Count)];
        Gender = FirstNames[firstNameIndex].gender.ToString();
        FullName = FirstName + " " + LastName;

        // Initialize the mail property
        var f = FirstName.ToLower();
        var l = LastName.ToLower();
        var a = GetAlphabetNumber(f[0]).ToString();
        var b = GetAlphabetNumber(l[0]).ToString();

        Mail = f + l + a + b + "@mailinator.com";
        TaxTerms = GetTaxTerms();
        Designation = GetDesignation();
        Phone = GetPhone();
        DOB = GetDOB();
        Address1 = GetAddress1();
        Address2 = GetAddress2();
        City = GetCity();
        EmploymentType = GetEmploymentType();
        EmploymentStartDate = GetStartDate();
        WorkAuthType = GetWorkAuth(TaxTerms);
    }

    /// <summary>
    /// This method is used to get the alphabet number
    /// </summary>
    /// <param name="c"></param>
    /// <returns></returns>
    private static int GetAlphabetNumber(char c)
    {
        // Convert character to lowercase
        c = char.ToLower(c);
        // Get ASCII value of character and subtract 96
        int number = c - 96;
        while (number >= 10)
        {
            string numStr = number.ToString();

            int sum = 0;

            for (int i = 0; i < numStr.Length; i++)
            {
                sum += int.Parse(numStr[i].ToString());
            }
            number = sum;
        }
        return number;
    }

    private static string GetTaxTerms()
    {
        string[] taxTerms = { "W2", "C2C", "1099" };

        string randomTaxTerm = taxTerms[random.Next(taxTerms.Length)];

        return randomTaxTerm;
    }

    private static string GetDesignation()
    {
        string[] designations = { "HR Manager", "Software Engineer", "QA Analyst", "UI Developer", "UX Designer", "Project Manager", "Data Scientist",
        "Sales Representative", "Marketing Specialist", "HR Consultant", "Financial Analyst", "Product Manager", "QA Tester", "Accountant", "Legal Counsel" };

        string randomDesignation = designations[random.Next(designations.Length)];
        return randomDesignation;
    }

    private static string GetPhone()
    {
        string phoneNumber = random.Next(6, 10).ToString(); // Start with a random digit from 1 to 9

        for (int i = 0; i < 9; i++)
        {
            phoneNumber += random.Next(10); // Append a random digit (0-9)
        }

        return phoneNumber;
    }

    private static string GetDOB()
    {
        // Define a date range for DOB (e.g., 18 to 65 years old)
        DateTime minDOB = DateTime.Today.AddYears(-65);
        DateTime maxDOB = DateTime.Today.AddYears(-18);

        int range = (maxDOB - minDOB).Days;
        DateTime randomDOB = minDOB.AddDays(random.Next(range));

        // Format the DateTime as "MM/dd/yyyy"
        string formattedDOB = randomDOB.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);

        return formattedDOB;
    }

    private static string GetAddress1()
    {
        string[] streetNames = { "Main St", "Oak Ave", "Elm St", "Maple Ln", "Cedar Rd", "Pine St", "Sunset Blvd", "Springfield Dr",
        "Birch St", "Holly Ave", "Cypress Rd", "Willow Ln", "Chestnut Dr", "Rosewood Ave", "Sycamore Rd", "Meadowview Dr",
        "Riverfront Rd", "Harborview Dr", "Hillside Ave", "Lakeview Rd", "Mountain St", "Valley Ave", "Highland Rd", "Woodland Ln" };

        string randomStreet = streetNames[random.Next(streetNames.Length)];

        return randomStreet;
    }

    private static string GetAddress2()
    {
        string[] address2Options = { "Apt 101", "Suite 202", "Unit B", "Office 303", "Floor 4", "P.O. Box 123",
        "Room 301", "Studio A", "Bldg C, Unit 5", "Floor 2, Office 220", "Suite 501A",
        "Unit 3B", "Apt 401A", "Floor 5, Room 503", "Suite 1010", "Unit D3",
        "Penthouse 3", "Bldg 7, Office 301", "Floor 8, Apt 801", "Studio 5C", "Unit 12B" };

        string randomAddress2 = address2Options[random.Next(address2Options.Length)];

        return randomAddress2;
    }

    private static string GetCity()
    {
        string[] cities = { "New York", "Los Angeles", "Chicago", "Houston", "Miami", "Dallas", "San Francisco", "Boston", "Seattle", "Atlanta",
        "Philadelphia", "Denver", "Phoenix", "Austin", "San Diego", "Portland", "Nashville", "Orlando", "Raleigh", "Minneapolis", "Detroit",
        "Tampa", "Las Vegas", "Charlotte", "Indianapolis", "New Orleans", "Salt Lake City", "Cincinnati", "Kansas City", "Pittsburgh" };

        string randomCity = cities[random.Next(cities.Length)];

        return randomCity;
    }

    private static string GetEmploymentType()
    {
        string[] employmentTypes = { "Full-Time", "Part-Time", "Temporary", "Intern" };

        string randomEmploymentType = employmentTypes[random.Next(employmentTypes.Length)];

        return randomEmploymentType;
    }

    private static string GetStartDate()
    {
        DateTime minDate = DateTime.Today.AddYears(-2); // Minimum date (e.g., 2 years ago)
        DateTime maxDate = DateTime.Today.AddMonths(5); // Maximum date (today + 5 months)

        int range = (maxDate - minDate).Days;
        DateTime randomStartDate = minDate.AddDays(random.Next(range));

        // Format the DateTime as "MM/dd/yyyy"
        string formattedStartDate = randomStartDate.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);

        return formattedStartDate;
    }

    public static string GetWorkAuth(string taxTerm)
    {
        string randomWorkAuth;

        switch (taxTerm)
        {
            case "W2":
            string[] w2WorkAuthOptions = { "H-1B", "New H-1B (CAP)", "H-1B Extension", "H-1B Transfer", "H-1B Amendment",
            "New H-1B (CAP Exempt)", "H-1B Amendment + Extension", "H-1B Concurrent", "L-1 Visa", "E-3 Visa", "TN Visa",
            "Green Card", "US Citizen", "CPT", "EAD OTHERS", "OPT EAD", "STEM OPT" };
            randomWorkAuth = w2WorkAuthOptions[random.Next(w2WorkAuthOptions.Length)];
            break;

            case "C2C":
            string[] c2cWorkAuthOptions = { "H-1B", "CPT", "Green Card", "US Citizen", "EAD OTHERS", "STEM OPT", "OPT EAD" };
            randomWorkAuth = c2cWorkAuthOptions[random.Next(c2cWorkAuthOptions.Length)];
            break;

            default:
            string[] _1099WorkAuthOptions = { "EAD OTHERS", "Green Card", "US Citizen" };
            randomWorkAuth = _1099WorkAuthOptions[random.Next(_1099WorkAuthOptions.Length)];
            break;
        }

        return randomWorkAuth;
    }
}
