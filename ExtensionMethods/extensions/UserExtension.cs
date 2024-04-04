using ExtensionMethods.Modesls;

namespace ExtensionMethods.extensionsk;

public static class UserExtension
{
    public static void DisplayUser(this UserModel userExtension)
    {
        Console.WriteLine($"User's name is: {userExtension.Name}.");
    }
    public static void CreateUser(this UserModel UserExtension, List<UserModel> users)
    {
        users.Add(UserExtension);
        Console.WriteLine("User created");
    }
    public static void UpdateUser(this UserModel UserExtension, List<UserModel> users, string UserName)
    {
        foreach (var user in users)
        {
            if (user.Name == UserName)
            {
                user.Name = UserName;
                Console.WriteLine("UserUpdated");
                break;
            }
        }
    }
    public static void DeleteUser(this UserModel UserExtension, List<UserModel> users, string name)
    {
        foreach (var user in users)
        {
            if (user.Name == name)
            {
                users.Remove(user);
                Console.WriteLine("UserDeleted");
                break;
            }
        }
    }
}
