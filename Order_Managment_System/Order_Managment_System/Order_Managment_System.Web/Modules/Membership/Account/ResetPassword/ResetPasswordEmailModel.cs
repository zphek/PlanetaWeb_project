
namespace Order_Managment_System.Membership
{
    public class ResetPasswordEmailModel
    {
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public string ResetLink { get; set; }
    }
}