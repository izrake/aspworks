
create procedure LoopConcept1 @var int
as
begin
declare @tracl int = 1;
	while(@tracl<=10)
	begin
	select +@var+'*'+@tracl ,@var*@tracl;
	set @tracl=@tracl+1;
	end
end
go


exec LoopConcept1 5;

create function LoopConcept(@var int)
returns int
as
begin 
return 0
end