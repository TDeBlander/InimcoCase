using InimcoCase.Common;
using InimcoCase.Util;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace InimcoCase.Domain;

    
public class UserSocialProfile
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    
    public string[] SocialSkills { get; set; }
    public UserName UserName { get; set; }

    public SocialMediaAccountGetDto[] SocialMediaAccounts{
        get;
        set;
    }

}

public class UserName
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    
    public int VowelsInName => FirstName.GetVowelCount() + LastName.GetVowelCount();
    public int ConsonantInName => FirstName.GetConsonantCount() + LastName.GetConsonantCount();
    public string ReversedName => LastName.Reverse() + " " + FirstName.Reverse();
}