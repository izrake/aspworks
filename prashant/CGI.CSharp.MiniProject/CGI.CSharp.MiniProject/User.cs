using System;
using System.Collections.Generic;
using System.Collections;

namespace CGI.CSharp.MiniProject
{
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string PassWord { get; set; }

        public User(string fname, string lname, string emaildId, string pass)
        {
            FirstName = fname;
            LastName = lname;
            PassWord = pass;
            EmailId = emaildId;
        }
    }
}
