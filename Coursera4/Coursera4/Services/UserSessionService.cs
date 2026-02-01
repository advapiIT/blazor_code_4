using Coursera4.Models;

namespace Coursera4.Services
{
    public class UserSessionService
    {
        public string UserName { get; private set; } = "Guest";
        public string Email { get; private set; } = "";
        public bool IsRegistered { get; private set; } = false;

        private List<int> _attendedEventIds = new();

        public void RegisterUser(string name, string email)
        {
            UserName = name;
            Email = email;
            IsRegistered = true;
        }

        public void JoinEvent(int eventId)
        {
            if (!_attendedEventIds.Contains(eventId))
            {
                _attendedEventIds.Add(eventId);
            }
        }

        public bool HasJoined(int eventId) => _attendedEventIds.Contains(eventId);

        public int GetAttendanceCount() => _attendedEventIds.Count;
    }
}