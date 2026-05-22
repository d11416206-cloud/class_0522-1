using System;

public class IData
{
	public string GetName();

}

public interface ICard
{
    public string GetCard();
}

public interface IName : IData, ICard
{
    public string GetName();
}

public class Person : IName
{
    public string GetName()
    {
        return "Name";
    }
    public string GetCard()
    {
        return "Card";
    }
    public string GetData()
    {
        return "Data";
    }
}
public class Student : ICard
{

}
    
    
