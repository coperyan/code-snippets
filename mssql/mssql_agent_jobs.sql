SELECT j.job_id JobID
	,j.name JobName
	,j.enabled JobEnabled
	,s.name ScheduleName
	,STUFF(' - ' + 
			CASE s.freq_type
				WHEN 4 THEN 'Daily'
				WHEN 8 THEN 'Weekly'
			END + 
		COALESCE(' - ' + CASE s.freq_type WHEN 8
			THEN CASE s.freq_interval
					WHEN 1 THEN 'Sunday'
					WHEN 2 THEN 'Monday'
					WHEN 4 THEN 'Tuesday'
					WHEN 8 THEN 'Wednesday'
					WHEN 16 THEN 'Thursday'
					WHEN 32 THEN 'Friday'
					WHEN 64 THEN 'Saturday'
						END
				END,'')
		,1,3,'')
		Frequency
	,CONVERT(VARCHAR(15),CAST(dbo.fn_ConvertCharToDateTime(s.active_start_date,s.active_start_time) AS TIME),100) RunTime
	,dbo.fn_ConvertCharToDateTime(js.next_run_date,js.next_run_time) NextRunDateTime
	,j.start_step_id JobStartStep
	,j.date_created JobDateCreated
	,j.date_modified JobDateModified
FROM msdb.dbo.SysJobs j
	LEFT JOIN msdb.dbo.sysjobschedules js
		ON j.job_id = js.job_id
	LEFT JOIN msdb.dbo.sysschedules s
		ON js.schedule_id = s.schedule_id