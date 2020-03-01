using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Hackathon.Feature.Banner.Models.Template;

namespace Hackathon.Feature.Banner.Models
{
    [SitecoreType(TemplateId = Template.Slider.ID)]
    public interface IBanner 
    {
        #region Sitecore Data
        [SitecoreField(Template.Slider.Fields.Slides)]
        IEnumerable<SlideItem> Slides { get; set; }

        #endregion
    }
}



