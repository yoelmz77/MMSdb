CREATE FUNCTION Decrypt(@EncryptedString nvarchar(max), @Key nvarchar(max))
RETURNS 
   nvarchar(max) 

EXTERNAL NAME [Security].[Security.clsSecurity].[Decrypt]