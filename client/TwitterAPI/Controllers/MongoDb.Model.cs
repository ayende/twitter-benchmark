using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

[BsonIgnoreExtraElements]
public class UserModel
{
    [BsonId]
    [BsonElement("_id")]
    public string Id { get; set; }

    [BsonElement("id")]
    public long UserId { get; set; }

    [BsonElement("id_str")]
    public string UserIdString { get; set; }

    [BsonElement("name")]
    public string Name { get; set; }

    [BsonElement("screen_name")]
    public string ScreenName { get; set; }

    [BsonElement("location")]
    public string Location { get; set; }

    [BsonElement("description")]
    public string Description { get; set; }

    [BsonElement("url")]
    public string Url { get; set; }

    [BsonElement("entities")]
    public UserEntities Entities { get; set; }

    [BsonElement("protected")]
    public bool Protected { get; set; }

    [BsonElement("followers_count")]
    public int FollowersCount { get; set; }

    [BsonElement("fast_followers_count")]
    public int FastFollowersCount { get; set; }

    [BsonElement("normal_followers_count")]
    public int NormalFollowersCount { get; set; }

    [BsonElement("friends_count")]
    public int FriendsCount { get; set; }

    [BsonElement("listed_count")]
    public int ListedCount { get; set; }

    [BsonElement("favourites_count")]
    public int FavouritesCount { get; set; }

    [BsonElement("utc_offset")]
    public int? UTCOffset { get; set; }

    [BsonElement("time_zone")]
    public string TimeZone { get; set; }

    [BsonElement("geo_enabled")]
    public bool GeoEnabled { get; set; }

    [BsonElement("verified")]
    public bool Verified { get; set; }

    [BsonElement("statuses_count")]
    public int StatusesCount { get; set; }

    [BsonElement("media_count")]
    public int MediaCount { get; set; }

    [BsonElement("lang")]
    public string Language { get; set; }

    [BsonElement("contributors_enabled")]
    public bool ContributorsEnabled { get; set; }

    [BsonElement("is_translator")]
    public bool IsTranslator { get; set; }

    [BsonElement("is_translation_enabled")]
    public bool IsTranslationEnabled { get; set; }

    [BsonElement("profile_background_color")]
    public string ProfileBackgroundColor { get; set; }

    [BsonElement("profile_background_image_url")]
    public string ProfileBackgroundImageUrl { get; set; }

    [BsonElement("profile_background_image_url_https")]
    public string ProfileBackgroundImageUrlHttps { get; set; }

    [BsonElement("profile_background_tile")]
    public bool ProfileBackgroundTile { get; set; }

    [BsonElement("profile_image_url")]
    public string ProfileImageUrl { get; set; }

    [BsonElement("profile_image_url_https")]
    public string ProfileImageUrlHttps { get; set; }

    [BsonElement("profile_banner_url")]
    public string ProfileBannerUrl { get; set; }

    [BsonElement("profile_image_extensions_media_color")]
    public MediaColorExtensions ProfileImageExtensionsMediaColor { get; set; }

    [BsonElement("profile_image_extensions_alt_text")]
    public string ProfileImageExtensionsAltText { get; set; }

    [BsonElement("profile_image_extensions")]
    public ImageExtensions ProfileImageExtensions { get; set; }

    [BsonElement("profile_banner_extensions_alt_text")]
    public string ProfileBannerExtensionsAltText { get; set; }

    [BsonElement("profile_banner_extensions_media_color")]
    public MediaColorExtensions ProfileBannerExtensionsMediaColor { get; set; }

    [BsonElement("profile_banner_extensions")]
    public ImageExtensions ProfileBannerExtensions { get; set; }

    [BsonElement("profile_link_color")]
    public string ProfileLinkColor { get; set; }

    [BsonElement("profile_sidebar_border_color")]
    public string ProfileSidebarBorderColor { get; set; }

    [BsonElement("profile_sidebar_fill_color")]
    public string ProfileSidebarFillColor { get; set; }

    [BsonElement("profile_text_color")]
    public string ProfileTextColor { get; set; }

    [BsonElement("profile_use_background_image")]
    public bool ProfileUseBackgroundImage { get; set; }

    [BsonElement("has_extended_profile")]
    public bool HasExtendedProfile { get; set; }

    [BsonElement("default_profile")]
    public bool DefaultProfile { get; set; }

    [BsonElement("default_profile_image")]
    public bool DefaultProfileImage { get; set; }

    [BsonElement("pinned_tweet_ids")]
    public string[] PinnedTweetIds { get; set; }

    [BsonElement("pinned_tweet_ids_str")]
    public string[] PinnedTweetIdsStr { get; set; }

    [BsonElement("has_custom_timelines")]
    public bool HasCustomTimelines { get; set; }

    [BsonElement("can_dm")]
    public bool? CanDM { get; set; }

    [BsonElement("following")]
    public bool? Following { get; set; }

    [BsonElement("follow_request_sent")]
    public bool? FollowRequestSent { get; set; }

    [BsonElement("notifications")]
    public bool? Notifications { get; set; }

    [BsonElement("muting")]
    public bool? Muting { get; set; }

    [BsonElement("blocking")]
    public bool? Blocking { get; set; }

    [BsonElement("blocked_by")]
    public bool? BlockedBy { get; set; }

    [BsonElement("want_retweets")]
    public bool? WantRetweets { get; set; }

    [BsonElement("advertiser_account_type")]
    public string AdvertiserAccountType { get; set; }

    [BsonElement("advertiser_account_service_levels")]
    public string[] AdvertiserAccountServiceLevels { get; set; }

    [BsonElement("profile_interstitial_type")]
    public string ProfileInterstitialType { get; set; }

    [BsonElement("business_profile_state")]
    public string BusinessProfileState { get; set; }

    [BsonElement("translator_type")]
    public string TranslatorType { get; set; }

    [BsonElement("withheld_in_countries")]
    public string[] WithheldInCountries { get; set; }

    [BsonElement("followed_by")]
    public bool? FollowedBy { get; set; }

    [BsonElement("require_some_consent")]
    public bool RequireSomeConsent { get; set; }

    [BsonElement("created_at")]
    public DateTime CreatedAt { get; set; }
}

public class UserEntities
{
    [BsonElement("url")]
    public UserUrl Url { get; set; }

    [BsonElement("description")]
    public UserDescription Description { get; set; }
}

public class UserUrl
{
    [BsonElement("urls")]
    public UserUrlData[] Urls { get; set; }
}

public class UserUrlData
{
    [BsonElement("url")]
    public string Url { get; set; }

    [BsonElement("expanded_url")]
    public string ExpandedUrl { get; set; }

    [BsonElement("display_url")]
    public string DisplayUrl { get; set; }

    [BsonElement("indices")]
    public int[] Indices { get; set; }
}

public class UserDescription
{
    [BsonElement("urls")]
    public UserDescriptionUrl[] Urls { get; set; }
}

public class UserDescriptionUrl
{
    // Add properties if necessary
}

public class MediaColorExtensions
{
    [BsonElement("palette")]
    public Palette[] Palette { get; set; }
}

public class Palette
{
    [BsonElement("rgb")]
    public Rgb RGB { get; set; }

    [BsonElement("percentage")]
    public double Percentage { get; set; }
}

public class Rgb
{
    [BsonElement("red")]
    public int Red { get; set; }

    [BsonElement("green")]
    public int Green { get; set; }

    [BsonElement("blue")]
    public int Blue { get; set; }
}

public class ImageExtensions
{
    [BsonElement("mediaStats")]
    public MediaStats MediaStats { get; set; }
}

public class MediaStats
{
    [BsonElement("r")]
    public R R { get; set; }

    [BsonElement("ttl")]
    public int TTL { get; set; }
}

public class R
{
    [BsonElement("missing")]
    public bool? Missing { get; set; }
}



[BsonIgnoreExtraElements]
public class TweetModel
{
    [BsonId]
    [BsonElement("_id")]
    public string Id { get; set; }

    [BsonElement("id")]
    public long TweetId { get; set; }

    [BsonElement("id_str")]
    public string TweetIdString { get; set; }

    [BsonElement("full_text")]
    public string FullText { get; set; }

    [BsonElement("truncated")]
    public bool Truncated { get; set; }

    [BsonElement("display_text_range")]
    public int[] DisplayTextRange { get; set; }


    [BsonElement("source")]
    public string Source { get; set; }

    [BsonElement("in_reply_to_status_id")]
    public long? InReplyToStatusId { get; set; }

    [BsonElement("in_reply_to_status_id_str")]
    public string InReplyToStatusIdString { get; set; }

    [BsonElement("in_reply_to_user_id")]
    public long? InReplyToUserId { get; set; }

    [BsonElement("in_reply_to_user_id_str")]
    public string InReplyToUserIdString { get; set; }

    [BsonElement("in_reply_to_screen_name")]
    public string InReplyToScreenName { get; set; }

    [BsonElement("geo")]
    public object Geo { get; set; }

    [BsonElement("coordinates")]
    public object Coordinates { get; set; }

    [BsonElement("place")]
    public object Place { get; set; }

    [BsonElement("contributors")]
    public object Contributors { get; set; }

    [BsonElement("is_quote_status")]
    public bool IsQuoteStatus { get; set; }

    [BsonElement("retweet_count")]
    public int RetweetCount { get; set; }

    [BsonElement("favorite_count")]
    public int FavoriteCount { get; set; }

    [BsonElement("reply_count")]
    public int ReplyCount { get; set; }

    [BsonElement("conversation_id")]
    public long ConversationId { get; set; }

    [BsonElement("conversation_id_str")]
    public string ConversationIdString { get; set; }

    [BsonElement("favorited")]
    public bool Favorited { get; set; }

    [BsonElement("retweeted")]
    public bool Retweeted { get; set; }

    [BsonElement("possibly_sensitive")]
    public bool PossiblySensitive { get; set; }

    [BsonElement("possibly_sensitive_editable")]
    public bool PossiblySensitiveEditable { get; set; }

    [BsonElement("lang")]
    public string Language { get; set; }

    [BsonElement("supplemental_language")]
    public object SupplementalLanguage { get; set; }

    [BsonElement("retrieved_utc")]
    public long RetrievedUtc { get; set; }

    [BsonElement("created_at")]
    public DateTime CreatedAt { get; set; }

    [BsonElement("user")]
    public string User { get; set; }

}


[BsonIgnoreExtraElements]
public class Media
{
    [BsonElement("id")]
    public long Id { get; set; }

    [BsonElement("id_str")]
    public string IdString { get; set; }

    [BsonElement("indices")]
    public int[] Indices { get; set; }

    [BsonElement("media_url")]
    public string MediaUrl { get; set; }

    [BsonElement("media_url_https")]
    public string MediaUrlHttps { get; set; }

    [BsonElement("url")]
    public string Url { get; set; }

    [BsonElement("display_url")]
    public string DisplayUrl { get; set; }

    [BsonElement("expanded_url")]
    public string ExpandedUrl { get; set; }

    [BsonElement("type")]
    public string Type { get; set; }

    [BsonElement("original_info")]
    public OriginalInfo OriginalInfo { get; set; }

    [BsonElement("sizes")]
    public Sizes Sizes { get; set; }
}

public class OriginalInfo
{
    [BsonElement("width")]
    public int Width { get; set; }

    [BsonElement("height")]
    public int Height { get; set; }

    [BsonElement("focus_rects")]
    public FocusRect[] FocusRects { get; set; }
}

public class FocusRect
{
    [BsonElement("x")]
    public int X { get; set; }

    [BsonElement("y")]
    public int Y { get; set; }

    [BsonElement("h")]
    public int Height { get; set; }

    [BsonElement("w")]
    public int Width { get; set; }
}

public class Sizes
{
    [BsonElement("thumb")]
    public ThumbSize Thumb { get; set; }

    [BsonElement("small")]
    public ImageSize Small { get; set; }

    [BsonElement("large")]
    public ImageSize Large { get; set; }

    [BsonElement("medium")]
    public ImageSize Medium { get; set; }
}

public class ThumbSize
{
    [BsonElement("w")]
    public int Width { get; set; }

    [BsonElement("h")]
    public int Height { get; set; }

    [BsonElement("resize")]
    public string Resize { get; set; }
}

public class ImageSize
{
    [BsonElement("w")]
    public int Width { get; set; }

    [BsonElement("h")]
    public int Height { get; set; }

    [BsonElement("resize")]
    public string Resize { get; set; }
}

public class ExtendedEntities
{
    [BsonElement("media")]
    public Media[] Media { get; set; }
}
