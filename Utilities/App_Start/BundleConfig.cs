using System;
using System.Web.Optimization;

namespace Utilities
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery")
                .Include("~/Scripts/jquery-{version}.js")
                .Include("~/Scripts/jquery.unobtrusive-ajax.min.js")
                    .Include("~/Scripts/modal.js")
                    .Include("~/Scripts/style.js"));

        }
    }
}
