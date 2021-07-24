using Camp.Business.DataTransferObjects;
using Camp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Camp.Business
{
    public interface ILoginService

    {
        IList<LoginListResponse> GetAllAccounts();
       Login GetUser(string userName,string password);
    }
}
