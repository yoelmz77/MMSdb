using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_UserRights")]
    public class tbl_UserRights
    {
        [Key]
        public long ur_ID { get; set; }
        public long usr_ID { get; set; }
        public Boolean? ur_AccessCalendar { get; set; }
        public Boolean? ur_AddAppointments { get; set; }
        public Boolean? ur_EditAppointments { get; set; }
        public Boolean? ur_DeleteAppointments { get; set; }
        public Boolean? ur_AccessAdultInterview { get; set; }
        public Boolean? ur_AddAdultInterview { get; set; }
        public Boolean? ur_EditAdultInterview { get; set; }
        public Boolean? ur_DeleteAdultInterview { get; set; }
        public Boolean? ur_AccessChildInterview { get; set; }
        public Boolean? ur_AddChildInterview { get; set; }
        public Boolean? ur_EditChildInterview { get; set; }
        public Boolean? ur_DeleteChildInterview { get; set; }
        public Boolean? ur_AccessSocialSecurity { get; set; }
        public Boolean? ur_AddSocialSecurity { get; set; }
        public Boolean? ur_EditSocialSecurity { get; set; }
        public Boolean? ur_DeleteSocialSecurity { get; set; }
        public Boolean? ur_AccessAdultDDS { get; set; }
        public Boolean? ur_AddAdultDDS { get; set; }
        public Boolean? ur_EditAdultDDS { get; set; }
        public Boolean? ur_DeleteAdultDDS { get; set; }
        public Boolean? ur_AccessChildDDS { get; set; }
        public Boolean? ur_AddChildDDS { get; set; }
        public Boolean? ur_EditChildDDS { get; set; }
        public Boolean? ur_DeleteChildDDS { get; set; }
        public Boolean? ur_AccessAccountsReceivables { get; set; }
        public Boolean? ur_AddAccountsReceivables { get; set; }
        public Boolean? ur_EditAccountsReceivables { get; set; }
        public Boolean? ur_DeleteAccountsReceivables { get; set; }
        public Boolean? ur_AccessPatientInvoices { get; set; }
        public Boolean? ur_AccessHospitalInvoices { get; set; }
        public Boolean? ur_AccessReports { get; set; }
        public Boolean? ur_AccessHospitalInfo { get; set; }
        public Boolean? ur_AddHospitalInfo { get; set; }
        public Boolean? ur_EditHospitalInfo { get; set; }
        public Boolean? ur_DeleteHospitalInfo { get; set; }
        public Boolean? ur_AccessAdministration { get; set; }
        public Boolean? ur_AccessUsers { get; set; }
        public Boolean? ur_AddUsers { get; set; }
        public Boolean? ur_EditUsers { get; set; }
        public Boolean? ur_DeleteUsers { get; set; }
        public Boolean? ur_AccessGroups { get; set; }
        public Boolean? ur_AddGroups { get; set; }
        public Boolean? ur_EditGroups { get; set; }
        public Boolean? ur_DeleteGroups { get; set; }
        public Boolean? ur_AccessMembersOf { get; set; }
        public Boolean? ur_AddMembers { get; set; }
        public Boolean? ur_DeleteMembers { get; set; }
        public Boolean? ur_AccessUserRights { get; set; }
        public Boolean? ur_EditUserRights { get; set; }
        public Boolean? ur_AccessGroupRights { get; set; }
        public Boolean? ur_EditGroupRights { get; set; }
        public Boolean? ur_AddContactInfo { get; set; }
        public Boolean? ur_EditContactInfo { get; set; }
        public Boolean? ur_DeleteContactInfo { get; set; }
        public Boolean? ur_AddHouseHoldResident { get; set; }
        public Boolean? ur_EditHouseHoldResident { get; set; }
        public Boolean? ur_DeleteHouseHoldResident { get; set; }
        public Boolean? ur_AddFinancialInfo { get; set; }
        public Boolean? ur_EditFinancialInfo { get; set; }
        public Boolean? ur_DeleteFinancialInfo { get; set; }
        public Boolean? ur_AddCarsOwned { get; set; }
        public Boolean? ur_EditCarsOwned { get; set; }
        public Boolean? ur_DeleteCarsOwned { get; set; }
        public Boolean? ur_AddEmployerInfo { get; set; }
        public Boolean? ur_EditEmployerInfo { get; set; }
        public Boolean? ur_DeleteEmployerInfo { get; set; }
        public Boolean? ur_AddPhysicianInfo { get; set; }
        public Boolean? ur_EditPhysicianInfo { get; set; }
        public Boolean? ur_DeletePhysicianInfo { get; set; }
        public Boolean? ur_AddMedications { get; set; }
        public Boolean? ur_EditMedications { get; set; }
        public Boolean? ur_DeleteMedications { get; set; }
        public Boolean? ur_AddHospitals { get; set; }
        public Boolean? ur_EditHospitals { get; set; }
        public Boolean? ur_DeleteHospitals { get; set; }
        public Boolean? ur_AddComments { get; set; }
        public Boolean? ur_EditComments { get; set; }
        public Boolean? ur_DeleteComments { get; set; }
        public Boolean? ur_AccessConsultation { get; set; }
        public Boolean? ur_AddConsultation { get; set; }
        public Boolean? ur_EditConsultation { get; set; }
        public Boolean? ur_DelConsultation { get; set; }
        public Boolean? deleted { get; set; }
    }
}
