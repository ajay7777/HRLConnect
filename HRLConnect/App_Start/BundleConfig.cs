using System.Web;
using System.Web.Optimization;

namespace HRLConnect
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            BundleTable.EnableOptimizations = true;

            bundles.Add(new ScriptBundle("~/bundles/HRLConnect")
            .IncludeDirectory("~/Scripts/Controllers", "*.js")
            .Include("~/Scripts/HRLConnect.js"));
        }
    }
}
