using MongoDB.Bson;
using MongoDB.Driver;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TwitterAPI;
using System;
using MongoDB.Bson.IO;

namespace TwitterAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class MongoController : Controller
    {
        private readonly IMongoCollection<BsonDocument> _tweets;
        private readonly IMongoCollection<BsonDocument> _users;

        public MongoController(Tuple<IMongoCollection<BsonDocument>, IMongoCollection<BsonDocument>> i)
        {
            _tweets = i.Item1;
            _users = i.Item2;
        }

        [HttpGet]
        public async Task<ActionResult> Users(long id)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", "users/" + id);
            var document = await _users.Find(filter).FirstOrDefaultAsync();
            if (document == null)
            {
                return NotFound();
            }
            return new ContentResult
            {
                Content = document.ToJson(new JsonWriterSettings { OutputMode = JsonOutputMode.RelaxedExtendedJson }),
                ContentType = "application/json"
            };
        }

        [HttpGet]
        public async Task<ActionResult> Tweet(long id)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", "tweets/" + id);
            var document = await _tweets.Find(filter).FirstOrDefaultAsync();
            if (document == null)
            {
                return NotFound();
            }
            return new ContentResult
            {
                Content = document.ToJson(new JsonWriterSettings { OutputMode = JsonOutputMode.RelaxedExtendedJson }),
                ContentType = "application/json"
            };
        }

        [HttpGet]
        public async Task<ActionResult> TweetsFor(long id, int page = 0)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("user", "users/" + id);
            var results = await _tweets.Find(filter)
                .Sort(Builders<BsonDocument>.Sort.Descending("created_at"))
                .Limit(15)
                .Skip(page * 15)
                .Project(Builders<BsonDocument>.Projection
                    .Include("user")
                    .Include("created_at")
                    .Include("favorite_count")
                    .Include("geo")
                    .Include("in_reply_to_screen_name")
                    .Include("place")
                    .Include("full_text")
                    .Include("reply_count")
                    .Include("retrieved_utc")
                    .Include("source")
                    .Include("lang")
                    .Include("supplemental_language")
                    .Include("possibly_sensitive")
                    .Include("conversation_id")
                 )
                .ToListAsync();
            return new ContentResult
            {
                Content = results.ToJson(new JsonWriterSettings { OutputMode = JsonOutputMode.RelaxedExtendedJson }),
                ContentType = "application/json"
            };
        }
    }
}

