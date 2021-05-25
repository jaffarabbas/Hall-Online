using System.Web;
using System.Web.Optimization;

namespace WebAppHallOnline
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/fonts/font-awesome.min.css",
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));



            bundles.Add(new ScriptBundle("~/bundles/Websites").Include(
                        "~/Scripts/Main sites/agency.js",
                        "~/Scripts/Main sites/Animated-Pretty-Product-List-v12.js",
                        "~/Scripts/Main sites/Contact-Form-v2-Modal--Full-with-Google-Map.js",
                        "~/Scripts/Main sites/jquery.min.js",
                        "~/Scripts/Main sites/Multi-step-form.js",
                        "~/Scripts/Main sites/Product-Slider-1.js",
                        "~/Scripts/Main sites/Product-Slider-2.js",
                        "~/Scripts/Main sites/Product-Slider-3.js",
                        "~/Scripts/Main sites/Product-Slider-9.js",
                        "~/Scripts/Main sites/Product-Slider.js",
                        "~/Scripts/Main sites/SBWP-Search-Bar-With-Parameters.js",
                        "~/Scripts/Main sites/Simple-Slider.js",
                        "~/Scripts/Main sites/Swipe-Slider-7.js",
                        "~/Scripts/Main sites/bootstrap.min.js",
                        "~/Scripts/Main sites/agency.js"
                        ));

            bundles.Add(new StyleBundle("~/Content/Websites").Include(
                      "~/Content/Websites/Extra_CSS/bootstrap.min.css",
                      "~/Content/Websites/Extra_CSS/canitoLogin.css",
                      "~/Content/Websites/Extra_CSS/Contact-Form-v2-Modal--Full-with-Google-Map.css",
                      "~/Content/Websites/Extra_CSS/Multi-step-form.css",
                      "~/Content/Websites/Extra_CSS/MUSA_carousel-product-cart-slider-1.css",
                      "~/Content/Websites/Extra_CSS/MUSA_carousel-product-cart-slider.css",
                      "~/Content/Websites/Extra_CSS/Product-Slider-9-1.css",
                      "~/Content/Websites/Extra_CSS/Product-Slider-9.css",
                      "~/Content/Websites/Extra_CSS/s-product-catalog-1.css",
                      "~/Content/Websites/Extra_CSS/s-product-catalog-2.css",
                      "~/Content/Websites/Extra_CSS/s-product-catalog",
                      "~/Content/Websites/Extra_CSS/SBWP-Search-Bar-With-Parameters.css",
                      "~/Content/Websites/Extra_CSS/Simple-Slider.css",
                      "~/Content/Websites/Extra_CSS/smoothproducts.css",
                      "~/Content/Websites/Extra_CSS/styles.css",
                      "~/Content/Websites/Extra_CSS/Swipe-Slider-7.css",
                      "~/Content/Websites/Extra_CSS/Testimonials.css",
                      "~/Content/Websites/Extra_CSS/untitled.css",
                      "~/Content/Websites/Extra_CSS/Brands.css",
                      "~/Content/Websites/Extra_CSS/Pretty-Footer.css",
                      "~/Content/WebSites/Index.css",
                      "~/Content/WebSites/media.css"));




                  bundles.Add(new StyleBundle("~/Content/Admin_css").Include(
                                        "~/Content/Admin/assets/css/bootstrap.min.css",
                                        "~/Content/Admin/assets/css/now-ui-dashboard.css",
                                        "~/Content/Admin/assets/demo/demo.css"));


                         bundles.Add(new ScriptBundle("~/bundles/Admin").Include(
                        "~/Content/Admin/assets/js/core/jquery.min.js",
                        "~/Content/Admin/assets/js/core/popper.min.js",
                        "~/Content/Admin/assets/js/core/bootstrap.min.js",
                        "~/Content/Admin/assets/js/plugins/perfect-scrollbar.jquery.min.js",
                        "~/Content/Admin/assets/js/plugins/chartjs.min.js",
                        "~/Content/Admin/assets/js/chart_runner.js",
                         "~/Content/Admin/assets/demo/demo.js",
                        "~/Content/Admin/assets/js/plugins/bootstrap-notify.js",
                        "~/Content/Admin/assets/js/now-ui-dashboard.min.js?v=1.5.0"
                        ));


         }                        
    }
}
