namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo() { Name = "Gül Sevim", Phone = "555-123-4567", Email = "gulsevim@gmail.com", WillAttend = true });
            _users.Add(new UserInfo() { Name = "Ahmet Yılmaz", Phone = "555-987-6543", Email = "ahmetYilmaz@gmail.com", WillAttend = false });
            _users.Add(new UserInfo() { Name = "Ayşe Kaya", Phone = "555-555-5555", Email = "ayseKaya@gmail.com", WillAttend = true });
        }

        public static List<UserInfo> Users
        {
            get { return _users; }
        }

        public static void CreateUser(UserInfo user)
        {
            _users.Add(user);
        }
    }
}