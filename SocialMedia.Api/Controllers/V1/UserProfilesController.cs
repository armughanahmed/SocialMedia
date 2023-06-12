namespace SocialMedia.Api.Controllers.V1
{
    using AutoMapper;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;
    using SocialMedia.Api.Contracts.UserProfile.Requests;
    using SocialMedia.Api.Contracts.UserProfile.Responses;
    using SocialMedia.Application.UserProfile.Commands;
    using SocialMedia.Application.UserProfiles.Commands;
    using SocialMedia.Application.UserProfiles.Queries;

    /// <summary>
    /// Controller Responsible For User Profile Domain
    /// </summary>
    [ApiVersion("1.0")]
    [Route(ApiRoutes.BaseRoute)]
    [ApiController]
    public class UserProfilesController : Controller
    {
        /// <summary>
        /// Mediator instance
        /// </summary>
        private readonly IMediator _mediator;

        /// <summary>
        /// AutoMapper instance
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfilesController"/> class.
        /// </summary>
        /// <param name="mediator">mediator injection used for CQRS</param>
        /// <param name="mapper">auto mapper injection used for mapping</param>
        public UserProfilesController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        /// <summary>
        /// Get All User Profiles
        /// </summary>
        /// <returns>List of User Profiles</returns>
        [HttpGet]
        public async Task<IActionResult> GetAllProfiles()
        {
            var query = new GetAllUserProfiles();
            var response = await _mediator.Send(query);
            var profiles = _mapper.Map<List<UserProfileResponse>>(response);

            return Ok(profiles);
        }

        /// <summary>
        /// Get User Profile By Id
        /// </summary>
        /// <returns>User Profile</returns>
        /// <param name="id">User Id</param>
        [Route("{id}")]
        [HttpGet]
        public async Task<IActionResult> GetUserProfileById(string id)
        {
            var query = new GetUserProfileById
            {
                UserProfileId = Guid.Parse(id),
            };

            var response = await _mediator.Send(query);
            var userProfile = _mapper.Map<UserProfileResponse>(response);
            return Ok(userProfile);
        }

        /// <summary>
        /// Creates a User Profile
        /// </summary>
        /// <param name="request">User Profile Create Request</param>
        /// <returns>User Profile</returns>
        [HttpPost]
        public async Task<IActionResult> CreateUserProfile([FromBody] UserProfileCreateUpdate request)
        {
            var command = _mapper.Map<CreateUserCommand>(request);
            var response = await _mediator.Send(command);
            var userProfile = _mapper.Map<UserProfileResponse>(response);

            return CreatedAtAction(nameof(GetUserProfileById), new { id = response.UserProfileId }, userProfile);
        }

        /// <summary>
        /// Update User Profile
        /// </summary>
        /// <param name="id">User Profile Id</param>
        /// <param name="request">User Profile Update Request</param>
        /// <returns>User Profile</returns>
        [HttpPatch]
        public async Task<IActionResult> UpdateUserProfile(string id, UserProfileCreateUpdate request)
        {
            var command = _mapper.Map<UpdateUserProfileBasicInfo>(request);
            command.UserProfileId = Guid.Parse(id);
            await _mediator.Send(command);

            return NoContent();
        }

        /// <summary>
        /// Update User Profile
        /// </summary>
        /// <param name="id">User Profile Id</param>
        /// <returns>User Profile</returns>
        [HttpDelete]
        public async Task<IActionResult> DeleteUserProfile(string id)
        {
            var command = new DeleteUserProfile()
            {
                UserProfileId = Guid.Parse(id),
            };

            await _mediator.Send(command);

            return NoContent();
        }
    }
}
