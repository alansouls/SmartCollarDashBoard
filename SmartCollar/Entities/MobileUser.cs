using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCollar.Entities
{
    public class MobileUser
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string UserName { get; set; }

        public string Hash { get; set; }

        public IEnumerable<UserNotification> Notifications { get; set; }

        public string Token { get; set; }
    }
}
