using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_UserRights")]
    public class tblUserRights
    {
        [Key]
        public long ur_ID { get; set; }
        public long usr_ID { get; set; }
        public bool ur_AccessCalendar { get; set; }
        public bool ur_AddAppointments { get; set; }
        public bool ur_EditAppointments { get; set; }
        public bool ur_DeleteAppointments { get; set; }
        public bool ur_AccessAdultInterview { get; set; }
        public bool ur_AddAdultInterview { get; set; }
        public bool ur_EditAdultInterview { get; set; }
        public bool ur_DeleteAdultInterview { get; set; }
        public bool ur_AccessChildInterview { get; set; }
        public bool ur_AddChildInterview { get; set; }
        public bool ur_EditChildInterview { get; set; }
        public bool ur_DeleteChildInterview { get; set; }
        public bool ur_AccessSocialSecurity { get; set; }
        public bool ur_AddSocialSecurity { get; set; }
        public bool ur_EditSocialSecurity { get; set; }
        public bool ur_DeleteSocialSecurity { get; set; }
        public bool ur_AccessAdultDDS { get; set; }
        public bool ur_AddAdultDDS { get; set; }
        public bool ur_EditAdultDDS { get; set; }
        public bool ur_DeleteAdultDDS { get; set; }
        public bool ur_AccessChildDDS { get; set; }
        public bool ur_AddChildDDS { get; set; }
        public bool ur_EditChildDDS { get; set; }
        public bool ur_DeleteChildDDS { get; set; }
        public bool ur_AccessAccountsReceivables { get; set; }
        public bool ur_AddAccountsReceivables { get; set; }
        public bool ur_EditAccountsReceivables { get; set; }
        public bool ur_DeleteAccountsReceivables { get; set; }
        public bool ur_AccessPatientInvoices { get; set; }
        public bool ur_AccessHospitalInvoices { get; set; }
        public bool ur_AccessReports { get; set; }
        public bool ur_AccessHospitalInfo { get; set; }
        public bool ur_AddHospitalInfo { get; set; }
        public bool ur_EditHospitalInfo { get; set; }
        public bool ur_DeleteHospitalInfo { get; set; }
        public bool ur_AccessAdministration { get; set; }
        public bool ur_AccessUsers { get; set; }
        public bool ur_AddUsers { get; set; }
        public bool ur_EditUsers { get; set; }
        public bool ur_DeleteUsers { get; set; }
        public bool ur_AccessGroups { get; set; }
        public bool ur_AddGroups { get; set; }
        public bool ur_EditGroups { get; set; }
        public bool ur_DeleteGroups { get; set; }
        public bool ur_AccessMembersOf { get; set; }
        public bool ur_AddMembers { get; set; }
        public bool ur_DeleteMembers { get; set; }
        public bool ur_AccessUserRights { get; set; }
        public bool ur_EditUserRights { get; set; }
        public bool ur_AccessGroupRights { get; set; }
        public bool ur_EditGroupRights { get; set; }
        public bool ur_AddContactInfo { get; set; }
        public bool ur_EditContactInfo { get; set; }
        public bool ur_DeleteContactInfo { get; set; }
        public bool ur_AddHouseHoldResident { get; set; }
        public bool ur_EditHouseHoldResident { get; set; }
        public bool ur_DeleteHouseHoldResident { get; set; }
        public bool ur_AddFinancialInfo { get; set; }
        public bool ur_EditFinancialInfo { get; set; }
        public bool ur_DeleteFinancialInfo { get; set; }
        public bool ur_AddCarsOwned { get; set; }
        public bool ur_EditCarsOwned { get; set; }
        public bool ur_DeleteCarsOwned { get; set; }
        public bool ur_AddEmployerInfo { get; set; }
        public bool ur_EditEmployerInfo { get; set; }
        public bool ur_DeleteEmployerInfo { get; set; }
        public bool ur_AddPhysicianInfo { get; set; }
        public bool ur_EditPhysicianInfo { get; set; }
        public bool ur_DeletePhysicianInfo { get; set; }
        public bool ur_AddMedications { get; set; }
        public bool ur_EditMedications { get; set; }
        public bool ur_DeleteMedications { get; set; }
        public bool ur_AddHospitals { get; set; }
        public bool ur_EditHospitals { get; set; }
        public bool ur_DeleteHospitals { get; set; }
        public bool ur_AddComments { get; set; }
        public bool ur_EditComments { get; set; }
        public bool ur_DeleteComments { get; set; }
        public bool ur_AccessConsultation { get; set; }
        public bool ur_AddConsultation { get; set; }
        public bool ur_EditConsultation { get; set; }
        public bool ur_DelConsultation { get; set; }
    }
}
