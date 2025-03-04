using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GuestManager : IGuestService
    {
        private readonly IGuestDal _guestDal;

        public GuestManager(IGuestDal guestDal)
        {
            _guestDal = guestDal;
        }

        public void TDelete(Guests t)
        {
            _guestDal.Delete(t);
        }

        public Guests TGetById(int id)
        {
            return _guestDal.GetById(id);
        }

        public List<Guests> TGetList()
        {
            return _guestDal.GetList();
        }

        public void TInsert(Guests t)
        {
            _guestDal.Insert(t);
        }

        public void TUpdate(Guests t)
        {
            _guestDal.Update(t);
        }
    }
}
