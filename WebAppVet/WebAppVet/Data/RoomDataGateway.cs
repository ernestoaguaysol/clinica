using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
            var cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ClinicaDbContext"].ToString());
            var cmd = new SqlCommand();
            var query = "select * from dbo.Rooms";

            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                var reader = cmd.ExecuteReader();
                List<Room> rooms = new List<Room>();

                //cmd.CommandText = "Select * From Table Where Title = @Title";
                //cmd.Parameters.Add("@Title", someone);

                while (reader.Read())
                {
                    rooms.Add(new Room
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader["Name"].ToString(),
                                    Location = reader["Location"].ToString()
                    });
                }
                cn.Close();
                return rooms;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public void Delete(int id)
        {
            //var strsql = "DELETE FROM dbo.Room WHERE Id='id';";
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