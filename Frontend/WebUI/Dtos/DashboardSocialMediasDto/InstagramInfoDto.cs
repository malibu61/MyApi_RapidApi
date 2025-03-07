namespace WebUI.Dtos.DashboardSocialMediasDto
{
    public class InstagramInfoDto
    {
        public string id { get; set; }
        public string fbid { get; set; }
        public string username { get; set; }
        public string full_name { get; set; }
        public string bio { get; set; }
        public int followers { get; set; }
        public int following { get; set; }
        public string category_name { get; set; }
        public bool is_private { get; set; }
        public bool is_verified { get; set; }
        public bool is_business { get; set; }
        public string profile_pic_url { get; set; }
        public string profile_pic_url_proxy { get; set; }
        public string profile_pic_url_hd { get; set; }
        public string profile_pic_url_hd_proxy { get; set; }
        public int media_count { get; set; }
        public Lastmedia lastMedia { get; set; }

        public class Lastmedia
        {
            public Medium[] media { get; set; }
            public Page_Info page_info { get; set; }
        }

        public class Page_Info
        {
            public bool has_next_page { get; set; }
            public string next { get; set; }
        }

        public class Medium
        {
            public string id { get; set; }
            public string shortcode { get; set; }
            public string link_to_post { get; set; }
            public string display_url { get; set; }
            public string display_url_proxy { get; set; }
            public Is_Video[] is_video { get; set; }
            public bool is_pinned { get; set; }
            public int comment_count { get; set; }
            public int like { get; set; }
            public string caption { get; set; }
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
            public Thumbnail_Variant thumbnail_variant { get; set; }
            public long timestamp { get; set; }
            public bool is_more_than_one { get; set; }
            public object[] children { get; set; }
            public string video_url { get; set; }
            public string accessibility_caption { get; set; }
        }

        public class Thumbnail_Variant
        {
            public Xxsmall xxsmall { get; set; }
            public _640X1136 _640x1136 { get; set; }
            public _480X852 _480x852 { get; set; }
            public _320X568 _320x568 { get; set; }
            public _240X426 _240x426 { get; set; }
            public _640X640 _640x640 { get; set; }
            public _270X270 _270x270 { get; set; }
            public _180X180 _180x180 { get; set; }
            public _135X135 _135x135 { get; set; }
            public _85X85 _85x85 { get; set; }
            public _1440X1800 _1440x1800 { get; set; }
            public _1080X1350 _1080x1350 { get; set; }
            public _720X900 _720x900 { get; set; }
            public _640X800 _640x800 { get; set; }
            public _480X600 _480x600 { get; set; }
            public _320X400 _320x400 { get; set; }
            public _240X300 _240x300 { get; set; }
            public _864X864 _864x864 { get; set; }
            public _600X600 _600x600 { get; set; }
            public _512X512 _512x512 { get; set; }
            public _384X384 _384x384 { get; set; }
            public _256X256 _256x256 { get; set; }
            public _192X192 _192x192 { get; set; }
            public _120X120 _120x120 { get; set; }
            public _720X1280 _720x1280 { get; set; }
            public _640X1138 _640x1138 { get; set; }
            public _480X853 _480x853 { get; set; }
            public _320X569 _320x569 { get; set; }
            public _240X427 _240x427 { get; set; }
            public _720X720 _720x720 { get; set; }
            public _360X360 _360x360 { get; set; }
            public _84X84 _84x84 { get; set; }
            public _1170X2080 _1170x2080 { get; set; }
            public _608X608 _608x608 { get; set; }
            public _422X422 _422x422 { get; set; }
            public _480X854 _480x854 { get; set; }
            public _2268X4032 _2268x4032 { get; set; }
            public _1080X1920 _1080x1920 { get; set; }
        }

        public class Xxsmall
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class _640X1136
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class _480X852
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class _320X568
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class _240X426
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class _640X640
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class _270X270
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class _180X180
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class _135X135
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class _85X85
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class _1440X1800
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class _1080X1350
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class _720X900
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class _640X800
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class _480X600
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class _320X400
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class _240X300
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class _864X864
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class _600X600
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class _512X512
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class _384X384
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class _256X256
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class _192X192
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class _120X120
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class _720X1280
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class _640X1138
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class _480X853
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class _320X569
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class _240X427
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class _720X720
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class _360X360
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class _84X84
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class _1170X2080
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class _608X608
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class _422X422
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class _480X854
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class _2268X4032
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class _1080X1920
        {
            public string thumbnail_src { get; set; }
            public string thumbnail_src_proxy { get; set; }
        }

        public class Is_Video
        {
            public int bandwidth { get; set; }
            public int height { get; set; }
            public string id { get; set; }
            public int type { get; set; }
            public string url { get; set; }
            public int width { get; set; }
        }

    }
}
