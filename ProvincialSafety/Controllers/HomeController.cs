using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.ServiceModel.Syndication;
using System.Web.Configuration;

namespace ProvincialSafety.Controllers
{
    public class HomeController : Controller
    {
        //public List<SyndicationItem> RSSPosts { get; set; }
        public ActionResult Index()
        {
            SyndicationFeed feed = GetNewsFeed();

            return View(feed.Items);
        }

        private static SyndicationFeed GetNewsFeed()
        {
            string url = WebConfigurationManager.AppSettings["RSSFeed"].ToString();

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.DtdProcessing = DtdProcessing.Parse;

            XmlReader reader = XmlReader.Create(url, settings);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();

            return feed;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Industries()
        {
            return View();
        }

        public ActionResult FindUs()
        {
            return View();
        }

        public ActionResult News()
        {
            SyndicationFeed feed = GetNewsFeed();

            return View(feed.Items);
        }
    }
}