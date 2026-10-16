using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccesLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System.Collections.Generic;

namespace HotelProject.BusinessLayer.Concrete
{
    public class SubscribeManager : ISubscribeService
    {
        private readonly ISubscribeDal _subscribeDal;

        public SubscribeManager(ISubscribeDal subscribeDal)
        {
            _subscribeDal = subscribeDal;
        }

        public void TDelete(Subscribe t)
        {
            _subscribeDal.TDelete(t);
        }

        public Subscribe TGetByID(int id)
        {
            return _subscribeDal.TGetByID(id);
        }

        public List<Subscribe> TGetList()
        {
            return _subscribeDal.TGetList();
        }

        public void TInsert(Subscribe t)
        {
            _subscribeDal.TInsert(t);
        }

        public void TUpdate(Subscribe t)
        {
            _subscribeDal.TUpdate(t);
        }
    }
}