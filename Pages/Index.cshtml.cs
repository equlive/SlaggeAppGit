using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Net;
using Newtonsoft.Json;

namespace SlaggeApp.Pages
{
    public class IndexModel : PageModel
    {
        SlaggeStatus mySlaggeStatus;

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var myContainerOffset = 10;

            using (var webClient = new WebClient())
            {
                String rawJSON = webClient.DownloadString("http://slaggestatus.norfors.dk/myContainerData.json");
                mySlaggeStatus = JsonConvert.DeserializeObject<SlaggeStatus>(rawJSON);
            }

            int myCounter = Int32.Parse(mySlaggeStatus.Containerempty);
            if (myCounter > myContainerOffset)
            {
                mySlaggeStatus.Containerempty = (myCounter - myContainerOffset).ToString();
            }

            ViewData["theDate"] = mySlaggeStatus.Mydate;
            ViewData["theTime"] = mySlaggeStatus.Mytime;
            ViewData["theContainerFulde"] = mySlaggeStatus.Containerfull;
            ViewData["theContainerTomme"] = mySlaggeStatus.Containerempty;
        }
    }
}
