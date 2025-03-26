using System;

class Program {
    static void Main() {
        Library usfLibrary = new Library();

        // Adding Books
        usfLibrary.AddBook(new Book("The Art of Data Strategy", "Liam Reynolds", "ISBN111", 4));
        usfLibrary.AddBook(new Book("Business Insights with AI", "Olivia Carter", "ISBN222", 3));
        usfLibrary.AddBook(new Book("Analytics in Action", "Nathan Brooks", "ISBN333", 6));

        // Adding Students
        usfLibrary.AddPatron(new Student("Akhil", "akhil@usf.edu", "S001", "Business Analytics", 2026));
        usfLibrary.AddPatron(new Student("Sandeep", "sandeep@usf.edu", "S002", "Information Systems", 2025));

        // Adding Staff
        usfLibrary.AddPatron(new Staff("Grandon Gill", "grandon@usf.edu", "ST001", "Librarian", "Library Services"));

        // Display Initial Library State
        usfLibrary.DisplayBooks();
        usfLibrary.DisplayPatrons();

        // Borrow Books
        Console.WriteLine("\nBorrowing Books...");
        usfLibrary.BorrowBook("Sandeep", "Business Insights with AI");
        usfLibrary.BorrowBook("Akhil", "Analytics in Action");

        // Display Library After Borrowing
        usfLibrary.DisplayBooks();
    }
}
