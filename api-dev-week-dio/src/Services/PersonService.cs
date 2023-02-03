
using src.Models;
using src.Persistence;

namespace src.Services;

    public class PersonService
    {
        private readonly PersonRepository _repository;

        public PersonService(PersonRepository repository)
        {
            this._repository = repository;
        }

        public Person FindById(int id)
        {
            return _repository.FindById(id);
        }
        
        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

        public Person Add(Person person)
        {
            try 
            {
                _repository.Add(person);
            }
            catch(Exception e)
            {
                throw new InvalidOperationException("Ocorreu um erro durante o cadastro.", e);
            }
            return person;
        }

         public Person Update(int id, Person person)
        {
            var existingPerson = _repository.FindById(id);

            if(existingPerson == null)
                throw new Exception($"Cadastro não encontrado");

            existingPerson.Name = person.Name;
            existingPerson.Age = person.Age;
            existingPerson.Cpf = person.Cpf;
            existingPerson.Activated = person.Activated;
            existingPerson.Contracts = person.Contracts;

            try 
            {
                _repository.Update(existingPerson);
            }
            catch(Exception e)
            {
                throw new InvalidOperationException("Ocorreu um erro durante a atualização.", e);
            }
            return existingPerson;
        }

        public void Remove(int id)
        {
            var existingPerson = _repository.FindById(id);

            if(existingPerson == null)
                throw new Exception($"Cadastro não encontrado");

            try 
            {
                _repository.Remove(existingPerson);
            }
            catch(Exception e)
            {
                throw new InvalidOperationException("Ocorreu um erro durante a atualização.", e);
            }
        }
    }
