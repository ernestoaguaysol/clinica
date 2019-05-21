using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppVet.Interfaces;
using WebAppVet.Models;

namespace WebAppVet.Data
{

    public class RoomFacade : IRepository<Room>
    {
        private static RoomFacade roomFacade;

        protected RoomFacade()
        {

        }

        public static RoomFacade getInstance()
        {
            if (roomFacade == null)
            {
                roomFacade = new RoomFacade();
            }
            return roomFacade;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Room GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Room entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Room> List()
        {
            return RoomDataGateway.List();
        }

        public void Update(Room entity)
        {
            throw new NotImplementedException();
        }
    }


    internal class RoomDataGateway
    {
        public static IEnumerable<Room> List()
        {
            var strsql = "select * from dbo.Room";
            try
            {
                IEnumerable<Room> rooms = null;
                return rooms;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void Delete(int id)
        {
            var strsql = "DELETE FROM dbo.Room WHERE Id='id';";
            try
            {
                //TODO
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}