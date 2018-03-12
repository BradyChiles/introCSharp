using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BradyChilesUnit10
{
    //Employee Class
    class Employee
    {
        //Variables
        private String _name;
        private int _empNum;

        //Default Constructor
        public Employee()
        {
            _name = "";
            _empNum = 0;
        }

        //Get/Set Name
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        //Get/Set Employee Numnber
        public int EmpNum
        {
            get { return _empNum; }
            set { _empNum = value; }
        }
    }
}
