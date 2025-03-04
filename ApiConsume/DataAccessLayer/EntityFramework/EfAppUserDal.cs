using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfAppUserDal : GenericRepository<AppUser>, IAppUserDal
    {
        public EfAppUserDal(Context context) : base(context)
        {
        }

        public List<AppUser> AppUserListWithWorkLocation()
        {
            var context = new Context();

            var values = context.Users.Include(x => x.WorkLocation).ToList();

            return values;
        }

        public int GetAllAppUsersCount()
        {
            var context= new Context();
            return context.Users.Count();
        }
    }
}
