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


CREATE PROCEDURE AddMember
    @Name NVARCHAR(80),
    @Phone NVARCHAR(15),
    @Email NVARCHAR(80)
AS
BEGIN
    INSERT INTO MEMBER (Name, Phone, Email)
    VALUES (@Name, @Phone, @Email);
END;


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


CREATE FUNCTION CountBorrowedBooks()
RETURNS INT
AS
BEGIN
    RETURN (SELECT COUNT(*) FROM LOAN WHERE Status = 'Borrowed');
END;

