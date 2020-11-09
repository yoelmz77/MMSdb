# MMSdb

## Useful links

1. [Code First Mirgations Link](https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/migrations/?redirectedfrom=MSDN)
1. [SQL Server 2017 SQLCLR - Whitelisting Assemblies](https://nielsberglund.com/2017/07/23/sql-server-2017-sqlclr---whitelisting-assemblies/)


## Sql Scripts
```
USE master;
GO
DECLARE @clrName nvarchar(4000) = 'security, ...';
DECLARE @asmBin varbinary(max) = 0x4D5A90000300000004000000...;
DECLARE @hash varbinary(64);

SELECT @hash = HASHBYTES('SHA2_512', @asmBin);

EXEC sys.sp_add_trusted_assembly @hash = @hash, @description = @clrName;
```
