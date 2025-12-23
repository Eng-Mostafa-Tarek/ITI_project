USE LibraryDB;
GO

IF OBJECT_ID('vw_BooksWithCategory', 'V') IS NOT NULL DROP VIEW vw_BooksWithCategory;
GO

CREATE VIEW vw_BooksWithCategory AS
SELECT 
    B.BookID,
    B.Title,
    B.Author,
    B.PublishYear,
    B.Available,
    C.CategoryName
FROM BOOK B
JOIN CATEGORY C ON B.CategoryID = C.CategoryID;
GO

IF OBJECT_ID('AddMember', 'P') IS NOT NULL DROP PROCEDURE AddMember;
GO

CREATE PROCEDURE AddMember
    @Name NVARCHAR(80),
    @Phone NVARCHAR(15),
    @Email NVARCHAR(80)
AS
BEGIN
    INSERT INTO MEMBER (Name, Phone, Email)
    VALUES (@Name, @Phone, @Email);
END;
GO

IF OBJECT_ID('BorrowBook', 'P') IS NOT NULL DROP PROCEDURE BorrowBook;
GO

CREATE PROCEDURE BorrowBook
    @BookID INT,
    @MemberID INT,
    @StaffID INT
AS
BEGIN
    UPDATE BOOK
    SET Available = 0
    WHERE BookID = @BookID;

    INSERT INTO LOAN (BookID, MemberID, StaffID, LoanDate, Status)
    VALUES (@BookID, @MemberID, @StaffID, GETDATE(), 'Borrowed');
END;
GO

IF OBJECT_ID('ReturnBook', 'P') IS NOT NULL DROP PROCEDURE ReturnBook;
GO

CREATE PROCEDURE ReturnBook
    @LoanID INT
AS
BEGIN
    UPDATE LOAN
    SET ReturnDate = GETDATE(),
        Status = 'Returned'
    WHERE LoanID = @LoanID;

    DECLARE @BookID INT = (SELECT BookID FROM LOAN WHERE LoanID = @LoanID);

    UPDATE BOOK
    SET Available = 1
    WHERE BookID = @BookID;
END;
GO
