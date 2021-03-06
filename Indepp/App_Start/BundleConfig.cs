﻿using System.Web;
using System.Web.Optimization;

namespace Indepp
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                      "~/Scripts/jquery-2.1.4.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/bootstrap-combobox.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap-combobox.css",
                      "~/Content/font-awesome.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/editor").Include(
                "~/Scripts/ckeditor/ckeditor.js",
                "~/Scripts/ckeditor/config.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/knockout").Include(
                "~/Scripts/knockout-3.3.0.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/placemap").Include(
                "~/Scripts/fontawesome-markers.js",
                "~/Scripts/google-map-helper.js",
                "~/Scripts/places-map.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/placesearch").Include(
                "~/Scripts/google-place-search.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/placepublishhelper").Include(
                "~/Scripts/google-place-publish-helper.js"
                ));
        }
    }
}