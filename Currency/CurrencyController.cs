using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DiamondDrillingReport.Currency;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RestSharp;

namespace DiamondDrillingReport.Pages
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly IOptions<AppConfig> appSettings;
        XeResult xe = new XeResult();
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public CurrencyController(IOptions<AppConfig> app)
        {
            appSettings = app;
        }

        // GET: api/Currency
        [HttpGet]
        public ActionResult<string> Get()
        {
            logger.Info("Begin check service status");
            try
            {
                var status = CheckXeServiceStatus("account_info");
                logger.Info("End check service status");

                if (status.ToUpper() != "OK")
                    return "Service status: " + status;

                status = "Service status: " + status+"\n";
                //var EUR_toAny = ConvertFrom(appSettings.Value.currency1, "*", out xe);
                var MyCurrency_toAny = ConvertFrom(appSettings.Value.currency1, "*", out xe)
                    + "\n" + ConvertFrom(appSettings.Value.currency2, "*", out xe)
                    + "\n" + ConvertFrom(appSettings.Value.currency3, "*", out xe)
                    + "\n" + ConvertFrom(appSettings.Value.currency4, "*", out xe)
                    + "\n" + ConvertFrom(appSettings.Value.currency5, "*", out xe)
                    + "\n" + ConvertFrom(appSettings.Value.currency6, "*", out xe);

                status =status + MyCurrency_toAny;

                return status;
            }
            catch (Exception e)
            {
                logger.Error(e);
                return e.Message;
            }
        }

        [HttpGet("{currency1},{currency2}", Name = "Get")]
        public string Get(string currency1, string currency2)
        {
            SoapClient soapClient = new SoapClient(appSettings);
            var js = ConvertFrom(currency1, currency2, out xe);
            soapClient.ServiceClientCallAsync(xe);
            return currency1 + currency2;
        }

        [HttpGet("{soap}", Name = "soap")]
        public Task<string> soap()
        {
            Task<string> result = Task.FromResult("");
            SoapClient soapClient = new SoapClient(appSettings);
            result = soapClient.SoapCheck();
            return result;
        }

       


        ///URL Convert from
        /// https://xecdapi.xe.com:443/v1/convert_from?from=EUR&to=AUD&amount=1&decimal_places=4
        ///
        private string ConvertFrom(string from, string to, out XeResult xe)
        {
            var result = "";
            var encoded = AuthParams();
            var wc = new WebClient();
            wc.Headers.Add("Content-Type", "application/json");
            wc.Headers.Add("authorization", "Basic " + encoded);
            wc.QueryString.Add("from", from);
            wc.QueryString.Add("to", to);
            wc.QueryString.Add("decimal_places", "4");
            wc.QueryString.Add("amount", "1");

            try
            {


                dynamic dparce = wc.DownloadString(appSettings.Value.xeUrl + "convert_from");
                //"https://xecdapi.xe.com:443/v1/convert_from?from=" + from + "&to=" + to + "&amount=1&decimal_places=4");

                string parce = null;
                parce = dparce;

                var welcome = XeResult.FromJson(parce);

                xe = welcome;

                result = welcome.From;
                switch (from)
                {
                    case "EUR":
                        var EUR_AUD = welcome.To.Find(x => x.Quotecurrency == appSettings.Value.currency2);
                        var EUR_GBP = welcome.To.Find(x => x.Quotecurrency == appSettings.Value.currency3);
                        var EUR_CHF = welcome.To.Find(x => x.Quotecurrency == appSettings.Value.currency4);
                        var EUR_KZT = welcome.To.Find(x => x.Quotecurrency == appSettings.Value.currency5);
                        var EUR_RUB = welcome.To.Find(x => x.Quotecurrency == appSettings.Value.currency6);
                        result += " \n -> " + EUR_AUD.Quotecurrency + " " + EUR_AUD.Mid
                               + " \n -> " + EUR_GBP.Quotecurrency + " " + EUR_GBP.Mid
                               + " \n -> " + EUR_CHF.Quotecurrency + " " + EUR_CHF.Mid
                               + " \n -> " + EUR_KZT.Quotecurrency + " " + EUR_KZT.Mid
                               + " \n -> " + EUR_RUB.Quotecurrency + " " + EUR_RUB.Mid;

                        SoapClient soapClient = new SoapClient(appSettings);
                        soapClient.SoapCheck();
                        //soapClient.ServiceClientCallAsync(xe);

                        break;
                    case "AUD":
                        var AUD_EUR = welcome.To.Find(x => x.Quotecurrency == appSettings.Value.currency1);
                        var AUD_GBP = welcome.To.Find(x => x.Quotecurrency == appSettings.Value.currency3);
                        var AUD_CHF = welcome.To.Find(x => x.Quotecurrency == appSettings.Value.currency4);
                        var AUD_KZT = welcome.To.Find(x => x.Quotecurrency == appSettings.Value.currency5);
                        var AUD_RUB = welcome.To.Find(x => x.Quotecurrency == appSettings.Value.currency6);
                        result += " \n -> " + AUD_EUR.Quotecurrency + " " + AUD_EUR.Mid
                                  + " \n -> " + AUD_GBP.Quotecurrency + " " + AUD_GBP.Mid
                                  + " \n -> " + AUD_CHF.Quotecurrency + " " + AUD_CHF.Mid
                                  + " \n -> " + AUD_KZT.Quotecurrency + " " + AUD_KZT.Mid
                                  + " \n -> " + AUD_RUB.Quotecurrency + " " + AUD_RUB.Mid;
                        break;
                    case "GBP":
                        var GBP_EUR = welcome.To.Find(x => x.Quotecurrency == appSettings.Value.currency1);
                        var GBP_AUD = welcome.To.Find(x => x.Quotecurrency == appSettings.Value.currency2);
                        var GBP_CHF = welcome.To.Find(x => x.Quotecurrency == appSettings.Value.currency4);
                        var GBP_KZT = welcome.To.Find(x => x.Quotecurrency == appSettings.Value.currency5);
                        var GBP_RUB = welcome.To.Find(x => x.Quotecurrency == appSettings.Value.currency6);
                        result += " \n -> " + GBP_AUD.Quotecurrency + " " + GBP_AUD.Mid
                                  + " \n -> " + GBP_EUR.Quotecurrency + " " + GBP_EUR.Mid
                                  + " \n -> " + GBP_CHF.Quotecurrency + " " + GBP_CHF.Mid
                                  + " \n -> " + GBP_KZT.Quotecurrency + " " + GBP_KZT.Mid
                                  + " \n -> " + GBP_RUB.Quotecurrency + " " + GBP_RUB.Mid;
                        break;
                    case "CHF":
                        var CHF_EUR = welcome.To.Find(x => x.Quotecurrency == appSettings.Value.currency1);
                        var CHF_AUD = welcome.To.Find(x => x.Quotecurrency == appSettings.Value.currency2);
                        var CHF_GBP = welcome.To.Find(x => x.Quotecurrency == appSettings.Value.currency3);
                        var CHF_KZT = welcome.To.Find(x => x.Quotecurrency == appSettings.Value.currency5);
                        var CHF_RUB = welcome.To.Find(x => x.Quotecurrency == appSettings.Value.currency6);
                        result += " \n -> " + CHF_AUD.Quotecurrency + " " + CHF_AUD.Mid
                                  + " \n -> " + CHF_GBP.Quotecurrency + " " + CHF_GBP.Mid
                                  + " \n -> " + CHF_EUR.Quotecurrency + " " + CHF_EUR.Mid
                                  + " \n -> " + CHF_KZT.Quotecurrency + " " + CHF_KZT.Mid
                                  + " \n -> " + CHF_RUB.Quotecurrency + " " + CHF_RUB.Mid;
                        break;
                    case "KZT":
                        var KZT_EUR = welcome.To.Find(x => x.Quotecurrency == appSettings.Value.currency1);
                        var KZT_AUD = welcome.To.Find(x => x.Quotecurrency == appSettings.Value.currency2);
                        var KZT_GBP = welcome.To.Find(x => x.Quotecurrency == appSettings.Value.currency3);
                        var KZT_CHF = welcome.To.Find(x => x.Quotecurrency == appSettings.Value.currency4);
                        var KZT_RUB = welcome.To.Find(x => x.Quotecurrency == appSettings.Value.currency6);
                        result += " \n -> " + KZT_AUD.Quotecurrency + " " + KZT_AUD.Mid
                                  + " \n -> " + KZT_GBP.Quotecurrency + " " + KZT_GBP.Mid
                                  + " \n -> " + KZT_CHF.Quotecurrency + " " + KZT_CHF.Mid
                                  + " \n -> " + KZT_EUR.Quotecurrency + " " + KZT_EUR.Mid
                                  + " \n -> " + KZT_RUB.Quotecurrency + " " + KZT_RUB.Mid;
                        break;
                    case "RUB":
                        var RUB_EUR = welcome.To.Find(x => x.Quotecurrency == appSettings.Value.currency1);
                        var RUB_AUD = welcome.To.Find(x => x.Quotecurrency == appSettings.Value.currency2);
                        var RUB_GBP = welcome.To.Find(x => x.Quotecurrency == appSettings.Value.currency3);
                        var RUB_CHF = welcome.To.Find(x => x.Quotecurrency == appSettings.Value.currency4);
                        var RUB_KZT = welcome.To.Find(x => x.Quotecurrency == appSettings.Value.currency5);
                        result += " \n -> " + RUB_AUD.Quotecurrency + " " + RUB_AUD.Mid
                                  + " \n -> " + RUB_GBP.Quotecurrency + " " + RUB_GBP.Mid
                                  + " \n -> " + RUB_CHF.Quotecurrency + " " + RUB_CHF.Mid
                                  + " \n -> " + RUB_KZT.Quotecurrency + " " + RUB_KZT.Mid
                                  + " \n -> " + RUB_EUR.Quotecurrency + " " + RUB_EUR.Mid;
                        break;
                        default:
                            result = "Currency "+ from+ " is not supported";
                            break;
                }

            }
            //{"terms":"http://www.xe.com/legal/dfs.php","privacy":"http://www.xe.com/privacy.php","from":"EUR","amount":1.0,"timestamp":"2019-01-18T00:00:00Z","to":[{"quotecurrency":"KZT","mid":430.7385}]}
            catch (Exception e)
            {
                xe = null;
                return e.Message;
            }

            return result;

        }

        private string AuthParams()
        {
            string encoded = "";
            var username = appSettings.Value.username;
            var password = appSettings.Value.password;
            encoded = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            return encoded;
        }
        private string CheckXeServiceStatus(string method)
        {
            var encoded = AuthParams();
            try
            {
                var client = new RestClient(appSettings.Value.xeUrl + method);
                var request = new RestRequest(Method.GET);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("authorization", "Basic " + encoded);
                var iresponse = client.Execute(request);
                var status = iresponse.StatusCode;
                return status.ToString();
            }
            catch (Exception e)
            {
                logger.Error(e);
                return e.Message;
            }
        }
    }



   
    public class AccountInfo
    {
        public string id { get; set; }
        public string organization { get; set; }
        public string package { get; set; }
        public string service_start_timestamp { get; set; }
        public string service_end_timestamp { get; set; }
        public int package_limit { get; set; }
        public int package_limit_remaining { get; set; }
    }
    public class AppConfig
    {
        public string username { get; set; }
        public string password { get; set; }
        public string xeUrl { get; set; }
        public string currency1 { get; set; }
        public string currency2 { get; set; }
        public string currency3 { get; set; }
        public string currency4 { get; set; }
        public string currency5 { get; set; }
        public string currency6 { get; set; }
        public string el_UserID { get; set; }
        public string el_psw { get; set; }
        public string el_OrgID { get; set; }
        public string el_role { get; set; }
        public string el_LogicalID { get; set; }
        public string el_district { get; set; }
        public string el_position { get; set; }
    }
    public partial class XeResult
    {
        [JsonProperty("terms")]
        public Uri Terms { get; set; }

        [JsonProperty("privacy")]
        public Uri Privacy { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("timestamp")]
        public DateTimeOffset Timestamp { get; set; }

        [JsonProperty("to")]
        public List<To> To { get; set; }
    }

    public partial class To
    {
        [JsonProperty("quotecurrency")]
        public string Quotecurrency { get; set; }

        [JsonProperty("mid")]
        public double Mid { get; set; }
    }

    public partial class XeResult
    {
        public static XeResult FromJson(string json) => JsonConvert.DeserializeObject<XeResult>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this XeResult self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
