using MMSdb.dbo.Tables;
using System;
using System.Configuration;
using System.Data.Entity;

namespace MMSdb.dbo
{
    public class MMSdbDBContext : DbContext
    {
        public MMSdbDBContext()
            //: base("name=mmsdbconnection")
            : base("Data Source=.\\SQLEXPRESS;Initial Catalog=MMS;User ID=yoel;Password=Abc123..;")
        
        {
        }
        //public DbSet<clsCase> CaseTable { get; set; }
        public DbSet<tblUsers> UsersTable { get; set; }
        public DbSet<tblGroups> GroupsTable { get; set; }
        public DbSet<tblMembersof> MemberofTable { get; set; }
        public DbSet<tblUserRights> UserRightsTable { get; set; }

    }
}
