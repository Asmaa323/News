#pragma checksum "C:\Users\Asmaa\source\repos\News\News\Views\Home\Teammember.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7712d71101096fbc9c8a32401af94dbf5aa27f2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Teammember), @"mvc.1.0.view", @"/Views/Home/Teammember.cshtml")]
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
#line 1 "C:\Users\Asmaa\source\repos\News\News\Views\_ViewImports.cshtml"
using News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asmaa\source\repos\News\News\Views\_ViewImports.cshtml"
using News.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7712d71101096fbc9c8a32401af94dbf5aa27f2a", @"/Views/Home/Teammember.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e49202278a3870a90142506eb5694186b602837c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Teammember : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Teammember>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("testimonial-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<section id=""testimonials"" class=""testimonials section-bg"">
    <div class=""container aos-init aos-animate"" data-aos=""fade-up"">

        <div class=""section-title"">
        
            <p>The Team</p>
        </div>

   
        <div class=""testimonials-slider swiper swiper-initialized swiper-horizontal swiper-pointer-events aos-init aos-animate"" data-aos=""fade-up"" data-aos-delay=""100"">
            <div class=""swiper-wrapper"" id=""swiper-wrapper-b324edccaf2dba10c"" aria-live=""off"" style=""transform: translate3d(-5736px, 0px, 0px); transition-duration: 0ms;"">
");
#nullable restore
#line 13 "C:\Users\Asmaa\source\repos\News\News\Views\Home\Teammember.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""swiper-slide swiper-slide-duplicate-active"" role=""group"" aria-label=""1 / 5"" style=""width: 936px; margin-right: 20px;"" data-swiper-slide-index=""0"">
                        <div class=""testimonial-item"">
                            <p>
                                <i class=""bx bxs-quote-alt-left quote-icon-left""></i>
                                ");
#nullable restore
#line 19 "C:\Users\Asmaa\source\repos\News\News\Views\Home\Teammember.cshtml"
                           Write(item.Descripation);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <i class=\"bx bxs-quote-alt-right quote-icon-right\"></i>\r\n                            </p>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7712d71101096fbc9c8a32401af94dbf5aa27f2a5390", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1233, "~/", 1233, 2, true);
#nullable restore
#line 22 "C:\Users\Asmaa\source\repos\News\News\Views\Home\Teammember.cshtml"
AddHtmlAttributeValue("", 1235, item.Image, 1235, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <h3>");
#nullable restore
#line 23 "C:\Users\Asmaa\source\repos\News\News\Views\Home\Teammember.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <h4>");
#nullable restore
#line 24 "C:\Users\Asmaa\source\repos\News\News\Views\Home\Teammember.cshtml"
                           Write(item.TitleJob);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        </div>\r\n                    </div><!-- End testimonial item -->\r\n");
#nullable restore
#line 27 "C:\Users\Asmaa\source\repos\News\News\Views\Home\Teammember.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"





                </div>
            <div class=""swiper-pagination swiper-pagination-clickable swiper-pagination-bullets swiper-pagination-horizontal""><span class=""swiper-pagination-bullet swiper-pagination-bullet-active"" tabindex=""0"" role=""button"" aria-label=""Go to slide 1""></span><span class=""swiper-pagination-bullet"" tabindex=""0"" role=""button"" aria-label=""Go to slide 2""></span><span class=""swiper-pagination-bullet"" tabindex=""0"" role=""button"" aria-label=""Go to slide 3""></span><span class=""swiper-pagination-bullet"" tabindex=""0"" role=""button"" aria-label=""Go to slide 4""></span><span class=""swiper-pagination-bullet"" tabindex=""0"" role=""button"" aria-label=""Go to slide 5""></span></div>
            <span class=""swiper-notification"" aria-live=""assertive"" aria-atomic=""true""></span>
        </div>
        

    </div>
</section>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Teammember>> Html { get; private set; }
    }
}
#pragma warning restore 1591
