using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HotelProject.BusinessLayer.Abstract
{
    public interface IRoomService : IGenericService<Room>
    {
        void TDelete(Room t);
        Room TGetByID(int id);
        List<Room> TGetList();
        void TInsert(Room t);
        void TUpdate(Room t);
    }
}
