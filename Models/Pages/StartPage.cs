using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core; // use this namespace to be able to use the superclass "PageData" below
using EPiServer.DataAnnotations; // to be able to specify the page type below

namespace EPIserverTestSite.Models.Pages
{
    [ContentType] // this is the page type that we are creating. this is needed.

    public class StartPage : PageData // derive from this to get be able to start a page
    {

    }
}