using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace BundlingandMinification
{
    public class BundleConfig
    {
        public static void RegisterBundle(BundleCollection bundles)
        {
            //var bundle = new ScriptBundle("~/Bundle/js");

            // bundle.Include("~/Content/Script/JavaScript1.js",
            //     "~/Content/script/javaScript2.js",
            //     "~/Content/script/javaScript3.js",
            //     "~/Content/script/javaScript4.js",
            //     "/Content/script/javaScript5.js"
            //     );
            // bundles.Add(bundle);

            bundles.Add(new ScriptBundle("~/bundle/js").IncludeDirectory("~/Content/Script","*.js"));
            bundles.Add(new StyleBundle("~/bundle/css").IncludeDirectory("~/Content/Style", "*.css"));


            BundleTable.EnableOptimizations = true;

        }
    }
}