--Tables------------------------
CREATE TABLE Branch (
    Branch_ID VARCHAR2(8) PRIMARY KEY,
    Branch_Name VARCHAR2(100),
    Address VARCHAR2(255)
);
CREATE TABLE Credentials (
    Branch_ID VARCHAR2(8) PRIMARY KEY,
    password  VARCHAR2(20),
    FOREIGN KEY (Branch_ID) REFERENCES Branch(Branch_ID)
);

CREATE TABLE Supplier (
    Supplier_ID VARCHAR2(8) PRIMARY KEY,
    Name VARCHAR2(100),
    Address VARCHAR2(255),
    Contact_Number VARCHAR2(15),
    CONSTRAINT check_SupplierContactNumber_format
        CHECK (REGEXP_LIKE(Contact_Number, '^01[0-9]{9}$'))
);

CREATE TABLE Product (
    Product_ID VARCHAR2(8) PRIMARY KEY,
    Name VARCHAR2(100),
    Description VARCHAR2(255),
    Price DECIMAL(10, 2)
);

CREATE TABLE Inventory (
    Branch_ID VARCHAR2(8),
    Product_ID VARCHAR2(8),
    Quantity INT,
    PRIMARY KEY (Branch_ID, Product_ID),
    FOREIGN KEY (Branch_ID) REFERENCES Branch(Branch_ID),
    FOREIGN KEY (Product_ID) REFERENCES Product(Product_ID)
);

CREATE TABLE Customer (
    Contact_Number VARCHAR2(15) PRIMARY KEY,
    Name VARCHAR2(100),
    Email VARCHAR2(100),
    CONSTRAINT check_CustomerContactNumber_format
        CHECK (REGEXP_LIKE(Contact_Number, '^01[0-9]{9}$'))
);

CREATE TABLE Payment_Method (
    Payment_Method VARCHAR2(50) PRIMARY KEY,
    Balance DECIMAL(10, 2)
);

CREATE TABLE Transaction (
    Transaction_ID VARCHAR2(8) PRIMARY KEY,
    Payment_Method VARCHAR2(50),
    Paid DECIMAL(10, 2),
    Change DECIMAL(10, 2),
    FOREIGN KEY (Payment_Method) REFERENCES Payment_Method(Payment_Method)
);

CREATE TABLE Orders (
    Order_ID VARCHAR2(8) PRIMARY KEY,
    Contact_Number VARCHAR2(15),
    Product_ID VARCHAR2(8),
    Transaction_ID VARCHAR2(8),
    Order_Date DATE,
    Quantity INT,
    FOREIGN KEY (Contact_Number) REFERENCES Customer(Contact_Number),
    FOREIGN KEY (Product_ID) REFERENCES Product(Product_ID),
    FOREIGN KEY (Transaction_ID) REFERENCES Transaction(Transaction_ID)
);

CREATE TABLE Sourcing (
    Product_ID VARCHAR2(8),
    Supplier_ID VARCHAR2(8),
    PRIMARY KEY (Product_ID, Supplier_ID),
    FOREIGN KEY (Product_ID) REFERENCES Product(Product_ID),
    FOREIGN KEY (Supplier_ID) REFERENCES Supplier(Supplier_ID)
);


----------------
-- DROP TABLE Sourcing CASCADE CONSTRAINTS;
-- DROP TABLE Orders CASCADE CONSTRAINTS;
-- DROP TABLE Transaction CASCADE CONSTRAINTS;
-- DROP TABLE Payment_Method CASCADE CONSTRAINTS;
-- DROP TABLE Customer CASCADE CONSTRAINTS;
-- DROP TABLE Inventory CASCADE CONSTRAINTS;
-- DROP TABLE Product CASCADE CONSTRAINTS;
-- DROP TABLE Supplier CASCADE CONSTRAINTS;
-- DROP TABLE Branch CASCADE CONSTRAINTS;



--------------------------------------------------------------
--Sequence For all the ID's
CREATE SEQUENCE seq_supplier_id 
  START WITH 1 
  INCREMENT BY 1 
  MINVALUE 1 
  MAXVALUE 99999 
  NOCYCLE;
CREATE SEQUENCE seq_branch_id 
  START WITH 1 
  INCREMENT BY 1 
  MINVALUE 1 
  MAXVALUE 99999 
  NOCYCLE;
CREATE SEQUENCE seq_product_id 
  START WITH 1 
  INCREMENT BY 1 
  MINVALUE 1 
  MAXVALUE 99999 
  NOCYCLE;
CREATE SEQUENCE seq_order_id 
  START WITH 1 
  INCREMENT BY 1 
  MINVALUE 1 
  MAXVALUE 99999 
  NOCYCLE;
CREATE SEQUENCE seq_transaction_id 
  START WITH 1 
  INCREMENT BY 1 
  MINVALUE 1 
  MAXVALUE 99999 
  NOCYCLE;


-------------------------------------
--Function to GenerateID
CREATE OR REPLACE FUNCTION generate_id(type_prefix IN VARCHAR2, seq_name IN VARCHAR2)
RETURN VARCHAR2
IS
    id_val VARCHAR2(8);
    seq_val NUMBER;
BEGIN
    EXECUTE IMMEDIATE 'SELECT ' || seq_name || '.NEXTVAL FROM DUAL' INTO seq_val;
    id_val := type_prefix || LPAD(TO_CHAR(seq_val), 5, '0');
    RETURN id_val;
END;
/


----------------------------------------
--Triggers
----
CREATE OR REPLACE TRIGGER trg_supplier_id
BEFORE INSERT ON Supplier
FOR EACH ROW
BEGIN
    :NEW.Supplier_ID := generate_id('sup', 'seq_supplier_id');
END;
/
----
CREATE OR REPLACE TRIGGER trg_branch_id
BEFORE INSERT ON Branch
FOR EACH ROW
BEGIN
    :NEW.Branch_ID := generate_id('brn', 'seq_branch_id');
END;
/
----
CREATE OR REPLACE TRIGGER trg_product_id
BEFORE INSERT ON Product
FOR EACH ROW
BEGIN
    :NEW.Product_ID := generate_id('pro', 'seq_product_id');
END;
/
----
CREATE OR REPLACE TRIGGER trg_order_id
BEFORE INSERT ON Orders
FOR EACH ROW
BEGIN
    :NEW.Order_ID := generate_id('ord', 'seq_order_id');
END;
/
----
CREATE OR REPLACE TRIGGER trg_transaction_id
BEFORE INSERT ON Transaction
FOR EACH ROW
BEGIN
    :NEW.Transaction_ID := generate_id('trn', 'seq_transaction_id');
END;
/
