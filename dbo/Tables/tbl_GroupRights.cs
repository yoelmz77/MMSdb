using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_GroupRights")]
    public class tbl_GroupRights
    {
        [Key]
        public long gr_ID { get; set; }
        public long grp_ID { get; set; }
        public Boolean? gr_AccessCalendar { get; set; }
        public Boolean? gr_AddAppointments { get; set; }
        public Boolean? gr_EditAppointments { get; set; }
        public Boolean? gr_DeleteAppointments { get; set; }
        public Boolean? gr_AccessAdultInterview { get; set; }
        public Boolean? gr_AddAdultInterview { get; set; }
        public Boolean? gr_EditAdultInterview { get; set; }
        public Boolean? gr_DeleteAdultInterview { get; set; }
        public Boolean? gr_AccessChildInterview { get; set; }
        public Boolean? gr_AddChildInterview { get; set; }
        public Boolean? gr_EditChildInterview { get; set; }
        public Boolean? gr_DeleteChildInterview { get; set; }
        public Boolean? gr_AccessSocialSecurity { get; set; }
        public Boolean? gr_AddSocialSecurity { get; set; }
        public Boolean? gr_EditSocialSecurity { get; set; }
        public Boolean? gr_DeleteSocialSecurity { get; set; }
        public Boolean? gr_AccessAdultDDS { get; set; }
        public Boolean? gr_AddAdultDDS { get; set; }
        public Boolean? gr_EditAdultDDS { get; set; }
        public Boolean? gr_DeleteAdultDDS { get; set; }
        public Boolean? gr_AccessChildDDS { get; set; }
        public Boolean? gr_AddChildDDS { get; set; }
        public Boolean? gr_EditChildDDS { get; set; }
        public Boolean? gr_DeleteChildDDS { get; set; }
        public Boolean? gr_AccessAccountsReceivables { get; set; }
        public Boolean? gr_AddAccountsReceivables { get; set; }
        public Boolean? gr_EditAccountsReceivables { get; set; }
        public Boolean? gr_DeleteAccountsReceivables { get; set; }
        public Boolean? gr_AccessPatientInvoices { get; set; }
        public Boolean? gr_AccessHospitalInvoices { get; set; }
        public Boolean? gr_AccessReports { get; set; }
        public Boolean? gr_AccessHospitalInfo { get; set; }
        public Boolean? gr_AddHospitalInfo { get; set; }
        public Boolean? gr_EditHospitalInfo { get; set; }
        public Boolean? gr_DeleteHospitalInfo { get; set; }
        public Boolean? gr_AccessAdministration { get; set; }
        public Boolean? gr_AccessUsers { get; set; }
        public Boolean? gr_AddUsers { get; set; }
        public Boolean? gr_EditUsers { get; set; }
        public Boolean? gr_DeleteUsers { get; set; }
        public Boolean? gr_AccessGroups { get; set; }
        public Boolean? gr_AddGroups { get; set; }
        public Boolean? gr_EditGroups { get; set; }
        public Boolean? gr_DeleteGroups { get; set; }
        public Boolean? gr_AccessMembersOf { get; set; }
        public Boolean? gr_AddMembers { get; set; }
        public Boolean? gr_DeleteMembers { get; set; }
        public Boolean? gr_AccessUserRights { get; set; }
        public Boolean? gr_EditUserRights { get; set; }
        public Boolean? gr_AccessGroupRights { get; set; }
        public Boolean? gr_EditGroupRights { get; set; }
        public Boolean? gr_AddContactInfo { get; set; }
        public Boolean? gr_EditContactInfo { get; set; }
        public Boolean? gr_DeleteContactInfo { get; set; }
        public Boolean? gr_AddHouseHoldResident { get; set; }
        public Boolean? gr_EditHouseHoldResident { get; set; }
        public Boolean? gr_DeleteHouseHoldResident { get; set; }
        public Boolean? gr_AddFinancialInfo { get; set; }
        public Boolean? gr_EditFinancialInfo { get; set; }
        public Boolean? gr_DeleteFinancialInfo { get; set; }
        public Boolean? gr_AddCarsOwned { get; set; }
        public Boolean? gr_EditCarsOwned { get; set; }
        public Boolean? gr_DeleteCarsOwned { get; set; }
        public Boolean? gr_AddEmployerInfo { get; set; }
        public Boolean? gr_EditEmployerInfo { get; set; }
        public Boolean? gr_DeleteEmployerInfo { get; set; }
        public Boolean? gr_AddPhysicianInfo { get; set; }
        public Boolean? gr_EditPhysicianInfo { get; set; }
        public Boolean? gr_DeletePhysicianInfo { get; set; }
        public Boolean? gr_AddMedications { get; set; }
        public Boolean? gr_EditMedications { get; set; }
        public Boolean? gr_DeleteMedications { get; set; }
        public Boolean? gr_AddHospitals { get; set; }
        public Boolean? gr_EditHospitals { get; set; }
        public Boolean? gr_DeleteHospitals { get; set; }
        public Boolean? gr_AddComments { get; set; }
        public Boolean? gr_EditComments { get; set; }
        public Boolean? gr_DeleteComments { get; set; }
        public Boolean? gr_AccessConsultation { get; set; }
        public Boolean? gr_AddConsultation { get; set; }
        public Boolean? gr_EditConsultation { get; set; }
        public Boolean? gr_DelConsultation { get; set; }
        public Boolean? deleted { get; set; }
    }
}
