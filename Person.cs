using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;


//designa  personal phone and address book using Dictionary collection. 
//write a person class to store details such as
//first name, last name, mobile phone, work phone, and address
//provide a grid to display all, add more, and delete with confirmation
//and search by name

namespace Assignment_4._1
{

    //define class and variables
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobilePhone { get; set; }
        public string WorkPhone {  get; set; }
        public string Address { get; set; }

        private string fullName;
        public string FullName
        {
            get
            {
                return LastName + FirstName;
            }
        }

        //constructor
        //public Person(string firstName, string lastName, string mobilePhone, string workPhone, string address)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //    MobilePhone = mobilePhone;
        //    WorkPhone = workPhone;
        //    Address = address;
        //}

        //output
        //public override string ToString()
        //{
        //    return $"Name: {FirstName} {LastName}";
        //    return $"Mobile: {MobilePhone}";
        //    return $"Work Phone: {WorkPhone}";
        //    return $"Address: {Address}";
        //}

        //public override string ToString()
        //{
        //    return $"{FirstName} {LastName}";
        //}
    }
}
