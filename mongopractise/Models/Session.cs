using MongoDB.Bson.Serialization.Attributes;

namespace mongopractise.Models
{
    public class Session
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("user_id")]
        public string UserId { get; set; }

        [BsonElement("jwt")]
        public string Jwt { get; set; }
    }
}
