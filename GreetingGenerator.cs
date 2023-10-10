using System;

namespace GreetingLib
{
    public class GreetingGenerator
    {
        public static string GenerateGreeting(string username)
        {
            return $"{DateTime.Now}: Hello, {username}!";
        }
    }
}
