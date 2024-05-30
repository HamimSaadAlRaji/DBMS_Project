CREATE TABLE Branch (
    Branch_ID INT PRIMARY KEY,
    Branch_Name VARCHAR2(100),
    Address VARCHAR2(255)
);

CREATE TABLE Supplier (
    Supplier_ID INT PRIMARY KEY,
    Name VARCHAR2(100),
    Address VARCHAR2(255),
    Contact_Number VARCHAR2(15),
    CONSTRAINT check_SupplierContactNumber_format
        CHECK (REGEXP_LIKE(Contact_Number, '^01[0-9]{9}$'))
);

CREATE TABLE Product (
    Product_ID INT PRIMARY KEY,
    Name VARCHAR2(100),
    Description VARCHAR2(255),
    Price DECIMAL(10, 2)
);

CREATE TABLE Inventory (
    Branch_ID INT,
    Product_ID INT,
    Quantity INT,
    PRIMARY KEY (Branch_ID, Product_ID),
    FOREIGN KEY (Branch_ID) REFERENCES Branch(Branch_ID),
    FOREIGN KEY (Product_ID) REFERENCES Product(Product_ID)
);

CREATE TABLE Customer (
    Customer_ID INT PRIMARY KEY,
    Name VARCHAR2(100),
    Contact_Number VARCHAR2(15),
    Email VARCHAR2(100),
    CONSTRAINT check_CustomerContactNumber_format
        CHECK (REGEXP_LIKE(Contact_Number, '^01[0-9]{9}$'))
);

CREATE TABLE Transaction (
    Transaction_ID INT PRIMARY KEY,
    Payment_Method VARCHAR2(50),
    Paid DECIMAL(10, 2),
    Return DECIMAL(10, 2),
    FOREIGN KEY (Payment_Method) REFERENCES Payment_Method(Payment_Method)
);

CREATE TABLE Orders(
    Order_ID INT PRIMARY KEY,
    Customer_ID INT,
    Product_ID INT,
    Transaction_ID INT,
    Order_Date DATE,
    Quantity INT,
    FOREIGN KEY (Customer_ID) REFERENCES Customer(Customer_ID),
    FOREIGN KEY (Product_ID) REFERENCES Product(Product_ID),
    FOREIGN KEY (Transaction_ID) REFERENCES Transaction(Transaction_ID)
);

CREATE TABLE Payment_Method (
    Payment_Method VARCHAR2(50) PRIMARY KEY,
    Balance DECIMAL(10, 2)
);

CREATE TABLE Sourcing (
    Product_ID INT,
    Supplier_ID INT,
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
