
using LookLike.Shared.Models;
using System;
using System.Net;

namespace LookLike.Desktop.Repositories
{
    public class AdminRepository
    {
        public bool AuthenticateUser(NetworkCredential credential)
        {
            bool validAdmin = true;
            return validAdmin;
        }

        public Admin? GetByUsername(string userName)
        {
             return new Admin
             {
                 Username = "teszt",
                 Password = "test@123"
             };
        }
    }
}
