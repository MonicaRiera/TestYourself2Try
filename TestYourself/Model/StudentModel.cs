using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestYourself.Model
{
    class StudentModel
    {
        private string _firstName;
        private string _lastName;
        private int _cpr;
        private string _education;

        public String FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public String LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public int Cpr
        {
            get { return _cpr; }
            set { _cpr = value; }
        }

        public String Education
        {
            get { return _education; }
            set { _education = value; }
        }

        public override string ToString()
        {
            return FirstName.ToString();
        }

    }
}
