using BusinessLayer.Interface;
using CommonLayer.Model;
using RepositoryLayer.Entities;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Service
{
    public class UserBl : IUserBl
    {
        private readonly IUserRl userRl;
        public UserBl(IUserRl userRl)
        {
            this.userRl = userRl;
        }

       public UserEntity UserRegisteration(Registeration registeration)
        {
            try
            {
                return userRl.UserRegisteration(registeration);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
