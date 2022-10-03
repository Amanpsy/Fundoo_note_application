using CommonLayer.Model;
using RepositoryLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interface
{
    public interface IUserBl
    {
        public UserEntity UserRegisteration(Registeration registeration);
    }
}
