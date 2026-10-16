using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccesLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System.Collections.Generic;

namespace HotelProject.BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonial _testimonialDal;

        public TestimonialManager(ITestimonial testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void TDelete(Testimonial t)
        {
            _testimonialDal.TDelete(t);
        }

        public Testimonial TGetByID(int id)
        {
            return _testimonialDal.TGetByID(id);
        }

        public List<Testimonial> TGetList()
        {
            return _testimonialDal.TGetList();
        }

        public void TInsert(Testimonial t)
        {
            _testimonialDal.TInsert(t);
        }

        public void TUpdate(Testimonial t)
        {
            _testimonialDal.TUpdate(t);
        }
    }
}