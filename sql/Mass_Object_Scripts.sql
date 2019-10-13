use databasename

select 'drop procedure ' + b.name+'.'+a.name+';'
from sys.procedures a
	join sys.schemas b
		on a.schema_id = b.schema_id
where b.name = 'tsqlt'

select 'drop view ' + b.name+'.'+a.name+';'
from sys.views a
	join sys.schemas b
		on a.schema_id = b.schema_id
where b.name = 'tsqlt'

select 'drop function ' + b.name+'.'+a.name+';'
from sys.objects a
	join sys.schemas b
		on a.schema_id = b.schema_id
where type in ('fn','if','tf')
and b.name = 'tsqlt'
