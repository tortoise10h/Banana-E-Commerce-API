using System;

namespace Banana_E_Commerce_API.Entities
{
    public class Notification
    {
        public int Id { get; set; }
        public NotificationType Type { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }

        public Admin Admin { get; set; }
        public int CreatedBy { get; set; }

        public User User { get; set; }
        public int NotificationTo { get; set; }
    }

    public enum NotificationType
    {
        General,
        Sale,
        Bill
    }
}