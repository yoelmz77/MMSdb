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
        public DbSet<tbl_Users> UsersTable { get; set; }
        public DbSet<tbl_Groups> GroupsTable { get; set; }
        public DbSet<tbl_Membersof> MemberofTable { get; set; }
        public DbSet<tbl_UserRights> UserRightsTable { get; set; }

        public DbSet<tbl_AccntReceivables> AccntReceivablesTable { get; set; }
        public DbSet<tbl_Appointments> AppointmentsTable { get; set; }
        public DbSet<tbl_Cars> CarsTable { get; set; }
        public DbSet<tbl_CarsOwned> CarsOwnedTable { get; set; }
        public DbSet<tbl_Cases> CasesTable { get; set; }
        public DbSet<tbl_ClinicalConditions> ClinicalConditionsTable { get; set; }
        public DbSet<tbl_Comments> CommentsTable { get; set; }
        public DbSet<tbl_Consultations> ConsultationsTable { get; set; }
        public DbSet<tbl_ConsultationPmts> ConsultationPmtsTable { get; set; }
        public DbSet<tbl_Contacts> ContactsTable { get; set; }
        public DbSet<tbl_DCF> DCFTable { get; set; }
        public DbSet<tbl_DDS> DDSTable { get; set; }
        public DbSet<tbl_DDSA> DDSATable { get; set; }
        public DbSet<tbl_Demographics> DemographicsTable { get; set; }
        public DbSet<tbl_Employment> EmploymentTable { get; set; }
        public DbSet<tbl_Facilities> FacilitiesTable { get; set; }
        public DbSet<tbl_Financials> FinancialsTable { get; set; }
        public DbSet<tbl_GroupRights> GroupRightsTable { get; set; }
        public DbSet<tbl_HospitalInfo> HospitalInfoTable { get; set; }
        public DbSet<tbl_HouseHold> HouseHoldTable { get; set; }
        public DbSet<tbl_Image> ImageTable { get; set; }
        public DbSet<tbl_Immigration> ImmigrationTable { get; set; }
        public DbSet<tbl_Insurance> InsuranceTable { get; set; }
        public DbSet<tbl_MaritalStatus> MaritalStatusTable { get; set; }
        public DbSet<tbl_Payments> PaymentsTable { get; set; }
        public DbSet<tbl_Physicians> PhysiciansTable { get; set; }
        public DbSet<tbl_Reports> ReportsTable { get; set; }
        public DbSet<tbl_SchoolInfo> SchoolInfoTable { get; set; }
        public DbSet<tbl_SocialSecurity> SocialSecurityTable { get; set; }
        public DbSet<tbl_WorkHistory> WorkHistoryTable { get; set; }

    }
}
