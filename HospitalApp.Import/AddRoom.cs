using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalApp.Data;
using HospitalApp.Data.Dtos;
using Models;
using Newtonsoft.Json;

namespace HospitalApp.Import
{
    public class AddRoom
    {
        public static void AddRooms()
        {
            var json = File.ReadAllText("../../../datasets/rooms.json");
            var rooms = JsonConvert.DeserializeObject<IEnumerable<RoomDto>>(json);
            AddRoom.AddRooms(rooms);
        }

        public static void AddRooms(IEnumerable<RoomDto> rooms)
        {
            using (var context = new HospitalAppEntities())
            {
                foreach (var room in rooms)
                {
                    context.Rooms.Add(new Room {Number = room.Number});
                    Console.WriteLine($"Imported room { room.Number}!");
                }
                context.SaveChanges();
            }
            
        }
    }
}
