#pragma checksum "C:\CSharp\Project_PostOffice\Views\Shared\Partials\_ClientScripts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45a6b74ac35fef63b2b9a97b487d508401a8d341"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partials__ClientScripts), @"mvc.1.0.view", @"/Views/Shared/Partials/_ClientScripts.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45a6b74ac35fef63b2b9a97b487d508401a8d341", @"/Views/Shared/Partials/_ClientScripts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c33bc81411c8478abb59bd49d3925a21ba29a7b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partials__ClientScripts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script>
    (function (body) {
        'use strict';
        body.className = body.className.replace(/\btribe-no-js\b/, 'tribe-js');
    })(document.body);
</script>
<script>
    (function () {
        function maybePrefixUrlField() {
            if (this.value.trim() !== '' && this.value.indexOf('http') !== 0) {
                this.value = ""http://"" + this.value;
            }
        }

        var urlFields = document.querySelectorAll('.mc4wp-form input[type=""url""]');
        if (urlFields) {
            for (var j = 0; j < urlFields.length; j++) {
                urlFields[j].addEventListener('blur', maybePrefixUrlField);
            }
        }
    })();</script>
<script>
        /* <![CDATA[ */var tribe_l10n_datatables = { ""aria"": { ""sort_ascending"": "": activate to sort column ascending"", ""sort_descending"": "": activate to sort column descending"" }, ""length_menu"": ""Show _MENU_ entries"", ""empty_table"": ""No data available in table"", ""info"": ""Showing _START_ to _END_ of _TOTAL_ entri");
            WriteLiteral(@"es"", ""info_empty"": ""Showing 0 to 0 of 0 entries"", ""info_filtered"": ""(filtered from _MAX_ total entries)"", ""zero_records"": ""No matching records found"", ""search"": ""Search:"", ""all_selected_text"": ""All items on this page were selected. "", ""select_all_link"": ""Select all pages"", ""clear_selection"": ""Clear Selection."", ""pagination"": { ""all"": ""All"", ""next"": ""Next"", ""previous"": ""Previous"" }, ""select"": { ""rows"": { ""0"": """", ""_"": "": Selected %d rows"", ""1"": "": Selected 1 row"" } }, ""datepicker"": { ""dayNames"": [""Sunday"", ""Monday"", ""Tuesday"", ""Wednesday"", ""Thursday"", ""Friday"", ""Saturday""], ""dayNamesShort"": [""Sun"", ""Mon"", ""Tue"", ""Wed"", ""Thu"", ""Fri"", ""Sat""], ""dayNamesMin"": [""S"", ""M"", ""T"", ""W"", ""T"", ""F"", ""S""], ""monthNames"": [""January"", ""February"", ""March"", ""April"", ""May"", ""June"", ""July"", ""August"", ""September"", ""October"", ""November"", ""December""], ""monthNamesShort"": [""January"", ""February"", ""March"", ""April"", ""May"", ""June"", ""July"", ""August"", ""September"", ""October"", ""November"", ""December""], ""monthNamesMin"": [""Jan"", ""Feb"", ""Mar"", ""Apr");
            WriteLiteral(@""", ""May"", ""Jun"", ""Jul"", ""Aug"", ""Sep"", ""Oct"", ""Nov"", ""Dec""], ""nextText"": ""Next"", ""prevText"": ""Prev"", ""currentText"": ""Today"", ""closeText"": ""Done"", ""today"": ""Today"", ""clear"": ""Clear"" } };/* ]]> */ 
</script>
<script type=""text/html"" id=""wpb-modifications""></script>
<script>
    (function () {
        var c = document.body.className;
        c = c.replace(/postalservice-no-js/, 'postalservice-js');
        document.body.className = c;
    })()
</script>
<script>
    if (typeof revslider_showDoubleJqueryError === ""undefined"") {
        function revslider_showDoubleJqueryError(sliderID) {
            var err = ""<div class='rs_error_message_box'>"";
            err += ""<div class='rs_error_message_oops'>Oops...</div>"";
            err += ""<div class='rs_error_message_content'>"";
            err += ""You have some jquery.js library include that comes after the Slider Revolution files js inclusion.<br>"";
            err += ""To fix this, you can:<br>&nbsp;&nbsp;&nbsp; 1. Set 'Module General Options' -> '");
            WriteLiteral(@"Advanced' -> 'jQuery & OutPut Filters' -> 'Put JS to Body' to on"";
            err += ""<br>&nbsp;&nbsp;&nbsp; 2. Find the double jQuery.js inclusion and remove it"";
            err += ""</div>"";
            err += ""</div>"";
            var slider = document.getElementById(sliderID); slider.innerHTML = err; slider.style.display = ""block"";
        }
    }
</script>
<link rel='stylesheet' id='themestek-footer-gfonts-css'
    href='//fonts.googleapis.com/css?family=Abril+Fatface%7CArimo%3A700&#038;ver=1.0.0' media='all' />
<script src='../../js/client/wp-polyfill.min.js' id='wp-polyfill-js'></script>
<script id='wp-polyfill-js-after'>
    ('fetch' in window) || document.write('<script src=""../../js/client/wp-polyfill-fetch.min.js""></scr' + 'ipt>'); (document.contains) || document.write('<script src=""https://moversco.themestek.com/demo6/wp-includes/js/dist/vendor/wp-polyfill-node-contains.min.js?ver=3.42.0""></scr' + 'ipt>'); (window.DOMRect) || document.write('<script src=""https://moversco.themestek.com");
            WriteLiteral(@"/demo6/wp-includes/js/dist/vendor/wp-polyfill-dom-rect.min.js?ver=3.42.0""></scr' + 'ipt>'); (window.URL && window.URL.prototype && window.URLSearchParams) || document.write('<script src=""https://moversco.themestek.com/demo6/wp-includes/js/dist/vendor/wp-polyfill-url.min.js?ver=3.6.4""></scr' + 'ipt>'); (window.FormData && window.FormData.prototype.keys) || document.write('<script src=""https://moversco.themestek.com/demo6/wp-includes/js/dist/vendor/wp-polyfill-formdata.min.js?ver=3.0.12""></scr' + 'ipt>'); (Element.prototype.matches && Element.prototype.closest) || document.write('<script src=""https://moversco.themestek.com/demo6/wp-includes/js/dist/vendor/wp-polyfill-element-closest.min.js?ver=2.0.2""></scr' + 'ipt>');
</script>
<script src='../../js/client/i18n.min.js' id='wp-i18n-js'></script>
<script src='../../js/client/lodash.min.js' id='lodash-js'></script>
<script id='lodash-js-after'>
    window.lodash = _.noConflict();
</script>
<script src='../../js/client/url.min.js' id='wp-url-js'></script>
<");
            WriteLiteral(@"script src='../../js/client/hooks.min.js' id='wp-hooks-js'></script>
<script id='wp-api-fetch-js-translations'>
    (function (domain, translations) {
        var localeData = translations.locale_data[domain] || translations.locale_data.messages;
        localeData[""""].domain = domain;
        wp.i18n.setLocaleData(localeData, domain);
    })(""default"", { ""locale_data"": { ""messages"": { """": {} } } });
</script>
<script src='../../js/client/api-fetch.min.js' id='wp-api-fetch-js'></script>
<script id='wp-api-fetch-js-after'>
    wp.apiFetch.use(wp.apiFetch.createRootURLMiddleware(""https://moversco.themestek.com/demo6/wp-json/""));
    wp.apiFetch.nonceMiddleware = wp.apiFetch.createNonceMiddleware(""cfbc40b9c2"");
    wp.apiFetch.use(wp.apiFetch.nonceMiddleware);
    wp.apiFetch.use(wp.apiFetch.mediaUploadMiddleware);
    wp.apiFetch.nonceEndpoint = ""https://moversco.themestek.com/demo6/wp-admin/admin-ajax.php?action=rest-nonce"";
</script>
<script id='contact-form-7-js-extra'>
    /* <![CDATA[ */
");
            WriteLiteral(@"    var postoffice = { ""cached"": ""1"" };
    /* ]]> */
</script>
<script src='../../js/client/index.js' id='contact-form-7-js'></script>
<script src='../../js/client/js.cookie.min.js' id='js-cookie-js'></script>
<script id='postalservice-js-extra'>
    /* <![CDATA[ */
    var postalservice_params = { ""ajax_url"": ""\/demo6\/wp-admin\/admin-ajax.php"", ""wc_ajax_url"": ""\/demo6\/?wc-ajax=%%endpoint%%"" };
    /* ]]> */
</script>
<script src='../../js/client/postalservice.min.js' id='postalservice-js'></script>
<script id='wc-cart-fragments-js-extra'>
    /* <![CDATA[ */
    var wc_cart_fragments_params = { ""ajax_url"": ""\/demo6\/wp-admin\/admin-ajax.php"", ""wc_ajax_url"": ""\/demo6\/?wc-ajax=%%endpoint%%"", ""cart_hash_key"": ""wc_cart_hash_51f5e9663d885b27a809352f17a7ba73"", ""fragment_name"": ""wc_fragments_51f5e9663d885b27a809352f17a7ba73"", ""request_timeout"": ""5000"" };
    /* ]]> */
</script>
<script src='../../js/client/cart-fragments.min.js' id='wc-cart-fragments-js'></script>
<script src='../../js/client/p");
            WriteLiteral(@"erfect-scrollbar.jquery.min.js' id='perfect-scrollbar-js'></script>
<script src='../../js/client/select2.full.min.js' id='select2-js'></script> 
<script src='../../js/client/isotope.pkgd.min.js' id='isotope-js'></script>
<script src='../../js/client/jquery.mousewheel.min.js' id='jquery-mousewheel-js'></script>
<script src='../../js/client/jquery.flexslider.min.js' id='flexslider-js'></script>
<script src='../../js/client/jquery.sticky-kit.min.js' id='sticky-kit-js'></script>
<script src='../../js/client/slick.min.js' id='slick-js'></script>
<script src='../../js/client/jquery.prettyPhoto.min.js' id='prettyphoto-js'></script>
<script src='../../js/client/js_composer_front.min.js' id='wpb_composer_front_js-js'></script>
<script id='moversco-script-js-extra'>
    /* <![CDATA[ */
    var themestek_breakpoint = ""1200"";
    var ajaxurl = ""https:\/\/moversco.themestek.com\/demo6\/wp-admin\/admin-ajax.php"";
    /* ]]> */
</script>
<script src='../../js/client/scripts.js' id='moversco-script-js'></scrip");
            WriteLiteral(@"t>
<script src='../../js/client/wp-embed.min.js' id='wp-embed-js'></script>
<script src='../../js/client/vc-waypoints.min.js' id='vc_waypoints-js'></script>
<script src='../../js/client/numinate.min.js' id='numinate-js'></script>
<script src='../../js/client/forms.js' id='mc4wp-forms-api-js'></script>

<script src='../../js/client/core.min.js' id='jquery-ui-core-js'></script>
<script src='../../js/client/mouse.min.js' id='jquery-ui-mouse-js'></script>
<script src='../../js/client/slider.min.js' id='jquery-ui-slider-js'></script>
<script src='../../js/client/jquery-ui-touch-punch.min.js' id='wc-jquery-ui-touchpunch-js'></script>
<script src='../../js/client/accounting.min.js' id='accounting-js'></script>
<script src='../../js/client/price-slider.min.js' id='wc-price-slider-js'></script>
<script src='../../js/client/forms.min.js' id='mc4wp-forms-api-js'></script>
");
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
