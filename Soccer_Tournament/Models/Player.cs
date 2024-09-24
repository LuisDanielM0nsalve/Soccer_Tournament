using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Soccer_Tournament.Models
{
    public class Player
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public int Position { get; set; }
    }
}
