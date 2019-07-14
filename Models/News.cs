using System;
using System.Collections.Generic;
namespace DeviceWebApi.Models
{
    public enum AppDeviceType
    {
        Mobile,
        Tablet,
        Desktop
    }
    // Snap shot data for mobile
    public class MobileNews
    {
        public Guid Id { get; set; }
        public string Source { get; set; }
        public string HeadLine { get; set; }
        public string Summary { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Target { get; set; } = "Mobile";
    }
    // Brief data for Tablet
    public class TabletNews
    {
        public Guid Id { get; set; }
        public string Source { get; set; }
        public string HeadLine { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public DateTime PublishedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Target { get; set; } = "Tablet";
    }

    // Complete Article for Desktop
    public class DesktopNews
    {
        public Guid Id { get; set; }
        public string Source { get; set; }
        public string HeadLine { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public Author Author { get; set; }
        public DateTime PublishedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Target { get; set; } = "Desktop";
    }

    public class Author
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; } = string.Empty;
        public Profile Profile { get; set; }
    }

    public class Profile
    {
        public Guid Id { get; set; }
        public string Url { get; set; }
        public string ProfilePic { get; set; }
        public List<Publication> Publications { get; set; }
    }

    public class Publication
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string[] Tags { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}