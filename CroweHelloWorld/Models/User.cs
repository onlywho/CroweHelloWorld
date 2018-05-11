using System;
namespace CroweHelloWorld.Models
{
    public class User
    {
        public string firstName;
        public string lastName;
        private int _age;

        public User(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            _age = age;
        }
    }
}
