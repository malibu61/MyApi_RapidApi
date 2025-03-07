namespace WebUI.Dtos.DashboardSocialMediasDto
{
    public class LinkednInfoDto
    {
        public Data data { get; set; }
        public string message { get; set; }


        public class Data
        {
            public object about { get; set; }
            public string city { get; set; }
            public object company { get; set; }
            public object company_description { get; set; }
            public string company_domain { get; set; }
            public object company_employee_range { get; set; }
            public object company_industry { get; set; }
            public object company_linkedin_url { get; set; }
            public object company_logo_url { get; set; }
            public object company_website { get; set; }
            public object company_year_founded { get; set; }
            public int connection_count { get; set; }
            public string country { get; set; }
            public object current_company_join_month { get; set; }
            public object current_company_join_year { get; set; }
            public string current_job_duration { get; set; }
            public Education[] educations { get; set; }
            public string email { get; set; }
            public object[] experiences { get; set; }
            public string first_name { get; set; }
            public int follower_count { get; set; }
            public string full_name { get; set; }
            public string headline { get; set; }
            public object hq_city { get; set; }
            public object hq_country { get; set; }
            public object hq_region { get; set; }
            public object job_title { get; set; }
            public object[] languages { get; set; }
            public string last_name { get; set; }
            public string linkedin_url { get; set; }
            public string location { get; set; }
            public string phone { get; set; }
            public string profile_id { get; set; }
            public string profile_image_url { get; set; }
            public string public_id { get; set; }
            public string school { get; set; }
            public string state { get; set; }
            public string urn { get; set; }
        }

        public class Education
        {
            public string activities { get; set; }
            public string date_range { get; set; }
            public string degree { get; set; }
            public string end_month { get; set; }
            public int end_year { get; set; }
            public string field_of_study { get; set; }
            public string school { get; set; }
            public string school_id { get; set; }
            public string school_linkedin_url { get; set; }
            public string school_logo_url { get; set; }
            public string start_month { get; set; }
            public int start_year { get; set; }
        }

    }
}
