--------------USER: SYSDBA----------------------------
alter session set "_oracle_script"=true;

DROP USER matthew CASCADE;
-- USER MATTHEW DONG VAI TRO THIET KE DATABASE, TAO CAC POLICY, AUDIT
CREATE USER matthew IDENTIFIED BY 1;

GRANT CREATE SESSION TO matthew WITH ADMIN OPTION;
GRANT CONNECT TO matthew WITH ADMIN OPTION;
GRANT CREATE ANY CONTEXT TO matthew;
GRANT DROP ANY CONTEXT TO matthew;
GRANT CREATE PUBLIC SYNONYM TO matthew;
GRANT CREATE ANY TABLE TO matthew;
GRANT CREATE PROCEDURE TO matthew;
GRANT CREATE TRIGGER TO matthew;
GRANT ADMINISTER DATABASE TRIGGER TO matthew;
GRANT SELECT ANY TABLE TO matthew;
GRANT CREATE ROLE TO matthew WITH ADMIN OPTION;
GRANT CREATE USER TO matthew WITH ADMIN OPTION;
GRANT DROP USER TO matthew WITH ADMIN OPTION;
GRANT SELECT ON DBA_SYS_PRIVS TO matthew;
GRANT SELECT ON DBA_TAB_PRIVS TO matthew;
GRANT SELECT ON DBA_ROLE_PRIVS TO PUBLIC;
GRANT SELECT ON DBA_ROLES TO matthew;
GRANT SELECT ON DBA_COL_PRIVS TO matthew;

GRANT AUDIT_ADMIN TO MATTHEW ;
GRANT AUDIT_VIEWER TO MATTHEW ;

GRANT INHERIT ANY PRIVILEGES TO MATTHEW ;
GRANT SELECT ANY DICTIONARY TO MATTHEW ;

GRANT DROP ANY ROLE TO matthew;
GRANT DROP ANY PROCEDURE TO matthew;

GRANT SELECT ON DBA_SEC_RELEVANT_COLS TO matthew;

grant execute on DBMS_RLS to matthew;
grant execute on DBMS_CRYPTO to matthew;
ALTER USER matthew QUOTA UNLIMITED ON USERS;

/
DROP PROCEDURE CREATEUSER;
DROP PROCEDURE UPDATEUSER;
DROP PROCEDURE DROPUSER;
DROP PROCEDURE CREATEROLE;
DROP PROCEDURE DROPROLE;
DROP PROCEDURE UPDATEROLE;
DROP PROCEDURE GRANTUSERIU;
DROP PROCEDURE GRANTROLEIU;
DROP PROCEDURE GRANTUSERSD;
DROP PROCEDURE GRANTROLESD;
DROP PROCEDURE REVOKEUSER;
DROP PROCEDURE REVOKEROLE;

connect matthew/1
----------------------------------------------------
-- XOA CSDL (Keo 1 vung bam 2 lan)
DROP TABLE PHANCONG;
DROP TABLE NHANVIEN;
DROP TABLE DEAN;
DROP TABLE PHONGBAN;
DROP TABLE LUONGTAM;
/

----------------------------------------------------
-- TABLE NHANVIEN
CREATE TABLE NHANVIEN
(
    MANV VARCHAR(10),
    TENNV VARCHAR2(30),
    PHAI VARCHAR2(3),
    NGAYSINH DATE,
    DIACHI VARCHAR2(100),
    SODT VARCHAR(10),
    LUONG RAW(2000),
    PHUCAP RAW(2000),
    VAITRO VARCHAR2(20),
    MANQL VARCHAR(10),
    PHG VARCHAR(10),
    PRIMARY KEY (MANV)
);

-- TABLE PHONGBAN
CREATE TABLE PHONGBAN 
(
    MAPB VARCHAR(10),
    TENPB VARCHAR2(20),
    TRPHG VARCHAR(10),
    PRIMARY KEY (MAPB)
);

-- TABLE DEAN
CREATE TABLE DEAN
(
    MADA VARCHAR(8),
    TENDA VARCHAR2(20),
    NGAYBD DATE,
    PHONG VARCHAR(8),
    PRIMARY KEY (MADA)
);

-- TABLE PHANCONG
CREATE TABLE PHANCONG
(
    MANV VARCHAR(10),
    MADA VARCHAR(8),
    THOIGIAN DATE,
    PRIMARY KEY (MANV, MADA)
);

CREATE TABLE LUONGTAM
(
    MANV VARCHAR(10),
    LUONG INT,
    PHUCAP INT,
    PHG VARCHAR(10),
    PRIMARY KEY (MANV)
);

-- FOREIGN KEY
ALTER TABLE NHANVIEN
ADD CONSTRAINT FK_NHANVIEN_PHONGBAN
FOREIGN KEY (PHG)
REFERENCES PHONGBAN(MAPB);

ALTER TABLE DEAN
ADD CONSTRAINT FK_DEAN_PHONGBAN
FOREIGN KEY (PHONG)
REFERENCES PHONGBAN(MAPB);

ALTER TABLE PHANCONG
ADD CONSTRAINT FK_PHANCONG_NHANVIEN
FOREIGN KEY (MANV)
REFERENCES NHANVIEN(MANV);

ALTER TABLE PHANCONG
ADD CONSTRAINT FK_PHANCONG_DEAN
FOREIGN KEY (MADA)
REFERENCES DEAN(MADA);

CONNECT SYS/1 AS SYSDBA
-- Tao User
CREATE OR REPLACE PROCEDURE createUser (user IN VARCHAR2, password IN VARCHAR2)
IS
  v_user_check NUMBER;
BEGIN

  SELECT COUNT(*) INTO v_user_check
  FROM all_users
  WHERE username = UPPER(user);
  EXECUTE IMMEDIATE 'alter session set "_oracle_script"=true';
  IF v_user_check = 0 THEN
    EXECUTE IMMEDIATE 'CREATE USER ' || UPPER(user) || ' IDENTIFIED BY ' || password;
    DBMS_OUTPUT.PUT_LINE('User ' || UPPER(user) || ' created successfully.');
    EXECUTE IMMEDIATE 'GRANT CREATE SESSION TO ' || UPPER(user);    
    ELSE
    DBMS_OUTPUT.PUT_LINE('User ' || UPPER(user) || ' already exists.');
  END IF;
END;
/

--dropUser
CREATE OR REPLACE PROCEDURE dropUser (user IN VARCHAR2)
IS
  v_user_check NUMBER;
BEGIN
  EXECUTE IMMEDIATE 'alter session set "_oracle_script"=true';
  SELECT COUNT(*) INTO v_user_check
  FROM all_users
  WHERE username = UPPER(user);
  
  IF v_user_check != 0 THEN
    EXECUTE IMMEDIATE ('DROP USER ' ||UPPER(user));
    DBMS_OUTPUT.PUT_LINE('User ' ||  UPPER(user) || ' drop successfully.');
    ELSE
    DBMS_OUTPUT.PUT_LINE('User ' ||  UPPER(user) || ' not exists.');
  END IF;
END;
/

--updateUser
CREATE OR REPLACE PROCEDURE updateUser (user IN VARCHAR2, password IN VARCHAR2)
IS
  v_user_check NUMBER;
BEGIN
  EXECUTE IMMEDIATE 'alter session set "_oracle_script"=true';
  SELECT COUNT(*) INTO v_user_check
  FROM all_users
  WHERE username = UPPER(user);
  
  IF v_user_check != 0 THEN
    EXECUTE IMMEDIATE 'ALTER USER ' || UPPER(user) || ' IDENTIFIED BY ' || password;
    DBMS_OUTPUT.PUT_LINE('User ' || UPPER(user) || ' update password successfully.');
    
    ELSE
    DBMS_OUTPUT.PUT_LINE('User ' || UPPER(user) || ' not exists.');
  END IF;
END;
/

--createRole
CREATE OR REPLACE PROCEDURE createRole (user IN VARCHAR2, password IN VARCHAR2)
IS
  v_role_check NUMBER;
BEGIN
  EXECUTE IMMEDIATE 'alter session set "_oracle_script"=true';
  SELECT COUNT(*) INTO v_role_check
  FROM DBA_ROLES
  WHERE ROLE = UPPER(user);
  
  IF v_role_check = 0 THEN
    EXECUTE IMMEDIATE 'CREATE ROLES ' || UPPER(user) || password;
    DBMS_OUTPUT.PUT_LINE('Role ' || UPPER(user) || ' create successfully.');
    
    ELSE
    DBMS_OUTPUT.PUT_LINE('Role ' || UPPER(user) || ' is exists.');
  END IF;
END;
/

--dropRole
CREATE OR REPLACE PROCEDURE dropRole (
    user IN VARCHAR2)
AS
    C_USER VARCHAR2(50);
BEGIN
    EXECUTE IMMEDIATE 'alter session set "_oracle_script"=true';
    SELECT COUNT(1) INTO C_USER FROM DBA_ROLES WHERE ROLE = UPPER(user);
    IF C_USER = 0
    THEN
        DBMS_OUTPUT.PUT_LINE('NONE EXISTED ROLE');
    END IF;
    EXECUTE IMMEDIATE ('DROP ROLE ' ||UPPER(user));
END dropRole;
/

--updateRole
CREATE OR REPLACE PROCEDURE updateRole (
    user IN VARCHAR2,
    password IN VARCHAR2)
AS
    C_USER VARCHAR2(50);
BEGIN
    SELECT COUNT(1) INTO C_USER FROM DBA_ROLES WHERE ROLE = UPPER(user);
    IF C_USER != 0
    THEN
        EXECUTE IMMEDIATE ('ALTER ROLE ' ||UPPER(user)|| ' ' ||password);
    END IF;
END updateRole;
/
  
--grantUserIU
CREATE OR REPLACE PROCEDURE grantUserIU(
    user VARCHAR2,
    priv VARCHAR2,
    tabl VARCHAR2,
    wgo VARCHAR2, 
    col VARCHAR2  
    )
AS
    C_USER VARCHAR2(50);
BEGIN
    SELECT COUNT(1) INTO C_USER FROM DBA_USERS WHERE USERNAME = UPPER(user);
    IF C_USER != 0
    THEN
        EXECUTE IMMEDIATE ('GRANT ' ||priv||col|| ' ON matthew.' ||tabl|| ' TO ' ||UPPER(user)|| ' ' ||wgo);
    END IF;
END grantUserIU;
/

--grantRoleIU
CREATE OR REPLACE PROCEDURE grantRoleIU(
    user VARCHAR2,
    priv VARCHAR2,
    tabl VARCHAR2,
    wgo VARCHAR2, 
    col VARCHAR2  
    )
AS
    C_USER VARCHAR2(50);
BEGIN
    SELECT COUNT(1) INTO C_USER FROM DBA_ROLES WHERE ROLE = UPPER(user);
    IF C_USER != 0
    THEN
        EXECUTE IMMEDIATE ('GRANT ' ||priv||' '||col|| ' ON matthew.' ||tabl||  ' TO ' ||UPPER(user)|| ' ' ||wgo);
    END IF;
END grantRoleIU;
/

--grantUserSD
CREATE OR REPLACE PROCEDURE grantUserSD(user IN VARCHAR2, priv VARCHAR2, tabl VARCHAR2, wgo VARCHAR2)
AS
    C_USER VARCHAR2(50);
BEGIN
    EXECUTE IMMEDIATE 'alter session set "_oracle_script"=true';
    SELECT COUNT(1) INTO C_USER FROM DBA_USERS WHERE USERNAME = UPPER(USER);
    IF C_USER != 0
    THEN
        EXECUTE IMMEDIATE ('GRANT '||priv||' ON matthew.'|| UPPER(tabl)|| ' TO '|| UPPER(user)||' '||wgo);
    END IF;
END;
/

--grantRoleSD
CREATE OR REPLACE PROCEDURE grantRoleSD(user IN VARCHAR2, priv VARCHAR2, tabl VARCHAR2, wgo VARCHAR2)
AS
    C_USER VARCHAR2(50);
BEGIN
    EXECUTE IMMEDIATE 'alter session set "_oracle_script"=true';
    SELECT COUNT(1) INTO C_USER FROM DBA_ROLES WHERE ROLE = UPPER(user);
    IF C_USER != 0
    THEN
        EXECUTE IMMEDIATE ('GRANT '||priv||' ON matthew.'|| UPPER(tabl)|| ' TO '|| UPPER(user)||' '||wgo);
    END IF;
END;
/
--revokeUser
CREATE OR REPLACE PROCEDURE revokeUser(user IN VARCHAR2, priv VARCHAR2, tabl VARCHAR2)
AS
    C_USER VARCHAR2(50);
BEGIN
    EXECUTE IMMEDIATE 'alter session set "_oracle_script"=true';
    SELECT COUNT(1) INTO C_USER FROM DBA_USERS WHERE USERNAME = UPPER(USER);
    IF C_USER != 0
    THEN
        EXECUTE IMMEDIATE ('REVOKE '||priv||' ON matthew.'||UPPER(tabl)||' FROM '|| UPPER(user));
    END IF;
END;
/

--revokeRole
CREATE OR REPLACE PROCEDURE revokeRole(user IN VARCHAR2, priv VARCHAR2, tabl VARCHAR2)
AS
    C_USER VARCHAR2(50);
BEGIN
    EXECUTE IMMEDIATE 'alter session set "_oracle_script"=true';
    SELECT COUNT(1) INTO C_USER FROM SYS.DBA_ROLES WHERE ROLE = UPPER(user);
    IF C_USER != 0
    THEN
        EXECUTE IMMEDIATE ('REVOKE '||priv||' ON matthew.'||UPPER(tabl)|| ' FROM '|| UPPER(user));
    END IF;
END;
/

---------------------------------------------------------------------------------------------

-- SELECT * FROM DBMS_RLS; 

