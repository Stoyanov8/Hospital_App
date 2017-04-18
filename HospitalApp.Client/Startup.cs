using HospitalApp.Data;
using HospitalApp.Import;

namespace HospitalApp.Client
{
    class Startup
    {
        static void Main(string[] args)
        {
            Utility.InitDb();
            AddRoom.AddRooms();
            AddDoctor.AddDoctors();
        }
    }
}
