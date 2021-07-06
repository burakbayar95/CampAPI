using Camp.Business.DataTransferObjects;
using Camp.DataAccess.Repositories;
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
                Password = g.Password
            })) ;

            return result;
        }
    }
}
