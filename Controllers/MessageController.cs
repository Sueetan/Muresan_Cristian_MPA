﻿using Microsoft.AspNetCore.Mvc;

namespace Muresan_Cristian_Lab1.Controllers
{
    public class MessageController : Controller
    {
        public string Index()
        {
            return "Bun venit!";
        }

        public string Hello()
        {
            return "Salut!";
        }

        public string ShowValues(string firstValue, int secondValue)
        {
            return $"Here are some values {firstValue} and {secondValue}";
        }
    }
}