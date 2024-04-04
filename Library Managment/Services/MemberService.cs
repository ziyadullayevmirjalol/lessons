using Library_Managment.Interfaces;
using Library_Managment.Models;

namespace Library_Managment.Services;

public class MemberService : IMemberService
{
    private readonly List<Member> members;
    private readonly List<Book> BorrowedBooks;
    private readonly BookService _bookService;

    public MemberService(BookService bookService)
    {
        _bookService = bookService;
        members = new List<Member>();
        BorrowedBooks = new List<Book>();
    }
    public bool borrowBook(int bookId, int memberID)
    {
        bool found = false;

        foreach (Member member in members)
        {
            if (member.membershipId == memberID)
            {
                foreach (Book book in _bookService.GetBooks())
                {
                    if (book.Id == bookId)
                    {
                        book.borrowedMemberID = memberID;
                        book.isBorrowed = true;
                        book.isAvailable = false;
                        BorrowedBooks.Add(book);
                        found = true;
                    }
                    break;
                }
            }
        }
        return found;
    }
    public bool deleteMember(int id)
    {
        bool found = false;
        foreach (Member member in members)
        {
            if (member.membershipId == id)
            {
                foreach (Book book in BorrowedBooks)
                {
                    if (book.Id == id)
                    {
                        BorrowedBooks.Remove(book);
                        break;
                    }
                }
                members.Remove(member);
                found = true;
            }
        }
        return found;
    }
    public bool updateMember(Member member)
    {
        bool found = false;
        foreach (Member memberitem in members)
        {
            if (memberitem.membershipId == member.membershipId)
            {
                memberitem.phoneoremail = member.phoneoremail;
                memberitem.name = member.name;
                found = true;
                break;
            }
        }
        return found;
    }
    public Member displayMemberDetails(int id)
    {
        Member found = null;
        foreach (Member member in members)
        {
            if (member.membershipId == id)
            {
                found = member;
                break;
            }
        }
        return found;
    }
    public Member registerNewMember(Member member)
    {
        member.membershipId = members.Count + 1;
        members.Add(member);
        return member;
    }
    public bool returnBook(int bookId, int memberID)
    {
        bool found = false;
        foreach (Book book in _bookService.GetBooks())
        {
            if (book.Id == bookId)
            {
                if (book.borrowedMemberID == memberID)
                {
                    BorrowedBooks.Remove(book);
                    found = true;
                    break;
                }
            }
        }
        return found;
    }
    public List<Book> displayBorrowedBooksByMemberID(int memberId)
    {
        List<Book> userBooks = new List<Book>();
        foreach (Book book in BorrowedBooks)
        {
            if (book.borrowedMemberID == memberId)
            {
                userBooks.Add(book);
            }
        }
        return userBooks;
    }
    public List<Book> displayBorrowedBooks()
    {
        return BorrowedBooks;
    }
    public List<Member> getAllMembers()
    {
        return members;
    }
}
