using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace countries_web_app.Models
{
    public class Country
    {
        public string Name { get; set; }
        public string OfficialLanguages { get; set; }
        public string Greeting { get; set; }
        public string Description { get; set; }
        public string Colors { get; set; }

        public Country() { }
        public Country(string name, string officialLanguage, string greeting, string description, string colors)
        {
            this.Name = name;
            this.OfficialLanguages = officialLanguage;
            this.Greeting = greeting;
            this.Description = description;
            this.Colors = colors;
        }
    }
}
