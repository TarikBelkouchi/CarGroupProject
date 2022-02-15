using System;
namespace CarGroupProject
{
	public class Cars
	{
		string Make { get; set; }
		string Model { get; set; }
		int Year { get; set; }
		decimal Price { get; set; }

		public Cars()
		{

		}


		public Cars(string _make, string _model, int _year, decimal _price)
		{
			Make = _make;
			Model = _model;
			Year = _year;
			Price = _price;

		}
		public override string ToString()
		{
			return $"{Make} {Model} {Year} {Price}";
		}


	}
 
}

