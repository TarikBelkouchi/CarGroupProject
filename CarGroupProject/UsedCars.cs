using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGroupProject
{
    internal class UsedCars : Cars
    {
        public double Mileage { get; set; }

        public UsedCars(string _make, string _model, int _year, decimal _price, double _mileage):base(_make, _model, _year, _price)
        {
            Mileage = _mileage;

        }

        public override string ToString()
        {
            return base.ToString() + $" Used Mileage: {Mileage}";

        }
    }
}
