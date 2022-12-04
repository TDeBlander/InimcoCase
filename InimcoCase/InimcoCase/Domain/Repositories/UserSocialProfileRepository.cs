using MongoDB.Bson;
using MongoDB.Driver;

namespace InimcoCase.Domain.Repositories;

internal class UserSocialProfileRepository : IUserSocialProfileRepository
{

    public async Task<UserSocialProfile> Create(UserSocialProfilePostDto userSocialProfilePostDto)
    {
        var profile = new UserSocialProfile()
        {
           UserName = new UserName()
           {
            FirstName = userSocialProfilePostDto.FirstName,
           LastName = userSocialProfilePostDto.LastName,   
           },
           SocialSkills = userSocialProfilePostDto.SocialSkills,
           SocialMediaAccounts = userSocialProfilePostDto.SocialMediaAccounts
        };

        var table = GetUserSocialProfileCollection();
        await table.InsertOneAsync(profile);
        
        return profile;
    }

    private IMongoDatabase GetDatabaseClient()
    {
        var settings = MongoClientSettings.FromConnectionString("");
        var client = new MongoClient(settings);
        var database = client.GetDatabase("test");
        return database;
    }
    
    private IMongoCollection<UserSocialProfile> GetUserSocialProfileCollection()
    {
        var database = GetDatabaseClient();
        return database.GetCollection<UserSocialProfile>("UserSocialProfile");
    }
}