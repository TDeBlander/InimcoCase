namespace InimcoCase.Domain.Services;

public interface IUserSocialProfileService
{
    Task<UserSocialProfileGetDto> Create(UserSocialProfilePostDto userSocialProfilePostDto);
}