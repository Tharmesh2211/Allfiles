using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    public class SchoolStudent
    {
        public SchoolStudent() { }
        public string SchoolName { get; set; } = "Bell Matriculation School";
        public int StudentID { get; set; } = 100;
        public string StudentName { get; set;}
        public DateTime DOB { get; set; }
        public string Gender {  get; set; }
        public int Standard {  get; set; }
        public long PhoneNumber {  get; set; }
        public string Address {  get; set; }
        public string City { get; set; }    

    }
}
