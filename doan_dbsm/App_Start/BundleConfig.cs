using System.Web;
using System.Web.Optimization;

namespace doan_dbsm
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        { 
            bundles.Add(new ScriptBundle("~/bundles/admin/js").Include(
                    "~/Content/share/js/main.js", "~/Content/share/vendor/perfect-scrollbar/perfect-scrollbar.min.js", "~/Content/share/vendor/sweetalert/sweetalert.min.js", "~/Content/share/vendor/isotope/isotope.pkgd.min.js"
                    , "~/Content/share/vendor/MagnificPopup/jquery.magnific-popup.min.js", "~/Content/share/vendor/parallax100/parallax100.js",
                    "~/Content/share/js/slick-custom.js", "~/Content/share/vendor/slick/slick.min.js","~/Content/share/vendor/daterangepicker/daterangepicker.js", "~/Content/share/vendor/daterangepicker/moment.min.js",
                    "~/Content/share/vendor/select2/select2.min.js", "~/Content/share/vendor/bootstrap/js/bootstrap.min.js", "~/Content/share/vendor/bootstrap/js/popper.js", "~/Content/share/vendor/animsition/js/animsition.min.js",
                    "~/Content/share/vendor/jquery/jquery-3.2.1.min.js", "~/Content/share/vendor/slick/slick.min.js"));

            bundles.Add(new StyleBundle("~/Content/admin/css").Include(
                      "~/Content/share/images/icons/favicon.png",
                      "~/Content/share/vendor/bootstrap/css/bootstrap.min.css",
                      "~/Content/share/fonts/font-awesome-4.7.0/css/font-awesome.min.css",
                      "~/Content/share/fonts/iconic/css/material-design-iconic-font.min.css",
                      "~/Content/share/fonts/linearicons-v1.0.0/icon-font.min.css",
                      "~/Content/share/vendor/animate/animate.css",
                      "~/Content/share/vendor/css-hamburgers/hamburgers.min.css",
                      
                      "~/Content/share/vendor/select2/select2.min.css",
                      "~/Content/share/vendor/daterangepicker/daterangepicker.css",
                      "~/Content/share/vendor/slick/slick.css",
                      "~/Content/share/vendor/MagnificPopup/magnific-popup.css",
                      "~/Content/share/vendor/perfect-scrollbar/perfect-scrollbar.css",
                      "~/Content/share/css/util.css"));
        }
    }
}
