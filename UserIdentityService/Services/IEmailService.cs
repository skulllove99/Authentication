using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserIdentityService.Models;

namespace UserIdentityService.Services
{
    public interface IEmailService
    {
        void SendEmail(Message message);
    }
}
