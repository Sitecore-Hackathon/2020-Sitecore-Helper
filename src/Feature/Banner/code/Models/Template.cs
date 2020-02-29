using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackathon.Feature.Banner.Models
{
    public class Template
    {
        public struct SlideItem
        {
            public const string ID = "{6B24A470-EB9A-46BB-BBBB-53FC92113C41}";

            public struct Fields
            {
                public const string Description = "{AA98D154-75CE-4573-9676-79C62919E53E}";
                public const string Image = "{F33C1590-D915-48E0-9845-8A9B5C56A1C1}";
                public const string Link = "{45D6FA05-6653-4463-8674-4F78C583F611}";
                public const string Title = "{9ABC1DEC-B130-4848-A0E4-9B02ED47F854}";
            }
        }


        public struct Slider
        {
            public const string ID = "{C19275FA-C270-4C0D-A560-AB9816FD2DD7}";

            public struct Fields
            {
                public const string Slides = "{2B451274-3A2F-4D6C-ADE5-C5E3169C1BD5}";
            }
        }
    }
}


