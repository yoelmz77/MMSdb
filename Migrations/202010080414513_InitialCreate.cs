namespace MMSdb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_AccntReceivables",
                c => new
                    {
                        recv_ID = c.Long(nullable: false, identity: true),
                        dmg_ID = c.Long(nullable: false),
                        recv_SSIMonthlyAmt = c.Double(),
                        recv_SSIRetroAmt = c.Double(),
                        recv_SSIMMS25 = c.Double(),
                        recv_SSIMedicalConference = c.Double(),
                        recv_SSIPhysician = c.String(),
                        recv_SSICopyExpense = c.Double(),
                        recv_SSICertifiedMail = c.Double(),
                        recv_SSIRegStamps = c.Double(),
                        recv_SSITravel = c.Double(),
                        recv_SSIOfficeSupplies = c.Double(),
                        recv_SSIMedicaid = c.Double(),
                        recv_SSIOther = c.String(),
                        recv_SSIOtherAmt = c.Double(),
                        recv_SSDIMonthlyAmt = c.Double(),
                        recv_SSDIRetroAmt = c.Double(),
                        recv_SSDIMMS25 = c.Double(),
                        recv_SSDIMedicalConference = c.Double(),
                        recv_SSDIPhysician = c.String(),
                        recv_SSDICopyExpense = c.Double(),
                        recv_SSDICertifiedMail = c.Double(),
                        recv_SSDIRegStamps = c.Double(),
                        recv_SSDITravel = c.Double(),
                        recv_SSDIOfficeSupplies = c.Double(),
                        recv_SSDIMedicaid = c.Double(),
                        recv_SSDIOther = c.String(),
                        recv_SSDIOtherAmt = c.Double(),
                        deleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.recv_ID);
            
            CreateTable(
                "dbo.tbl_Appointments",
                c => new
                    {
                        app_ID = c.Long(nullable: false, identity: true),
                        case_ID = c.Long(nullable: false),
                        usr_ID = c.Long(nullable: false),
                        app_Subject = c.String(),
                        app_Location = c.String(),
                        app_StartDate = c.DateTime(),
                        app_StartTime = c.DateTime(),
                        app_EndDate = c.DateTime(),
                        app_EndTime = c.DateTime(),
                        app_Body = c.String(),
                        deleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.app_ID);
            
            CreateTable(
                "dbo.tbl_CarsOwned",
                c => new
                    {
                        cars_ID = c.Long(nullable: false, identity: true),
                        dmg_ID = c.Long(nullable: false),
                        cars_Notes = c.String(),
                        deleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.cars_ID);
            
            CreateTable(
                "dbo.tbl_Cars",
                c => new
                    {
                        car_ID = c.Long(nullable: false, identity: true),
                        cars_ID = c.Long(nullable: false),
                        car_Type = c.String(),
                        car_Year = c.String(),
                        car_Make = c.String(),
                        car_Model = c.String(),
                        car_Marketvalue = c.Double(),
                        car_Color = c.String(),
                        car_LicensePlate = c.String(),
                        deleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.car_ID);
            
            CreateTable(
                "dbo.tbl_Cases",
                c => new
                    {
                        case_ID = c.Long(nullable: false, identity: true),
                        usr_ID = c.Int(nullable: false),
                        sts_id = c.Int(),
                        fac_id = c.Int(),
                        case_date = c.DateTime(nullable: false),
                        case_Reminder = c.Boolean(),
                        case_ReminderDate = c.DateTime(),
                        case_Elgible = c.Boolean(),
                        case_type = c.String(maxLength: 1, unicode: false),
                        case_StatusDate = c.DateTime(),
                        case_FirstInitial = c.Boolean(),
                        case_SSIOnly = c.Boolean(),
                        case_Concurrent = c.Boolean(),
                        case_ByAge = c.Boolean(),
                        case_Medicare = c.Boolean(),
                        case_Medicaid = c.Boolean(),
                        case_EmergencyMedicaid = c.Boolean(),
                        case_SSDI = c.Boolean(),
                        case_Consultation = c.Boolean(),
                        case_MedicallyNeedy = c.Boolean(),
                        case_DDD = c.Boolean(),
                        case_Phostomous = c.Boolean(),
                        case_Appeal = c.Boolean(),
                        case_AppealDate = c.DateTime(),
                        case_AppealDeadline = c.String(),
                        case_Hearing = c.Boolean(),
                        case_HearingDate = c.DateTime(),
                        case_HearingDeadline = c.String(),
                        case_Referral = c.String(),
                        case_DCFOnlineAccessNo = c.String(),
                        case_DCFOnlineAccessDate = c.DateTime(),
                        case_DCF_PR_MedRecords = c.Boolean(),
                        case_DCF_PR_IncomeEveryone = c.Boolean(),
                        case_DCF_PR_IncomeClient = c.Boolean(),
                        case_DCF_PR_PatientID = c.Boolean(),
                        case_DCF_PR_ImmigrationDocs = c.Boolean(),
                        case_DCF_PR_EMAForm = c.Boolean(),
                        case_DCF_PR_2514Form = c.Boolean(),
                        case_DCF_PR_2613Form = c.Boolean(),
                        case_DCF_PR_FinancialRelease = c.Boolean(),
                        case_DCF_PR_CarStatement = c.Boolean(),
                        case_DCF_PR_ChildSuppProof = c.Boolean(),
                        case_DCF_PR_LongTermCareInfo = c.Boolean(),
                        case_Disability_TaxThisYear = c.Boolean(),
                        case_Disability_TaxLastYear = c.Boolean(),
                        case_Disability_PictureID = c.Boolean(),
                        case_Disability_SSNCard = c.Boolean(),
                        case_Disability_BirthCert = c.Boolean(),
                        case_Disability_UtilitiesExp = c.Boolean(),
                        case_Disability_MortgageReceipt = c.Boolean(),
                        case_Disability_PropertyTaxes = c.Boolean(),
                        case_Disability_HomeIns = c.Boolean(),
                        case_Disability_Association = c.Boolean(),
                        case_Disability_DivorceCert = c.Boolean(),
                        case_Disability_MarriageCert = c.Boolean(),
                        case_Disability_RentLtr = c.Boolean(),
                        case_Disability_MedRecs = c.Boolean(),
                        case_Disability_MentalEval = c.Boolean(),
                        case_Disability_FoodStamps = c.Boolean(),
                        case_Disability_ChildSuppLtr = c.Boolean(),
                        deleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.case_ID);
            
            CreateTable(
                "dbo.tbl_ClinicalConditions",
                c => new
                    {
                        clc_ID = c.Long(nullable: false, identity: true),
                        dmg_ID = c.Long(nullable: false),
                        clc_Cancer = c.Boolean(),
                        clc_Metastasi = c.Boolean(),
                        clc_OnsetDate = c.DateTime(),
                        clc_Condition = c.String(),
                        clc_MentalEval = c.Boolean(),
                        clc_MentalEvalGiven = c.String(),
                        clc_MentalEvalReturned = c.String(),
                        clc_Diagnosis = c.String(),
                        deleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.clc_ID);
            
            CreateTable(
                "dbo.tbl_Comments",
                c => new
                    {
                        cmt_ID = c.Long(nullable: false, identity: true),
                        dmg_ID = c.Long(nullable: false),
                        cmt_Date = c.DateTime(),
                        cmt_Notes = c.String(),
                        deleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.cmt_ID);
            
            CreateTable(
                "dbo.tbl_ConsultationPmts",
                c => new
                    {
                        cpmt_ID = c.Long(nullable: false, identity: true),
                        cnl_ID = c.Long(nullable: false),
                        cpmt_Date = c.DateTime(),
                        cpmt_Type = c.String(),
                        cpmt_Info = c.String(),
                        cpmt_Amount = c.Double(),
                        cpmt_WriteOff = c.Double(),
                        deleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.cpmt_ID);
            
            CreateTable(
                "dbo.tbl_Consultations",
                c => new
                    {
                        cnl_ID = c.Long(nullable: false, identity: true),
                        cnl_Amount = c.Double(),
                        cnl_Charity = c.Boolean(),
                        cnl_AdminApproved = c.Boolean(),
                        cnl_Date = c.DateTime(),
                        cnl_FirstName = c.String(),
                        cnl_LastName = c.String(),
                        cnl_MiddleName = c.String(),
                        cnl_Address1 = c.String(),
                        cnl_Address2 = c.String(),
                        cnl_City = c.String(),
                        cnl_State = c.String(),
                        cnl_Zip = c.String(),
                        cnl_ResidentAddress = c.String(),
                        cnl_ResidentCity = c.String(),
                        cnl_ResidentState = c.String(),
                        cnl_ResidentZip = c.String(),
                        cnl_Phone = c.String(),
                        cnl_Cell = c.String(),
                        cnl_DOB = c.DateTime(),
                        cnl_Age = c.Int(),
                        cnl_SSN = c.String(),
                        cnl_Height = c.String(),
                        cnl_Weight = c.Double(),
                        cnl_Gender = c.String(),
                        deleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.cnl_ID);
            
            CreateTable(
                "dbo.tbl_Contacts",
                c => new
                    {
                        cnt_ID = c.Long(nullable: false, identity: true),
                        dmg_ID = c.Long(nullable: false),
                        cnt_Relationship = c.String(),
                        cnt_FName = c.String(),
                        cnt_LName = c.String(),
                        cnt_Address = c.String(),
                        cnt_City = c.String(),
                        cnt_State = c.String(),
                        cnt_Zip = c.String(),
                        cnt_Phone = c.String(),
                        deleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.cnt_ID);
            
            CreateTable(
                "dbo.tbl_DCF",
                c => new
                    {
                        dcf_ID = c.Long(nullable: false, identity: true),
                        dmg_ID = c.Long(nullable: false),
                        dcf_EmaForm = c.Boolean(),
                        dcf_BillTracking = c.Boolean(),
                        dcf_Medicaid = c.Boolean(),
                        dcf_MedicallyNeeded = c.Boolean(),
                        dcf_QMB = c.Boolean(),
                        dcf_SLMB = c.Boolean(),
                        dcf_MedicareSecondary = c.Boolean(),
                        dcf_Posthumous = c.Boolean(),
                        dcf_MedicalRecords = c.Boolean(),
                        dcf_IncomeforEveryone = c.Boolean(),
                        dcf_IncomeforClient = c.Boolean(),
                        dcf_IDforPatient = c.Boolean(),
                        dcf_ImmigrationDocs = c.Boolean(),
                        dcf_2514Form = c.Boolean(),
                        dcf_2613Form = c.Boolean(),
                        dcf_FinancialRelease = c.Boolean(),
                        dcf_CarStatement = c.Boolean(),
                        dcf_ChildSupportProof = c.Boolean(),
                        dcf_LongTermCareInfo = c.Boolean(),
                        dcf_OnlineAccessNo = c.String(),
                        dcf_OnlineAccessDate = c.DateTime(),
                        dcf_CaseNo = c.String(),
                        dcf_DateOfMedicaidApplication = c.DateTime(),
                        dcf_PinNo = c.String(),
                        dcf_CaseWorkerName = c.String(),
                        dcf_CaseWorkerPhone = c.String(),
                        dcf_DateApplicationDenial = c.DateTime(),
                        dcf_DateApplicationreSubmitted = c.DateTime(),
                        dcf_Notes = c.String(),
                        dcf_SOC = c.String(),
                        dcf_FSValue = c.String(),
                        dcf_FS = c.Boolean(),
                        dcf_2039Form = c.Boolean(),
                        dcf_IBForm = c.Boolean(),
                        dcf_DisabilityReport = c.Boolean(),
                        dcf_Passport = c.Boolean(),
                        dcf_PayStubs = c.Boolean(),
                        dcf_SocialSecurityCard = c.Boolean(),
                        dcf_BankStatement = c.Boolean(),
                        dcf_HouseExpenses = c.Boolean(),
                        deleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.dcf_ID);
            
            CreateTable(
                "dbo.tbl_DDSA",
                c => new
                    {
                        ddsa_ID = c.Long(nullable: false, identity: true),
                        dmg_ID = c.Long(nullable: false),
                        ddsa_AdjudicatorName = c.String(),
                        ddsa_AdjudicatorPhone = c.String(),
                        ddsa_AdjudicatorPhoneExt = c.String(),
                        ddsa_Address = c.String(),
                        ddsa_WorkHistory = c.Boolean(),
                        ddsa_WorkHistoryDate = c.DateTime(),
                        ddsa_ADL = c.Boolean(),
                        ddsa_ADLDate = c.DateTime(),
                        ddsa_ThirdPartyADL = c.Boolean(),
                        ddsa_ThirdPartyADLDate = c.DateTime(),
                        ddsa_ContactList = c.Boolean(),
                        ddsa_ContactListDate = c.DateTime(),
                        ddsa_Physician = c.Boolean(),
                        ddsa_PhysicianDate = c.DateTime(),
                        ddsa_PainQuestionaire = c.Boolean(),
                        ddsa_PainQuestionaireDate = c.DateTime(),
                        ddsa_Anxiety = c.Boolean(),
                        ddsa_AnxietyDate = c.DateTime(),
                        ddsa_PanicAttack = c.Boolean(),
                        ddsa_PanicAttackDate = c.DateTime(),
                        ddsa_Cardiac = c.Boolean(),
                        ddsa_CardiacDate = c.DateTime(),
                        ddsa_Neuropathy = c.Boolean(),
                        ddsa_NeuropathyDate = c.DateTime(),
                        ddsa_NeuropathyRpt = c.Boolean(),
                        ddsa_NeuropathyRptDate = c.DateTime(),
                        ddsa_IQ = c.Boolean(),
                        ddsa_IQDate = c.DateTime(),
                        ddsa_Eye = c.Boolean(),
                        ddsa_EyeDate = c.DateTime(),
                        ddsa_Teacher = c.Boolean(),
                        ddsa_TeacherDate = c.DateTime(),
                        ddsa_SSA3820 = c.Boolean(),
                        ddsa_SSA3820Date = c.DateTime(),
                        ddsa_ReportCard = c.Boolean(),
                        ddsa_ReportCardDate = c.DateTime(),
                        ddsa_SchoolWorksheet = c.Boolean(),
                        ddsa_SchoolWorksheetDate = c.DateTime(),
                        ddsa_Counselor = c.Boolean(),
                        ddsa_CounselorDate = c.DateTime(),
                        ddsa_MedRecSentFrom = c.String(),
                        ddsa_MedRecDate = c.DateTime(),
                        ddsa_OnsetDate = c.DateTime(),
                        ddsa_ApprovalDate = c.DateTime(),
                        ddsa_Notes = c.String(),
                        ddsa_ReleaseFormDueDate = c.DateTime(),
                        ddsa_SeizureRptDate = c.DateTime(),
                        ddsa_SeizureRpt = c.Boolean(),
                        ddsa_HeadacheRpt = c.Boolean(),
                        ddsa_HeadacheRptDate = c.DateTime(),
                        ddsa_MSRFCRpt = c.Boolean(),
                        ddsa_MSRFCRptDate = c.DateTime(),
                        deleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.ddsa_ID);
            
            CreateTable(
                "dbo.tbl_DDS",
                c => new
                    {
                        dds_ID = c.Long(nullable: false, identity: true),
                        dmg_ID = c.Long(nullable: false),
                        dds_AdjudicatorName = c.String(),
                        dds_AdjudicatorPhone = c.String(),
                        dds_AdjudicatorPhoneExt = c.String(),
                        dds_Address = c.String(),
                        dds_WorkHistory = c.Boolean(),
                        dds_WorkHistoryDate = c.DateTime(),
                        dds_ADL = c.Boolean(),
                        dds_ADLDate = c.DateTime(),
                        dds_ThirdPartyADL = c.Boolean(),
                        dds_ThirdPartyADLDate = c.DateTime(),
                        dds_ContactList = c.Boolean(),
                        dds_ContactListDate = c.DateTime(),
                        dds_Physician = c.Boolean(),
                        dds_PhysicianDate = c.DateTime(),
                        dds_PainQuestionaire = c.Boolean(),
                        dds_PainQuestionaireDate = c.DateTime(),
                        dds_Anxiety = c.Boolean(),
                        dds_AnxietyDate = c.DateTime(),
                        dds_PanicAttack = c.Boolean(),
                        dds_PanicAttackDate = c.DateTime(),
                        dds_Cardiac = c.Boolean(),
                        dds_CardiacDate = c.DateTime(),
                        dds_Neuropathy = c.Boolean(),
                        dds_NeuropathyDate = c.DateTime(),
                        dds_NeuropathyRpt = c.Boolean(),
                        dds_NeuropathyRptDate = c.DateTime(),
                        dds_IQ = c.Boolean(),
                        dds_IQDate = c.DateTime(),
                        dds_Eye = c.Boolean(),
                        dds_EyeDate = c.DateTime(),
                        dds_Teacher = c.Boolean(),
                        dds_TeacherDate = c.DateTime(),
                        dds_SSA3820 = c.Boolean(),
                        dds_SSA3820Date = c.DateTime(),
                        dds_ReportCard = c.Boolean(),
                        dds_ReportCardDate = c.DateTime(),
                        dds_SchoolWorksheet = c.Boolean(),
                        dds_SchoolWorksheetDate = c.DateTime(),
                        dds_Counselor = c.Boolean(),
                        dds_CounselorDate = c.DateTime(),
                        dds_MedRecSentFrom = c.String(),
                        dds_MedRecDate = c.DateTime(),
                        dds_OnsetDate = c.DateTime(),
                        dds_ApprovalDate = c.DateTime(),
                        dds_Notes = c.String(),
                        dds_ReleaseFormDueDate = c.DateTime(),
                        dds_SeizureRptDate = c.DateTime(),
                        dds_SeizureRpt = c.Boolean(),
                        dds_HeadacheRpt = c.Boolean(),
                        dds_HeadacheRptDate = c.DateTime(),
                        dds_MSRFCRpt = c.Boolean(),
                        dds_MSRFCRptDate = c.DateTime(),
                        deleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.dds_ID);
            
            CreateTable(
                "dbo.tbl_Demographics",
                c => new
                    {
                        dmg_ID = c.Long(nullable: false, identity: true),
                        case_ID = c.Long(nullable: false),
                        dmg_OtherNameOpt = c.Boolean(),
                        dmg_OtherName = c.String(),
                        dmg_Race = c.String(),
                        dmg_LastSchoolGrade = c.String(),
                        dmg_LastSchoolYear = c.String(),
                        dmg_PrefLangEn = c.Boolean(),
                        dmg_PrefLangSP = c.Boolean(),
                        dmg_PrefLangCR = c.Boolean(),
                        dmg_PlaceBorn = c.String(),
                        dmg_Homeless = c.Boolean(),
                        dmg_FirstName = c.String(),
                        dmg_LastName = c.String(),
                        dmg_MiddleName = c.String(),
                        dmg_Address = c.String(),
                        dmg_Address2 = c.String(),
                        dmg_City = c.String(),
                        dmg_State = c.String(),
                        dmg_Zip = c.String(),
                        dmg_ResidentAddress = c.String(),
                        dmg_ResidentCity = c.String(),
                        dmg_ResidentState = c.String(),
                        dmg_ResidentZip = c.String(),
                        dmg_HomePhone = c.String(),
                        dmg_CellPhone = c.String(),
                        dmg_DOB = c.DateTime(nullable: false),
                        dmg_Age = c.Int(),
                        dmg_SSN = c.String(),
                        dmg_Height = c.String(),
                        dmg_Weight = c.Double(),
                        dmg_Gender = c.String(),
                        deleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.dmg_ID);
            
            CreateTable(
                "dbo.tbl_Employment",
                c => new
                    {
                        emp_ID = c.Long(nullable: false, identity: true),
                        wh_ID = c.Long(nullable: false),
                        emp_Employer = c.String(),
                        emp_BusinessType = c.String(),
                        emp_Address = c.String(),
                        emp_Began = c.String(),
                        emp_End = c.String(),
                        emp_Contact = c.String(),
                        emp_Phone = c.String(),
                        emp_Hours = c.String(),
                        emp_Days = c.String(),
                        emp_PayRate = c.String(),
                        emp_MonthlyEarnings = c.Double(),
                        emp_JobTitle = c.String(),
                        deleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.emp_ID);
            
            CreateTable(
                "dbo.tbl_Facilities",
                c => new
                    {
                        fac_ID = c.Long(nullable: false, identity: true),
                        fac_Name = c.String(),
                        fac_Address = c.String(),
                        fac_City = c.String(),
                        fac_State = c.String(),
                        fac_Zip = c.String(),
                        fac_Phone = c.String(),
                        fac_Fax = c.String(),
                        fac_Perdiem = c.Double(),
                        fac_Percent = c.Double(),
                        fac_Active = c.Boolean(),
                        deleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.fac_ID);
            
            CreateTable(
                "dbo.tbl_Financials",
                c => new
                    {
                        fin_ID = c.Long(nullable: false, identity: true),
                        dmg_ID = c.Long(nullable: false),
                        fin_BankName = c.String(),
                        fin_Address = c.String(),
                        fin_City = c.String(),
                        fin_State = c.String(),
                        fin_Zip = c.String(),
                        fin_AccountType = c.String(),
                        fin_RoutingNo = c.String(),
                        fin_AccountNo = c.String(),
                        fin_JointPerson = c.String(),
                        fin_Balance = c.Double(),
                        fin_ClosedDate = c.DateTime(),
                        deleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.fin_ID);
            
            CreateTable(
                "dbo.tbl_GroupRights",
                c => new
                    {
                        gr_ID = c.Long(nullable: false, identity: true),
                        grp_ID = c.Long(nullable: false),
                        gr_AccessCalendar = c.Boolean(),
                        gr_AddAppointments = c.Boolean(),
                        gr_EditAppointments = c.Boolean(),
                        gr_DeleteAppointments = c.Boolean(),
                        gr_AccessAdultInterview = c.Boolean(),
                        gr_AddAdultInterview = c.Boolean(),
                        gr_EditAdultInterview = c.Boolean(),
                        gr_DeleteAdultInterview = c.Boolean(),
                        gr_AccessChildInterview = c.Boolean(),
                        gr_AddChildInterview = c.Boolean(),
                        gr_EditChildInterview = c.Boolean(),
                        gr_DeleteChildInterview = c.Boolean(),
                        gr_AccessSocialSecurity = c.Boolean(),
                        gr_AddSocialSecurity = c.Boolean(),
                        gr_EditSocialSecurity = c.Boolean(),
                        gr_DeleteSocialSecurity = c.Boolean(),
                        gr_AccessAdultDDS = c.Boolean(),
                        gr_AddAdultDDS = c.Boolean(),
                        gr_EditAdultDDS = c.Boolean(),
                        gr_DeleteAdultDDS = c.Boolean(),
                        gr_AccessChildDDS = c.Boolean(),
                        gr_AddChildDDS = c.Boolean(),
                        gr_EditChildDDS = c.Boolean(),
                        gr_DeleteChildDDS = c.Boolean(),
                        gr_AccessAccountsReceivables = c.Boolean(),
                        gr_AddAccountsReceivables = c.Boolean(),
                        gr_EditAccountsReceivables = c.Boolean(),
                        gr_DeleteAccountsReceivables = c.Boolean(),
                        gr_AccessPatientInvoices = c.Boolean(),
                        gr_AccessHospitalInvoices = c.Boolean(),
                        gr_AccessReports = c.Boolean(),
                        gr_AccessHospitalInfo = c.Boolean(),
                        gr_AddHospitalInfo = c.Boolean(),
                        gr_EditHospitalInfo = c.Boolean(),
                        gr_DeleteHospitalInfo = c.Boolean(),
                        gr_AccessAdministration = c.Boolean(),
                        gr_AccessUsers = c.Boolean(),
                        gr_AddUsers = c.Boolean(),
                        gr_EditUsers = c.Boolean(),
                        gr_DeleteUsers = c.Boolean(),
                        gr_AccessGroups = c.Boolean(),
                        gr_AddGroups = c.Boolean(),
                        gr_EditGroups = c.Boolean(),
                        gr_DeleteGroups = c.Boolean(),
                        gr_AccessMembersOf = c.Boolean(),
                        gr_AddMembers = c.Boolean(),
                        gr_DeleteMembers = c.Boolean(),
                        gr_AccessUserRights = c.Boolean(),
                        gr_EditUserRights = c.Boolean(),
                        gr_AccessGroupRights = c.Boolean(),
                        gr_EditGroupRights = c.Boolean(),
                        gr_AddContactInfo = c.Boolean(),
                        gr_EditContactInfo = c.Boolean(),
                        gr_DeleteContactInfo = c.Boolean(),
                        gr_AddHouseHoldResident = c.Boolean(),
                        gr_EditHouseHoldResident = c.Boolean(),
                        gr_DeleteHouseHoldResident = c.Boolean(),
                        gr_AddFinancialInfo = c.Boolean(),
                        gr_EditFinancialInfo = c.Boolean(),
                        gr_DeleteFinancialInfo = c.Boolean(),
                        gr_AddCarsOwned = c.Boolean(),
                        gr_EditCarsOwned = c.Boolean(),
                        gr_DeleteCarsOwned = c.Boolean(),
                        gr_AddEmployerInfo = c.Boolean(),
                        gr_EditEmployerInfo = c.Boolean(),
                        gr_DeleteEmployerInfo = c.Boolean(),
                        gr_AddPhysicianInfo = c.Boolean(),
                        gr_EditPhysicianInfo = c.Boolean(),
                        gr_DeletePhysicianInfo = c.Boolean(),
                        gr_AddMedications = c.Boolean(),
                        gr_EditMedications = c.Boolean(),
                        gr_DeleteMedications = c.Boolean(),
                        gr_AddHospitals = c.Boolean(),
                        gr_EditHospitals = c.Boolean(),
                        gr_DeleteHospitals = c.Boolean(),
                        gr_AddComments = c.Boolean(),
                        gr_EditComments = c.Boolean(),
                        gr_DeleteComments = c.Boolean(),
                        gr_AccessConsultation = c.Boolean(),
                        gr_AddConsultation = c.Boolean(),
                        gr_EditConsultation = c.Boolean(),
                        gr_DelConsultation = c.Boolean(),
                        deleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.gr_ID);
            
            CreateTable(
                "dbo.tbl_Groups",
                c => new
                    {
                        grp_ID = c.Long(nullable: false, identity: true),
                        grp_Name = c.String(),
                        grp_Created = c.DateTime(),
                        grp_Modified = c.DateTime(),
                        deleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.grp_ID);
            
            CreateTable(
                "dbo.tbl_HospitalInfo",
                c => new
                    {
                        hosp_ID = c.Long(nullable: false, identity: true),
                        dmg_ID = c.Long(nullable: false),
                        fac_ID = c.Long(),
                        hosp_StatusID = c.Int(),
                        hosp_ChartNo = c.String(),
                        hosp_Admission = c.String(),
                        hosp_Discharge = c.String(),
                        hosp_Reason = c.String(),
                        hosp_Notes = c.String(),
                        hosp_Recipient = c.String(),
                        hosp_AnticipatedRecovery = c.Double(),
                        hosp_Referred = c.String(),
                        hosp_Balance = c.Double(),
                        hosp_Account = c.String(),
                        hosp_ApplyDate = c.DateTime(),
                        hosp_CaseType = c.String(),
                        hosp_DateInvoiced = c.DateTime(),
                        hosp_DateMMSPaid = c.DateTime(),
                        hosp_StatusDate = c.DateTime(),
                        hosp_MMSAntRecv = c.Double(),
                        hosp_StatusList = c.String(),
                        hosp_Name = c.String(),
                        deleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.hosp_ID);
            
            CreateTable(
                "dbo.tbl_Householdresidents",
                c => new
                    {
                        hour_ID = c.Long(nullable: false, identity: true),
                        hou_ID = c.Long(nullable: false),
                        hour_Name = c.String(),
                        hour_Relationship = c.String(),
                        hour_DOB = c.DateTime(),
                        hour_Disabled = c.Boolean(),
                        hour_Married = c.Boolean(),
                        hour_Student = c.Boolean(),
                        hour_Minor = c.Boolean(),
                        deleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.hour_ID);
            
            CreateTable(
                "dbo.tbl_HouseHold",
                c => new
                    {
                        hou_ID = c.Long(nullable: false, identity: true),
                        dmg_ID = c.Long(nullable: false),
                        hou_Type = c.Int(),
                        hou_AssocName = c.String(),
                        hou_AssocAddress = c.String(),
                        hou_AssocCity = c.String(),
                        hou_AssocState = c.String(),
                        hou_AssocZip = c.String(),
                        hou_AssocPhone = c.String(),
                        hou_AssocFees = c.Double(),
                        hou_InsName = c.String(),
                        hou_InsAddress = c.String(),
                        hou_InsCity = c.String(),
                        hou_InsState = c.String(),
                        hou_InsZip = c.String(),
                        hou_Insphone = c.String(),
                        hou_InsFees = c.Double(),
                        hou_LandLordName = c.String(),
                        hou_LandLordAddress = c.String(),
                        hou_LandLordCity = c.String(),
                        hou_LandLordState = c.String(),
                        hou_LandLordZip = c.String(),
                        hou_LandLordPhone = c.String(),
                        hou_MtgBankName = c.String(),
                        hou_MtgAddress = c.String(),
                        hou_MtgCity = c.String(),
                        hou_MtgState = c.String(),
                        hou_MtgZip = c.String(),
                        hou_MtgPhone = c.String(),
                        hou_MtgPropertyTaxes = c.Double(),
                        hou_ExpensesElectricity = c.Double(),
                        hou_ExpensesWater = c.Double(),
                        hou_ExpensesGarbage = c.Double(),
                        hou_ExpensesFoodStamps = c.Double(),
                        hou_ExpensesChildSupp = c.Double(),
                        hou_ExpensesChildSuppType = c.Int(),
                        hou_Childrenunder18 = c.Boolean(),
                        hou_Childrenunder22 = c.Boolean(),
                        hou_Notes = c.String(),
                        hou_ExpensesRent = c.Double(),
                        deleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.hou_ID);
            
            CreateTable(
                "dbo.tbl_Image",
                c => new
                    {
                        img_ID = c.Long(nullable: false, identity: true),
                        dmg_ID = c.Long(nullable: false),
                        img_Image = c.String(),
                        deleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.img_ID);
            
            CreateTable(
                "dbo.tbl_Immigration",
                c => new
                    {
                        imm_ID = c.Long(nullable: false, identity: true),
                        dmg_ID = c.Long(nullable: false),
                        imm_Status = c.Int(),
                        imm_DateArrivedinUS = c.DateTime(),
                        imm_Proof = c.Boolean(),
                        imm_AlienNo = c.String(),
                        imm_ResidencyDate = c.DateTime(),
                        imm_ResidentCategory = c.String(),
                        imm_NaturalizationDate = c.DateTime(),
                        imm_NaturalizationCert = c.String(),
                        imm_CitizenshipDate = c.DateTime(),
                        imm_Passport = c.String(),
                        deleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.imm_ID);
            
            CreateTable(
                "dbo.tbl_Insurance",
                c => new
                    {
                        ins_ID = c.Long(nullable: false, identity: true),
                        dmg_ID = c.Long(nullable: false),
                        ins_Medicare = c.Boolean(),
                        ins_PartA = c.Boolean(),
                        ins_PartB = c.Boolean(),
                        ins_Medicaid = c.Boolean(),
                        ins_MedicaidSharedCost = c.Boolean(),
                        ins_MedicaidSharedCostAmt = c.Double(),
                        ins_MedicaidIDNo = c.String(),
                        ins_Life = c.Boolean(),
                        ins_LifeName = c.String(),
                        ins_LifePolicyNo = c.String(),
                        ins_HMO = c.Boolean(),
                        ins_HMOName = c.String(),
                        ins_HMOPolicyNo = c.String(),
                        ins_PPO = c.Boolean(),
                        ins_PPOName = c.String(),
                        ins_PPOPolicyNo = c.String(),
                        ins_MedicalPlan = c.Boolean(),
                        ins_MedicalPlanName = c.String(),
                        ins_MedicalPlanPolicyNo = c.String(),
                        ins_Obamacare = c.Boolean(),
                        ins_ObamacarePlanName = c.String(),
                        ins_ObamacarePolicyNo = c.String(),
                        deleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.ins_ID);
            
            CreateTable(
                "dbo.tbl_MaritalStatus",
                c => new
                    {
                        mrs_ID = c.Long(nullable: false, identity: true),
                        dmg_ID = c.Long(nullable: false),
                        mrs_Married = c.Boolean(),
                        mrs_SpouseName = c.String(),
                        mrs_SpouseDOB = c.String(),
                        mrs_SpouseAge = c.Int(),
                        mrs_SpouseSSN = c.String(),
                        mrs_MarriagePlace = c.String(),
                        mrs_Proof = c.Boolean(),
                        mrs_Status = c.Int(),
                        mrs_StatusDate = c.DateTime(),
                        mrs_SpouseWages = c.Double(),
                        mrs_SpouseWageType = c.String(),
                        mrs_SpouseEmployed = c.Boolean(),
                        mrs_SpouseEmployer = c.String(),
                        mrs_SpouseEmployerAddress = c.String(),
                        mrs_SpouseEmployerCity = c.String(),
                        mrs_SpouseEmployerState = c.String(),
                        mrs_SpouseEmployerZip = c.String(),
                        mrs_SpouseEmployerPhone = c.String(),
                        mrs_Notes = c.String(),
                        mrs_SpouseUnpStart = c.String(),
                        mrs_SpouseUnpEnd = c.String(),
                        mrs_SpouseUnpAmt = c.Double(),
                        mrs_SpouseDisabilityStart = c.String(),
                        mrs_SpouseDisabilityEnd = c.String(),
                        mrs_SpouseDisabilityAmt = c.Double(),
                        deleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.mrs_ID);
            
            CreateTable(
                "dbo.tbl_Medications",
                c => new
                    {
                        med_ID = c.Long(nullable: false, identity: true),
                        dmg_ID = c.Long(nullable: false),
                        med_Name = c.String(),
                        med_Dosage = c.String(),
                        med_PrescribingPhysician = c.String(),
                        med_Reason = c.String(),
                        med_SideEffect = c.String(),
                        deleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.med_ID);
            
            CreateTable(
                "dbo.tbl_Membersof",
                c => new
                    {
                        grp_ID = c.Long(nullable: false),
                        usr_ID = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.grp_ID, t.usr_ID });
            
            CreateTable(
                "dbo.tbl_Payments",
                c => new
                    {
                        pmt_ID = c.Long(nullable: false, identity: true),
                        pmt_ReceivableID = c.Long(),
                        pmt_Type = c.Int(),
                        pmt_Date = c.DateTime(),
                        pmt_PaidinFull = c.Boolean(),
                        pmt_NoRetroAmt = c.Double(),
                        pmt_Method = c.String(),
                        pmt_Info = c.String(),
                        pmt_Amount = c.Double(),
                        deleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.pmt_ID);
            
            CreateTable(
                "dbo.tbl_Physicians",
                c => new
                    {
                        phy_ID = c.Long(nullable: false, identity: true),
                        dmg_ID = c.Long(nullable: false),
                        phy_Name = c.String(),
                        phy_Specialty = c.String(),
                        phy_Address = c.String(),
                        phy_Phone = c.String(),
                        phy_Fax = c.String(),
                        phy_FirstVisit = c.String(),
                        phy_LastVisit = c.String(),
                        phy_NextVisit = c.String(),
                        phy_MedRecRequested = c.String(),
                        phy_MedRecReceived = c.String(),
                        phy_MedRecPaid = c.String(),
                        phy_Treatment = c.String(),
                        deleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.phy_ID);
            
            CreateTable(
                "dbo.tbl_ReportRightsUsers",
                c => new
                    {
                        rpt_ID = c.Long(nullable: false),
                        usr_ID = c.Long(nullable: false),
                        rpt_CanAccess = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => new { t.rpt_ID, t.usr_ID });
            
            CreateTable(
                "dbo.tbl_Reports",
                c => new
                    {
                        rpt_ID = c.Long(nullable: false, identity: true),
                        rpt_Name = c.String(),
                        rpt_Description = c.String(),
                        rpt_Path = c.String(),
                        rpt_Enabled = c.Boolean(),
                        rpt_CanAccess = c.Boolean(),
                        deleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.rpt_ID);
            
            CreateTable(
                "dbo.tbl_SchoolInfo",
                c => new
                    {
                        sch_ID = c.Long(nullable: false, identity: true),
                        dmg_ID = c.Long(nullable: false),
                        sch_ParentMakingPmt = c.String(),
                        sch_SchoolName = c.String(),
                        sch_Address = c.String(),
                        sch_City = c.String(),
                        sch_State = c.String(),
                        sch_Zip = c.String(),
                        sch_Phone = c.String(),
                        sch_Grade = c.String(),
                        sch_Teacher = c.String(),
                        sch_MotherName = c.String(),
                        sch_MotherDOB = c.String(),
                        sch_MotherSSN = c.String(),
                        sch_MotherUnemployment = c.Boolean(),
                        sch_MotherUnpAmt = c.Double(),
                        sch_MotherUnpStartDate = c.DateTime(),
                        sch_MotherUnpEndDate = c.DateTime(),
                        sch_MotherEmployed = c.Boolean(),
                        sch_MotherEmployername = c.String(),
                        sch_MotherEmployerAddress = c.String(),
                        sch_MotherEmployerCity = c.String(),
                        sch_MotherEmployerState = c.String(),
                        sch_MotherEmployerZip = c.String(),
                        sch_MotherEmploymentStartDate = c.DateTime(),
                        sch_MotherEmploymentEndDate = c.DateTime(),
                        sch_MotherDateLastPaid = c.DateTime(),
                        sch_MotherSalary = c.Double(),
                        sch_MotherSalaryRate = c.String(),
                        sch_MotherMedicaid = c.Boolean(),
                        sch_MotherHealthIns = c.String(),
                        sch_MotherPolicy = c.String(),
                        sch_FatherName = c.String(),
                        sch_FatherDOB = c.String(),
                        sch_FatherSSN = c.String(),
                        sch_FatherUnemployment = c.Boolean(),
                        sch_FatherUnpAmt = c.Double(),
                        sch_FatherUnpStartDate = c.DateTime(),
                        sch_FatherUnpEndDate = c.DateTime(),
                        sch_FatherEmployed = c.Boolean(),
                        sch_FatherEmployername = c.String(),
                        sch_FatherEmployerAddress = c.String(),
                        sch_FatherEmployerCity = c.String(),
                        sch_FatherEmployerState = c.String(),
                        sch_FatherEmployerZip = c.String(),
                        sch_FatherEmploymentStartDate = c.DateTime(),
                        sch_FatherEmploymentEndDate = c.DateTime(),
                        sch_FatherDateLastPaid = c.DateTime(),
                        sch_FatherSalary = c.Double(),
                        sch_FatherSalaryRate = c.String(),
                        sch_FatherMedicaid = c.String(),
                        sch_FatherHealthIns = c.String(),
                        sch_FatherPolicy = c.String(),
                        sch_ParentsLivingTogether = c.Boolean(),
                        sch_ParentsMarried = c.Boolean(),
                        sch_SeparatedDate = c.DateTime(),
                        sch_DivorcedDate = c.DateTime(),
                        deleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.sch_ID);
            
            CreateTable(
                "dbo.tbl_SocialSecurity",
                c => new
                    {
                        ss_ID = c.Long(nullable: false, identity: true),
                        dmg_ID = c.Long(nullable: false),
                        ss_OnlineReentry = c.String(),
                        ss_AppealReentry = c.String(),
                        ss_DateProcessOnlineReentry = c.DateTime(),
                        ss_ApplicationNo = c.String(),
                        ss_DateProcessApplication = c.DateTime(),
                        ss_NameExaminer16 = c.String(),
                        ss_PhoneExaminer16 = c.String(),
                        ss_PhoneExtExaminer16 = c.String(),
                        ss_NameExaminer2 = c.String(),
                        ss_Phoneexaminer2 = c.String(),
                        ss_PhoneExtExaminer2 = c.String(),
                        ss_PerkDate = c.DateTime(),
                        ss_SSAAppointmentDate = c.DateTime(),
                        ss_ApprovalDate = c.DateTime(),
                        ss_Notes = c.String(),
                        ss_ClaimAddress = c.String(),
                        ss_ClaimCity = c.String(),
                        ss_ClaimState = c.String(),
                        ss_ClaimZip = c.String(),
                        ss_SSAPhone = c.String(),
                        ss_FirstInitial = c.Boolean(),
                        ss_Appeal = c.Boolean(),
                        ss_Hearing = c.Boolean(),
                        ss_SSIClaim = c.Boolean(),
                        ss_SSDIClaim = c.Boolean(),
                        ss_Concurrent = c.Boolean(),
                        ss_ByAge = c.Boolean(),
                        ss_OnsetDate = c.DateTime(),
                        deleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.ss_ID);
            
            CreateTable(
                "dbo.tbl_UserRights",
                c => new
                    {
                        ur_ID = c.Long(nullable: false, identity: true),
                        usr_ID = c.Long(nullable: false),
                        ur_AccessCalendar = c.Boolean(),
                        ur_AddAppointments = c.Boolean(),
                        ur_EditAppointments = c.Boolean(),
                        ur_DeleteAppointments = c.Boolean(),
                        ur_AccessAdultInterview = c.Boolean(),
                        ur_AddAdultInterview = c.Boolean(),
                        ur_EditAdultInterview = c.Boolean(),
                        ur_DeleteAdultInterview = c.Boolean(),
                        ur_AccessChildInterview = c.Boolean(),
                        ur_AddChildInterview = c.Boolean(),
                        ur_EditChildInterview = c.Boolean(),
                        ur_DeleteChildInterview = c.Boolean(),
                        ur_AccessSocialSecurity = c.Boolean(),
                        ur_AddSocialSecurity = c.Boolean(),
                        ur_EditSocialSecurity = c.Boolean(),
                        ur_DeleteSocialSecurity = c.Boolean(),
                        ur_AccessAdultDDS = c.Boolean(),
                        ur_AddAdultDDS = c.Boolean(),
                        ur_EditAdultDDS = c.Boolean(),
                        ur_DeleteAdultDDS = c.Boolean(),
                        ur_AccessChildDDS = c.Boolean(),
                        ur_AddChildDDS = c.Boolean(),
                        ur_EditChildDDS = c.Boolean(),
                        ur_DeleteChildDDS = c.Boolean(),
                        ur_AccessAccountsReceivables = c.Boolean(),
                        ur_AddAccountsReceivables = c.Boolean(),
                        ur_EditAccountsReceivables = c.Boolean(),
                        ur_DeleteAccountsReceivables = c.Boolean(),
                        ur_AccessPatientInvoices = c.Boolean(),
                        ur_AccessHospitalInvoices = c.Boolean(),
                        ur_AccessReports = c.Boolean(),
                        ur_AccessHospitalInfo = c.Boolean(),
                        ur_AddHospitalInfo = c.Boolean(),
                        ur_EditHospitalInfo = c.Boolean(),
                        ur_DeleteHospitalInfo = c.Boolean(),
                        ur_AccessAdministration = c.Boolean(),
                        ur_AccessUsers = c.Boolean(),
                        ur_AddUsers = c.Boolean(),
                        ur_EditUsers = c.Boolean(),
                        ur_DeleteUsers = c.Boolean(),
                        ur_AccessGroups = c.Boolean(),
                        ur_AddGroups = c.Boolean(),
                        ur_EditGroups = c.Boolean(),
                        ur_DeleteGroups = c.Boolean(),
                        ur_AccessMembersOf = c.Boolean(),
                        ur_AddMembers = c.Boolean(),
                        ur_DeleteMembers = c.Boolean(),
                        ur_AccessUserRights = c.Boolean(),
                        ur_EditUserRights = c.Boolean(),
                        ur_AccessGroupRights = c.Boolean(),
                        ur_EditGroupRights = c.Boolean(),
                        ur_AddContactInfo = c.Boolean(),
                        ur_EditContactInfo = c.Boolean(),
                        ur_DeleteContactInfo = c.Boolean(),
                        ur_AddHouseHoldResident = c.Boolean(),
                        ur_EditHouseHoldResident = c.Boolean(),
                        ur_DeleteHouseHoldResident = c.Boolean(),
                        ur_AddFinancialInfo = c.Boolean(),
                        ur_EditFinancialInfo = c.Boolean(),
                        ur_DeleteFinancialInfo = c.Boolean(),
                        ur_AddCarsOwned = c.Boolean(),
                        ur_EditCarsOwned = c.Boolean(),
                        ur_DeleteCarsOwned = c.Boolean(),
                        ur_AddEmployerInfo = c.Boolean(),
                        ur_EditEmployerInfo = c.Boolean(),
                        ur_DeleteEmployerInfo = c.Boolean(),
                        ur_AddPhysicianInfo = c.Boolean(),
                        ur_EditPhysicianInfo = c.Boolean(),
                        ur_DeletePhysicianInfo = c.Boolean(),
                        ur_AddMedications = c.Boolean(),
                        ur_EditMedications = c.Boolean(),
                        ur_DeleteMedications = c.Boolean(),
                        ur_AddHospitals = c.Boolean(),
                        ur_EditHospitals = c.Boolean(),
                        ur_DeleteHospitals = c.Boolean(),
                        ur_AddComments = c.Boolean(),
                        ur_EditComments = c.Boolean(),
                        ur_DeleteComments = c.Boolean(),
                        ur_AccessConsultation = c.Boolean(),
                        ur_AddConsultation = c.Boolean(),
                        ur_EditConsultation = c.Boolean(),
                        ur_DelConsultation = c.Boolean(),
                        deleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.ur_ID);
            
            CreateTable(
                "dbo.tbl_Users",
                c => new
                    {
                        usr_ID = c.Long(nullable: false, identity: true),
                        usr_LoginName = c.String(),
                        usr_Password = c.String(),
                        usr_FullName = c.String(),
                        usr_Active = c.Boolean(),
                        usr_Created = c.DateTime(),
                        usr_Modified = c.DateTime(),
                        deleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.usr_ID);
            
            CreateTable(
                "dbo.tbl_WorkHistory",
                c => new
                    {
                        wh_ID = c.Long(nullable: false, identity: true),
                        dmg_ID = c.Long(nullable: false),
                        wh_Employed = c.Boolean(),
                        wh_Unemployment = c.Double(),
                        wh_UnemploymentStartDate = c.DateTime(),
                        wh_UnemploymentEndDate = c.DateTime(),
                        wh_DateLastworked = c.DateTime(),
                        wh_TotalEarningsLastYear = c.Double(),
                        wh_TotalEarningsthisYear = c.Double(),
                        wh_Type = c.Int(),
                        wh_SelfEmployed = c.Boolean(),
                        wh_SelfEmployedAmount = c.Double(),
                        wh_Notes = c.String(),
                        deleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.wh_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tbl_WorkHistory");
            DropTable("dbo.tbl_Users");
            DropTable("dbo.tbl_UserRights");
            DropTable("dbo.tbl_SocialSecurity");
            DropTable("dbo.tbl_SchoolInfo");
            DropTable("dbo.tbl_Reports");
            DropTable("dbo.tbl_ReportRightsUsers");
            DropTable("dbo.tbl_Physicians");
            DropTable("dbo.tbl_Payments");
            DropTable("dbo.tbl_Membersof");
            DropTable("dbo.tbl_Medications");
            DropTable("dbo.tbl_MaritalStatus");
            DropTable("dbo.tbl_Insurance");
            DropTable("dbo.tbl_Immigration");
            DropTable("dbo.tbl_Image");
            DropTable("dbo.tbl_HouseHold");
            DropTable("dbo.tbl_Householdresidents");
            DropTable("dbo.tbl_HospitalInfo");
            DropTable("dbo.tbl_Groups");
            DropTable("dbo.tbl_GroupRights");
            DropTable("dbo.tbl_Financials");
            DropTable("dbo.tbl_Facilities");
            DropTable("dbo.tbl_Employment");
            DropTable("dbo.tbl_Demographics");
            DropTable("dbo.tbl_DDS");
            DropTable("dbo.tbl_DDSA");
            DropTable("dbo.tbl_DCF");
            DropTable("dbo.tbl_Contacts");
            DropTable("dbo.tbl_Consultations");
            DropTable("dbo.tbl_ConsultationPmts");
            DropTable("dbo.tbl_Comments");
            DropTable("dbo.tbl_ClinicalConditions");
            DropTable("dbo.tbl_Cases");
            DropTable("dbo.tbl_Cars");
            DropTable("dbo.tbl_CarsOwned");
            DropTable("dbo.tbl_Appointments");
            DropTable("dbo.tbl_AccntReceivables");
        }
    }
}
