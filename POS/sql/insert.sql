-- Insert into Branch
INSERT INTO Branch (Branch_Name, Address) VALUES ('Main Branch', '123 Main St, City, Country');
INSERT INTO Branch (Branch_Name, Address) VALUES ('West Branch', '456 West St, City, Country');
INSERT INTO Branch (Branch_Name, Address) VALUES ('East Branch', '789 East St, City, Country');
INSERT INTO Branch (Branch_Name, Address) VALUES ('North Branch', '101 North St, City, Country');
INSERT INTO Branch (Branch_Name, Address) VALUES ('South Branch', '202 South St, City, Country');

-- Insert into Credentials
INSERT INTO Credentials (Branch_ID, password) VALUES ('brn00001', 'password123');
INSERT INTO Credentials (Branch_ID, password) VALUES ('brn00002', 'password456');
INSERT INTO Credentials (Branch_ID, password) VALUES ('brn00003', 'password789');
INSERT INTO Credentials (Branch_ID, password) VALUES ('brn00004', 'password101');
INSERT INTO Credentials (Branch_ID, password) VALUES ('brn00005', 'password202');

-- Insert into Supplier
INSERT INTO Supplier (Name, Address, Contact_Number) VALUES ('Supplier A', '789 Supplier St, City, Country', '01123456789');
INSERT INTO Supplier (Name, Address, Contact_Number) VALUES ('Supplier B', '101 Supplier Ave, City, Country', '01198765432');
INSERT INTO Supplier (Name, Address, Contact_Number) VALUES ('Supplier C', '102 Supplier Blvd, City, Country', '01134567890');
INSERT INTO Supplier (Name, Address, Contact_Number) VALUES ('Supplier D', '103 Supplier Way, City, Country', '01145678901');
INSERT INTO Supplier (Name, Address, Contact_Number) VALUES ('Supplier E', '104 Supplier Ln, City, Country', '01156789012');

-- Insert into Product
INSERT INTO Product (Name, Description, Price) VALUES ('Product 1', 'Description for product 1', 10.99);
INSERT INTO Product (Name, Description, Price) VALUES ('Product 2', 'Description for product 2', 20.50);
INSERT INTO Product (Name, Description, Price) VALUES ('Product 3', 'Description for product 3', 30.75);
INSERT INTO Product (Name, Description, Price) VALUES ('Product 4', 'Description for product 4', 40.20);
INSERT INTO Product (Name, Description, Price) VALUES ('Product 5', 'Description for product 5', 50.99);

-- Insert into Inventory
INSERT INTO Inventory (Branch_ID, Product_ID, Quantity) VALUES ('brn00001', 'pro00001', 100);
INSERT INTO Inventory (Branch_ID, Product_ID, Quantity) VALUES ('brn00002', 'pro00002', 200);
INSERT INTO Inventory (Branch_ID, Product_ID, Quantity) VALUES ('brn00003', 'pro00003', 150);
INSERT INTO Inventory (Branch_ID, Product_ID, Quantity) VALUES ('brn00004', 'pro00004', 250);
INSERT INTO Inventory (Branch_ID, Product_ID, Quantity) VALUES ('brn00005', 'pro00005', 300);

-- Insert into Customer
INSERT INTO Customer (Contact_Number, Name, Email) VALUES ('01123456789', 'John Doe', 'john@example.com');
INSERT INTO Customer (Contact_Number, Name, Email) VALUES ('01198765432', 'Jane Smith', 'jane@example.com');
INSERT INTO Customer (Contact_Number, Name, Email) VALUES ('01134567890', 'Alice Johnson', 'alice@example.com');
INSERT INTO Customer (Contact_Number, Name, Email) VALUES ('01145678901', 'Bob Brown', 'bob@example.com');
INSERT INTO Customer (Contact_Number, Name, Email) VALUES ('01156789012', 'Carol White', 'carol@example.com');

-- Insert into Payment_Method
INSERT INTO Payment_Method (Payment_Method, Balance) VALUES ('Credit Card', 5000.00);
INSERT INTO Payment_Method (Payment_Method, Balance) VALUES ('Cash', 1000.00);
INSERT INTO Payment_Method (Payment_Method, Balance) VALUES ('Debit Card', 3000.00);
INSERT INTO Payment_Method (Payment_Method, Balance) VALUES ('Bank Transfer', 2000.00);
INSERT INTO Payment_Method (Payment_Method, Balance) VALUES ('PayPal', 1500.00);

-- Insert into Transaction
INSERT INTO Transaction (Payment_Method, Paid, Change) VALUES ('Credit Card', 100.00, 0.00);
INSERT INTO Transaction (Payment_Method, Paid, Change) VALUES ('Cash', 50.00, 0.00);
INSERT INTO Transaction (Payment_Method, Paid, Change) VALUES ('Debit Card', 75.00, 0.00);
INSERT INTO Transaction (Payment_Method, Paid, Change) VALUES ('Bank Transfer', 120.00, 0.00);
INSERT INTO Transaction (Payment_Method, Paid, Change) VALUES ('PayPal', 90.00, 0.00);

-- Insert into Orders
INSERT INTO Orders (Contact_Number, Product_ID, Transaction_ID, Order_Date, Quantity) VALUES ('01123456789', 'pro00001', 'trn00001', TO_DATE('2023-05-31', 'YYYY-MM-DD'), 10);
INSERT INTO Orders (Contact_Number, Product_ID, Transaction_ID, Order_Date, Quantity) VALUES ('01198765432', 'pro00002', 'trn00002', TO_DATE('2023-05-31', 'YYYY-MM-DD'), 5);
INSERT INTO Orders (Contact_Number, Product_ID, Transaction_ID, Order_Date, Quantity) VALUES ('01134567890', 'pro00003', 'trn00003', TO_DATE('2023-05-31', 'YYYY-MM-DD'), 8);
INSERT INTO Orders (Contact_Number, Product_ID, Transaction_ID, Order_Date, Quantity) VALUES ('01145678901', 'pro00004', 'trn00004', TO_DATE('2023-05-31', 'YYYY-MM-DD'), 12);
INSERT INTO Orders (Contact_Number, Product_ID, Transaction_ID, Order_Date, Quantity) VALUES ('01156789012', 'pro00005', 'trn00005', TO_DATE('2023-05-31', 'YYYY-MM-DD'), 6);

-- Insert into Sourcing
INSERT INTO Sourcing (Product_ID, Supplier_ID) VALUES ('pro00001', 'sup00001');
INSERT INTO Sourcing (Product_ID, Supplier_ID) VALUES ('pro00002', 'sup00002');
INSERT INTO Sourcing (Product_ID, Supplier_ID) VALUES ('pro00003', 'sup00003');
INSERT INTO Sourcing (Product_ID, Supplier_ID) VALUES ('pro00004', 'sup00004');
INSERT INTO Sourcing (Product_ID, Supplier_ID) VALUES ('pro00005', 'sup00005');
