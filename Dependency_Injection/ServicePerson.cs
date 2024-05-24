namespace Dependency_Injection
{
    public class ServicePerson:IPerson
    {
        List<Person> persons = new List<Person>() { new Person { ID = 1, Name = "saurabh" }, new Person { ID = 2, Name = "sda" } };
       

        public Person getById(int id)
        {
            return persons.Where(x=>x.ID==id).FirstOrDefault();
        }
    }
}
