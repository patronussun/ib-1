using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IB_1
{
    public class User
    {
        [XmlElement("Login")]
        public string Login
        {
            get;
            set;
        }
        [XmlElement("Password")]
        public string Password
        {
            get;
            set;
        }
        [XmlElement("isAdmin")]
        public bool isAdmin
        {
            get;
            set;
        }
        [XmlElement("isBlocked")]
        public bool isBlocked
        {
            get;
            set;
        }
        [XmlElement("isPasswordRestricted")]
        public bool isPasswordRestricted
        {
            get;
            set;
        }
    }
}
