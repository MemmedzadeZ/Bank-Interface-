using BankInheritence;

IBank bank = new Bank
{
    Name = "Kapital Bank",
    Budget = 10000000
};

Iceo ceo = new CEO
{
    Guid = Guid.NewGuid(),
    Name = "Zehra",
    Surname = "Memmedzade",
    Age = 30,
    Position = "Ceo",
    Salary = 10000
};

IWorker worker = new Worker
{
    Guid= Guid.NewGuid(),
    Name = "Alina",
    Surname = "Cosqun",
    Age = 28,
    Position = "Employee",
    Salary = 8000,
    StartTime  = DateTime.Now,
    EndTime= DateTime.Now,
    Operations = new List<IOperation>()  
    
};


IManager manager = new Manager
{
    Guid = Guid.NewGuid(),
    Name = "Ellada",
    Surname = "Ceferova",
    Age = 40,
    Position = "Manager",
    Salary = 8000
};


// Müşteri oluştur
IClient client = new Client
{
    Guid = Guid.NewGuid(),
    Name = "Elvira",
    Surname = "Babayeva",
    Age = 24,
    LiveAddress = "123 Main St",
    Salary = 6000
};


bank.CEO = ceo;
bank.Workers.Add(worker);
bank.Workers.Add(worker);
bank.Clients.Add(client);

bank.ShowAllCredit();
bank.PayCredit(client, 5000);
bank.ShowAllCredit();

decimal maas = bank.CalculateProfil();
Console.WriteLine($"Bank Karindaki meblwg{maas}");
Console.ReadLine();

