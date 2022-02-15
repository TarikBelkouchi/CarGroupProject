using System;
using CarGroupProject;

public class CarLot
{
    public List<Cars> CarLotList { get; set; }
        
    public CarLot()
    {
        CarLotList = new List<Cars>();
    }
    public void RemoveCarLotList(Cars x)
    {
        CarLotList.Remove(x);
    }



    public void AddCarLotList(Cars x)
    {
        CarLotList.Add(x);
    }
    public void PrintCarLotList()
    {
        foreach (Cars x in CarLotList)
        {
            Console.WriteLine(x);
        }
    }
}



