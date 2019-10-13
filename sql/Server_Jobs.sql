USE msdb
GO

SELECT a.Name as 'ProcName'
	,b.Step_ID as 'ProcOrderNumber'
	,b.Command as 'ProcCommand'
FROM sysjobs a
	JOIN sysjobsteps b
		ON b.job_id = a.job_id
WHERE a.Name LIKE '%Job Name%'
ORDER BY a.Name ASC
