CREATE Procedure [dbo].[rpt_Statistics1]
(
 @Year Varchar(4),
 @Facilities INT
 )
AS
BEGIN



--DECLARE @Year Varchar(4)
--DECLARE @Facilities INT
--SET @Year='2015' SET @Facilities=1


SELECT  * 
INTO #tbl_HospitalInfo
FROM [dbo].tbl_HospitalInfo H 
WHERE 
YEAR(H.hosp_StatusDate)=@Year 
AND H.Fac_ID = @Facilities


SELECT
 DateName(month,hosp_StatusDate) Month_ID, MONTH(hosp_StatusDate) MONTHn,
-- AnticipatedRecovery=SUM(CASE WHEN hosp_StatusID  =5 THEN hosp_AnticipatedRecovery ELSE 0 END)
 AnticipatedRecovery=SUM(CASE WHEN MONTH(hosp_StatusDate) = MONTH(hosp_DateInvoiced) THEN hosp_AnticipatedRecovery ELSE 0 END)
,Pending   = SUM(CASE WHEN hosp_StatusID  = 1 THEN 1 ELSE 0 END)
,Closed    = SUM(CASE WHEN hosp_StatusID  in (2,3) THEN 1 ELSE 0 END)
,Approved  = SUM(CASE WHEN hosp_StatusID  = 5 THEN 1 ELSE 0 END)
,Referred  = SUM(CASE WHEN hosp_StatusID  in (1,2,3,5) THEN 1 ELSE 0 END)
INTO #tbl_HospitalInfo1
FROM  #tbl_HospitalInfo
GROUP BY  DateName(month,hosp_StatusDate),MONTH(hosp_StatusDate)

SELECT  Month_ID AS Month
       ,Referred
	   ,Pending
	   ,Closed
	   ,Approved
       ,AnticipatedRecovery
      ,Converted = CASE 
			WHEN Referred = 0 
			THEN 0 
			ELSE CAST(CAST(Approved AS DECIMAL(18, 4))/CAST(Referred AS DECIMAL(18, 4)) AS DECIMAL(18, 4))
		   END

FROM #tbl_HospitalInfo1  
ORDER BY MonthN 


END


--Exec dbo.rpt_Statistics 2016,1
--Exec dbo.rpt_Statistics1 2017,1011