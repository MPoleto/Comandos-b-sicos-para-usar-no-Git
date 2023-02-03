using src.Models;

namespace src.Persistence;

    public class DbInitializer
    {  
        public static void Initializer(DatabaseContext context)
        {
            if (context.People.Any())
            {
                return;
            }

            var firstContract = new Contract 
                { 
                    CreationDate = DateTime.Now.AddMonths(-17), 
                    TokenId = "753649", 
                    Value = 785.36, 
                    Payment = true 
                };
            var secondContract = new Contract 
                { 
                    CreationDate = DateTime.Now.AddDays(-28), 
                    TokenId = "987465", 
                    Value = 1653, 
                    Payment = false 
                };
            var thirdContract = new Contract 
                { 
                    CreationDate = DateTime.Now.AddYears(-22), 
                    TokenId = "450093", 
                    Value = 8704.58, 
                    Payment = true 
                };
            var fourthContract = new Contract 
                { 
                    CreationDate = DateTime.Now.AddDays(-35), 
                    TokenId = "856056", 
                    Value = 125.09, 
                    Payment = false 
                };
            
            var people = new Person[]
            {
                new Person
                {
                    Name = "João da Silva",
                    Age = 54,
                    Cpf = "87981798197",
                    Activated = true,
                    Contracts = new List<Contract>
                        {
                            firstContract, 
                            fourthContract
                        }
                },
                new Person
                {
                    Name = "Caroline Oliveira",
                    Age = 33,
                    Cpf = "12321653574",
                    Activated = true,
                    Contracts = new List<Contract>
                        {
                            secondContract
                        }
                },
                new Person
                {
                    Name = "Pedro Cardoso",
                    Age = 90,
                    Cpf = "21354652351",
                    Activated = false,
                    Contracts = new List<Contract>
                        {
                           thirdContract
                        }
                }
            };

            context.People.AddRange(people);
            context.SaveChanges();
        }

    }
