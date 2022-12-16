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
            //var bundle = new scriptbundle("~/bundle/js");

            //bundle.include("~/content/script/javascript1.js",
            //    "~/content/script/javascript2.js",
            //    "~/content/script/javascript3.js",
            //    "~/content/script/javascript4.js",
            //    "/content/script/javascript5.js"
            //    );
            //bundles.add(bundle);

            bundles.Add(new ScriptBundle("~/bundle/js").IncludeDirectory("~/Content/Script","*.js"));
            bundles.Add(new StyleBundle("~/bundle/css").IncludeDirectory("~/Content/Style", "*.css"));


            BundleTable.EnableOptimizations = true;

        }
    }
}