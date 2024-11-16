using lab3_factory_method;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to our fitness club!");
        Console.WriteLine("Select the type of membership you want to create");
        Console.WriteLine("S - standart");
        Console.WriteLine("P - standart with pool");
        Console.WriteLine("F - family");


        string membershipType = Console.ReadLine();
        MembershipFactory factory = GetFactory(membershipType);
        MembershipInterface membership = factory.GetMembership();
        Console.WriteLine("\tCreated membership:");
        Console.WriteLine(
            $"Name:\t\t\t{membership.Name}\n" +
            $"Description:\t\t{membership.Description}\n" +
            $"Duration:\t\t{membership.Duration}\n" +
            $"Price:\t\t\t{membership.GetPrice()}");
        Console.ReadKey();

    }

    private static MembershipFactory GetFactory(string membershipType) =>
        membershipType.ToLower() switch
        {
            "s" => new StandardMembershipFactory(4000, "Membership for beginners"),
            "p" => new StandartAndPoolMembershipFactory(5500, "Membership for professionals"),
            "f" => new FamilyMembershipFactory(8000, "Membership for the whole family"),
            _ => null
        };
}


