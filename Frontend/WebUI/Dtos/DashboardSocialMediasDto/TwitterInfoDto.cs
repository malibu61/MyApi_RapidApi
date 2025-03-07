namespace WebUI.Dtos.DashboardSocialMediasDto
{
    public class TwitterInfoDto
    {

        public string status { get; set; }
        public string profile { get; set; }
        public string rest_id { get; set; }
        //public bool blue_verified { get; set; }
        public object[] affiliates { get; set; }
        public Business_Account business_account { get; set; }
        public string avatar { get; set; }
        public string header_image { get; set; }
        public string desc { get; set; }
        public string name { get; set; }
        public string website { get; set; }
        public object _protected { get; set; }
        public string location { get; set; }
        public int? friends { get; set; }
        public int sub_count { get; set; }
        public int statuses_count { get; set; }
        public int media_count { get; set; }
        public object[] pinned_tweet_ids_str { get; set; }
        public string created_at { get; set; }
        public string id { get; set; }


        public class Business_Account
        {
            public int affiliates_count { get; set; }
        }

    }
}
