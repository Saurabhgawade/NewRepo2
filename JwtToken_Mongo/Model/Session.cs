using MongoDB.Bson.Serialization.Attributes;

namespace Mongo2.Model
{
    public class Session
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("user_id")]
        public string userId { get; set; }

        [BsonElement("jwt")]
        public string Jwt { get; set; }
    }
}
