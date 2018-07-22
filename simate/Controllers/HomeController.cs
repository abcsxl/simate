using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using simate.Models;

namespace simate.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringLocalizer<HomeController> _localizer;
        private readonly ILogger _logger;

        public HomeController(IStringLocalizer<HomeController> localizer, ILogger<HomeController> logger)
        {
            _localizer = localizer;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = _localizer["Wuhan SIMATE Bearing Co., Ltd"];

            Response.HttpContext.Request.Cookies.TryGetValue(Microsoft.AspNetCore.Localization.CookieRequestCultureProvider.DefaultCookieName, out string lan);
            if (lan?.IndexOf("en-US") >= 0)
            {
                ViewData["Content"] =
                    "<p>" +
                    "Wuhan SIMATE Bearing Co., Ltd. is a professional company that sells bearings and related products.<br />" +
                    "Founded in 2006, SIMATE is committed to providing a full range of bearing one-stop solutions. The company's own trademark \"SIMATE &reg;\" is a more reliable and high-quality bearing product for users, creating more value for customers. There are over 20,500 models of stock in stock in 20 major categories. With dedicated inventory for industry customer needs, we are always ready to meet the professional needs of our customers. " +
                    "</p>"
                    ;

                ViewData["leading products"] =
                    "<p>" +
                    "	◎leading products" +
                    "   <ul>" +
                    "		<li>Precision miniature ball bearings: Miniature radial ball bearings, thrust ball bearings, self-aligning ball bearings, etc. with an inner diameter of 10 mm or less are available in a wide range of specifications. Meet the wide range of needs of customers such as instrumentation, automation, and micro-motors.</li> " +
                    "		<li>High-quality imported bearing brands: Sweden SKF, Germany FAG, INA, Japan NSK, NTN, NACHI, IKO, NMB, ASAHI, the United States McGILL and other precision high-quality bearings. Meet the customer's high-end demanding application environment.</li> " +
                    "		<li>Domestic precision bearing series: A reliable solution to replace imported bearings with high-quality domestic bearings, saving manufacturing costs and improving market competitiveness for customers.</li> " +
                    "		<li>Special bearing series: one-way bearing series, all kinds of self-lubricating bearing sleeves, linear optical axes, guide rails, lead screws, bearing housings, steel balls, needle rollers, rollers, lubricating grease and other bearing related products are available. Can undertake a variety of non-standard bearings and related parts.</li> " +
                    "	</ul> " +
                    "</p> "
                    ;

                ViewData["business philosophy"] =
                    "<p> " +
                    "	◎business philosophy" +
                    "	<ol> " +
                    "		<li><strong>Integrity:</strong>We have to keep our promise, a word spoken is past recalling. " +
                    "		<li><strong>Difference: </strong>differentiation, serving the public, but not pandering, not following." +
                    "		<li><strong>Quality:</strong>create the highest value for customers with high quality products." +
                    "		<li><strong>Win-win:</strong>Join hands with customers in fair, just and open cooperation, and achieve development and win-win with the best quality and service. " +
                    "	</ol> " +
                    "</p>"
                    ;
            }
            else
            {
                ViewData["Content"] =
                    //HtmlEncoder.Default.Encode(
                    "<p>" +
                    "&nbsp;&nbsp;&nbsp;&nbsp;武汉驷马特轴承有限公司是一家专业销售轴承及相关产品的公司企业。<br />" +
                    "&nbsp;&nbsp;&nbsp;&nbsp;驷马特成立于2006年，致力于提供全系列轴承一站式解决方案。公司自有商标“SIMATE &reg;”，为用户更可靠高品质轴承产品，为客户创造更多价值。现备有20大类系列的4500多种型号现货库存。针对行业客户需求配备专用库存，随时满足客户的专业使用需求。" +
                    "</p>"
                    ;

                ViewData["leading products"] =
                    "<p>" +
                    "    ◎主导产品" +
                    "    <ul>" +
                    "        <li>精密微型球轴承：内径10mm以下的微型向心球轴承、推力球轴承、调心球轴承等型号规格齐全，备有大量现货。满足仪表、自动化、微型电机等客户的广泛需求。</li>" +
                    "        <li>高品质进口轴承品牌：瑞典SKF、德国FAG、INA、日本NSK、NTN、NACHI、IKO、NMB、ASAHI、美国McGILL等等精密高品质轴承。满足客户的高端严苛要求应用环境。</li>" +
                    "        <li>国产精密轴承系列：高品质国产轴承替代进口轴承的可靠解决方案，为客户节约制造成本，提升市场竞争力。</li>" +
                    "        <li>特种轴承系列：单向轴承系列、各类自润滑轴承套、直线光轴、导轨、丝杠、轴承座、钢球、滚针、滚子、润滑油脂等轴承相关配套产品皆可提供。承接定做各种非标轴承及相关零件。</li>" +
                    "    </ul>" +
                    "</p>"
                    ;

                ViewData["business philosophy"] =
                    "<p>" +
                    "    ◎经营理念" +
                    "    <ol>" +
                    "        <li><strong>诚信：</strong>君子一言，“驷马”难追。 诚：诚意、真诚，信：有信、守信；诚信就是付出再多也要说到做到。" +
                    "        <li><strong>差异：</strong>公司名称取义：驷马特的“特”就是要体现差异化经营，服务大众，但不迎合、不追随。" +
                    "        <li><strong>品质：</strong>提供精益求精的表里如一高品质产品，用高品质产品为客户创造最高价值。" +
                    "        <li><strong>共赢：</strong>在公平、公正、开放的合作关系中携手客户，用最好的品质与服务获得发展共赢。" +
                    "    </ol>" +
                    "</p>"
                    //)
                    ;
            }

            return View();
        }

        public IActionResult Contact()
        {
            //ViewData["Message"] = "Your contact page.";
            ViewData["Message"] = _localizer["Contact SIMATE. We’re here to help."];

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                Microsoft.AspNetCore.Localization.CookieRequestCultureProvider.DefaultCookieName,
                Microsoft.AspNetCore.Localization.CookieRequestCultureProvider.MakeCookieValue(new Microsoft.AspNetCore.Localization.RequestCulture(culture)),
                new Microsoft.AspNetCore.Http.CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl);
        }
    }
}
