﻿using Sitecore;
using Sitecore.Shell.Framework.Commands;
using Sitecore.Text;
using Sitecore.Web.UI.Sheer;

namespace StrikersInfy.Feature.Translator.Commands
{
    public class TranslatorDialog : Sitecore.Shell.Framework.Commands.Command
    {
        public override void Execute(CommandContext context)
        {
            Sitecore.Context.ClientPage.Start(this, "Run", context.Parameters);
        }

        protected static void Run(ClientPipelineArgs args)
        {
            if (!args.IsPostBack)
            {
                UrlString urlString = new UrlString(UIUtil.GetUri("control:TranslatorDialog"));
                SheerResponse.ShowModalDialog(urlString.ToString(), "800", "400", "", true);
                args.WaitForPostBack();
            }
            else
            {
                if (args.HasResult)
                {
                    if (Sitecore.Context.Item.Name == "Content Editor")
                    {
                        Sitecore.Context.ClientPage.ClientResponse.SetLocation(Sitecore.Links.LinkManager.GetItemUrl(Sitecore.Context.Item));
                    }
                }
            }
        }
    }
}