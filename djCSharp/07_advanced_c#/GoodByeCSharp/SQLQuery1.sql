-- use ProjectDataBase; -- ���� �����ͺ��̽� ���� Ű����
-- insert into testtable values('038','�ĵ���');
delete from testtable where hakbeon='1';
update testtable set name='������' where hakbeon='007';
select * from [ProjectDataBase].[dbo].[testtable];