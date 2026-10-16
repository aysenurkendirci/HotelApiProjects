using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccesLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System.Collections.Generic;

namespace HotelProject.BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IServicesDal _servicesDal;

        public ServiceManager(IServicesDal servicesDal)
        {
            _servicesDal = servicesDal;
        }

        public void TDelete(Service t)
        {
            _servicesDal.TDelete(t);
        }

        public Service TGetByID(int id)
        {
            return _servicesDal.TGetByID(id);
        }

        public List<Service> TGetList()
        {
            return _servicesDal.TGetList();
        }

        public void TInsert(Service t)
        {
            _servicesDal.TInsert(t);
        }

        public void TUpdate(Service t)
        {
            _servicesDal.TUpdate(t);
        }
    }
}