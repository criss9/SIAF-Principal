using System.Web;
using System.Web.Optimization;

namespace SIAF
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.bundle.js"));

            bundles.Add(new ScriptBundle("~/bundles/pikeadm").Include(
                      "~/Scripts/pikeAdmin/detect.js",
                       "~/Scripts/pikeAdmin/fastclick.js",
                        "~/Scripts/pikeAdmin/jquery.blockUI.js",
                         "~/Scripts/pikeAdmin/jquery.nicescroll.js",
                          "~/Scripts/pikeAdmin/jquery.scrollto.min.js",
                          "~/Scripts/pikeAdmin/switchery.min.js",
                      "~/Scripts/pikeAdmin/pikeadmin.js"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/Plugins/switchery/swtchery.min.css",
                      "~/Content/bootstrap.css",
                      "~/Content/font-awesome.min.css",
                     "~/Content/Site.css"));
#if !DEBUG
            BundleTable.EnableOptimizations = true;
#endif
        }
    }
}
