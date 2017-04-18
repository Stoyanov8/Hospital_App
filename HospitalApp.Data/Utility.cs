namespace HospitalApp.Data
{
    public class Utility
    {
        public static void InitDb()
        {
            var context = new HospitalAppEntities();
            context.Database.Initialize(true);
        }
    }
}