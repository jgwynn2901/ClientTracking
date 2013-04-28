Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Optimization

Public Class BundleConfig
  ' For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254726
  Public Shared Sub RegisterBundles(ByVal bundles As BundleCollection)
    bundles.Add(New ScriptBundle("~/bundles/WebFormsJs").Include(
                    "~/Scripts/WebForms/WebForms.js",
                    "~/Scripts/WebForms/WebUIValidation.js",
                    "~/Scripts/WebForms/MenuStandards.js",
                    "~/Scripts/WebForms/Focus.js",
                    "~/Scripts/WebForms/GridView.js",
                    "~/Scripts/WebForms/DetailsView.js",
                    "~/Scripts/WebForms/TreeView.js",
                    "~/Scripts/WebForms/WebParts.js"))

    ' Order is very important for these files to work, they have explicit dependencies
    bundles.Add(New ScriptBundle("~/bundles/MsAjaxJs").Include(
            "~/Scripts/WebForms/MsAjax/MicrosoftAjax.js",
            "~/Scripts/WebForms/MsAjax/MicrosoftAjaxApplicationServices.js",
            "~/Scripts/WebForms/MsAjax/MicrosoftAjaxTimer.js",
            "~/Scripts/WebForms/MsAjax/MicrosoftAjaxWebForms.js"))

    bundles.Add(New ScriptBundle("~/bundles/jquery").Include(
              "~/Scripts/jquery-{version}.js"))

    bundles.Add(New ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/underscore.js",
                "~/Scripts/bootstrap.js"))

    bundles.Add(New StyleBundle("~/Content/css").Include(
                  "~/Content/bootstrap.css",
                  "~/Content/bootstrap2.css",
                  "~/Content/bootstrap-responsive.css",
                  "~/Content/Site.css"))

    ' Use the Development version of Modernizr to develop with and learn from. Then, when you’re
    ' ready for production, use the build tool at http://modernizr.com to pick only the tests you need
    bundles.Add(New ScriptBundle("~/bundles/modernizr").Include(
                    "~/Scripts/modernizr-*"))

  End Sub
End Class
