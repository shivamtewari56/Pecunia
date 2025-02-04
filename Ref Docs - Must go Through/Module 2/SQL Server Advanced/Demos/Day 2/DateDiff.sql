SELECT DATEDIFF(year, '2005-12-31 23:59:59.9999999'
, '2006-01-01 00:00:00.0000000');

SELECT DATEDIFF(quarter, '2005-12-31 23:59:59.9999999'
, '2006-01-01 00:00:00.0000000');

SELECT DATEDIFF(month, '2005-12-31 23:59:59.9999999'
, '2006-01-01 00:00:00.0000000');

SELECT DATEDIFF(dayofyear, '2005-12-31 23:59:59.9999999'
, '2006-01-01 00:00:00.0000000');

SELECT DATEDIFF(day, '2005-12-31 23:59:59.9999999'
, '2006-01-01 00:00:00.0000000');

SELECT DATEDIFF(week, '2005-12-31 23:59:59.9999999'
, '2006-01-01 00:00:00.0000000');

SELECT DATEDIFF(hour, '2005-12-31 23:59:59.9999999'
, '2006-01-01 00:00:00.0000000');

SELECT DATEDIFF(minute, '2005-12-31 23:59:59.9999999'
, '2006-01-01 00:00:00.0000000');

SELECT DATEDIFF(second, '2005-12-31 23:59:59.9999999'
, '2006-01-01 00:00:00.0000000');

SELECT DATEDIFF(millisecond, '2005-12-31 23:59:59.9999999'
, '2006-01-01 00:00:00.0000000');


CREATE TABLE dbo.Duration
(
    	startDate datetime2,
	endDate datetime2
);

INSERT INTO dbo.Duration(startDate,endDate)
VALUES('2007-05-06 12:10:09','2007-05-07 12:10:09');

SELECT DATEDIFF(day,startDate,endDate) AS 'Duration'
FROM dbo.Duration;

SELECT DATEDIFF(millisecond, GETDATE(), SYSDATETIME());
