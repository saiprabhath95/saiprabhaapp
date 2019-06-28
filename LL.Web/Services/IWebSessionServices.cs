using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LL.Web.Models;

namespace LL.Web.Services
{
    public interface IWebSessionServices
    {
        Task<double> ComputeUserSession(ViewModel.WebSessionItem input);
    }
}
