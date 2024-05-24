-- PHAN KHOI TAO --
--Tao 2 role cho chuc nang Audit
CREATE ROLE GIAMDOC;
CREATE ROLE DBA;

--Trao quyen xem xet doi voi he thong audit cho admin va giam doc
GRANT AUDIT_ADMIN TO GIAMDOC;
GRANT AUDIT_ADMIN TO DBA;

GRANT SELECT ANY DICTIONARY TO DBA;
GRANT SELECT ON SYS.AUD$ TO DBA;
GRANT SELECT ON SYS.AUD$ TO GIAMDOC;

--Trao key ma hoa cho Giam doc, thang ADMIN ke cha no
CREATE KEYSTORE 'my_keystore' IDENTIFIED BY 'keystore_password' USING 'keystore_type';
ALTER SYSTEM SET ENCRYPTION KEY IDENTIFIED BY 'data_key_password' FOR keystore 'my_keystore';
ALTER SYSTEM SET ENCRYPTION KEY IDENTIFIED BY 'data_key_password' FOR keystore 'my_keystore';
GRANT ENCRYPT ANY TABLE TO GIAMDOC;
ALTER SYSTEM SET AUDIT_TRAIL ENCRYPT;
AUDIT SELECT TABLE, INSERT TABLE, UPDATE TABLE, DELETE TABLE BY GIAMDOC BY ACCESS;


--Gan quyen cho GIAM DOC va ADMIN
GRANT SELECT ON sys.aud$ TO GIAMDOC;
GRANT SELECT ON sys.aud$ TO ADMIN;

GRANT SELECT ON sys.dba_audit_trail TO GIAMDOC;
GRANT SELECT ON sys.dba_audit_trail TO ADMIN;

GRANT SELECT ON sys.dba_audit_session TO GIAMDOC;
GRANT SELECT ON sys.dba_audit_session TO ADMIN;

GRANT SELECT ON sys.dba_audit_object TO GIAMDOC;
GRANT SELECT ON sys.dba_audit_object TO ADMIN;

GRANT SELECT ON sys.dba_audit_statement TO GIAMDOC;
GRANT SELECT ON sys.dba_audit_statement TO ADMIN;

GRANT ALTER SYSTEM TO ADMIN;
GRANT ALTER SYSTEM TO GIAMDOC;


-- PHAN THUC HIEN --

--Nen giam sat hoat dong cua cac roles co quyen sua, xoa, them hoac co thua hanh quyen cua Giam Doc
AUDIT SELECT TABLE, INSERT TABLE, UPDATE TABLE, DELETE TABLE BY "TRUONGPHONG", "TRUONGDEAN" BY ACCESS;

--Theo doi LUONG, PHU CAP 
AUDIT SELECT TABLE ON NHANVIEN.luong BY ACCESS;
AUDIT INSERT TABLE ON NHANVIEN.luong BY ACCESS;
AUDIT UPDATE TABLE ON NHANVIEN.luong BY ACCESS;
AUDIT DELETE TABLE ON NHANVIEN.luong BY ACCESS;
AUDIT SELECT TABLE ON NHANVIEN.phucap BY ACCESS;
AUDIT INSERT TABLE ON NHANVIEN.phucap BY ACCESS;
AUDIT UPDATE TABLE ON NHANVIEN.phucap BY ACCESS;
AUDIT DELETE TABLE ON NHANVIEN.phucap BY ACCESS;

-- CAU 1.
AUDIT UPDATE ("THOIGIAN") ON phancong BY ACCESS WHEN (NEW_VALUE IS NOT NULL);

-- CAU 2.
CREATE OR REPLACE TRIGGER luong_read_trigger
AFTER SELECT ON luong
FOR EACH ROW
BEGIN
   IF :NEW.username <> :OLD.username THEN
      INSERT INTO audit_table (username, table_name, action)
      VALUES (USER, 'LUONG', 'SELECT');
   END IF;
END;
/

CREATE OR REPLACE TRIGGER phucap_read_trigger
AFTER SELECT ON phucap
FOR EACH ROW
BEGIN
   IF :NEW.username <> :OLD.username THEN
      INSERT INTO audit_table (username, table_name, action)
      VALUES (USER, 'PHUCAP', 'SELECT');
   END IF;
END;
/

-- Cau 3.
CREATE OR REPLACE TRIGGER luong_phucap_update_trigger
AFTER UPDATE ON nhanvien
FOR EACH ROW
DECLARE
   v_user_role VARCHAR2(50);
BEGIN
   SELECT role INTO v_user_role FROM user_roles WHERE username = USER;
   IF v_user_role <> 'Tài chính' THEN
      IF :NEW.LUONG <> :OLD.LUONG OR :NEW.PHUCAP <> :OLD.PHUCAP THEN
         INSERT INTO audit_table (username, table_name, action)
         VALUES (USER, 'NHANVIEN', 'UPDATE');
      END IF;
   END IF;
END;
/