class Program
{
public static void ProcessPerson(Person person)
    {

        Console.Write(person.GetPersonInformation());
        Console.WriteLine($", My Salary is {person.GetSalary()}");
        if (person is Police police)
        {
        //    Console.WriteLine(police.GetPoliceInformation());
        }
        else if (person is Doctor doctor)
        {
        //    Console.WriteLine(doctor.GetDoctorInformation());
        }
        else
        {
        //    Console.WriteLine(person.GetPersonInformation());
        }
    }

    public static void Main(string[] args)
    {
        //Person person = new Person("Bob", "Ross", 55, 195);
        //Console.WriteLine(person.GetPersonInformation());

        Doctor doctor = new Doctor("Ax", "Bob", "Budge", 75, 210);
        //Console.WriteLine(doctor.GetDoctorInformation());

        Police police = new Police("Gun", "Lance", "Bob", 43 , 198);
        //Console.WriteLine(police.GetPoliceInformation());

        police.SetWeight(police.GetWeight()+ 5);
        police.SetAge(police.GetAge() + 1);
        //Console.WriteLine(police.GetPoliceInformation());

        List<Person> myPeople = new List<Person>();
        //myPeople.Add(person);
        myPeople.Add(doctor);
        myPeople.Add(police);

        foreach(Person tempPerson in myPeople)
        {
            ProcessPerson(tempPerson);
        }
    }
}