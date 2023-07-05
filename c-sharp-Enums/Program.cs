using c_sharp_Enums;
using System;
using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        User user1 = new User("omar", 123, Gender.MALE);
        User user2 = new User("aisha", 120, Gender.FEMALE);

        User user3 = new User("OMRAN", 122, CarType.ULTRA_PREMIUM);
        User user4 = new User("ALI", 127, CarType.VAN);

        Console.WriteLine((int)user3.carType);

        string description=getEnumDescription(CarType.VAN);
        Console.WriteLine(description);

        int ordinalValue = 200;
        CarType type = (CarType)ordinalValue;
        Console.WriteLine(type.ToString());



    }

    private static string getEnumDescription(Enum enums)
    {
        var field = enums.GetType().GetField(enums.ToString());
        var attribute=Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute))as DescriptionAttribute;
        return attribute!=null ? attribute.Description :enums.ToString();
    }





}




