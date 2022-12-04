using InimcoCase.Common;
using InimcoCase.Controllers;
using InimcoCase.Domain;
using InimcoCase.Util;

namespace InimcoCase;

public class UserSocialProfileGetDto
{
    public string Id { get; set; }
    
    internal UserName UserName { get; set; }
    public string FirstName => UserName.FirstName;
    public string LastName => UserName.LastName;
    public string[] SocialSkills { get; set; }

    public SocialMediaAccountGetDto[] SocialMediaAccounts{
        get;
        set;
    }

    public int VowelsInName => UserName.VowelsInName;
    public int ConsonantInName => UserName.ConsonantInName;
    public string ReversedName => UserName.ReversedName;
}