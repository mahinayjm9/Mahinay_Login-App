create database db_login

use db_login

create table info(
id int,
Fname varchar(50),
Lname varchar(50),
Username varchar(50),
Passwords varchar(50),
usertype int
)

create procedure sp_login
@Username varchar(50),
@Passwords varchar(50)
as
select Username, Passwords, usertype from info
where Username = @Username and Passwords = @Passwords

create procedure sp_type
@Username varchar(50),
@Passwords varchar(50)
as
declare @type int
select @type = usertype 
from info 
where Username = @Username and Passwords = @Passwords
return @type

insert into info values (1, 'John Marcel', 'Mahinay', 'admin', 'admin', 0);

select * from info