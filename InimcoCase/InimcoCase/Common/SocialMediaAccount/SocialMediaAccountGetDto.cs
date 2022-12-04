using InimcoCase.Common.Enums;
namespace InimcoCase.Common;


public record SocialMediaAccountGetDto
{
    public string User { get; set; }
    public SocialMediaPlatform SocialMediaPlatform { get; set; }
}