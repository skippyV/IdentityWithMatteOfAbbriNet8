using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using AspNetCore.Identity.Mongo.Model;

namespace IdentityWithMatteOfAbbriNet8.Data.Models
{
    [BsonIgnoreExtraElements]
    public class SiteUser : MongoUser
    {
    }
}
