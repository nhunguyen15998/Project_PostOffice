#pragma checksum "C:\CSharp\Project_PostOffice\Views\Shared\Partials\_ClientStyles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d976f10f50aa0d06b94585a9eac484a472a77d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partials__ClientStyles), @"mvc.1.0.view", @"/Views/Shared/Partials/_ClientStyles.cshtml")]
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
#line 1 "C:\CSharp\Project_PostOffice\Views\_ViewImports.cshtml"
using post_office;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\CSharp\Project_PostOffice\Views\_ViewImports.cshtml"
using post_office.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\CSharp\Project_PostOffice\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\CSharp\Project_PostOffice\Views\_ViewImports.cshtml"
using post_office.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\CSharp\Project_PostOffice\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d976f10f50aa0d06b94585a9eac484a472a77d4", @"/Views/Shared/Partials/_ClientStyles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c33bc81411c8478abb59bd49d3925a21ba29a7b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partials__ClientStyles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Add up -->
<script> 'use strict'; (function (html) { html.className = html.className.replace(/\bno-js\b/, 'js') })(document.documentElement);</script>
<link rel='dns-prefetch' href='//fonts.googleapis.com' />
<link rel='dns-prefetch' href='//s.w.org' />
<link rel=""alternate"" type=""application/rss+xml"" title=""MoversCO Demo 6 &raquo; Feed""
    href=""https://moversco.themestek.com/demo6/feed/"" />
<link rel=""alternate"" type=""application/rss+xml"" title=""MoversCO Demo 6 &raquo; Comments Feed""
    href=""https://moversco.themestek.com/demo6/comments/feed/"" />
<link rel=""alternate"" type=""text/calendar"" title=""MoversCO Demo 6 &raquo; iCal Feed""
    href=""https://moversco.themestek.com/demo6/events/?ical=1"" />
<script>
    window._wpemojiSettings = { ""baseUrl"": ""https:\/\/s.w.org\/images\/core\/emoji\/13.0.1\/72x72\/"", ""ext"": "".png"", ""svgUrl"": ""https:\/\/s.w.org\/images\/core\/emoji\/13.0.1\/svg\/"", ""svgExt"": "".svg"", ""source"": { ""concatemoji"": ""https:..\/..\/js\/client\/wp-emoji-release.min.js"" } };
   ");
            WriteLiteral(@" !function (e, a, t) { var n, r, o, i = a.createElement(""canvas""), p = i.getContext && i.getContext(""2d""); function s(e, t) { var a = String.fromCharCode; p.clearRect(0, 0, i.width, i.height), p.fillText(a.apply(this, e), 0, 0); e = i.toDataURL(); return p.clearRect(0, 0, i.width, i.height), p.fillText(a.apply(this, t), 0, 0), e === i.toDataURL() } function c(e) { var t = a.createElement(""script""); t.src = e, t.defer = t.type = ""text/javascript"", a.getElementsByTagName(""head"")[0].appendChild(t) } for (o = Array(""flag"", ""emoji""), t.supports = { everything: !0, everythingExceptFlag: !0 }, r = 0; r < o.length; r++)t.supports[o[r]] = function (e) { if (!p || !p.fillText) return !1; switch (p.textBaseline = ""top"", p.font = ""600 32px Arial"", e) { case ""flag"": return s([127987, 65039, 8205, 9895, 65039], [127987, 65039, 8203, 9895, 65039]) ? !1 : !s([55356, 56826, 55356, 56819], [55356, 56826, 8203, 55356, 56819]) && !s([55356, 57332, 56128, 56423, 56128, 56418, 56128, 56421, 56128, 56430, 56128, 56423, 56128, 56447");
            WriteLiteral(@"], [55356, 57332, 8203, 56128, 56423, 8203, 56128, 56418, 8203, 56128, 56421, 8203, 56128, 56430, 8203, 56128, 56423, 8203, 56128, 56447]); case ""emoji"": return !s([55357, 56424, 8205, 55356, 57212], [55357, 56424, 8203, 55356, 57212]) }return !1 }(o[r]), t.supports.everything = t.supports.everything && t.supports[o[r]], ""flag"" !== o[r] && (t.supports.everythingExceptFlag = t.supports.everythingExceptFlag && t.supports[o[r]]); t.supports.everythingExceptFlag = t.supports.everythingExceptFlag && !t.supports.flag, t.DOMReady = !1, t.readyCallback = function () { t.DOMReady = !0 }, t.supports.everything || (n = function () { t.readyCallback() }, a.addEventListener ? (a.addEventListener(""DOMContentLoaded"", n, !1), e.addEventListener(""load"", n, !1)) : (e.attachEvent(""onload"", n), a.attachEvent(""onreadystatechange"", function () { ""complete"" === a.readyState && t.readyCallback() })), (n = t.source || {}).concatemoji ? c(n.concatemoji) : n.wpemoji && n.twemoji && (c(n.twemoji), c(n.wpemoji))) }(window, document, wind");
            WriteLiteral(@"ow._wpemojiSettings);
</script>
<style>
    img.wp-smiley,
    img.emoji {
        display: inline !important;
        border: none !important;
        box-shadow: none !important;
        height: 1em !important;
        width: 1em !important;
        margin: 0 .07em !important;
        vertical-align: -0.1em !important;
        background: none !important;
        padding: 0 !important;
    }

    .col-lg-20percent {
        max-width: 20%;
    }

    .main-form .select2-container--default .select2-selection--single .select2-selection__arrow b {
        border-color: gray transparent transparent transparent !important;
    }
</style>
<link rel='stylesheet' id='tribe-common-skeleton-style-css' href='../../css/client/common-skeleton.min.css'
    media='all' />
<link rel='stylesheet' id='tribe-tooltip-css' href='../../css/client/tooltip.min.css' media='all' />
<link rel='stylesheet' id='wp-block-library-css' href='../../css/client/style.min.css' media='all' />
<link rel='stylesheet' ");
            WriteLiteral(@"id='wc-block-vendors-style-css' href='../../css/client/vendors-style.css' media='all' />
<link rel='stylesheet' id='wc-block-style-css' href='../../css/client/style.css' media='all' />
<link rel='stylesheet' id='bbp-default-css' href='../../css/client/bbpress.min.css' media='all' />
<link rel='stylesheet' id='contact-form-7-css' href='../../css/client/styles.css' media='all' />
<link rel='stylesheet' id='rs-plugin-settings-css' href='../../css/client/rs6.css' media='all' />
<style id='rs-plugin-settings-inline-css'>
    #rs-demo-id {}
</style>
");
            WriteLiteral(@"<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css""
    integrity=""sha512-KfkfwYDsLkIlwQp6LFnl8zNdLGxu9YAA1QvwINks4PhcElQSvqcyVLLD9aMhXd13uQjoXtEKNosOWaZqXgel0g==""
    crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
<link rel='stylesheet' id='themify-css' href='../../css/client/themify-icons.css' media='all' />
<link rel='stylesheet' id='sgicon-css' href='../../css/client/linecons-style.css' media='all' />
<link rel='stylesheet' id='vc_linecons-css' href='../../css/client/vc_linecons_icons.min.css' media='all' />
<link rel='stylesheet' id='themestek_moversco_business_icon-css' href='../../css/client/flaticon.css' media='all' />
<link rel='stylesheet' id='postalservice-layout-css' href='../../css/client/postalservice-layout.css' media='all' />
<link rel='stylesheet' id='postalservice-smallscreen-css' href='../../css/client/postalservice-smallscreen.css'
    media='only screen and (max-width: 768px)' />
<link rel='stylesheet' id='postalservic");
            WriteLiteral(@"e-general-css' href='../../css/client/postalservice.css' media='all' />
<style id='postalservice-inline-inline-css'>
    .postalservice form .form-row .required {
        visibility: visible;
    }
</style>
<link rel='stylesheet' id='themestek-cs-google-fonts-css'
    href='//fonts.googleapis.com/css?family=Nunito+Sans%3A200%2C200italic%2C300%2C300italic%2C400%2Citalic%2C600%2C600italic%2C700%2C700italic%2C800%2C800italic%2C900%2C900italic%7CBiryani%3A200%2C300%2C400%2C600%2C700%2C800%2C900%7CRoboto%3A500&#038;ver=1.0.0'
    media='all' />
<link rel='stylesheet' id='themestek-base-icons-css' href='../../css/client/themestek-moversco-icons.css' media='all' />
<link rel='stylesheet' id='perfect-scrollbar-css' href='../../css/client/perfect-scrollbar.min.css' media='all' />
<link rel='stylesheet' id='chrisbracco-tooltip-css' href='../../css/client/chrisbracco-tooltip.min.css' media='all' />
<link rel='stylesheet' id='multi-columns-row-css' href='../../css/client/multi-columns-row.css' media='all' />");
            WriteLiteral(@"
<link rel='stylesheet' id='select2-css' href='../../css/client/select2.css' media='all' />
<link rel='stylesheet' id='flexslider-css' href='../../css/client/flexslider.min.css' media='all' />
<link rel='stylesheet' id='slick-css' href='../../css/client/slick.css' media='all' />
<link rel='stylesheet' id='slick-theme-css' href='../../css/client/slick-theme.css' media='all' />
<link rel='stylesheet' id='prettyphoto-css' href='../../css/client/prettyPhoto.min.css' media='all' />
<link rel='stylesheet' id='js_composer_front-css' href='../../css/client/js_composer.min.css' media='all' />
");
            WriteLiteral(@"<link rel='stylesheet' id='bootstrap-theme-css' href='../../css/client/bootstrap-theme.min.css' media='all' />
<link rel='stylesheet' id='moversco-core-style-css' href='../../css/client/core.css' media='all' />
<link rel='stylesheet' id='moversco-master-style-css' href='../../css/client/master.css' media='all' />
<link rel='stylesheet' id='moversco-responsive-style-css' href='../../css/client/responsive.css' media='all' />
<link rel='stylesheet' id='tste-moversco-theme-style-css' href='../../css/client/admin-ajax.css' media='all' />
<script src='../../js/client/jquery-migrate.min.js' id='jquery-migrate-js'></script>
<script src='../../js/client/rbtools.min.js' id='tp-tools-js'></script>
<script src='../../js/client/rs6.min.js' id='revmin-js'></script>
<script src='../../js/client/jquery-resize.min.js' id='jquery-resize-js'></script>
<script src='../../js/client/jquery.blockUI.min.js' id='jquery-blockui-js'></script>
<script id='wc-add-to-cart-js-extra'>
    /* <![CDATA[ */
    var wc_add_to_cart_p");
            WriteLiteral(@"arams = { ""ajax_url"": ""\/demo6\/wp-admin\/admin-ajax.php"", ""wc_ajax_url"": ""\/demo6\/?wc-ajax=%%endpoint%%"", ""i18n_view_cart"": ""View cart"", ""cart_url"": ""https:\/\/moversco.themestek.com\/demo6\/cart\/"", ""is_cart"": """", ""cart_redirect_after_add"": ""no"" };
    /* ]]> */
</script>
<script src='../../js/client/add-to-cart.min.js' id='wc-add-to-cart-js'></script>
<script src='../../js/client/postalservice-add-to-cart.js' id='vc_postalservice-add-to-cart-js-js'></script>
<link rel=""https://api.w.org/"" href=""https://moversco.themestek.com/demo6/wp-json/"" />
<link rel=""alternate"" type=""application/json"" href=""https://moversco.themestek.com/demo6/wp-json/wp/v2/pages/6439"" />
<link rel=""EditURI"" type=""application/rsd+xml"" title=""RSD"" href=""https://moversco.themestek.com/demo6/xmlrpc.php?rsd"" />
<link rel=""wlwmanifest"" type=""application/wlwmanifest+xml""
    href=""https://moversco.themestek.com/demo6/wp-includes/wlwmanifest.xml"" />
<meta name=""generator"" content=""WordPress 5.6.8"" />
<meta name=""generator"" content");
            WriteLiteral(@"=""postalservice 5.0.3"" />
<link rel=""canonical"" href=""https://moversco.themestek.com/demo6/"" />
<link rel='shortlink' href='https://moversco.themestek.com/demo6/' />
<link rel=""alternate"" type=""application/json+oembed""
    href=""https://moversco.themestek.com/demo6/wp-json/oembed/1.0/embed?url=https%3A%2F%2Fmoversco.themestek.com%2Fdemo6%2F"" />
<link rel=""alternate"" type=""text/xml+oembed""
    href=""https://moversco.themestek.com/demo6/wp-json/oembed/1.0/embed?url=https%3A%2F%2Fmoversco.themestek.com%2Fdemo6%2F&#038;format=xml"" />
<meta name=""tec-api-version"" content=""v1"">
<meta name=""tec-api-origin"" content=""https://moversco.themestek.com/demo6"">
<link rel=""https://theeventscalendar.com/"" href=""https://moversco.themestek.com/demo6/wp-json/tribe/events/v1/"" />
");
            WriteLiteral(@"<link href=""https://fonts.googleapis.com/css?family=Biryani:700%7CNunito+Sans:400%2C700%7CRoboto:400%2C500""
    rel=""stylesheet"" property=""stylesheet"" media=""all"">

<!-- Inline CSS Start -->
<style>
    .vc_custom_1614080913480>.themestek-row-wrapper-bg-layer {
        padding-top: 0px !important;
        padding-bottom: 0px !important;
    }

    .vc_custom_1614080913480>.themestek-row-wrapper-bg-layer {
        background-image: none !important;
        margin: 0 !important;
        padding: 0 !important;
    }

    .vc_custom_1614082967799>.themestek-col-wrapper-bg-layer {
        background-image: url(../../img/defaults/transparent-img-01.png) !important;
        background-position: 0 0 !important;
        background-repeat: no-repeat !important;
    }

    .vc_custom_1614082967799>.themestek-col-wrapper-bg-layer>.themestek-bg-layer-inner {
        background-image: url(../../img/defaults/transparent-img-01.png) !important;
        background-position: 0 0 !important;
        bac");
            WriteLiteral(@"kground-repeat: no-repeat !important;
        background-image: none !important;
    }

    .vc_custom_1614084937811>.themestek-row-wrapper-bg-layer {
        padding-top: 110px !important;
        padding-bottom: 100px !important;
    }

    .vc_custom_1614084937811>.themestek-row-wrapper-bg-layer {
        background-image: none !important;
        margin: 0 !important;
        padding: 0 !important;
    }

    .vc_custom_1614083267804>.themestek-row-wrapper-bg-layer {
        padding-top: 75px !important;
        padding-bottom: 30px !important;
    }

    .vc_custom_1614083267804>.themestek-row-wrapper-bg-layer {
        background-image: none !important;
        margin: 0 !important;
        padding: 0 !important;
    }

    .vc_custom_1614082071961>.themestek-row-wrapper-bg-layer {
        margin-top: -130px !important;
        padding-top: 230px !important;
        padding-bottom: 125px !important;
        background-image: url(../../img/defaults/transparent-bg.png) !impor");
            WriteLiteral(@"tant;
        background-position: center !important;
        background-repeat: no-repeat !important;
        background-size: cover !important;
    }

    .vc_custom_1614082071961>.themestek-row-wrapper-bg-layer {
        background-image: none !important;
        margin: 0 !important;
        padding: 0 !important;
    }

    .vc_custom_1614081288285>.themestek-col-wrapper-bg-layer {
        background-image: url(../../img/defaults/transparent-img-02.png) !important;
        background-position: 0 0 !important;
        background-repeat: no-repeat !important;
    }

    .vc_custom_1614081288285>.themestek-col-wrapper-bg-layer>.themestek-bg-layer-inner {
        background-image: url(../../img/defaults/transparent-img-02.png) !important;
        background-position: 0 0 !important;
        background-repeat: no-repeat !important;
        background-image: none !important;
    }

    .vc_custom_1614084728369>.themestek-row-wrapper-bg-layer {
        padding-top: 50px !important;
  ");
            WriteLiteral(@"      padding-bottom: 110px !important;
    }

    .vc_custom_1614084728369>.themestek-row-wrapper-bg-layer {
        background-image: none !important;
        margin: 0 !important;
        padding: 0 !important;
    }

    .vc_custom_1614082446561>.themestek-row-wrapper-bg-layer {
        border-top-width: 1px !important;
        padding-bottom: 0px !important;
        border-top-color: #dddddd !important;
        border-top-style: solid !important;
    }

    .vc_custom_1614082446561>.themestek-row-wrapper-bg-layer {
        background-image: none !important;
        margin: 0 !important;
        padding: 0 !important;
    }

    .vc_custom_1614082521563>.themestek-row-wrapper-bg-layer {
        padding-top: 70px !important;
    }

    .vc_custom_1614082521563>.themestek-row-wrapper-bg-layer {
        background-image: none !important;
        margin: 0 !important;
        padding: 0 !important;
    }

    .vc_custom_1614084788560>.themestek-row-wrapper-bg-layer {
        p");
            WriteLiteral(@"adding-top: 0px !important;
        padding-bottom: 110px !important;
    }

    .vc_custom_1614084788560>.themestek-row-wrapper-bg-layer {
        background-image: none !important;
        margin: 0 !important;
        padding: 0 !important;
    }

    .vc_custom_1614083621136>.themestek-row-wrapper-bg-layer {
        padding-top: 0px !important;
        padding-bottom: 0px !important;
        background-image: url(../../img/defaults/testmonial-side-bg.png) !important;
        background-position: 0 0 !important;
        background-repeat: no-repeat !important;
    }

    .vc_custom_1614083621136>.themestek-row-wrapper-bg-layer {
        background-image: none !important;
        margin: 0 !important;
        padding: 0 !important;
    }

    .vc_custom_1614084846079>.themestek-row-wrapper-bg-layer {
        padding-top: 110px !important;
    }

    .vc_custom_1614084846079>.themestek-row-wrapper-bg-layer {
        background-image: none !important;
        margin: 0 !important");
            WriteLiteral(@";
        padding: 0 !important;
    }

    .limit-text {
        text-overflow: ellipsis;
        word-wrap: break-word;
        overflow: hidden;
        display: -webkit-box;
        -webkit-line-clamp: 5;
        -webkit-box-orient: vertical;
    }
</style><!-- Inline CSS End -->
<noscript>
    <style>
        .postalservice-product-gallery {
            opacity: 1 !important;
        }
    </style>
</noscript>
<meta name=""generator"" content=""Powered by WPBakery Page Builder-drag and drop page builder for WordPress."" />
<meta name=""generator""
    content=""Powered by Slider Revolution 6.3.9-responsive, Mobile-Friendly Slider Plugin for WordPress with comfortable drag and drop interface."" />
<script>
    function setREVStartSize(e) {
        //window.requestAnimationFrame(function() {				 
        window.RSIW = window.RSIW === undefined ? window.innerWidth : window.RSIW;
        window.RSIH = window.RSIH === undefined ? window.innerHeight : window.RSIH;
        try {
           ");
            WriteLiteral(@" var pw = document.getElementById(e.c).parentNode.offsetWidth,
                newh;
            pw = pw === 0 || isNaN(pw) ? window.RSIW : pw;
            e.tabw = e.tabw === undefined ? 0 : parseInt(e.tabw);
            e.thumbw = e.thumbw === undefined ? 0 : parseInt(e.thumbw);
            e.tabh = e.tabh === undefined ? 0 : parseInt(e.tabh);
            e.thumbh = e.thumbh === undefined ? 0 : parseInt(e.thumbh);
            e.tabhide = e.tabhide === undefined ? 0 : parseInt(e.tabhide);
            e.thumbhide = e.thumbhide === undefined ? 0 : parseInt(e.thumbhide);
            e.mh = e.mh === undefined || e.mh == """" || e.mh === ""auto"" ? 0 : parseInt(e.mh, 0);
            if (e.layout === ""fullscreen"" || e.l === ""fullscreen"")
                newh = Math.max(e.mh, window.RSIH);
            else {
                e.gw = Array.isArray(e.gw) ? e.gw : [e.gw];
                for (var i in e.rl) if (e.gw[i] === undefined || e.gw[i] === 0) e.gw[i] = e.gw[i - 1];
                e.gh = e.el === unde");
            WriteLiteral(@"fined || e.el === """" || (Array.isArray(e.el) && e.el.length == 0) ? e.gh : e.el;
                e.gh = Array.isArray(e.gh) ? e.gh : [e.gh];
                for (var i in e.rl) if (e.gh[i] === undefined || e.gh[i] === 0) e.gh[i] = e.gh[i - 1];

                var nl = new Array(e.rl.length),
                    ix = 0,
                    sl;
                e.tabw = e.tabhide >= pw ? 0 : e.tabw;
                e.thumbw = e.thumbhide >= pw ? 0 : e.thumbw;
                e.tabh = e.tabhide >= pw ? 0 : e.tabh;
                e.thumbh = e.thumbhide >= pw ? 0 : e.thumbh;
                for (var i in e.rl) nl[i] = e.rl[i] < window.RSIW ? 0 : e.rl[i];
                sl = nl[0];
                for (var i in nl) if (sl > nl[i] && nl[i] > 0) { sl = nl[i]; ix = i; }
                var m = pw > (e.gw[ix] + e.tabw + e.thumbw) ? 1 : (pw - (e.tabw + e.thumbw)) / (e.gw[ix]);
                newh = (e.gh[ix] * m) + (e.tabh + e.thumbh);
            }
            if (window.rs_init_css === undefined) w");
            WriteLiteral(@"indow.rs_init_css = document.head.appendChild(document.createElement(""style""));
            document.getElementById(e.c).height = newh + ""px"";
            window.rs_init_css.innerHTML += ""#"" + e.c + ""_wrapper { height: "" + newh + ""px }"";
        } catch (e) {
            console.log(""Failure at Presize of Slider:"" + e)
        }
        //});
    };
</script>
<style data-type=""vc_shortcodes-custom-css"">
    .vc_custom_1614080913480 {
        padding-top: 0px !important;
        padding-bottom: 0px !important;
    }

    .vc_custom_1614084937811 {
        padding-top: 110px !important;
        padding-bottom: 100px !important;
    }

    .vc_custom_1614083267804 {
        padding-top: 75px !important;
        padding-bottom: 30px !important;
    }

    .vc_custom_1614082071961 {
        margin-top: -130px !important;
        padding-top: 230px !important;
        padding-bottom: 125px !important;
        background-image: url(../../img/defaults/transparent-bg.png) !important;
    ");
            WriteLiteral(@"    background-position: center !important;
        background-repeat: no-repeat !important;
        background-size: cover !important;
    }

    .vc_custom_1614084728369 {
        padding-top: 50px !important;
        padding-bottom: 110px !important;
    }

    .vc_custom_1614082446561 {
        border-top-width: 1px !important;
        padding-bottom: 0px !important;
        border-top-color: #dddddd !important;
        border-top-style: solid !important;
    }

    .vc_custom_1614082521563 {
        padding-top: 70px !important;
    }

    .vc_custom_1614084788560 {
        padding-top: 0px !important;
        padding-bottom: 110px !important;
    }

    .vc_custom_1614083621136 {
        padding-top: 0px !important;
        padding-bottom: 0px !important;
        background-image: url(../../img/defaults/testmonial-side-bg.png) !important;
        background-position: 0 0 !important;
        background-repeat: no-repeat !important;
    }

    .vc_custom_1614084846079 {
");
            WriteLiteral(@"        padding-top: 110px !important;
    }

    .vc_custom_1614082967799 {
        background-image: url(../../img/defaults//transparent-img-01.png) !important;
        background-position: 0 0 !important;
        background-repeat: no-repeat !important;
    }

    .vc_custom_1614084889898 {
        padding-top: 50px !important;
        padding-left: 40px !important;
    }

    .vc_custom_1614081981259 {
        margin-bottom: 40px !important;
    }

    .vc_custom_1614084971451 {
        margin-top: 55px !important;
    }

    .vc_custom_1614081288285 {
        background-image: url(../../img/defaults/transparent-img-02.png) !important;
        background-position: 0 0 !important;
        background-repeat: no-repeat !important;
    }

    .vc_custom_1614085022030 {
        padding-top: 50px !important;
        padding-left: 40px !important;
    }

    #nav_menu-2 .menu li,
    #nav_menu-3 .menu li,
    #enhancedtextwidget-4 .textwidget,
    #custom_html-2 .widget_text {");
            WriteLiteral(@"
        line-height: 24px !important;
    }

    select {
        font-size: 12px !important;
        color: #999999 !important;
    }
</style>
<noscript>
    <style>
        .wpb_animate_when_almost_visible {
            opacity: 1;
        }
    </style>
</noscript>
<style>
    .jq-icon-info {
        background-color: #ffdc39 !important;
        color: #111 !important;
        border-color: transparent !important;
        background-image: url('../../img/defaults/toast-info.png') !important;
        background-size: 30px 30px;
    }
    .jq-icon-warning {
        background-color: #ffdc39 !important;
        color: #111 !important;
        border-color: transparent !important;
        background-image: url('../../img/defaults/toast-info.png') !important;
        background-size: 30px 30px;
    }
    .jq-icon-error {
        background-color: #dc3545 !important;
        color: #fff !important;
        border-color: transparent !important;
    }
    .dropdown-toggle butto");
            WriteLiteral("n{\r\n        text-transform: none !important;\r\n    }\r\n    .dropdown{\r\n        letter-spacing: 0;\r\n    }\r\n    .jq-toast-wrap{\r\n        inset: 100px 600px !important;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
