using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfStaffDal : GenericRepository<Staff>, IStaffDal
    {
        public EfStaffDal(Context context) : base(context)
        {
        }

        public int AllStaffCount()
        {
            var context = new Context();
            return context.Staffs.Count();
        }

        public List<Staff> Last4Staff()
        {
            var context = new Context();
            return context.Staffs.OrderByDescending(x => x.StaffID).ToList();
        }
    }
}
