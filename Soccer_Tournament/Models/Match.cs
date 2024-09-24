using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Soccer_Tournament.Models
{
    public class Match
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } 
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public string Category { get; set; }
        public int Time { get; set; }
        public string TeamWinner { get; set; }
        public string TeamLoser { get; set; }
    }
}
