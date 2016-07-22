using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGI.CSharp.MProject
{
    class User
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string EmailId { get; set; }
        public string MobileNo { get; set; }
        public string Pass { get; set; }

        public  User(String Fname, String LName, String EmailId, String MobileNo,String Pass)
        {
            this.FName = Fname;
            this.LName = LName;
            this.EmailId = EmailId;
            this.MobileNo = MobileNo;
            this.Pass = Pass;
        }

        public User()
        {
        }


    }
}
