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

        public User(string Name, int id, Gender gender) 
        { 
            this.Name = Name;
            this.id = id;
            this.gender = gender;
        }
    }

    enum Gender
    {
        MALE,
        FEMALE,
        OTHER

    }
}
