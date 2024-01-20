using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Person
    {
        private int personId;
        private string firstName;
        private string lastName ="";
        private string favoriteColour;
        private int age;
        private bool isWorking;
        public Person(int personId, string firstName, string lastName, string favoriteColour, int age, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favoriteColour = favoriteColour;
            this.age = age;
            this.isWorking = isWorking;
        }

        public string DisplayPersonInfo()
        {
            string name = this.firstName + " " + this.lastName;
            string output = String.Format("{0}: {1}'s favorite colour is {2}", this.personId, name, this.favoriteColour);
            return output;
        }
        public void ChangeFavouriteColour()
        {
            this.favoriteColour = "White";
        }

        public string GetAgeInTenYears()
        {
            return $"{this.firstName} {this.lastName}'s Age in 10 years is: {this.age + 10}";
        }

        public int PersonId
        {
            get {return this.personId; }
            set {this.personId = value; }
            
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }

        }

        public string LastName 
        {  
            get{ return this.lastName; } 
            set {this.lastName = value; } 
        }

        public string FavoriteColour
        {
            get { return this.favoriteColour; }
            set { this.favoriteColour = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public bool IsWorking
        {
            get { return this.isWorking; }
            set { this.isWorking = value; }
        }

        public override string ToString()
        {
            
            return $"PersonId: {this.personId}\n" +
                $"FirstName: {this.firstName}\n" +
                $"LastName: {this.lastName}\n" +
                $"FavoriteColour: {this.favoriteColour}\n" +
                $"Age: {this.age}\n" +
                $"IsWorking: {this.isWorking}";
        }

    }

}
