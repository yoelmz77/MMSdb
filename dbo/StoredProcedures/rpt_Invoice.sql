CREATE Procedure [dbo].[rpt_Invoice]
(
 @DateFrom Datetime,
 @DateTo Datetime,
 @StatusID Int,
 @FacilityID Int,
 @CaseType Char(1), 
 @Type Varchar(20),
 @WorkerID INT,
 @Eligible Bit
 )
AS
BEGIN


SELECT        [fac_Name] AS Facility
              ,H.dmg_ID
			  ,H.hosp_Account AS AccountNo
			  ,CS.sts_Description AS [Status]
			  ,H.hosp_StatusDate AS StatusDate 
			  ,D.dmg_FirstName + ' ' + ISNULL(D.dmg_MiddleName,'') + ' '+ D.dmg_LastName AS PatientName
			  ,H.hosp_Recipient AS RecipientNo
			  ,H.hosp_Admission AS AdmissionDate
			  ,H.hosp_Discharge AS DischargeDate
			  ,LenghtofStay=Cast(Case When(DateDiff(day,H.hosp_Admission,H.hosp_Discharge)) <0 Then 0 Else DateDiff(day,H.hosp_Admission,H.hosp_Discharge) END as varchar(10))+' day(s)'
			  ,H.hosp_Referred AS ReferredDate
			  ,H.hosp_CaseType AS AdmissionType
			  ,CASE WHEN C.case_type='A' THEN 'Adult' ELSE 'Child' END AS  CaseType
			  ,H.hosp_Balance AS Balance
              ,C.case_Elgible
			  ,H.hosp_AnticipatedRecovery AS AnticipatedRecovery
			  ,U.[usr_FullName] AS usr_FullName ---???
			  ,H.[hosp_DateMMSPaid] AS DateMMSPaid
			  ,h.[hosp_MMSAntRecv]  AS MMSAnticipatedRecovery
--Select H.hosp_StatusID,*
FROM [dbo].tbl_HospitalInfo H 
JOIN [dbo].tbl_Demographics D 
ON H.dmg_ID = D.dmg_ID
JOIN [dbo].tbl_Cases C 
ON C.case_id = D.case_id
JOIN [dbo].[tbl_Facilities] F
ON F.fac_ID = H.fac_ID
JOIN [dbo].[tbl_Status] CS
ON  CS.[sts_ID] =H.hosp_StatusID
JOIN [dbo].[tbl_Users] U
ON U.usr_ID = C.usr_ID
--WHERE 1=1
--AND H.dmg_ID  in (10377,20407,40,20322,30472) 
----    and H.hosp_StatusDate BETWEEN '2016-04-13 00:00:00' AND '2016-05-13 00:00:00'
    --AND  	H.hosp_StatusID =6
----	  AND H.Fac_ID = @FacilityID
----	  AND (@Type IS NULL OR H.Hosp_Casetype = @Type)
----	  AND (@CaseType IS NULL OR C.case_type =@CaseType)
WHERE H.hosp_StatusDate BETWEEN @DateFrom AND @DateTo
      AND H.hosp_StatusID = @StatusID
	  AND H.Fac_ID = @FacilityID
	  AND (@Type IS NULL OR H.Hosp_Casetype = @Type)
	  AND (@CaseType IS NULL OR C.case_type =@CaseType)
-----ORDER BY D.dmg_FirstName ASC, D.dmg_LastName ASC
ORDER BY PatientName ASC

END


--exec rpt_Invoice @DateFrom='2016-04-13 00:00:00',@DateTo='2016-05-13 00:00:00',@StatusID=5,@FacilityID=1,@CaseType=NULL,@Type=NULL,@WorkerID=NULL,@Eligible=NULL

--exec rpt_Invoice @DateFrom='2016-04-13 00:00:00',@DateTo='2016-05-13 00:00:00',@StatusID=6,@FacilityID=1,@CaseType=NULL,@Type=NULL,@WorkerID=NULL,@Eligible=NULL

