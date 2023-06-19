-- Create Vendor Information table
CREATE TABLE VendorInformation (
    VendorID INT IDENTITY(1,1) PRIMARY KEY,
    VendorName VARCHAR(255) NOT NULL,
    ContactNumber VARCHAR(20) NOT NULL UNIQUE,
    Email VARCHAR(255) NOT NULL UNIQUE,
    Address VARCHAR(255) NOT NULL UNIQUE,
    Commission DECIMAL(10, 2) NULL
);

-- Create Car Information table
CREATE TABLE CarInformation (
    CarID INT IDENTITY(1,1) PRIMARY KEY,
    Make VARCHAR(255) NOT NULL,
    Model VARCHAR(255) NOT NULL,
    Year INT NOT NULL,
    Color VARCHAR(255) NOT NULL,
    Mileage INT NOT NULL,
    Price DECIMAL(10, 2) NOT NULL,
    VIN VARCHAR(17) UNIQUE NOT NULL,
    VendorID INT,
    Status VARCHAR(255) NOT NULL,
    FOREIGN KEY (VendorID) REFERENCES VendorInformation(VendorID)
);



-- Create Customer Information table
CREATE TABLE CustomerInformation (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(255) NOT NULL,
    LastName VARCHAR(255) NOT NULL,
    ContactNumber VARCHAR(20) NOT NULL UNIQUE,
    Email VARCHAR(255) NOT NULL UNIQUE,
    Address VARCHAR(255) NOT NULL UNIQUE,
    
);

-- Create Customer-Vendor Relationship table
CREATE TABLE CustomerVendorRelationship (
    CustomerVendorID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID INT NOT NULL,
    VendorID INT NOT NULL,
    RelationshipStartDate DATE NOT NULL,
    RelationshipEndDate DATE NULL,
    CarID INT,
    Status VARCHAR(255) NOT NULL,
    FOREIGN KEY (CustomerID) REFERENCES CustomerInformation(CustomerID),
    FOREIGN KEY (VendorID) REFERENCES VendorInformation(VendorID),
    FOREIGN KEY (CarID) REFERENCES CarInformation(CarID)
);

-- Create Transaction Information table
CREATE TABLE TransactionInformation (
    TransactionID INT IDENTITY(1,1) PRIMARY KEY,
    CarID INT NOT NULL,
    CustomerID INT NOT NULL,
    VendorID INT NOT NULL,
    DateOfSale DATE NOT NULL,
    SalePrice DECIMAL(10, 2) NOT NULL,
    PaymentMethod VARCHAR(255) NOT NULL,

    FOREIGN KEY (CarID) REFERENCES CarInformation(CarID),
    FOREIGN KEY (CustomerID) REFERENCES CustomerInformation(CustomerID),
    FOREIGN KEY (VendorID) REFERENCES VendorInformation(VendorID)
);

-- Create Service Information table
CREATE TABLE ServiceInformation (
    ServiceID INT IDENTITY(1,1) PRIMARY KEY,
    CarID INT NOT NULL,
    DateOfService DATE NOT NULL,
    ServiceDescription VARCHAR(255) NOT NULL,
    ServiceCost DECIMAL(10, 2) NOT NULL,
    Status VARCHAR(255) NOT NULL,
    FOREIGN KEY (CarID) REFERENCES CarInformation(CarID)
);

select * from TransactionInformation
Select * from CarInformation
Select * from CustomerInformation
Select * from CustomerVendorRelationship
Select * from ServiceInformation
Select * from VendorInformation

					--TRIGGERS

-- Create trigger to allow service only for available cars
CREATE TRIGGER AllowServiceForAvailableCars
ON ServiceInformation
INSTEAD OF INSERT
AS
BEGIN
    -- Insert service entries only for available cars
    INSERT INTO ServiceInformation (CarID, DateOfService, ServiceDescription, ServiceCost, Status)
    SELECT i.CarID, i.DateOfService, i.ServiceDescription, i.ServiceCost, i.Status
    FROM inserted i
    INNER JOIN CarInformation c ON i.CarID = c.CarID
    WHERE c.Status = 'available';
END;







-- Create trigger to allow sale only for cars with status "modified"

CREATE TRIGGER CheckCarStatus
ON TransactionInformation
AFTER INSERT, UPDATE
AS
BEGIN
    -- Check if the associated car has a status of "modified"
    IF EXISTS (
        SELECT 1
        FROM inserted i
        JOIN ServiceInformation si ON i.CarID = si.CarID
        WHERE si.Status = 'notmodified'
    )
    BEGIN
        -- Raise an error and rollback the transaction
        RAISERROR ('The car cannot be sold as it has a status of "notmodified".', 16, 1)
        ROLLBACK TRANSACTION
    END
END;





-- Create trigger to update commission in VendorInformation table
CREATE TRIGGER UpdateVendorCommission
ON CustomerVendorRelationship
AFTER INSERT, UPDATE
AS
BEGIN
    -- Check if the 'status' column has been updated/inserted with 'sold'
    IF EXISTS(SELECT 1 FROM inserted WHERE Status = 'sold')
    BEGIN
        -- Update the commission for the corresponding vendor
        UPDATE v
        SET Commission = 0.1 * CAST(ti.SalePrice AS DECIMAL(10, 2))
        FROM VendorInformation v
        JOIN inserted i ON v.VendorID = i.VendorID
        JOIN TransactionInformation ti ON ti.CarID = i.CarID
        WHERE EXISTS (SELECT 1 FROM inserted WHERE VendorID = v.VendorID AND Status = 'sold')
    END
END;




-- Create trigger to reseed TransactionID when all rows are deleted
CREATE TRIGGER ReseedTransactionID
ON TransactionInformation
AFTER DELETE
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM TransactionInformation)
    BEGIN
        DBCC CHECKIDENT('TransactionInformation', RESEED, 0);
    END;
    ELSE
    BEGIN
        DECLARE @MaxTransactionID INT;
        SET @MaxTransactionID = (SELECT MAX(TransactionID) FROM TransactionInformation);
        DBCC CHECKIDENT('TransactionInformation', RESEED, @MaxTransactionID);
    END;
END;




-- Create trigger to reseed CarID when all rows are deleted
CREATE TRIGGER ReseedCarID
ON CarInformation
AFTER DELETE
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM CarInformation)
    BEGIN
        DBCC CHECKIDENT('CarInformation', RESEED, 0);
    END;
    ELSE
    BEGIN
        DECLARE @MaxCarID INT;
        SET @MaxCarID = (SELECT MAX(CarID) FROM CarInformation);
        DBCC CHECKIDENT('CarInformation', RESEED, @MaxCarID);
    END;
END;

-- Create trigger to reseed CustomerID when all rows are deleted
CREATE TRIGGER ReseedCustomerID
ON CustomerInformation
AFTER DELETE
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM CustomerInformation)
    BEGIN
        DBCC CHECKIDENT('CustomerInformation', RESEED, 0);
    END;
    ELSE
    BEGIN
        DECLARE @MaxCustomerID INT;
        SET @MaxCustomerID = (SELECT MAX(CustomerID) FROM CustomerInformation);
        DBCC CHECKIDENT('CustomerInformation', RESEED, @MaxCustomerID);
    END;
END;

-- Create trigger to reseed CustomerVendorID when all rows are deleted
CREATE TRIGGER ReseedCustomerVendorID
ON CustomerVendorRelationship
AFTER DELETE
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM CustomerVendorRelationship)
    BEGIN
        DBCC CHECKIDENT('CustomerVendorRelationship', RESEED, 0);
    END;
    ELSE
    BEGIN
        DECLARE @MaxCustomerVendorID INT;
        SET @MaxCustomerVendorID = (SELECT MAX(CustomerVendorID) FROM CustomerVendorRelationship);
        DBCC CHECKIDENT('CustomerVendorRelationship', RESEED, @MaxCustomerVendorID);
    END;
END;

-- Create trigger to reseed ServiceID when all rows are deleted
CREATE TRIGGER ReseedServiceID
ON ServiceInformation
AFTER DELETE
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM ServiceInformation)
    BEGIN
        DBCC CHECKIDENT('ServiceInformation', RESEED, 0);
    END;
    ELSE
    BEGIN
        DECLARE @MaxServiceID INT;
        SET @MaxServiceID = (SELECT MAX(ServiceID) FROM ServiceInformation);
        DBCC CHECKIDENT('ServiceInformation', RESEED, @MaxServiceID);
    END;
END;


-- Create trigger to reseed VendorID when all rows are deleted
CREATE TRIGGER ReseedVendorID
ON VendorInformation
AFTER DELETE
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM VendorInformation)
    BEGIN
        DBCC CHECKIDENT('VendorInformation', RESEED, 0);
    END;
    ELSE
    BEGIN
        DECLARE @MaxVendorID INT;
        SET @MaxVendorID = (SELECT MAX(VendorID) FROM VendorInformation);
        DBCC CHECKIDENT('VendorInformation', RESEED, @MaxVendorID);
    END;
END;




					--INSERTING VALUES


INSERT INTO VendorInformation (VendorName, ContactNumber, Email, Address, Commission)
VALUES
('Vendor A', '1234567890', 'vendorA@example.com', '123 Main Street', 0),
('Vendor B', '9876543210', 'vendorB@example.com', '456 Elm Avenue', 0),
('Vendor C', '5555555555', 'vendorC@example.com', '789 Oak Drive', 0),
('Vendor D', '1111111111', 'vendorD@example.com', '321 Pine Lane', 0),
('Vendor E', '9999999999', 'vendorE@example.com', '654 Maple Road', 0);


INSERT INTO CarInformation (Make, Model, Year, Color, Mileage, Price, VIN, VendorID, Status)
VALUES
('Toyota', 'Corolla', 2018, 'Silver', 50000, 15000.00, '1HGCM8263A1', 1, 'available'),
('Honda', 'Accord', 2019, 'White', 40000, 18000.00, '2HGFC2F59KH1', 2, 'available'),
('Ford', 'Mustang', 2020, 'Red', 20000, 25000.00, '1FA6P8CF3F5', 3, 'Sold'),
('Chevrolet', 'Cruze', 2017, 'Black', 60000, 12000.00, '3GNDA33P67S1', 4, 'available'),
('Nissan', 'Altima', 2018, 'Blue', 35000, 14000.00, '1N4AL2AP7AN1', 5, 'Sold'),
('BMW', '3 Series', 2021, 'Gray', 10000, 35000.00, 'WBA3A5C54CF1', 1, 'available'),
('Mercedes-Benz', 'C-Class', 2019, 'Silver', 30000, 40000.00, '55SWF4KB6KU1', 2, 'available'),
('Audi', 'A4', 2020, 'White', 15000, 38000.00, 'WAUENAF4XHN1', 3, 'available'),
('Lexus', 'RX 350', 2017, 'Black', 45000, 32000.00, '2T2BZMCA7HC1', 4, 'Sold'),
('Hyundai', 'Elantra', 2022, 'Red', 5000, 18000.00, 'KMHD74LF5NU1', 5, 'available');


CREATE TABLE Login (
    Username VARCHAR(255) NOT NULL,
    Password VARCHAR(255) NOT NULL,
);

INSERT INTO Login(Username,Password)
VALUES
('faraz','admin')

INSERT INTO CustomerInformation (FirstName, LastName, ContactNumber, Email, Address)
VALUES
('John', 'Doe', '1234567890', 'johndoe@example.com', '123 Main Street'),
('Jane', 'Smith', '9876543210', 'janesmith@example.com', '456 Elm Avenue'),
('Michael', 'Johnson', '5555555555', 'michaeljohnson@example.com', '789 Oak Drive'),
('Emily', 'Williams', '1111111111', 'emilywilliams@example.com', '321 Pine Lane'),
('David', 'Brown', '9999999999', 'davidbrown@example.com', '654 Maple Road');


INSERT INTO CustomerVendorRelationship (CustomerID, VendorID, RelationshipStartDate, RelationshipEndDate, CarID, Status)
VALUES
(1, 1, '2022-01-01', '2022-03-16', 1, 'sold'),
(2, 2, '2022-03-15', '2022-03-16', 2, 'sold'),
(3, 4, '2022-05-10', '2022-05-11', 4, 'sold');





INSERT INTO ServiceInformation (CarID, DateOfService, ServiceDescription, ServiceCost, Status)
VALUES
(1, '2022-02-05', 'Oil Change', 50.00, 'modified'),
(2, '2022-04-08', 'Tire Rotation', 30.00, 'modified'),
(6, '2022-06-12', 'Brake Repair', 200.00, 'not modified'),
(4, '2022-03-18', 'Battery Replacement', 100.00, 'modified'),
(7, '2022-05-22', 'Wheel Alignment', 80.00, 'modified');

-- Insert dummy values into TransactionInformation table
INSERT INTO TransactionInformation (CarID, CustomerID, VendorID, DateOfSale, SalePrice, PaymentMethod)
VALUES
    (1, 1, 1, '2023-06-01', 5000.00, 'Cash'),
    (2, 2, 2, '2023-06-02', 7500.00, 'Credit Card'),
    (4, 3, 4, '2023-06-03', 6000.00, 'PayPal');


--	-- Delete a trigger named "MyTrigger" in the "dbo" schema
--DROP TRIGGER dbo.UpdateVendorCommission;





--DELETE FROM CustomerVendorRelationship
--WHERE VendorID IN (1,2,4)
--DELETE FROM TransactionInformation
--WHERE VendorID IN (1,2,4)
--DBCC CHECKIDENT ('CustomerVendorRelationship', RESEED, 0);
--DBCC CHECKIDENT ('TransactionInformation', RESEED, 0);


ALTER TABLE VendorInformation
ALTER COLUMN Commission DECIMAL(10, 2) NOT NULL;


--UPDATE CustomerVendorRelationship
--SET Status = 'sold'
--WHERE VendorID = 1;



select * from TransactionInformation
Select * from CarInformation
Select * from CustomerInformation
Select * from CustomerVendorRelationship
Select * from ServiceInformation
Select * from VendorInformation

