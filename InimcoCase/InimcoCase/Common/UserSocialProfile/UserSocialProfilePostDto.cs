using System.ComponentModel.DataAnnotations;
using InimcoCase.Common;

namespace InimcoCase;

public record UserSocialProfilePostDto
{
    [Required(ErrorMessage = "First name is required")]
    public string FirstName { get; set; }
    [Required(ErrorMessage = "Last name is required")]
    public string LastName { get; set; }
    public string[] SocialSkills { get; set; }

    public SocialMediaAccountGetDto[] SocialMediaAccounts{
        get;
        set;
    }

}