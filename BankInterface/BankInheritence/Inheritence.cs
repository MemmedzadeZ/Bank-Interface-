namespace BankInheritence;

public interface Iceo
{
    Guid Guid { get; set; }
    string Name { get; set; }
    string Surname { get; set; }
    int Age { get; set; }
    string Position { get; set; }
    decimal Salary { get; set; }

    void Constrol();
    void Organize();
    void MakeMeeting();
    void DecreasePercentage(decimal percent);
}
public interface IOperation
{
    Guid Guid { get; }
    string ProcessName { get; }
    DateTime DateTime { get; }
}


public interface IWorker
{
    Guid Guid { get; }
    string Name { get; }
    string Surname { get; }
    int Age { get; }
    string Position { get; }
    decimal Salary { get; }
    DateTime StartTime { get; }
    DateTime EndTime { get; }
    List<IOperation> Operations { get; }
    void AddOperation(IOperation operation);

}

public interface IManager
{
    Guid Guid { get; set; }
    string Name { get; set; }
    string Surname { get; set; }    
    int Age { get; set; }
    string Position { get; set; }
    decimal Salary { get; set; }
    void Oeganize();
    void CalculateSalaries();
}

public interface IClient
{
    Guid Guid { get; set; }
    string Name { get; set; }
    string Surname { get; set; }
    int Age { get; set; }
    string LiveAddress { get; set; }
    decimal Salary { get; set; }
}
public interface ICredit
{
    Guid Guid { get; }
    IClient Client { get; }
    decimal Amount { get; }
    decimal Percent { get; }
    int Months { get; }
    decimal CalculatePercent();
    void Payment(decimal money);
}



public interface IBank
{
    string Name { get; set; }
    decimal Budget { get; set; }
    decimal CalculateProfil();
    Iceo CEO { get; set; }  
    List<IWorker> Workers { get; set; }
    List<IManager> Managers { get; set; }
    List<IClient> Clients { get; set; }

    IClient ShowClientCredit(string fullName);
    void PayCredit(IClient client, decimal monay);
    void ShowAllCredit();
}


public class Bank:IBank
{
    public string Name { get; set; }
    public decimal Budget { get; set;}
    public Iceo CEO { get; set; }
    public List<IWorker> Workers { get; set; }
    public List<IManager> managers { get; set; }
    public List <IClient> Clients { get; set; }
    public List<IManager> Managers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

   
    public IClient ShowClientCredit(string fullName)
    {
        Console.WriteLine($"Show ClientCredit{fullName}");
        return null;

    }
    
    public decimal CalculateProfil()
    {
        Console.WriteLine("CalculateProfil");
        return 0;
    }

    public void PayCredit(IClient client, decimal monay)
    {
        Console.WriteLine("PayCredit");
    }

    public void ShowAllCredit()
    {
        Console.WriteLine("ShowAllCredit");
    }
}

public class CEO : Iceo
{
    public Guid Guid { get ; set ; }
    public string Name { get ; set ; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public string Position { get    ; set   ; }
    public decimal Salary { get; set; }

    public void Constrol()
    {
        Console.WriteLine("Constrol");
    }

    public void DecreasePercentage(decimal percent)
    {
       Console.WriteLine($"DecreasePercentage{percent}")
    }

    public void MakeMeeting()
    {
        Console.WriteLine("MakeMeeting");
    }

    public void Organize()
    {
        Console.WriteLine("Organize");   
    }
}


public class Worker : IWorker
{
    public Guid Guid { get ; set ; }
    public string Name { get ; set ; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public string Position { get; set; }
    public decimal Salary { get; set;}
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public List<IOperation> Operations { get; set; }

    public void AddOperation(IOperation operation)
    {
        Console.WriteLine("AddOperation");
    }


}

public class Manager : IManager
{
    public Guid Guid { get; set; }
    public string Name { get ; set; }
    public string Surname { get; set ; }
    public int Age { get; set; }
    public string Position { get ; set; }
    public decimal Salary { get; set ; }

    public void CalculateSalaries()
    {
        Console.WriteLine("CalculateSalaries");
    }

    public void Oeganize()
    {
        Console.WriteLine("Oeganize");
    }
}

public class Operation : IOperation
{
    public Guid Guid { get; set; }
    public string ProcessName { get; set; }
    public DateTime DateTime { get; set; }
}

public class Credit:ICredit
{
    public Guid Guid { get; set; }
    public IClient Client { get; set; }
    public decimal Amount { get; set; }
    public decimal Percent { get; set; }
    public int Months { get; set; }

    public decimal CalculatePercent()
    {
        Console.WriteLine("Calculate Percent");
        return 0;
    }

    public void Payment(decimal money)
    {
        Console.WriteLine("Payment");
    }
        


}

public class Client : IClient
{
    public Guid Guid { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }

    public int Age { get; set; }
    public string LiveAddress { get; set; }
    public decimal Salary { get; set; }

}


