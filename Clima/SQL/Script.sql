create database climaservice
go

use climaservice
go

create table users(
iduser int primary key identity(1,1),
username nvarchar(50) not null,
email nvarchar(50) not null,
pass nvarchar(100) not null,
cities nvarchar(1000),
passtype int);
go

create procedure getusers
as
select * from users
go

create procedure adduser
(
	@username nvarchar(50),
	@email nvarchar(50),
	@pass nvarchar(50),
	@cities nvarchar(1000),
	@haserror bit out,
	@passtype int
)
as
set @haserror = 1
begin try
if not exists(select top 1 1 from users where username = @username AND email = @email)
begin
	set @haserror = 0;
	insert into users
	values
	(@username,@email,@pass,@cities,@passtype)
end
end try
begin catch
	set @haserror = 1;
end catch
go

create procedure getuser
(
	@username nvarchar(50),
	@pass nvarchar(100),
	@haserror bit out
)
as
set @haserror = 1
begin try
if exists(select top 1 1 from users where username = @username and pass = @pass)
begin
	set @haserror = 0
	select top 1 1 from users where username = @username and pass = @pass
end
end try
begin catch
	set @haserror = 1;
end catch
go

create procedure updateuser
(
	@username nvarchar(50),
	@email nvarchar(50),
	@pass nvarchar(100),
	@cities nvarchar(1000),
	@haserror bit out
)
as
set @haserror = 1
begin try
if exists(select top 1 1 from users where username = @username and pass = @pass)
begin
	set @haserror = 0
	update users
	set cities = @cities
	where username = @username and pass = @pass
end
end try
begin catch
	set @haserror = 1;
end catch
go

create procedure verifyuser
(
	@username nvarchar(50),
	@email nvarchar(50),
	@haserror bit out
)
as
set @haserror = 1
begin try
if exists(select top 1 1 from users where username = @username and email = @email)
begin
	set @haserror = 0
end
end try
begin catch
	set @haserror = 1;
end catch
go
