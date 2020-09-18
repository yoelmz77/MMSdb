using System;
using System.Configuration;
using System.Linq;
using MMSdb.dbo;

namespace MMSdb
{
    class Program
    {
        MMSdbDBContext db = new MMSdbDBContext();
        static void Main(string[] args)
        {

            using (var db = new MMSdbDBContext())
            {
                db.UsersTable.ToList();
                db.GroupsTable.ToList();
                db.MemberofTable.ToList();
                db.UserRightsTable.ToList();
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
