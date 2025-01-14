using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace All_For_One_API.Services
{
    public class AskingQuestionsService
    {
        public string GetInfo(string name, string wakeUpTime)
        {
            return $"{name} woke up at {wakeUpTime}. ";
        }
    }
}

