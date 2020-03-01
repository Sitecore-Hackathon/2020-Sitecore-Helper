using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Configuration.Attributes;
using Hackathon.Foundation.ORM;

namespace Hackathon.Feature.Banner.Models
{
    [SitecoreType(TemplateId = Template.SlideItem.ID)]
    public class IBannerImages
    {
        #region Sitecore Data
        [SitecoreField(Template.SlideItem.Fields.Image)]
        Glass.Mapper.Sc.Fields.Image SlideImage { get; set; }

        [SitecoreField(Template.SlideItem.Fields.Link)]
        Glass.Mapper.Sc.Fields.Link SlideURL { get; set; }

        [SitecoreField(Template.SlideItem.Fields.Title)]
        Glass.Mapper.Sc.Fields.HtmlEncodedString Title { get; set; }

        [SitecoreField(Template.SlideItem.Fields.Description)]
        Glass.Mapper.Sc.Fields.HtmlEncodedString Description { get; set; }
        #endregion
    }
}