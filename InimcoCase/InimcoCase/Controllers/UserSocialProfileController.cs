using InimcoCase.Common;
using InimcoCase.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace InimcoCase.Controllers;

[ApiController]
[Route("[controller]")]
public class UserSocialProfileController : ControllerBase
{

    private readonly ILogger<UserSocialProfileController> _logger;
    private readonly IUserSocialProfileService _userSocialProfileService;

    public UserSocialProfileController(ILogger<UserSocialProfileController> logger, IUserSocialProfileService userSocialProfileService)
    {
        _logger = logger;
        _userSocialProfileService = userSocialProfileService;
    }

    [HttpPost]
    public async Task<ActionResult<UserSocialProfileGetDto>> Create([FromBody] UserSocialProfilePostDto userSocialProfilePostDto)
    {
        var createdUserProfile = await _userSocialProfileService.Create(userSocialProfilePostDto);
        return Ok(createdUserProfile);
    }

}
