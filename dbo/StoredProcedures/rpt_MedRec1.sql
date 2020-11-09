CREATE  Procedure [dbo].[rpt_MedRec1]
(
 @DateFrom Datetime,
 @DateTo Datetime,
 @Key Varchar(20)
 )
AS
BEGIN


SELECT       
	
	D.dmg_FirstName + ' ' + ISNULL(D.dmg_MiddleName,'') + ' '+ D.dmg_LastName AS PatientName
	,D.dmg_DOB AS DOB
	--,'' as SN
	,dbo.[Decrypt](D.dmg_SSN, @Key) as SSN
	--, '1234567890' AS SSN
	, P.phy_Name AS Physician
	, P.phy_Specialty AS Specialty
	, P.phy_Phone AS Phone
	, P.phy_Fax AS Fax
	, P.phy_Address AS 'Address'
	, P.phy_MedRecRequested AS DateRequested
	, P.phy_MedRecPaid AS DatePaid
	,D.dmg_ID
FROM [dbo].[tbl_Physicians] P
JOIN [dbo].tbl_Demographics D 
ON P.dmg_ID = D.dmg_ID
JOIN [dbo].tbl_Cases C 
ON C.case_id = D.case_id
WHERE  P.phy_MedRecRequested BETWEEN @DateFrom AND @DateTo
	AND (P.phy_MedRecReceived = '1900-01-01'
	OR P.phy_MedRecReceived = ''
	OR P.phy_MedRecReceived IS NULL)
ORDER BY PatientName ASC

END


--exec rpt_MedRec1 @DateFrom='2020-01-01 00:00:00',@DateTo='2020-06-01 00:00:00', @Key=NULL

