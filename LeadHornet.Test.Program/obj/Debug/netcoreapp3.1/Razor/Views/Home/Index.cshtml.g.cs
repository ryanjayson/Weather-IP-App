#pragma checksum "C:\Users\ryanjayson\source\repos\LeadHornet.Test.Program\LeadHornet.Test.Program\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61f9c08a7af707fd28dadcf75b64363d5af39e8c"
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
#line 1 "C:\Users\ryanjayson\source\repos\LeadHornet.Test.Program\LeadHornet.Test.Program\Views\_ViewImports.cshtml"
using LeadHornet.Test.Program;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ryanjayson\source\repos\LeadHornet.Test.Program\LeadHornet.Test.Program\Views\_ViewImports.cshtml"
using LeadHornet.Test.Program.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f9c08a7af707fd28dadcf75b64363d5af39e8c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45140d8591e074bcd2c7a1863c80c1333eb843bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ryanjayson\source\repos\LeadHornet.Test.Program\LeadHornet.Test.Program\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Weather App";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""hero-section"">
    <div class=""container"">

        <div class=""banner-hero"">

            <div class=""banner-form"">

                <h1>Lead Hornet Programming test</h1>
                <span class=""sub-header-p"">
                    This simple Weather App will get the current IP address and search for it's locaion and weather.
                    It has location input where you can search for location and show it's weather. 
                </span>

                <div class=""form-group"">
                    <input id=""location-input"" type=""text"" class=""form-control"" placeholder=""Enter location"">
                    <small id=""emailHelp"" class=""form-text"">Location input has feature of location searching.</small>
                </div>

                <button id=""search-location"" type=""button"" class=""btn btn-primary"">Search Location</button>

            </div>

            <div class=""banner-result"">
                <div class=""result-location"">
                    ");
            WriteLiteral(@"<span class=""data-location-label"">My location</span>
                    <span class=""data-location"">{Location}</span>
                </div>
            </div>

        </div>

    </div>

</div>


<script id=""weather-result"" type=""text/x-jquery-tmpl"">
    <div class=""result-weather searched-result"">

        <div class=""result-weather-location"">
            <span class=""data-weather-loc-city"" data-content=""city"">${city}</span>
            <span class=""data-weather-loc-country"" data-content=""country"">${country}</span>
        </div>

        <div class=""result-weather-data"">
            <span class=""data-weather-icon""><img src=""${icon}"" /></span>
            <span class=""data-weather-desc"" data-content=""desc"">${description}</span>
        </div>

        <div class=""result-weather-temp"">
            <span class=""data-weather-temp"">TEMP<br> <i data-content=""temp"">${temperature}</i></span>
        </div>
    </div>

</script>


");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script src=""https://ajax.aspnetcdn.com/ajax/jquery.templates/beta1/jquery.tmpl.js""></script>

    <script src=""https://api.mqcdn.com/sdk/place-search-js/v1.0.0/place-search.js""></script>

    <link type=""text/css"" rel=""stylesheet"" href=""https://api.mqcdn.com/sdk/place-search-js/v1.0.0/place-search.css"" />

    <script>

        var ps;
        var rCity, rCountry;

        //INIT AUTOCOMPLETE
        window.onload = function () {
            ps = placeSearch({
                key: 'lYrP4vF3Uk5zgTiGGuEzQGwGIVDGuy24',
                container: document.querySelector('#location-input'),
                collection: [
                    'airport', 'address', 'adminArea', 'poi'
                ]
            });

            ps.on('change', (e) => {
                rCity = e.result.city
                rCountry = e.result.countryCode
            });
        }

        //GET USER LOCATION BASED ON IP LOAD, AND DISPLAY WEATHER
        function displayUserInfo(json) {

         ");
                WriteLiteral(@"   $.getJSON('https://ipapi.co/' + json.ip + '/json', function (data) {
                $('.data-location').text(data.city + ', ' + data.country_name);

                searchWeatherDetail(data);
            });

        }

        //GET WEATHER BASED ON LOCATION
        function searchWeatherDetail(location) {
            var appId = ""8dad832ddfefdbce0c47db083fc43bca"";
            var locationData = location.city + ', ' + location.country

            $.getJSON('https://api.openweathermap.org/data/2.5/weather?q=' + locationData + '&appid=' + appId + '&units=metric', function (res) {
                var weatherResult = [
                    {
                        city: res.name,
                        country: res.sys.country,
                        icon: 'http://openweathermap.org/img/w/' + res.weather[0].icon + '.png',
                        description: res.weather[0].description,
                        temperature: res.main.temp + '°c'
                    }
                ];");
                WriteLiteral(@"

                // Use the template
                $(""#weather-result"").tmpl(weatherResult).appendTo("".banner-result"");
            });

        }

        //SEARCH BUTTON EVENT
        $(""#search-location"").click(function () {
            var location = {
                city: rCity,
                country: rCountry
            };

            //CHECK WEATHER
            searchWeatherDetail(location)

            $(this).val('');
        });

    </script>

    <script src=""https://api.ipify.org?format=jsonp&callback=displayUserInfo""></script>

");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
