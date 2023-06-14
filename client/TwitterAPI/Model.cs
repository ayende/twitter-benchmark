using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Sparrow.Utils;
using TwitterAPI;

namespace TwitterAPI
{
    public class description
    {
        public List<object> urls { get; set; }
    }

    public class urls
    {
        public string display_url { get; set; }
        public Uri expanded_url { get; set; }
        public List<int> indices { get; set; }
        public Uri url { get; set; }
    }

    public class url
    {
        public List<urls> urls { get; set; }
    }

    public class media
    {
        public string display_url { get; set; }
        public Uri expanded_url { get; set; }
    
        public long id { get; set; }
        public long id_str { get; set; }
        public List<int> indices { get; set; }
        public Uri media_url { get; set; }
        public Uri media_url_https { get; set; }
        public original_info original_info { get; set; }
        public sizes sizes { get; set; }
        public string type { get; set; }
        public Uri url { get; set; }
    }

    public class image_size
    {
        public int h { get; set; }
        public string resize { get; set; }
        public int w { get; set; }
    }

    public class sizes
    {
        public image_size large { get; set; }
        public image_size medium { get; set; }
        public image_size small { get; set; }
        public image_size thumb { get; set; }
    }

    public class hashtags
    {
        public List<int> indices { get; set; }
        public string text { get; set; }
    }

    public class focus_rects
    {
        public int h { get; set; }
        public int w { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class original_info
    {
        public List<focus_rects> focus_rects { get; set; }
        public int height { get; set; }
        public int width { get; set; }
    }

    public class entities
    {
        public List<hashtags> hashtags { get; set; }
        public List<media> media { get; set; }
        public List<object> symbols { get; set; }
        public List<urls> urls { get; set; }
        public List<user_mentions> user_mentions { get; set; }
  
        public description description { get; set; }
        public url url { get; set; }
    }

    public class rgb
    {
        public int blue { get; set; }
        public int green { get; set; }
        public int red { get; set; }
    }

    public class palette
    {
        public float percentage { get; set; }
        public rgb rgb { get; set; }
    }

    public class profile_banner_extensions_media_color
    {
        public List<palette> palette { get; set; }
    }

    public class user
    {
        public List<string> advertiser_account_service_levels { get; set; }
        public string advertiser_account_type { get; set; }
        public object blocked_by { get; set; }
        public object blocking { get; set; }
        public string business_profile_state { get; set; }
        public object can_dm { get; set; }
        public bool contributors_enabled { get; set; }
        public DateTimeOffset created_at { get; set; }
        public bool default_profile { get; set; }
        public bool default_profile_image { get; set; }
        public string description { get; set; }
        public entities entities { get; set; }
        public object ext { get; set; }
        public int fast_followers_count { get; set; }
        public int favourites_count { get; set; }
        public object follow_request_sent { get; set; }
        public object followed_by { get; set; }
        public int followers_count { get; set; }
        public object following { get; set; }
        public int friends_count { get; set; }
        public bool geo_enabled { get; set; }
        public bool has_custom_timelines { get; set; }
        public bool has_extended_profile { get; set; }

        public long id { get; set; }

        public string id_str { get; set; }
        public bool is_translation_enabled { get; set; }
        public bool is_translator { get; set; }
        public object lang { get; set; }
        public int listed_count { get; set; }
        public string location { get; set; }
        public int media_count { get; set; }
        public object muting { get; set; }
        public string name { get; set; }
        public int normal_followers_count { get; set; }
        public object notifications { get; set; }
        public List<long> pinned_tweet_ids { get; set; }
        public List<long> pinned_tweet_ids_str { get; set; }
        public string profile_background_color { get; set; }
        public Uri profile_background_image_url { get; set; }
        public Uri profile_background_image_url_https { get; set; }
        public bool profile_background_tile { get; set; }
        public object profile_banner_extensions { get; set; }
        public object profile_banner_extensions_alt_text { get; set; }
        public object profile_banner_extensions_media_availability { get; set; }
        public profile_banner_extensions_media_color profile_banner_extensions_media_color { get; set; }
        public Uri profile_banner_url { get; set; }
        public object profile_image_extensions { get; set; }
        public object profile_image_extensions_alt_text { get; set; }
        public object profile_image_extensions_media_availability { get; set; }
        public profile_banner_extensions_media_color profile_image_extensions_media_color { get; set; }
        public Uri profile_image_url { get; set; }
        public Uri profile_image_url_https { get; set; }
        public string profile_interstitial_type { get; set; }
        public string profile_link_color { get; set; }
        public string profile_sidebar_border_color { get; set; }
        public string profile_sidebar_fill_color { get; set; }
        public string profile_text_color { get; set; }
        public bool profile_use_background_image { get; set; }
        public bool @protected { get; set; }
        public bool require_some_consent { get; set; }
        public string screen_name { get; set; }
        public int statuses_count { get; set; }
        public object time_zone { get; set; }
        public string translator_type { get; set; }
        public Uri url { get; set; }
        public object utc_offset { get; set; }
        public bool verified { get; set; }
        public object want_retweets { get; set; }
        public List<object> withheld_in_countries { get; set; }
    }

    public class user_mentions
    {
        public long id { get; set; }
        public string id_str { get; set; }
        public List<int> indices { get; set; }
        public string name { get; set; }
        public string screen_name { get; set; }
    }

    public class quoted_status
    {
        public object contributors { get; set; }
        public long conversation_id { get; set; }
        public string conversation_id_str { get; set; }
        public object coordinates { get; set; }
        public string created_at { get; set; }
        public List<int> display_text_range { get; set; }
        public entities entities { get; set; }
        public int favorite_count { get; set; }
        public bool favorited { get; set; }
        public string full_text { get; set; }
        public object geo { get; set; }
        public long id { get; set; }
        public string id_str { get; set; }
        public string in_reply_to_screen_name { get; set; }
        public long? in_reply_to_status_id { get; set; }
        public string in_reply_to_status_id_str { get; set; }
        public long? in_reply_to_user_id { get; set; }
        public string in_reply_to_user_id_str { get; set; }
        public bool is_quote_status { get; set; }
        public string lang { get; set; }
        public object place { get; set; }
        public int reply_count { get; set; }
        public long retrieved_utc { get; set; }
        public int retweet_count { get; set; }
        public bool retweeted { get; set; }
        public string source { get; set; }
        public object supplemental_language { get; set; }
        public bool truncated { get; set; }
        public user user { get; set; }
    }

    public class quoted_status_permalink
    {
        public string display { get; set; }
        public Uri expanded { get; set; }
        public Uri url { get; set; }
    }

    public class tweet
    {
        public object contributors { get; set; }
        public long? conversation_id { get; set; }
        public string conversation_id_str { get; set; }
        public object coordinates { get; set; }
        public DateTimeOffset created_at { get; set; }
        public List<int> display_text_range { get; set; }
        public entities entities { get; set; }
        public int favorite_count { get; set; }
        public bool favorited { get; set; }
        public string full_text { get; set; }
        public object geo { get; set; }
        public long id { get; set; }
        public string id_str { get; set; }
        public string in_reply_to_screen_name { get; set; }
        public long? in_reply_to_status_id { get; set; }
        public string in_reply_to_status_id_str { get; set; }
        public long? in_reply_to_user_id { get; set; }
        public string in_reply_to_user_id_str { get; set; }
        public bool is_quote_status { get; set; }
        public string lang { get; set; }
        public object place { get; set; }
        public bool possibly_sensitive { get; set; }
        public bool possibly_sensitive_editable { get; set; }
        public long? quoted_status_id { get; set; }
        public string quoted_status_id_str { get; set; }
        public quoted_status_permalink quoted_status_permalink { get; set; }
        public int reply_count { get; set; }
        public long retrieved_utc { get; set; }
        public int retweet_count { get; set; }
        public bool retweeted { get; set; }
        public string source { get; set; }
        public object supplemental_language { get; set; }
        public bool truncated { get; set; }
        public string user { get; set; }
    }
}
