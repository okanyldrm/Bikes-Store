#pragma checksum "C:\Users\okany\Source\Repos\okanyldrm\Bikes-Store\BikeStore.WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc3508a6899eec1b67203a67c38fb67d1fe9717d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\okany\Source\Repos\okanyldrm\Bikes-Store\BikeStore.WebUI\Views\_ViewImports.cshtml"
using BikeStore.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\okany\Source\Repos\okanyldrm\Bikes-Store\BikeStore.WebUI\Views\_ViewImports.cshtml"
using BikeStore.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc3508a6899eec1b67203a67c38fb67d1fe9717d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0549453a7e49f7cfc9c203ad7f2ff59b825c0028", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BikeStore.WebUI.IndexViewListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/video/bike.mp4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("video/mp4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\okany\Source\Repos\okanyldrm\Bikes-Store\BikeStore.WebUI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n<!-- ***** Preloader Start ***** -->\r\n\r\n<div id=\"preloader\">\r\n    <div class=\"jumper\">\r\n        <div></div>\r\n        <div></div>\r\n        <div></div>\r\n    </div>\r\n</div>\r\n\r\n<!-- ***** Preloader End ***** -->\r\n<!-- Header -->\r\n");
            WriteLiteral("<div class=\"container\">\r\n    <br /><br /> <br /><br /> <br /><br /> <br /><br />\r\n    <video id=\"bikevideo\" controls autoplay muted>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("source", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dc3508a6899eec1b67203a67c38fb67d1fe9717d4628", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        Your browser does not support the video tag.
    </video>
</div>
<!-- Page Content -->
<!-- Banner Starts Here -->
<!--<div class=""banner header-text"">
<div class=""owl-banner owl-carousel"">
<div class=""banner-item-01"">
<div class=""text-content"">
        <h4>Mountain Bike </h4>
                <br /> <br />
                <img id=""dagbisikleti"" src=""images/mountain.png"" alt=""Alternate Text"" style=""width: 50%;"" />
                <h2>New Arrivals On Sale</h2>
            </div>
        </div>
        <div class=""banner-item-02"">
            <div class=""text-content"">
                <h4>Road Bike</h4>
                <br /><br />
                <img id=""yolbisikleti"" src=""images/bycicle.png"" alt=""Alternate Text"" />
                <h2>Get your best products</h2>
            </div>
        </div>
        <div class=""banner-item-03"">
            <div class=""text-content"">
                <h4>Kid Bike</h4>
                <br /><br />
                <img id=""cocukbisikleti"" ");
            WriteLiteral("src=\"images/baby-bike.png\" alt=\"Alternate Text\" />\r\n                <h2>Grab last minute deals</h2>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>-->\r\n<!-- Banner Ends Here -->\r\n");
            WriteLiteral(@"



<div class=""latest-products"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""section-heading"">
                    <h2>Products</h2>
                    <a href=""products.html"">view all products <i class=""fa fa-angle-right""></i></a>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""product-item"">
                    <a href=""#""><img src=""https://images.unsplash.com/photo-1484920274317-87885fcbc504?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1489&q=80""");
            BeginWriteAttribute("alt", " alt=\"", 5447, "\"", 5453, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                    <div class=""down-content"">
                        <a href=""#""><h4>Tittle goes here</h4></a>
                        <h6>$50.75</h6>
                        <p>Lorem ipsume dolor sit amet, adipisicing elite. Itaque, corporis nulla aspernatur.</p>
                        <ul class=""stars"">
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                        </ul>
                        <span>Reviews (24)</span>
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""product-item"">
                    <a href=""#""><img src=""https://images.unsplash.com/photo-1595704667942-4f09b8181d9d?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9");
            WriteLiteral("&auto=format&fit=crop&w=1350&q=80\"");
            BeginWriteAttribute("alt", " alt=\"", 6512, "\"", 6518, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                    <div class=""down-content"">
                        <a href=""#""><h4>Tittle goes here</h4></a>
                        <h6>$40.25</h6>
                        <p>Lorem ipsume dolor sit amet, adipisicing elite. Itaque, corporis nulla aspernatur.</p>
                        <ul class=""stars"">
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                        </ul>
                        <span>Reviews (21)</span>
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""product-item"">
                    <a href=""#""><img src=""https://images.unsplash.com/15/tricycle.JPG?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80""");
            BeginWriteAttribute("alt", " alt=\"", 7534, "\"", 7540, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                    <div class=""down-content"">
                        <a href=""#""><h4>Tittle goes here</h4></a>
                        <h6>$49.45</h6>
                        <p>Sixteen Clothing is free CSS template provided by TemplateMo.</p>
                        <ul class=""stars"">
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                        </ul>
                        <span>Reviews (36)</span>
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""product-item"">
                    <a href=""#""><img src=""https://images.unsplash.com/photo-1469391923172-aacc0306ee0d?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop");
            WriteLiteral("&w=1384&q=80\"");
            BeginWriteAttribute("alt", " alt=\"", 8578, "\"", 8584, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                    <div class=""down-content"">
                        <a href=""#""><h4>Tittle goes here</h4></a>
                        <h6>$75.25</h6>
                        <p>Lorem ipsume dolor sit amet, adipisicing elite. Itaque, corporis nulla aspernatur.</p>
                        <ul class=""stars"">
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                        </ul>
                        <span>Reviews (48)</span>
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""product-item"">
                    <a href=""#""><img src=""https://images.unsplash.com/photo-1524083531058-82ec9694e8d5?ixlib=rb-1.2.1&auto=format&fit=crop&w=12");
            WriteLiteral("66&q=80\"");
            BeginWriteAttribute("alt", " alt=\"", 9617, "\"", 9623, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                    <div class=""down-content"">
                        <a href=""#""><h4>Tittle goes here</h4></a>
                        <h6>$32.50</h6>
                        <p>Lorem ipsume dolor sit amet, adipisicing elite. Itaque, corporis nulla aspernatur.</p>
                        <ul class=""stars"">
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                        </ul>
                        <span>Reviews (16)</span>
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""product-item"">
                    <a href=""#""><img src=""https://images.unsplash.com/photo-1579649452167-73ef3e6d5ec9?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9");
            WriteLiteral("&auto=format&fit=crop&w=1350&q=80\"");
            BeginWriteAttribute("alt", " alt=\"", 10682, "\"", 10688, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                    <div class=""down-content"">
                        <a href=""#""><h4>Tittle goes here</h4></a>
                        <h6>$60.50</h6>
                        <p>Lorem ipsume dolor sit amet, adipisicing elite. Itaque, corporis nulla aspernatur.</p>
                        <ul class=""stars"">
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                            <li><i class=""fa fa-star""></i></li>
                        </ul>
                        <span>Reviews (32)</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""best-features"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""section-heading"">
                ");
            WriteLiteral(@"    <h2>About Bicycle</h2>
                </div>
            </div>
            <div class=""col-md-6"">
                <div class=""left-content"">
                    <h4>Looking for the best products?</h4>
                    <p><a rel=""nofollow"" href=""https://templatemo.com/tm-546-sixteen-clothing"" target=""_parent"">This template</a> is free to use for your business websites. However, you have no permission to redistribute the downloadable ZIP file on any template collection website. <a rel=""nofollow"" href=""https://templatemo.com/contact"">Contact us</a> for more info.</p>
                    <ul class=""featured-list"">
                        <li><a href=""#"">Lorem ipsum dolor sit amet</a></li>
                        <li><a href=""#"">Consectetur an adipisicing elit</a></li>
                        <li><a href=""#"">It aquecorporis nulla aspernatur</a></li>
                        <li><a href=""#"">Corporis, omnis doloremque</a></li>
                        <li><a href=""#"">Non cum id reprehenderit</a></");
            WriteLiteral(@"li>
                    </ul>
                    <a href=""about.html"" class=""filled-button"">Read More</a>
                </div>
            </div>
            <div class=""col-md-6"">
                <div class=""right-image"">
                    <img src=""https://images.unsplash.com/photo-1511466431307-d603e868975c?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1350&q=80""");
            BeginWriteAttribute("alt", " alt=\"", 13135, "\"", 13141, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\r\n");
            WriteLiteral(@"





                </div>
            </div>
        </div>
    </div>
</div>


<div class=""call-to-action"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""inner-content"">
                    <div class=""row"">
                        <div class=""col-md-8"">
                            <h4>Creative &amp; Unique <em></em> Products</h4>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Itaque corporis amet elite author nulla.</p>
                        </div>
                        <div class=""col-md-4"">
                            <a href=""#"" class=""filled-button"">Purchase Now</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>


<footer>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""inner-content"">
       ");
            WriteLiteral(@"             <p>
                        Copyright &copy; 2020 Bike Store Co., Ltd.

                        - Design: <a rel=""nofollow noopener"" target=""_blank"">Mr-Oko</a>
                    </p>
                </div>
            </div>
        </div>
    </div>
</footer>


<!-- Bootstrap core JavaScript -->
<!-- Additional Scripts -->
<!--<script src=""/js/Scripts/template/custom.js""></script>
<script src=""/js/Scripts/template/owl.js""></script>
<script src=""/js/Scripts/template/slick.js""></script>
<script src=""/js/Scripts/template/isotope.js""></script>
<script src=""/js/Scripts/template/accordions.js""></script>-->


<script language=""text/Javascript"">

    cleared[0] = cleared[1] = cleared[2] = 0; //set a cleared flag for each field
    function clearField(t) {                   //declaring the array outside of the
        if (!cleared[t.id]) {                      // function makes it static and global
            cleared[t.id] = 1;  // you could use true and false, but that's mor");
            WriteLiteral("e typing\r\n            t.value = \'\';         // with more chance of typos\r\n            t.style.color = \'#fff\';\r\n        }\r\n    }\r\n</script>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BikeStore.WebUI.IndexViewListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
