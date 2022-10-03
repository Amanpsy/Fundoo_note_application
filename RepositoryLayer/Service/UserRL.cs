using CommonLayer.Model;
using RepositoryLayer.Context;
using RepositoryLayer.Entities;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Service
{
    public class UserRL : IUserRl
    {
       
        private readonly FundooContext fundooContext;

        public UserRL(FundooContext fundooContext)
        {
            this.fundooContext = fundooContext;
        }
        public UserEntity UserRegisteration(Registeration registeration)
        {
            try
            {
                UserEntity userEntity = new UserEntity();
                userEntity.FirstName = registeration.FirstName;
                userEntity.LastName = registeration.LastName;
                userEntity.Email = registeration.Email;
                userEntity.Password = registeration.Password;

                fundooContext.UserTable.Add(userEntity);
                int result =fundooContext.SaveChanges();
                if(result > 0)
                {
                    return userEntity;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception ex)       
            {
                throw ex;
            }
        }
    }
}
