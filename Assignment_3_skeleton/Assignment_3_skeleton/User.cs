using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Assignment_3_skeleton
{
    [DataContract]
    public class User
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Password;

        //Initializes a User object.
        public User(int id, string name, string email, string password)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
        }

        //Gets the users ID.
        public int getId()
        {
            return Id;
        }

        //Gets the users name.
        public string getName()
        {
            return Name;
        }

        //Gets the users email.
        public string getEmail()
        {
            return Email;
        }

        //Checks if the passed password is correct.
        public bool isCorrectPassword(string password)
        {
            if (Password == null && password == null)
                return true;
            else if (Password == null || password == null)
                return false;
            else
                return Password.Equals(password);
        }

        //Checks if object is equal to another object.
        public bool equals(User obj)
        {
            if (!(obj is User))
                return false;

            User other = (User)obj;

            return Id == other.Id &&
                    string.Equals(Name, other.Name) &&
                    string.Equals(Email, other.Email);
        }

        // Override Equals for proper C# equality comparison
        public override bool Equals(object obj)
        {
            if (obj is User user)
            {
                return equals(user);
            }
            return false;
        }

 
        public override string ToString()
        {
            return $"User(Id: {Id}, Name: {Name}, Email: {Email})";
        }
    }
}