using System.ComponentModel.DataAnnotations;

namespace JD.Invoicing.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}