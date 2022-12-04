namespace InimcoCase.Domain.Repositories;

internal interface IUserSocialProfileRepository
{
    Task<UserSocialProfile> Create(UserSocialProfilePostDto userSocialProfilePostDto);
}