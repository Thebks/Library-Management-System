# Library-Management-System
Library Management System  is an application which refers to library systems that are being used by librarian to manage the library using a computerized system where he/she can
record various transactions like issue of books, return of books, registration of new member, keeping track of the books being borrowed, late return fines etc. 

# Goals
It keeps track of all the books in the library that can be borrowed by the students who have the membership of the library, The program also shows  the list of the students who currently have the membership of the library, it also registers the students who want the membership, students can also cancel the Membership as the program has the delete option that can be used to remove the students from the registered member’s list, shows the list of the books that are available in the library, adds the new book into the database , keeps the record of the books that are borrowed, once the book is borrowed the loan information is saved in the data base along with the due date book loan, if the book is not returned before the due date the program calculates the late return fine and saves it in the database.

# Data-Requirement
•	LibraryMember
	Contains the list of Students that currently holds the membership of the library. The attributees in the table are MemberID, Title, FirstName, LastName, StudentID.

•	BookDetails
	Contains the list of books that are currently available in the library for the students. The attributes in the table are BookID, ISBN, BookTitle, Author, YearPublished, Category, Borrowed.

•	LibraryLoanInfo
	Contains the recods of the books being borrowed by the students from the library along with the due dates and late return fines. The attributes in the table are BookID, MemberID, DateReturn, LateReturnFine, Returned.
