using InimcoCase.Controllers;
using InimcoCase.Domain.Repositories;

namespace InimcoCase.Domain.Services;

internal class UserSocialProfileService : IUserSocialProfileService
{
    private readonly IUserSocialProfileRepository _userSocialProfileRepository;
    
    public UserSocialProfileService(IUserSocialProfileRepository userSocialProfileRepository)
    {
        _userSocialProfileRepository = userSocialProfileRepository;
    }
    public async Task<UserSocialProfileGetDto> Create(UserSocialProfilePostDto userSocialProfilePostDto)
    {
        var createdUserProfile = await _userSocialProfileRepository.Create(userSocialProfilePostDto);
        var userProfile = MapUserSocialProfileFromPostDtoToObject(createdUserProfile);
        return userProfile;
    }

    private static UserSocialProfileGetDto MapUserSocialProfileFromPostDtoToObject(UserSocialProfile userSocialProfile)
    {
        return new UserSocialProfileGetDto()
        {
            UserName = userSocialProfile.UserName,
            SocialSkills = userSocialProfile.SocialSkills,
            SocialMediaAccounts = userSocialProfile.SocialMediaAccounts,
            Id = userSocialProfile.Id
        };
    }
}
