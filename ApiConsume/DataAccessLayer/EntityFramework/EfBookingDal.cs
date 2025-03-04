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
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        Context context = new Context();
        public EfBookingDal(Context context) : base(context)
        {
        }

        public void BookingStatusChangeApproved(int id)
        {
            var values = context.Bookings.Find(id);
            values.Status = "Onaylandı";
            context.SaveChanges();
        }

        public void BookingStatusChangeCancel(int id)
        {
            var values = context.Bookings.Find(id);
            values.Status = "Onaylanmadı,İptal edildi.";
            context.SaveChanges();
        }

        public void BookingStatusChangeWait(int id)
        {
            var values = context.Bookings.Find(id);
            values.Status = "Müşteri Aranacak.";
            context.SaveChanges();
        }

        public int GetAllBookingsCount()
        {
            return context.Bookings.Count();
        }

        public List<Booking> Last6Booking()
        {
            var values = context.Bookings.OrderByDescending(x => x.BookingID).Take(6).ToList();
            return values;
        }
    }
}
