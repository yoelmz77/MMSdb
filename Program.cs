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

                db.AccntReceivablesTable.ToList();
                db.AppointmentsTable.ToList();
                db.CarsTable.ToList();
                db.CarsOwnedTable.ToList();
                db.CasesTable.ToList();
                db.ClinicalConditionsTable.ToList();
                db.CommentsTable.ToList();
                db.ConsultationsTable.ToList();
                db.ConsultationPmtsTable.ToList();
                db.ContactsTable.ToList();
                db.DCFTable.ToList();
                db.DDSTable.ToList();
                db.DDSATable.ToList();
                db.DemographicsTable.ToList();
                db.EmploymentTable.ToList();
                db.FacilitiesTable.ToList();
                db.FinancialsTable.ToList();
                db.GroupRightsTable.ToList();
                db.HospitalInfoTable.ToList();
                db.HouseHoldTable.ToList();
                db.HouseholdresidentsTable.ToList();
                db.ImageTable.ToList();
                db.ImmigrationTable.ToList();
                db.InsuranceTable.ToList();
                db.MaritalStatusTable.ToList();
                db.MedicationsTable.ToList();
                db.PaymentsTable.ToList();
                db.PhysiciansTable.ToList();
                db.ReportsTable.ToList();
                db.SchoolInfoTable.ToList();
                db.SocialSecurityTable.ToList();
                db.WorkHistoryTable.ToList();
                db.ReportRightsUsersTable.ToList();
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
