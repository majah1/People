using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    public class NewPerson
    {
        private string id;
        private int age;
        private string firstName;
        private string lastName;
        private string fullName;
        private Guid guid;


        public int Age { get => age; set => age = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Id { get => id; set => id = value; }

        public NewPerson(int Age, string FirstName, string LastName, string personID)

        {
            this.Age = Age;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.FullName = FirstName + " " + LastName;
            this.id = personID;
        }

        //private void setID()
        //{
        //    Guid Id;
        //   Id= Guid.NewGuid();

        //}

        // private void setID() => this.Id = this.Age + this.firstName;
        public void PromenaPrezimena(String newLastName) {
            this.lastName = newLastName;
            this.FullName = firstName + " " + newLastName;
        }

        public void PromenaGodina(int noveGodine)
        {
            this.Age += noveGodine;

        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
