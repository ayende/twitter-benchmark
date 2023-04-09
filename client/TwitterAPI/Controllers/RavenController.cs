using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Raven.Client.Documents;
using Raven.Client.Documents.Indexes;
using System.Runtime.Intrinsics.X86;

namespace TwitterAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class RavenController : Controller
    {
        private readonly IDocumentStore _store;

        public RavenController(IDocumentStore store)
        {
            _store = store;
        }

        [HttpGet]
        public async Task<ActionResult> Users(long id)
        {
            using var session = _store.OpenAsyncSession();
            var user = await session.LoadAsync<user>("users/" + id);
            if (user == null)
            {
                return NotFound();
            }
            return Json(user);
        }

        [HttpGet]
        public async Task<ActionResult> Tweet(long id)
        {
            using var session = _store.OpenAsyncSession();
            var tweet = await session.LoadAsync<tweet>("tweets/" + id);
            if (tweet == null)
            {
                return NotFound();
            }

            return Json(tweet);
        }

        [HttpGet]
        public async Task<ActionResult> Tag(string hashtag, int page = 0)
        {
            using var session = _store.OpenAsyncSession();
            var tweets = await session.Query<Twitter_Search.Item, Twitter_Search>()
                .Where(t => t.hashtags == hashtag)
                .OrderByDescending(t => t.created_at)
                .OfType<tweet>()
                .Skip(page * 15)
                .Take(15)
                .ToListAsync();
            return Json(tweets);
        }

        [HttpGet]
        public async Task<ActionResult> User(long id, int page = 0)
        {
            using var session = _store.OpenAsyncSession();
            var user = "users/" + id;
            var tweets = await session.Query<Twitter_Search.Item, Twitter_Search>()
                .Where(t => t.user == user)
                .OrderByDescending(t => t.created_at)
                .OfType<tweet>()
                .Skip(page * 15)
                .Take(15)
                .ToListAsync();
            return Json(tweets);
        }
    }

    public class Twitter_Search : AbstractIndexCreationTask<tweet>
    {
        public class Item
        {
            public string hashtags;
            public string user;
            public DateTime created_at;
        }
        
        public Twitter_Search() 
        {
            Map = tweets => from tweet in tweets
                            select new
                            {
                                tweet.created_at,
                                hashtags = tweet.entities.hashtags.Select(x => x.text),
                                tweet.user,
            //                  tweet.conversation_id,
            //                  tweet.full_text
                            };
            //Index(x => x.full_text, FieldIndexing.Search);
        }
    }
}
