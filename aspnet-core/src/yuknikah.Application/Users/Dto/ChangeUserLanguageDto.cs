using System.ComponentModel.DataAnnotations;

namespace yuknikah.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}