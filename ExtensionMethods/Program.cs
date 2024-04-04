using ExtensionMethods.extensionsk;
using ExtensionMethods.Modesls;

List<UserModel> UserModels = new List<UserModel>();

UserModel user = new UserModel();
user.Name = "nimadir";

user.CreateUser(UserModels);
user.DisplayUser();
user.UpdateUser(UserModels, "nimadir");
user.DeleteUser(UserModels, "nimadir");
