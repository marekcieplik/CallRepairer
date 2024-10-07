using CallRepairer.Data;
using CallRepairer.Entities;
using CallRepairer.Repositories;
using System.Diagnostics.Tracing;

Console.WriteLine("Call Repairer App");
var repairersRepository = new SqlRepository<Repairer>(new CallRepairerDbContext());
var workplacesRepository = new SqlRepository<Workplace>(new CallRepairerDbContext());

bool CloseApp = false;
while (!CloseApp)
{
    Console.WriteLine("'1' ComposeTeam ");
    Console.WriteLine("'2' AddWorkplace");
    Console.WriteLine("'3' Print All Repairers");
    Console.WriteLine("'4' Print All Workplace");
    Console.WriteLine("'q' Close App");
    var input = Console.ReadLine();
    switch (input)
    {
        case "1":
            ComposeTeam(repairersRepository);
            break;
        case "2":
            AddWorkplace(workplacesRepository);
            break;
        case "3":
            PrintAll(repairersRepository);
            break;
        case "4":
            PrintAll(workplacesRepository);
            break;
        default:
            if (input != "q")
                Console.WriteLine("Wrong function menu input. Try again");
            else
            {
                Console.WriteLine("exit main menu");
                CloseApp = true;
            }
            break;
    }
}
Console.WriteLine("Exit App: Call Repairer");

static void PrintAll(IReadRepositories<IEntity> repository)
{
    Console.WriteLine("Print All Repository: ");
    var entities = repository.GetAll();
    if (entities == null || !entities.Any())
    {
        Console.WriteLine("No items found");
    }
    else
    {
        foreach (var entity in entities)
        {
            Console.WriteLine(entity);
        }
    }
}

static void AddWorkplace(IRepository<Workplace> repository)
{
    Console.WriteLine("Workplace Address: ");
    var address = Console.ReadLine();
    Console.WriteLine("Who is needed (Profession): ");
    var profession = SetProfession();
    repository.Add(new Workplace(address, profession));
    repository.Save();
    Console.WriteLine($"save: {address} => {profession}");
}

static string SetProfession()
{
    string input;
    Console.WriteLine("Specify the profesion:");
    Console.WriteLine("'1' Postman");
    Console.WriteLine("'2' Plumber");
    Console.WriteLine("'3' Cleaning crew");
    string profession = "";
    bool setProfession = false;
    do
    {
        input = Console.ReadLine();
        switch (input)
        {
            case "1":
                profession = "Postman";
                setProfession = true;
                break;
            case "2":
                profession = "Plumber";
                setProfession = true;
                break;
            case "3":
                profession = "Cleaning crew";
                setProfession = true;
                break;
            default:
                Console.WriteLine("Wrong input. Try again");
                break;
        }
    } while (!setProfession);

    return profession;
}

static void ComposeTeam(IRepository<Repairer> repairersRepository)
{
    Console.WriteLine("Repairer First Name: ");
    var firstrName = Console.ReadLine();
    var profession = SetProfession();
    repairersRepository.Add(new Repairer() { FirstName = firstrName, RepairerProfession = profession });
    repairersRepository.Save();
}
