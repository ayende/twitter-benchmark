using MongoDB.Bson;
using MongoDB.Driver;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TwitterAPI;

namespace TwitterAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class MongoController : Controller
    {
        private readonly IMongoCollection<TweetModel> _tweets;
        private readonly IMongoCollection<UserModel> _users;

        public MongoController(IMongoCollection<TweetModel> tweets, IMongoCollection<UserModel> users)
        {
            _tweets = tweets;
            _users = users;
        }

        [HttpGet]
        public async Task<ActionResult> Users(long id)
        {
            var filter = Builders<UserModel>.Filter.Eq("_id", "users/" + id);
            var document = await _users.Find(filter).FirstOrDefaultAsync();
            if (document == null)
            {
                return NotFound();
            }
            return Json(document);
        }

        [HttpGet]
        public async Task<ActionResult> Tweet(long id)
        {
            var filter = Builders<TweetModel>.Filter.Eq("_id", "tweets/" + id);
            var document = await _tweets.Find(filter).FirstOrDefaultAsync();
            if (document == null)
            {
                return NotFound();
            }
            return Json(document);
        }

        [HttpGet]
        public async Task<ActionResult> TweetsFor(long id, int page = 0)
        {
            var filter = Builders<TweetModel>.Filter.Eq("user", "users/" + id);
            var results = await _tweets.Find(filter)
                .SortByDescending(x => x.CreatedAt)
                .Limit(15)
                .Skip(page * 15)
                .Project(x => new
                {
                    x.User,
                    x.CreatedAt,
                    x.FavoriteCount,
                    x.Geo,
                    x.InReplyToScreenName,
                    x.Place,
                    x.FullText,
                    x.ReplyCount,
                    x.RetrievedUtc,
                    x.Source,
                    x.Language,
                    x.SupplementalLanguage,
                    x.PossiblySensitive,
                    x.ConversationId,
                })
                .ToListAsync();
            return Json(results);
        }
    }
}

