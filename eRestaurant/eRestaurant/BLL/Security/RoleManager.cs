using eRestaurant.DAL;
using eRestaurant.Entities.Security;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.BLL.Security
{
    public class RoleManager : RoleManager<ApplicationRole>
    {
        public RoleManager()
            : base(new RoleStore<ApplicationRole>(new ApplicationDbContext()))
        {
        }
    }
}
