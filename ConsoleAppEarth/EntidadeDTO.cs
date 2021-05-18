using System.Collections.Generic;

namespace ConsoleAppEarth
{
    public class Landfield
    {
        public string listing_id { get; set; }
        public string country_code { get; set; }
        public string property_class { get; set; }
        public string listing_price { get; set; }
        public string property_amounts_tiles { get; set; }
        public string discount_percentage { get; set; }
        public string created_timestamp { get; set; }
        public string country_id { get; set; }
        public string country_name { get; set; }
        public string country_url_name { get; set; }
        public string country_new_tile_price { get; set; }
        public string country_tile_value { get; set; }
        public string country_sold_tiles { get; set; }
    }

    public class Root
    {
        public int total_landfields { get; set; }
        public int max_page { get; set; }
        public string current_page { get; set; }
        public List<Landfield> landfields { get; set; }
    }
}
