using System.ComponentModel.DataAnnotations;

namespace DIIssue.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}