using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using All_For_One_API.Models;

namespace All_For_One_API.Services
{
    public class SayHelloService
    {
          public string AddName(string name)
        {
            HelloWorld person = new HelloWorld { Name = name };
            if (person.Valid())
            {
                return $"Hello {person.Name}, nice to meet you!";
            }
            else
            {
                return "Name cannot be empty or cannot contain numbers or special characters.";
            }

        }
    }
}

