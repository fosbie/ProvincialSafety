using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.ServiceModel.Syndication;


namespace ProvincialSafety.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string url = "http://painlessmoneysaving.blogspot.co.uk/feeds/posts/default";

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.DtdProcessing = DtdProcessing.Parse;

            XmlReader reader = XmlReader.Create(url,settings);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();
            ViewBag.NewsTitle = feed.Items.First().Title.Text;
            ViewBag.NewsContent = ((System.ServiceModel.Syndication.TextSyndicationContent)feed.Items.First().Content).Text;

            //foreach (SyndicationItem item in feed.Items)
            //{
            //    String subject = item.Title.Text;
            //    //String summary = item.Summary.Text;
            //}

            return View();
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
    }
}