using System.ComponentModel.DataAnnotations;

namespace src.Models;

public class Person
{
    public Person()
    {
        this.Name = "template";
        this.Age= 0;
        this.Activated = true;
        this.Contracts = new List<Contract>();
    }

    public Person(string Name, int Age, string Cpf)
    {
        this.Name = Name;
        this.Age = Age;
        this.Cpf = Cpf;
        this.Activated = true;
        this.Contracts = new List<Contract>();

    }
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    [RegularExpression(@"^[0-9]+$", 
            ErrorMessage = "Este campo deve ser preenchido somente com números")]
    public string Cpf { get; set; }
    public bool Activated { get; set; }
    public List<Contract> Contracts { get; set; }
}