using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BradyChilesUnit9
{
    class Car
    {
        private int _year;
        private String _make;
        private int _speed;

        public Car()
        {
            _year = 0;
            _make = "";
            _speed = 0;
        }

        public Car(int year, String make)
        {
            _year = year;
            _make = make;
            _speed = 0;
        }

        public int Year
        {
            get{return _year;}
            set{ _year = value;}
        }

        public String Make
        {
            get {return _make;}
            set{_make = value;}
        }

        public int Speed
        {
            get{return _speed;}
            set{_speed = value;}
        }

        public void Accelerate()
        {
            this._speed = _speed + 5;
        }

        public void Brake()
        {
            this._speed = _speed - 5;
        }
    }
}
