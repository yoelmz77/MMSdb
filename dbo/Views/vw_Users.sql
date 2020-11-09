USE [MMS]
GO

/****** Object:  View [dbo].[vw_Users]    Script Date: 10/21/2020 12:05:04 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[vw_Users]
AS
SELECT dbo.tbl_Users.usr_ID AS UserID, dbo.tbl_UserRights.ur_AccessCalendar AS AccessCalendar, dbo.tbl_UserRights.ur_AddAppointments AS AddAppointments, dbo.tbl_UserRights.ur_EditAppointments AS EditAppointments, 
                  dbo.tbl_UserRights.ur_DeleteAppointments AS DeleteAppointments, dbo.tbl_UserRights.ur_AccessAdultInterview AS AccessAdultInterview, dbo.tbl_UserRights.ur_AddAdultInterview AS AddAdultInterview, 
                  dbo.tbl_UserRights.ur_EditAdultInterview AS EditAdultInterview, dbo.tbl_UserRights.ur_DeleteAdultInterview AS DeleteAdultInterview, dbo.tbl_UserRights.ur_AccessChildInterview AS AccessChildInterview, 
                  dbo.tbl_UserRights.ur_AddChildInterview AS AddChildInterview, dbo.tbl_UserRights.ur_EditChildInterview AS EditChildInterview, dbo.tbl_UserRights.ur_DeleteChildInterview AS DeleteChildInterview, 
                  dbo.tbl_UserRights.ur_AccessSocialSecurity AS AccessSocialSecurity, dbo.tbl_UserRights.ur_EditSocialSecurity AS EditSocialSecurity, dbo.tbl_UserRights.ur_AddSocialSecurity AS AddSocialSecurity, 
                  dbo.tbl_UserRights.ur_DeleteSocialSecurity AS DeleteSocialSecurity, dbo.tbl_UserRights.ur_AccessAdultDDS AS AccessAdultDDS, dbo.tbl_UserRights.ur_AddAdultDDS AS AddAdultDDS, 
                  dbo.tbl_UserRights.ur_EditAdultDDS AS EditAdultDDS, dbo.tbl_UserRights.ur_DeleteAdultDDS AS DeleteAdultDDS, dbo.tbl_UserRights.ur_AccessChildDDS AS AccessChildDDS, dbo.tbl_UserRights.ur_AddChildDDS AS AddChildDDS, 
                  dbo.tbl_UserRights.ur_EditChildDDS AS EditChildDDS, dbo.tbl_UserRights.ur_DeleteChildDDS AS DeleteChildDDS, dbo.tbl_UserRights.ur_AccessAccountsReceivables AS AccessAccountsReceivables, 
                  dbo.tbl_UserRights.ur_AddAccountsReceivables AS AddAccountsReceivables, dbo.tbl_UserRights.ur_EditAccountsReceivables AS EditAccountsReceivables, 
                  dbo.tbl_UserRights.ur_DeleteAccountsReceivables AS DeleteAccountsReceivables, dbo.tbl_UserRights.ur_AccessPatientInvoices AS AccessPatientInvoices, dbo.tbl_UserRights.ur_AccessHospitalInvoices AS AccessHospitalInvoices, 
                  dbo.tbl_UserRights.ur_AccessReports AS AccessReports, dbo.tbl_UserRights.ur_AccessHospitalInfo AS AccessHospitalInfo, dbo.tbl_UserRights.ur_AddHospitalInfo AS AddHospitalInfo, 
                  dbo.tbl_UserRights.ur_EditHospitalInfo AS EditHospitalInfo, dbo.tbl_UserRights.ur_DeleteHospitalInfo AS DeleteHospitalInfo, dbo.tbl_UserRights.ur_AccessAdministration AS AccessAdministration, 
                  dbo.tbl_UserRights.ur_AccessUsers AS AccessUsers, dbo.tbl_UserRights.ur_AddUsers AS AddUsers, dbo.tbl_UserRights.ur_EditUsers AS EditUsers, dbo.tbl_UserRights.ur_DeleteUsers AS DeleteUsers, 
                  dbo.tbl_UserRights.ur_AccessGroups AS AccessGroups, dbo.tbl_UserRights.ur_AddGroups AS AddGroups, dbo.tbl_UserRights.ur_EditGroups AS EditGroups, dbo.tbl_UserRights.ur_DeleteGroups AS DeleteGroups, 
                  dbo.tbl_UserRights.ur_AccessMembersOf AS AccessMembersOf, dbo.tbl_UserRights.ur_AddMembers AS AddMembers, dbo.tbl_UserRights.ur_DeleteMembers AS DeleteMembers, 
                  dbo.tbl_UserRights.ur_AccessUserRights AS AccessUserRights, dbo.tbl_UserRights.ur_EditUserRights AS EditUserRights, dbo.tbl_UserRights.ur_AccessGroupRights AS AccessGroupRights, 
                  dbo.tbl_UserRights.ur_EditGroupRights AS EditGroupRights, dbo.tbl_UserRights.ur_AddContactInfo AS AddContactInfo, dbo.tbl_UserRights.ur_EditContactInfo AS EditContactInfo, 
                  dbo.tbl_UserRights.ur_DeleteContactInfo AS DeleteContactInfo, dbo.tbl_UserRights.ur_AddHouseHoldResident AS AddHouseHoldResident, dbo.tbl_UserRights.ur_EditHouseHoldResident AS EditHouseHoldResident, 
                  dbo.tbl_UserRights.ur_DeleteHouseHoldResident AS DeleteHouseHoldResident, dbo.tbl_UserRights.ur_AddFinancialInfo AS AddFinancialInfo, dbo.tbl_UserRights.ur_EditFinancialInfo AS EditFinancialInfo, 
                  dbo.tbl_UserRights.ur_DeleteFinancialInfo AS DeleteFinancialInfo, dbo.tbl_UserRights.ur_AddCarsOwned AS AddCarsOwned, dbo.tbl_UserRights.ur_EditCarsOwned AS EditCarsOwned, 
                  dbo.tbl_UserRights.ur_DeleteCarsOwned AS DeleteCarsOwned, dbo.tbl_UserRights.ur_AddEmployerInfo AS AddEmployerInfo, dbo.tbl_UserRights.ur_EditEmployerInfo AS EditEmployerInfo, 
                  dbo.tbl_UserRights.ur_DeleteEmployerInfo AS DeleteEmployerInfo, dbo.tbl_UserRights.ur_AddPhysicianInfo AS AddPhysicianInfo, dbo.tbl_UserRights.ur_EditPhysicianInfo AS EditPhysicianInfo, 
                  dbo.tbl_UserRights.ur_DeletePhysicianInfo AS DeletePhysicianInfo, dbo.tbl_UserRights.ur_AddMedications AS AddMedications, dbo.tbl_UserRights.ur_EditMedications AS EditMedications, 
                  dbo.tbl_UserRights.ur_DeleteMedications AS DeleteMedications, dbo.tbl_UserRights.ur_AddHospitals AS AddHospitals, dbo.tbl_UserRights.ur_EditHospitals AS EditHospitals, dbo.tbl_UserRights.ur_DeleteHospitals AS DeleteHospitals, 
                  dbo.tbl_UserRights.ur_AddComments AS AddComments, dbo.tbl_UserRights.ur_EditComments AS EditComments, dbo.tbl_UserRights.ur_DeleteComments AS DeleteComments, 
                  dbo.tbl_UserRights.ur_AccessConsultation AS AccessConsultation, dbo.tbl_UserRights.ur_AddConsultation AS AddConsultation, dbo.tbl_UserRights.ur_EditConsultation AS EditConsultation, 
                  dbo.tbl_UserRights.ur_DelConsultation AS DelConsultation, dbo.tbl_Users.usr_LoginName AS LoginName, dbo.tbl_Users.usr_Password AS Password, dbo.tbl_Users.usr_FullName AS FullName, dbo.tbl_Users.usr_Active AS Active, 
                  dbo.tbl_Users.usr_Created AS DateCreated, dbo.tbl_Users.usr_Modified AS DateModified
FROM     dbo.tbl_UserRights INNER JOIN
                  dbo.tbl_Users ON dbo.tbl_UserRights.usr_ID = dbo.tbl_Users.usr_ID
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbl_UserRights"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 289
               Right = 352
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_Users"
            Begin Extent = 
               Top = 7
               Left = 392
               Bottom = 170
               Right = 589
            End
            DisplayFlags = 280
            TopColumn = 3
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 4632
         Alias = 5976
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_Users'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_Users'
GO


