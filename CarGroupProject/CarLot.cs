using System;

public class CarLot : Cars
{
    public List<Cars> CarLotList { get; set; }
        
    public CarLot()

        public void removeCarLotList(Cars x)
    {
        carLotList.Remove(x);
    }


    public void AddCarLotList(Cars x)
    {
        CarLotList.add(x)
            }
    public void PrintCarLotList()
    {
        foreach (Cars x in CarLotList)
        {
            Console.WriteLine(x);
        }
    }
}



