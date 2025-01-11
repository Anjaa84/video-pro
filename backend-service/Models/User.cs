namespace MyBackendService.Models
{
    public class User{
        public Guid Id {get;set;}
        public string Name{get;set;}
        public string Email {get;set;}
        public string PasswordHash{get;set;}
        public DateTime CreatedAt {get;set;}
        public bool IsActive{get;set;}
        public string ProfilePicture{get;set;}

        public string Expertise {get;set;}
        public string StreamKey{get;set;}
    }
}