using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using Zin_MediaRadar.Models;
using Zin_MediaRadar.AdDataService;

namespace Zin_MediaRadar.Controllers
{
    public class AdListController : Controller
    {
        protected string sDate = "01/01/2011";
        protected string eDate = "04/01/2011";
        protected DateTime startDate;
        protected DateTime endDate;

        // GET: Home
        public ActionResult Index()
        {
            return View();

        }//index

        //
        public ActionResult FullListAd(int? page, string sortBy = "BrandName", string sortOrder = "", int pageSize = 200, string currentSortBy = "", string currentSortByDir = "")
        {
            try
            {
                if (sortOrder == "")
                    ViewBag.SortDirParm = "desc";

                else
                    ViewBag.SortDirParm = sortOrder == "asc" ? "desc" : "asc";

                ViewBag.CurrentSortBy = sortBy;
                ViewBag.CurrentSortByDir = sortOrder;

                var sortExpression = String.Format("{0} {1}", sortBy, sortOrder);
                int pgNum = (page ?? 1);
                ViewBag.CurrentPage = pgNum;

                startDate = DateTime.Parse(sDate);
                endDate = DateTime.Parse(eDate);

                AdDataServiceClient ad = new AdDataServiceClient();
                var fullList = ad.GetAdDataByDateRange(startDate, endDate).ToList();

                switch(sortBy)
                {
                    case "BrandName":
                        fullList = sortOrder == "desc" ? fullList.OrderByDescending(b => b.Brand.BrandName).ToList() : fullList.OrderBy(b => b.Brand.BrandName).ToList();
                        break;
                    case "AdId":
                        fullList = sortOrder == "desc" ? fullList.OrderByDescending(a => a.AdId).ToList() : fullList.OrderBy(a => a.AdId).ToList();
                        break;
                    case "BrandId":
                        fullList = sortOrder == "desc" ? fullList.OrderByDescending(b => b.Brand.BrandId).ToList() : fullList.OrderBy(b => b.Brand.BrandId).ToList();
                        break;
                    case "NumPages":
                        fullList = sortOrder == "desc" ? fullList.OrderByDescending(n => n.NumPages).ToList() : fullList.OrderBy(n => n.NumPages).ToList();
                        break;
                    case "Position":
                        fullList = sortOrder == "desc" ? fullList.OrderByDescending(p => p.Position).ToList() : fullList.OrderBy(p => p.Position).ToList();
                        break;
                }

                return View("FullListAd", fullList.ToPagedList(pgNum, pageSize));
            }
            catch (Exception ex)
            {
                return View(ex.Message.ToString());
            }
        }//FullListAd

        public ActionResult CoverAdList(int? page, string sortBy = "BrandName", string sortOrder = "",
            int pageSize = 200, string currentSortBy = "", string currentSortByDir = "")
        {
            if (sortOrder == "")
                ViewBag.SortDirParm = "desc";

            else
                ViewBag.SortDirParm = sortOrder == "asc" ? "desc" : "asc";

            ViewBag.CurrentSortBy = sortBy;
            ViewBag.CurrentSortByDir = sortOrder;

            int pgNum = (page ?? 1);
            ViewBag.CurrentPage = pgNum;

            startDate = DateTime.Parse(sDate);
            endDate = DateTime.Parse(eDate);

            AdDataServiceClient ad = new AdDataServiceClient();
            var cl = ad.GetAdDataByDateRange(startDate, endDate);

            var coverList = (from c in cl
                            where c.Position == "Cover" && c.NumPages >= 0.5M
                            //orderby c.Brand.BrandName ascending
                            select c).ToList();
            switch (sortBy)
            {
                case "BrandName":
                    coverList = sortOrder == "desc" ? coverList.OrderByDescending(b => b.Brand.BrandName).ToList() : coverList.OrderBy(b => b.Brand.BrandName).ToList();
                    break;
                case "AdId":
                    coverList = sortOrder == "desc" ? coverList.OrderByDescending(a => a.AdId).ToList() : coverList.OrderBy(a => a.AdId).ToList();
                    break;
                case "BrandId":
                    coverList = sortOrder == "desc" ? coverList.OrderByDescending(b => b.Brand.BrandId).ToList() : coverList.OrderBy(b => b.Brand.BrandId).ToList();
                    break;
                case "NumPages":
                    coverList = sortOrder == "desc" ? coverList.OrderByDescending(n => n.NumPages).ToList() : coverList.OrderBy(n => n.NumPages).ToList();
                    break;
                case "Position":
                    coverList = sortOrder == "desc" ? coverList.OrderByDescending(p => p.Position).ToList() : coverList.OrderBy(p => p.Position).ToList();
                    break;
            }

            return View(coverList.ToPagedList(pgNum, pageSize));

        }//CoverAdList

        public ActionResult topFiveAds()
        {
            startDate = DateTime.Parse(sDate);
            endDate = DateTime.Parse(eDate);

            AdDataServiceClient ad = new AdDataServiceClient();
            var tAds = ad.GetAdDataByDateRange(startDate, endDate);

            var tfivead = (from t in tAds
                           orderby t.NumPages descending, t.Brand.BrandName
                           select t).Distinct().Take(5);

            //var tfiveAds = tfivead.GroupBy(b => b.Brand.BrandName)
            //               .Select(g => g.ToList())
            //               .ToList()
            //               .Distinct().Take(5);

            return View(tfivead.ToList());
        }//topFiveAds

        public ActionResult topFiveBrands()
        {
            startDate = DateTime.Parse(sDate);
            endDate = DateTime.Parse(eDate);

            AdDataServiceClient ad = new AdDataServiceClient();
            var tBrands = ad.GetAdDataByDateRange(startDate, endDate);

            var tBrand = (from t in tBrands                          
                          orderby t.NumPages descending, t.Brand.BrandName
                          select t).Take(5);

            return View(tBrand.ToList());

        }//topFiveBrands

    }//class
}//namespace