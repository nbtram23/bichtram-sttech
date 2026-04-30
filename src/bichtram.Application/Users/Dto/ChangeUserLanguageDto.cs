using System.ComponentModel.DataAnnotations;

namespace bichtram.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}