using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using HtmlAgilityPack;
using TheCoderForge.Net;

namespace Cupboard.Asda
{
    /// <summary>
    /// Class to scrape content from asda.com
    /// </summary>
    public class Scraper
    {


        /// <summary>
        /// Tests me.
        /// </summary>
        /// <returns></returns>
        public async Task<string> TestMe()
        {
  string url = "https://groceries.asda.com/product/white-bread/asda-soft-white-toastie-thick-sliced/1000002366355";

//  var content =await HttpHelper.GetPageAsync(url);


  // load the content into a HTMLDocument
  //HtmlWeb web = new HtmlWeb();
 // HtmlDocument doc = web.Load(url);

  HtmlDocument doc = new HtmlDocument();
  string filePath = "F:\\Repos\\Cupboard\\Cupboard.Asda\\SampleBread.html";
  Stream fileStream = File.OpenRead(filePath);
  doc.Load(fileStream);


  // product title is held in <h1 class="pdp-main-details__title">
  var nodeTitle = doc.DocumentNode.SelectNodes( "//h1[@class='pdp-main-details__title']");
            if (nodeTitle == null)
            {
                Debugger.Break();
                throw new Exception("Title Node not found");
            }
  return "node.InnerText";
            

        }
       
    }
}
