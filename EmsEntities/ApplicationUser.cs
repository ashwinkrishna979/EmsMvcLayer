
using Microsoft.AspNetCore.Identity;
using System;

namespace EmsEntities
{
    public class ApplicationUser : IdentityUser
    {

        public Role UserType { get; set; }

    }
}
