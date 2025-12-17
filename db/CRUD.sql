USE LibraryDB;

INSERT INTO CATEGORY (CategoryName)
VALUES 
('Programming'),
('History'),
('Science'),
('Novels'),
('Business');

INSERT INTO BOOK (Title, Author, PublishYear, Available, CategoryID)
VALUES
('Clean Code', 'Robert C. Martin', 2008, 1, 1),
('Python Crash Course', 'Eric Matthes', 2019, 1, 1),
('Sapiens', 'Yuval Noah Harari', 2011, 1, 2),
('Brief History of Time', 'Stephen Hawking', 1988, 1, 3),
('Atomic Habits', 'James Clear', 2018, 1, 5),
('1984', 'George Orwell', 1949, 1, 4);


INSERT INTO MEMBER (Name, Phone, Email)
VALUES
('Mostafa Tarek', '01006876746', 'mostafa@mail.com'),
('Ali Mohamed', '01098765432', 'ali@mail.com'),
('Sara Ahmed', '01122233344', 'sara@mail.com');


INSERT INTO STAFF (Name, Username, Password)
VALUES
('Admin One', 'admin1', 'adminpass'),
('Librarian Mohamed', 'moh_staff', '123456');


INSERT INTO LOAN (BookID, MemberID, StaffID, LoanDate, ReturnDate, Status)
VALUES
(1, 1, 1, '2025-01-05', NULL, 'Borrowed'),
(2, 2, 2, '2025-01-10', '2025-01-17', 'Returned'),
(3, 3, 1, '2025-01-12', NULL, 'Borrowed');


--Read
SELECT * FROM CATEGORY;
SELECT * FROM BOOK;
SELECT * FROM MEMBER;
SELECT * FROM STAFF;
SELECT * FROM LOAN;

--UPDATE
UPDATE BOOK
SET Available = 0
WHERE BookID = 1;

UPDATE LOAN
SET ReturnDate = '2025-01-20', Status = 'Returned'
WHERE LoanID = 1;

UPDATE MEMBER
SET Phone = '01000000000'
WHERE MemberID = 1;

--DELETE
DELETE FROM LOAN
WHERE LoanID = 2;

DELETE FROM BOOK
WHERE BookID = 6;

DELETE FROM MEMBER
WHERE MemberID = 3;
