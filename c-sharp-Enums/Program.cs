using c_sharp_Enums;

internal class Program
{
    private static void Main(string[] args)
    {
      User user1 = new User("omar", 123, Gender.MALE);
      User user2 = new User("aisha", 120, Gender.FEMALE);

       User user3 = new User("OMRAN", 122, CarType.ULTRA_PREMIUM);
       User user4 = new User("ALI", 127, CarType.VAN);

        Console.WriteLine((int)user3.carType);

    }
}