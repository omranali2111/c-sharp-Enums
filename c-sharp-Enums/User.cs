using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_Enums
{
    internal class User
    {
        public string Name { get; set; }
        public int id { get; set; }

        public Gender gender { get; set; }

        public CarType carType { get; set; }

        public User(string Name, int id, Gender gender) 
        { 
            this.Name = Name;
            this.id = id;
            this.gender = gender;
        }

        public User(string Name, int id, CarType carType)
        {
            this.Name = Name;
            this.id = id;
            this.carType = carType;
           
        }
    }

    enum Gender
    {
        MALE,
        FEMALE,
        OTHER

    }

    enum CarType
    {
        BASIC=100,
        PREMIUM=200,
        VAN=150,
        ULTRA_PREMIUM=250,

    }
}
