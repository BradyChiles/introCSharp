using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BradyChilesUnit10
{
    //Production worker class, inherits Employee
    class ProductionWorker : Employee
    {
        //Variables
        private int _shift;
        private decimal _rate;

        //Default Constructor
        public ProductionWorker()
        {
            _shift = 0;
            _rate = 0m;
        }

        //Get/Set Shift
        public int Shift
        {
            get { return _shift; }
            set { _shift = value; }
        }
        //Get/Set Rate
        public decimal Rate
        {
            get { return _rate; }
            set { _rate = value; }
        }
    }
}
