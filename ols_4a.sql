--ols_test1--
--Tao chinh sach OLS
BEGIN 
SA_SYSDBA.CREATE_POLICY( 
policy_name => 'nhanvien_policy', 
column_name => 'nhanvien_label', 
default_options => 'read_control, update_control' 
); 
END; 

--eneble policy
EXEC SA_SYSDBA.ENABLE_POLICY ('nhanvien_policy'); 

--tao level 
EXECUTE SA_COMPONENTS.CREATE_LEVEL('nhanvien_policy',10,'NV','Nhan vien'); 
EXECUTE SA_COMPONENTS.CREATE_LEVEL('nhanvien_policy',20,'TP','Truong phong'); 
EXECUTE SA_COMPONENTS.CREATE_LEVEL('nhanvien_policy',30,'GD','Giam doc'); 

--tao compartment
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('nhanvien_policy',100,'MB','Mua ban'); 
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('nhanvien_policy',120,'SX','San xuat'); 
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('nhanvien_policy',140,'GC','Gia cong'); 

--tao group 
EXECUTE SA_COMPONENTS.CREATE_GROUP('nhanvien_policy',20,'MB','Mien Bac'); 
EXECUTE SA_COMPONENTS.CREATE_GROUP('nhanvien_policy',40,'MT','Mien Trung'); 
EXECUTE SA_COMPONENTS.CREATE_GROUP('nhanvien_policy',60,'MN','Mien Nam'); 

--cap quyen cho admin tren ols policy
EXECUTE SA_USER_ADMIN.SET_USER_PRIVS('nhanvien_policy','OLS_TEST1','FULL,PROFILE_ACCESS'); 

--APPLY OLS VAO BANG NHANVIEN
BEGIN 
--SA_POLICY_ADMIN.REMOVE_TABLE_POLICY('nhanvien_policy','matthew','NHANVIEN'); 
SA_POLICY_ADMIN.APPLY_TABLE_POLICY ( 
 policy_name => 'nhanvien_policy', 
 schema_name => 'matthew', 
 table_name => 'NHANVIEN', 
 table_options => 'READ_CONTROL,WRITE_CONTROL,CHECK_CONTROL'); 
 --label_function => 'OLS_TEST1.get_customer_label(:new.VAITRO,:new.MIEN,:new.LINHVUC)', predicate => NULL); 
END; 

alter session set container=xepdb1;

--sys-----
-- Them cot Mien,LinhVuc cho bang NhanVien
Alter table matthew.NhanVien add (Mien varchar2(50), LinhVuc varchar2(50));

--Tao procedure tao mien va linh vuc cho bang Nhan Vien
--drop procedure add_mien_linhvuc;
CREATE OR REPLACE PROCEDURE ADD_MIEN_LINHVUC
IS
    v_diachi matthew.nhanvien.diachi%type;
    v_phg matthew.nhanvien.diachi%type;
        
        
    CURSOR c_check IS
        SELECT DIACHI, PHG 
        FROM MATTHEW.NHANVIEN;
        
begin
    for r_check in c_check loop
    v_diachi := r_check.DIACHI;
    v_phg := r_check.PHG;
    
    IF INSTR(v_diachi, 'Ho Chi Minh') > 0 THEN
      UPDATE matthew.nhanvien SET Mien = 'MIEN NAM' WHERE diachi = v_diachi;
    ELSIF INSTR(v_diachi, 'Ha Noi') > 0 THEN
      UPDATE matthew.nhanvien SET Mien = 'MIEN BAC' WHERE diachi = v_diachi;
    ELSIF INSTR(v_diachi, 'Da Nang') > 0 THEN
      UPDATE matthew.nhanvien SET Mien = 'MIEN TRUNG' WHERE diachi = v_diachi;
    END IF;
    
    IF v_phg = 'P01' or v_phg = 'P02' or v_phg = 'P03' THEN
      UPDATE matthew.nhanvien SET linhvuc = 'SAN XUAT' WHERE PHG = v_phg;
    ELSIF v_phg = 'P04' or v_phg = 'P05' or v_phg = 'P06' THEN
     UPDATE matthew.nhanvien SET linhvuc = 'MUA BAN' WHERE PHG = v_phg;
     ELSE
     UPDATE matthew.nhanvien SET linhvuc = 'GIA CONG' WHERE PHG = v_phg;
    END IF;
  END LOOP;
  COMMIT;
END;

exec add_mien_linhvuc;

--Ham tao nhan
CREATE OR REPLACE FUNCTION get_NV_label ( 
 p_NV_type IN VARCHAR2,  
 p_LV IN VARCHAR2,
 p_region IN VARCHAR2)
RETURN varchar--LBACSYS.LBAC_LABEL 
AS 
 v_label VARCHAR2(80); 
BEGIN 
IF p_NV_type = 'BAN GIAM DOC' THEN 
 v_label := 'GD:'; 
 ELSIF p_NV_type = 'TRUONG PHONG' THEN
 v_label := 'TP:'; 
 ELSE
 v_label := 'NV:'; 
 END IF; 
 IF p_LV = 'SAN XUAT' THEN 
 v_label := v_label || 'SX:'; 
 ELSIF p_LV = 'MUA BAN' THEN 
 v_label := v_label || 'MB:'; 
 ELSE 
 v_label := v_label || 'GC:'; 
 END IF; 
 IF p_region = 'MIEN BAC' THEN 
 v_label := v_label || 'MB'; 
 ELSIF p_region = 'MIEN TRUNG' THEN 
 v_label := v_label || 'MT'; 
 ELSIF p_region = 'MIEN NAM' THEN 
 v_label := v_label || 'MN'; 
 END IF; 
 RETURN CHAR_TO_LABEL('nhanvien_policy',v_label); 
END get_nv_label; 



--CAP NHAP NHAN CHO CAC DONG TRONG BANG
DECLARE 
 CURSOR CUR IS SELECT VAITRO,MIEN,LINHVUC,MANV FROM matthew.NHANVIEN; 
 VT VARCHAR2(20); 
 M VARCHAR2(50); 
 LV VARCHAR2(50); 
 MA VARCHAR2(10); 
BEGIN 
 OPEN CUR; 
 LOOP 
 FETCH cur into VT, M,LV,MA; 
 IF cur%NOTFOUND THEN 
 EXIT; 
 END IF; 
 
 UPDATE matthew.NHANVIEN 
 SET NHANVIEN_LABEL = get_NV_label(VT,LV,M) 
 where MANV = MA; 
 END LOOP; 
 CLOSE CUR; 
END; 

--USER OLS_TEST1--
--A--
EXECUTE SA_USER_ADMIN.SET_USER_PRIVS('NHANVIEN_policy','GIAMDOC_CAUA','FULL,PROFILE_ACCESS');

--B--
BEGIN 
SA_USER_ADMIN.SET_USER_LABELS('NHANVIEN_policy','TRUONGPHONG','TP:SX:MN'); 
END; 

--C--
BEGIN 
SA_USER_ADMIN.SET_USER_LABELS('NHANVIEN_policy','GIAMDOC','GD:GC,SX,MB:MB'); 
END; 

--USER SYS--

--A--
--DROP USER GIAMDOC_A;
alter session set "_oracle_script"=true;
CREATE USER GIAMDOC_CAUA IDENTIFIED BY 1;
GRANT CREATE SESSION TO GIAMDOC_CAUA;
GRANT CONNECT TO GIAMDOC_CAUA ; 
GRANT SELECT ON MATTHEW.NHANVIEN TO GIAMDOC_CAUA;

--B--
alter session set "_oracle_script"=true;
CREATE USER TRUONGPHONG IDENTIFIED BY 1;
GRANT CREATE SESSION TO TRUONGPHONG;
GRANT CONNECT TO TRUONGPHONG ; 
GRANT SELECT ON MATTHEW.NHANVIEN TO TRUONGPHONG;

--C--
alter session set "_oracle_script"=true;
CREATE USER GIAMDOC IDENTIFIED BY 1;
GRANT CREATE SESSION TO GIAMDOC;
GRANT CONNECT TO GIAMDOC ; 
GRANT SELECT ON MATTHEW.NHANVIEN TO GIAMDOC;
