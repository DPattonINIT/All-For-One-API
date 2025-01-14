using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Net.Http.Headers;

namespace All_For_One_API.Models
{
    public class HelloWorld
    {

        public string? Name { get; set; }

        public bool Valid()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                return false;
            }
            foreach (char c in Name)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
