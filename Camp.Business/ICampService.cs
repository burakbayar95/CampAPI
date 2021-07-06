using Camp.Business.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Camp.Business
{
    public interface ICampService
    {
        IList<CampListResponse> GetAllCamps();
    }
}
