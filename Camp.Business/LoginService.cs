using Camp.Business.DataTransferObjects;
using Camp.DataAccess.Repositories;
using Camp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Camp.Business
{
    public class LoginService : ILoginService
    {
        private ILoginRepository loginRepository;
        public LoginService(ILoginRepository loginRepository)

        {
            this.loginRepository = loginRepository;

        }

        public IList<LoginListResponse> GetAllAccounts()
        {
            var dtolist = loginRepository.GetAll().ToList();
            List<LoginListResponse> result = new List<LoginListResponse>();
            dtolist.ForEach(g => result.Add(new LoginListResponse
            {
                Id = g.Id,
                Password = g.Password,
                UserName=g.UserName,
                 Role=g.Role
                
            })) ;

            return result;
        }

        public Login GetUser(string userName,string password)
        {
            return loginRepository.GetWithCriteria(x => x.UserName == userName && x.Password == password).FirstOrDefault();
        }
    }
}
