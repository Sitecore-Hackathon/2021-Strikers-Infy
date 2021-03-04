using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.Links;
using Sitecore.Data.Fields;
using Sitecore.Resources.Media;
using Sitecore.Mvc.Presentation;
using Sitecore;
using Sitecore.Data;
using Sitecore.Data.Items;
using StrikersInfy.Foundation.Entensions.Models;

namespace StrikersInfy.Foundation.Entensions.Helpers
{
    public class SitecoreFieldHelper
    {
        public static string GetLinkFieldURL(LinkField field)
        {
            var link = string.Empty;

            if (field == null)
                link = string.Empty;
            else
            {
                switch (field.LinkType.ToLower())
                {
                    case "internal":
                        link = GetItemUrl(field);
                        break;
                    case "media":
                        link = field.TargetItem == null ? string.Empty : MediaManager.GetMediaUrl(field.TargetItem);
                        break;
                    case "external":
                        link = field.Url;
                        break;
                    case "anchor":
                        link = string.IsNullOrEmpty(field.Anchor) ? string.Empty : field.Anchor;
                        break;
                    case "mailto":
                        link = field.Url;
                        break;
                    case "javascript":
                        link = field.Url;
                        break;
                    default:
                        link = field.Url;
                        break;
                }
            }
            return link;
        }

        private static string GetItemUrl(LinkField linkField)
        {
            if (linkField.TargetItem == null)
                return string.Empty;

            string linkUrl = LinkManager.GetItemUrl(linkField.TargetItem);

            return linkUrl;
        }

        public static Sitecore.Data.Items.Item GetDatasourceItem()
        {
            var datasourceId = RenderingContext.Current.Rendering.DataSource;

            return ID.IsID(datasourceId) ? Context.Database.GetItem(datasourceId) : null;
        }

        public static Sitecore.Data.Items.Item GetDatasourceItem(ID datasourceId)
        {
            return Context.Database.GetItem(datasourceId);
        }

        /// <summary>
        /// Sitecore checkbox field IsChecked
        /// </summary>
        /// <param name="item">Current Sitecore Item</param>
        /// <param name="itemId">Checkbox Field ID</param>
        /// <returns></returns>
        public static bool IsCheckboxChecked(CheckboxField checkboxField)
        {
            if (checkboxField == null)
                throw new Exception("Checkbox Field error");

            return checkboxField.Checked;
        }

        public static SitecoreImageField GetImageField(ImageField imgField)
        {
            if (imgField != null && imgField.MediaItem != null)
            {
                string imageUrl = MediaManager.GetMediaUrl(imgField.MediaItem);
                string imageAlt = imgField.Alt;

                SitecoreImageField sitecoreImageField = new SitecoreImageField
                {
                    ImageUrl = imageUrl,
                    ImageAlt = imageAlt
                };

                return sitecoreImageField;
            }

            return null;
        }
    }
}
