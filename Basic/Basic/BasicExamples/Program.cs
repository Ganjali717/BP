using BasicExamples;

ConditionalOperators conditional = new ConditionalOperators();

Person person = new Person("Kamandar Imanov");

person.Print();

Employee employee = new Employee("Ganjali Imanov", "BP"); 

employee.Print();
Console.WriteLine(employee.Company);
class Person
{
    public string Name { get; set; }
    public Person(string name)
    {
        Name = name;
    }
    public virtual void Print()
    {
        Console.WriteLine(Name);
    }
}
class Employee : Person
{
    public string Company { get; set; }
    public Employee(string name, string company) : base(name)
    {
        Company = company;
    }
    public override void Print()
    {
        Console.WriteLine($"{Name} working in {Company}");
    }
}