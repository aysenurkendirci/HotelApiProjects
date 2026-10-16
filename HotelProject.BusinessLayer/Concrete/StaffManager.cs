using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccesLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System.Collections.Generic;

namespace HotelProject.BusinessLayer.Concrete
{
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _staffDal;

        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        public void TDelete(Staff t)
        {
            _staffDal.TDelete(t);
        }

        public Staff TGetByID(int id)
        {
            return _staffDal.TGetByID(id);
        }

        public List<Staff> TGetList()
        {
            return _staffDal.TGetList();
        }

        public void TInsert(Staff t)
        {
            _staffDal.TInsert(t);
        }

        public void TUpdate(Staff t)
        {
            _staffDal.TUpdate(t);
        }
    }
}