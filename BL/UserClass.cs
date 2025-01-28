using Microsoft.AspNetCore.Mvc;

namespace STEAM.Models
{
    public class UserClass
    {
        public UserClass() { }

        public int Id;
        public string Name;
        public string Email;
        public string Password;
        public bool IsActive;

        public static List<UserClass> UsersList = new List<UserClass>();
        public UserClass(int Id, string Name, string Email, string Password,bool IsActive)
        {
            id = Id;
            name = Name;
            email = Email;
            password = Password;
            isActive = IsActive;
        }

        public int id { get => Id; set => Id = value; }
        public string name { get => Name; set => Name = value; }
        public string email { get => Email; set => Email = value; }
        public string password { get => Password; set => Password = value; }
        public bool isActive { get => IsActive; set => IsActive = value; }

        public int AddNewUser(string Name, string Email, string Password)
        {
            DBservices dbs = new DBservices();
            return dbs.AddNewUser(Name, Email, Password);
        }


        //public List<UserClass> MyUsers()
        //{
        //    DBservices dbs = new DBservices();
        //    return dbs.MyUsers();
        //}
        public Object MyUsers()
        {
            DBservices dbs = new DBservices();
            return dbs.MyUsers();
        }

        public UserClass LoginUser(string Email, string Password)
        {
            DBservices dbs = new DBservices();
            return dbs.LoginUser(Email, Password);
        }

       
        public int UpdateUser(int Id,  string Email, string Password, string Name)
        {
            DBservices dbs = new DBservices();
            return dbs.UpdateUser(Id,  Email, Password, Name);
        }
        public int UpdateUserisActive(int Id, bool IsActive)
        {
            DBservices dbs = new DBservices();
            return dbs.UpdateUserisActive(Id, IsActive);
        }
        //public Object GetUsersWithGameDetails()
        //{
        //    DBservices dbs = new DBservices();
        //    return dbs.GetUsersWithGameDetails();
        //}

    }
}
