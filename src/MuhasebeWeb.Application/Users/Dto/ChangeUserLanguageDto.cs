using System.ComponentModel.DataAnnotations;

namespace MuhasebeWeb.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}