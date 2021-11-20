using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfLoginService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : ILoginService
    {
        public bool IsAuthenticatedUser(string Email, string Password)
        {
            if((Email=="fneishussein@gmail.com" && Password=="123456789") || (Email == "201710884@ua.edu.lb" && Password == "12345678") || (Email == "test@gmail.com" && Password == "1234567"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
