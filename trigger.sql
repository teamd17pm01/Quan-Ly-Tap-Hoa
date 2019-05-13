
create trigger fk_ThemSP on tbl_kho after insert
as
begin
	declare @masp nchar(10)=(select inserted.MASP from inserted)
	declare @tensp nvarchar(200)=(select inserted.TENSP from inserted)
	if(@masp!=null and @tensp!=null)
	begin
		insert into tbl_chitietsp(MASP,TENSP) values(@masp,@tensp)
		commit
	end
	rollback
end