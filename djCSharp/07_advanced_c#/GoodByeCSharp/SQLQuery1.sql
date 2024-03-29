-- use ProjectDataBase; -- 현재 데이터베이스 선택 키워드
-- insert into testtable values('038','컴돌이');
delete from testtable where hakbeon='1';
update testtable set name='돌돌이' where hakbeon='007';
select * from [ProjectDataBase].[dbo].[testtable];