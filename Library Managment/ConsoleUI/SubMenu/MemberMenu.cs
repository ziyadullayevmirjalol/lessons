using Library_Managment.Models;
using Library_Managment.Services;

namespace Library_Managment.ConsoleUI.SubMenu;

public class MemberMenu
{
    private readonly BookService bookService;
    private readonly MemberService memberService;
    public MemberMenu(BookService bookService, MemberService memberService)
    {
        this.bookService = bookService;
        this.memberService = memberService;
    }
    public void DisplayMember()
    {

        bool loop = true;
        while (loop)
        {
            Console.WriteLine("_____________ LibraryManagment System / Member Service _____________");
            Console.WriteLine(" 1. Create Member");
            Console.WriteLine(" 2. Update Member");
            Console.WriteLine(" 3. Delete Member");
            Console.WriteLine(" 4. Get All Members");
            Console.WriteLine(" 5. Borrow Book");
            Console.WriteLine(" 6. Return Book");
            Console.WriteLine(" 7. Display Members Borrowed Books\n");
            Console.WriteLine(" 8. Go Back... ");

            Console.Write("Enter your chose: >>> ");
            var choise = Console.ReadLine();
            Console.Clear();
            switch (choise)
            {
                case "1":
                create:
                    string cmembername = string.Empty;
                    string cmemberphoneoremail = string.Empty;


                    Console.WriteLine("_____________ LibraryManagment System / Book Service / Create _____________");
                    Console.Write(" Enter Member's name/full name: ");
                    cmembername = Console.ReadLine();
                    Console.Write(" Enter Member's phone/email: ");
                    cmemberphoneoremail = Console.ReadLine();

                    Member member = new Member();
                    member.name = cmembername;
                    member.phoneoremail = cmemberphoneoremail;

                    Member ccreatedMember = memberService.registerNewMember(member);
                    if (ccreatedMember != null)
                    {
                        Console.WriteLine("Success. Member registered...\n");
                        Console.WriteLine(
                            $" Member's ID: {ccreatedMember.membershipId},\n" +
                            $" Member's Name: {ccreatedMember.name},\n" +
                            $" Member's Author: {ccreatedMember.phoneoremail}\n"
                        );
                    }
                    else
                    {
                        Console.WriteLine("Aaugh, Dumbass. Enter Valid ID again!\n");
                        Console.WriteLine("Press any key to re-enter...");
                        Console.ReadLine();
                        goto create;
                    }

                    break;
                case "2":
                update:
                    int umemberid = 0;
                    string umembername = string.Empty;
                    string umemberphoneoremail = string.Empty;


                    Console.WriteLine("_____________ LibraryManagment System / Book Service / Update _____________");
                    Console.Write(" Enter Member's ID: ");
                    umemberid = int.Parse(Console.ReadLine());
                    Console.Write(" Enter Member's name/full name: ");
                    cmembername = Console.ReadLine();
                    Console.Write(" Enter Member's phone/email: ");
                    cmemberphoneoremail = Console.ReadLine();

                    Member updatemember = new Member();
                    updatemember.membershipId = umemberid;
                    updatemember.name = cmembername;
                    updatemember.phoneoremail = cmemberphoneoremail;

                    bool found = memberService.updateMember(updatemember);
                    if (found != false)
                    {
                        Console.WriteLine("Success. Member updated...\n");
                        Console.WriteLine(
                            $" Member's ID: {updatemember.membershipId},\n" +
                            $" Member's Name: {updatemember.name},\n" +
                            $" Member's Phone or email: {updatemember.phoneoremail}\n"
                        );
                    }
                    else
                    {
                        Console.WriteLine("Aaugh, Dumbass. Enter Valid ID again!\n");
                        Console.WriteLine("Press any key to re-enter...");
                        Console.ReadLine();
                        goto update;
                    }

                    break;
                case "3":
                delete:
                    int dmemberid = 0;

                    Console.WriteLine("_____________ LibraryManagment System / Member Service / Delete _____________");
                    Console.Write(" Enter Book's ID: ");
                    dmemberid = int.Parse(Console.ReadLine());

                    bool ddeletemember = memberService.deleteMember(dmemberid);
                    if (ddeletemember != false)
                    {
                        Console.WriteLine("Success. Member deleted...\n");
                    }
                    else
                    {
                        Console.WriteLine("Aaugh, Dumbass. Enter Valid ID again!\n");
                        Console.WriteLine("Press any key to re-enter...");
                        Console.ReadLine();
                        goto delete;
                    }

                    break;
                case "4":
                    List<Book> bookslist = new List<Book>();
                    bookslist = bookService.GetBooks();

                    Console.WriteLine("_____________ LibraryManagment System / Member Service / Get All _____________");
                    List<Member> memberlist = memberService.getAllMembers();
                    foreach (Member memberitem in memberlist)
                    {
                        Console.WriteLine(
                            $"__________________________________________________" +
                            $" Member's ID: {memberitem.membershipId},\n" +
                            $" Member's Name: {memberitem.name},\n" +
                            $" Member's Phone or Email: {memberitem.phoneoremail},\n" +
                            $"__________________________________________________"
                        );
                    }

                    break;
                case "5":
                borrowBook:
                    int bmemberid = 0;
                    int bbookid = 0;
                    List<Book> books1 = new List<Book>(); books1 = bookService.GetBooks();

                    Console.WriteLine("_____________ LibraryManagment System / Member Service / Borrow Book _____________");
                    Console.Write(" Enter Member's ID: ");
                    bmemberid = int.Parse(Console.ReadLine());
                    Console.WriteLine(" All Books: \n");

                    foreach (Book book in books1)
                    {
                        if (book.isBorrowed != true)
                        {
                            Console.WriteLine(
                                $"__________________________________________________" +
                                $" Book's ID: {book.Id},\n" +
                                $" Book's Name: {book.Title},\n" +
                                $" Book's Author: {book.Author},\n" +
                                $" Book's Genre: {book.Genre},\n" +
                                $" Book's Published Year: {book.PublicationYear},\n" +
                                $" Book's isBorrowed Status {book.isBorrowed}\n" +
                                $"__________________________________________________"
                            );
                        }
                    }
                    Console.Write(" You can choose a book among these booklist: ");
                    Console.Write(" Enter Book's ID: ");
                    bbookid = int.Parse(Console.ReadLine());
                    bool Borrowed = memberService.borrowBook(bbookid, bmemberid);
                    if (Borrowed != false)
                    {
                        Console.WriteLine($"Success. Member with ID {bmemberid} borrowed a book with ID {bbookid}");
                    }
                    else
                    {
                        Console.WriteLine("Aaugh, Dumbass. Enter Valid ID again!\n");
                        Console.WriteLine("Press any key to re-enter...");
                        Console.ReadLine();
                        goto borrowBook;
                    }

                    break;
                case "6":
                returnBook:
                    int rmemberid = 0;
                    int rbookid = 0;
                    List<Book> borrowedbooks = new List<Book>();
                    borrowedbooks = memberService.displayBorrowedBooks();

                    Console.WriteLine("_____________ LibraryManagment System / Member Service / Return Book _____________");
                    Console.Write(" Enter Member's ID: ");
                    rmemberid = int.Parse(Console.ReadLine());

                    Console.WriteLine(" All Borrowed Books: \n");

                    foreach (Book book in borrowedbooks)
                    {
                        if (book.borrowedMemberID == rmemberid)
                        {
                            Console.WriteLine(
                                $"__________________________________________________" +
                                $" Book's ID: {book.Id},\n" +
                                $" Book's Name: {book.Title},\n" +
                                $" Book's Author: {book.Author},\n" +
                                $" Book's Genre: {book.Genre},\n" +
                                $" Book's Published Year: {book.PublicationYear},\n" +
                                $" Book's isBorrowed Status {book.isBorrowed}\n" +
                                $"__________________________________________________"
                            );
                        }
                    }
                    Console.Write(" You can choose a which book you want to return: ");
                    Console.Write(" Enter Book's ID: ");
                    rbookid = int.Parse(Console.ReadLine());
                    bool returnned = memberService.returnBook(rbookid, rmemberid);
                    if (returnned != false)
                    {
                        Console.WriteLine($"Success. Member with ID {rmemberid} returned a book with ID {rbookid}");
                    }
                    else
                    {
                        Console.WriteLine("Aaugh, Dumbass. Enter Valid ID again!\n");
                        Console.WriteLine("Press any key to re-enter...");
                        Console.ReadLine();
                        goto returnBook;
                    }
                    break;
                case "7":
                    int dbmemberid = 0;
                    List<Book> dborrowedbooks = new List<Book>();

                    Console.WriteLine("_____________ LibraryManagment System / Member Service / Display Member's Books _____________");
                    Console.Write(" Enter Member's ID: ");
                    dbmemberid = int.Parse(Console.ReadLine());
                    borrowedbooks = memberService.displayBorrowedBooksByMemberID(dbmemberid);

                    Console.WriteLine(" All Borrowed Books: \n");

                    foreach (Book book in dborrowedbooks)
                    {
                        if (book.borrowedMemberID == dbmemberid)
                        {
                            Console.WriteLine(
                                $"__________________________________________________" +
                                $" Book's ID: {book.Id},\n" +
                                $" Book's Name: {book.Title},\n" +
                                $" Book's Author: {book.Author},\n" +
                                $" Book's Genre: {book.Genre},\n" +
                                $" Book's Published Year: {book.PublicationYear},\n" +
                                $" Book's isBorrowed Status {book.isBorrowed}\n" +
                                $"__________________________________________________"
                            );
                        }
                    }

                    break;
                case "8":
                    loop = false;
                    Console.WriteLine("Press any key to exit Book Service...");
                    Console.ReadLine();
                    return;
                default:
                    Console.WriteLine("Wrong choose!\nPress any key to re-enter");
                    Console.ReadLine();
                    continue;
            }
        }
    }
}
