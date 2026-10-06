using Library;

class Program
{
    static void Main(string[] args)
    {
        // Create a new instance (object) of the Book class
        // Note how the object name differs from the class name
        Book book = new Book("C# for beginners", "Bill Gates", "1234567");
        Book book1 = new Book("Ultimate C#", "Microsoft", "2233445");
        book.DisplayInfo();
        book1.DisplayInfo();

        // Create new instance of member class
        //These new members are created using the constructor of the Member class
        Member member = new Member(1, "John Doe", "123 Main St", "0790090090");
        Member member1 = new Member(2, "Jane Smith", "456 Oak Ave", "0791291291");
        member.DisplayInfo();
        member1.DisplayInfo();

        // Testing validation logic with invalid data
        Member invalidMember = new Member(3, "", "789 Pine Rd", "0791291291");
    }
}
