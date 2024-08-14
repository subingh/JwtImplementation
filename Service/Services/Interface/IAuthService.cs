using LogIn.Data.Models;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interface
{
    public interface IAuthService
    {
        User AddUser(User user);
        string LogIn(LoginRequest request);
    }
}
