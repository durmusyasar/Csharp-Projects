using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hospital_Management_and_Appointment_System_Automation
{
    class ConnectionClass
    {
        public string Adress = System.IO.File.ReadAllText(@"D:\C#_Projects\Test.txt");
    }
}
