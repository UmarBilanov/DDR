using System;
using System.IO;
using System.Net;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using DiamondDrillingReport.Pages;
using ExchangeRateService;
using ExchangeRateUpdService;
using Microsoft.Extensions.Options;
using OperationContext = ExchangeRateUpdService.OperationContext;
using RunAs = ExchangeRateService.RunAs;

namespace DiamondDrillingReport.Currency
{
    public class SoapClient : ExchangeRateUpdClient
    {
        private readonly IOptions<AppConfig> appSettings;
        public SoapClient(IOptions<AppConfig> app)
        {
            appSettings = app;
        }

        public const string _url = "https://dev03-n01-kum.ellipsehosting.com/ews/services/ExchangeRateService"; //"http://xxxxxxxxx/Service1.asmx";
        public const string _action = "https://dev03-n01-kum.ellipsehosting.com/ews/services/ExchangeRateService?WSDL";
        Uri uri = new Uri(_url);
        public async Task<string> SoapCheck()
        {
            string result = "";
            ExchangeRateUpdClient eupd = new ExchangeRateUpdClient();

            // TODO Create Security header by OASIS protocol
            //var wsHttpBinding = new WSHttpBinding(SecurityMode.Transport);
            //wsHttpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;


            OperationContext operationContext = new OperationContext
            {
                district = appSettings.Value.el_district,
                position = appSettings.Value.el_position,
                returnWarnings = true,
                runAs = new ExchangeRateUpdService.RunAs
                {
                    position = appSettings.Value.el_position,
                    district = appSettings.Value.el_district,
                    user = appSettings.Value.el_UserID
                }
            };
            var serviceDTO = new ExchangeRateUpdDTO
            {
                currentDate = DateTime.Now,
                buyingrate = 12,
                sellingRate = 25,
                lastModDate = DateTime.Now.AddHours(-1),
                foreignCurrency = "EUR",
                lastModUser = appSettings.Value.el_UserID,
                localCurrency = "AUD",
                nationalRate = 80,
                lastModTime = DateTime.Now.AddHours(-2).ToLongDateString(),
                datePerRevsd = DateTime.Now.AddMinutes(-20).ToLongTimeString()
            };

            await eupd.OpenAsync();
            try
            {
                if (eupd.State == CommunicationState.Opened)
                {
                    EndpointConfiguration rre = EndpointConfiguration.ExchangeRateUpdServiceHttpPort;
                    
                    
                    


                    ExchangeRateUpd e = new ExchangeRateUpdClient();
                    saveRequest saveRequest = new saveRequest(operationContext, serviceDTO);
                    saveResponse saveResponse = await e.saveAsync(saveRequest);
                    result = result + saveResponse.@out;

                    readRequest readRequest = new readRequest { serviceDTO = serviceDTO, context = operationContext };
                    readResponse readResponse = await e.readAsync(readRequest);
                    result = result + readResponse.@out;

                    updateRequest updateRequest = new updateRequest( operationContext, serviceDTO);
                    updateResponse updateResponse = await e.updateAsync(updateRequest);
                    result = result + updateResponse.@out;

                    ExchangeRateUpdServiceResult xResult = new ExchangeRateUpdServiceResult();

                    createRequest y = new createRequest(operationContext, serviceDTO);
                    createResponse x1 = new createResponse(xResult);

                    //x1 = await eupd.;

                    createResponse x = await eupd.createAsync(operationContext, serviceDTO);
                    updateResponse z = await eupd.updateAsync(operationContext, serviceDTO);
                    saveResponse sr = await eupd.saveAsync(operationContext, serviceDTO);
                    await eupd.CloseAsync();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;

        }
        public void ServiceClientCallAsync(XeResult xe)
        {
            ExchangeRateUpdClient exchangeRate = new ExchangeRateUpdClient();
            exchangeRate.ClientCredentials.UserName.UserName = appSettings.Value.el_UserID;
            exchangeRate.ClientCredentials.UserName.Password = appSettings.Value.el_psw;
            var b = exchangeRate.OpenAsync().Status;
            ExchangeRateUpdClient.EndpointConfiguration endpointConfiguration = ExchangeRateUpdClient.EndpointConfiguration.ExchangeRateUpdServiceHttpPort;
            var timestamp = DateTime.Now;

            var serviceDTO = new ExchangeRateUpdDTO
            {
                currentDate = xe.Timestamp.DateTime,
                buyingrate = Convert.ToDecimal(xe.To[0].Mid),
                sellingRate = Convert.ToDecimal(xe.To[0].Mid),
                lastModDate = timestamp,
                lastModUser = "Alis.Alymkulov",
                localCurrency = xe.From,
                foreignCurrency = xe.To[0].Quotecurrency
            };

            var operationContext = new OperationContext
            {
                district = appSettings.Value.el_district,
                position = appSettings.Value.el_position,
                returnWarnings = true,
                runAs = new ExchangeRateUpdService.RunAs
                {
                    position = appSettings.Value.el_position,
                    district = appSettings.Value.el_district,
                    user = appSettings.Value.el_UserID
                }
            };


            ExchangeRateUpdClient exchangeRateUpdClient = new ExchangeRateUpdClient(endpointConfiguration);
            var state = exchangeRateUpdClient.OpenAsync();

            createRequest cr = new createRequest(operationContext, serviceDTO);
            IAsyncResult asyncResult = exchangeRateUpdClient.updateAsync(operationContext, serviceDTO);
            IAsyncResult aasyncResult = exchangeRateUpdClient.readAsync(operationContext, serviceDTO);

            asyncResult.AsyncWaitHandle.WaitOne();
            aasyncResult.AsyncWaitHandle.WaitOne();
            // get the response from the completed web request.
            string soapResult;
            WebRequest webRequest = CreateWebRequest(_url, "update");
            using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
            {
                using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
                {
                    soapResult = rd.ReadToEnd();
                }

                Console.Write(soapResult);
            }


            currencyConvertRequest ccr = new currencyConvertRequest();
            ccr.context = new ExchangeRateService.OperationContext();
            ccr.requestParameters = new ExchangeRateServiceCurrencyConvertRequestDTO();


            cr.context = operationContext;
            cr.serviceDTO = serviceDTO;
            ExchangeRateUpdServiceResult rateUpdServiceResult = new ExchangeRateUpdServiceResult();
            createResponse ersp = new createResponse(rateUpdServiceResult);
            var a = rateUpdServiceResult.exchangeRateUpdDTO;
            var bb = rateUpdServiceResult.informationalMessages;
            updateRequest updateRequest = new updateRequest(operationContext, serviceDTO);

            CallWebService();




            //var tmp2 = exchangeRate.Endpoint.Name;
            //var ClientCredentials_UserName = exchangeRate.ClientCredentials.UserName.UserName;
            //var ClientCredentials_pasw = exchangeRate.ClientCredentials.UserName.Password;
            //var tmp = exchangeRate.ChannelFactory;
        }

        public static void CallWebService()
        {

            /*
             *https://dev03-n01-kum.ellipsehosting.com/ews/services/ExchangeRateService?WSDL
             *
             *https://dev03-n01-kum.ellipsehosting.com/ews/services/ExchangeRateUpdService?WSDL
             *
             */


            XmlDocument soapEnvelopeXml = CreateSoapEnvelope();
            HttpWebRequest webRequest = CreateWebRequest(_url, _action);
            InsertSoapEnvelopeIntoWebRequest(soapEnvelopeXml, webRequest);

            // begin async call to web request.
            IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);

            // suspend this thread until call is complete. You might want to
            // do something usefull here like update your UI.
            asyncResult.AsyncWaitHandle.WaitOne();

            // get the response from the completed web request.
            string soapResult;
            using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
            {
                using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
                {
                    soapResult = rd.ReadToEnd();
                }

                Console.Write(soapResult);
            }
        }

        private static HttpWebRequest CreateWebRequest(string url, string action)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Headers.Add("SOAPAction", action);
            webRequest.ContentType = "text/xml;charset=\"utf-8\"";
            webRequest.Accept = "text/xml";
            webRequest.Method = "POST";
            return webRequest;
        }

        private static XmlDocument CreateSoapEnvelope()
        {
            XmlDocument soapEnvelopeDocument = new XmlDocument();
            soapEnvelopeDocument.LoadXml(
                @"<SOAP-ENV:Envelope xmlns:SOAP-ENV=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:xsi=""http://www.w3.org/1999/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/1999/XMLSchema""><SOAP-ENV:Body><HelloWorld xmlns=""http://tempuri.org/"" SOAP-ENV:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/""><int1 xsi:type=""xsd:integer"">12</int1><int2 xsi:type=""xsd:integer"">32</int2></HelloWorld></SOAP-ENV:Body></SOAP-ENV:Envelope>");
            return soapEnvelopeDocument;
        }

        private static void InsertSoapEnvelopeIntoWebRequest(XmlDocument soapEnvelopeXml, HttpWebRequest webRequest)
        {
            using (Stream stream = webRequest.GetRequestStream())
            {
                soapEnvelopeXml.Save(stream);
            }
        }



        protected virtual WebRequest CreateRequest(ISoapMessage soapMessage)
        {
            var wr = WebRequest.Create(soapMessage.Uri);
            wr.ContentType = "text/xml;charset=utf-8";
            wr.ContentLength = soapMessage.ContentXml.Length;

            wr.Headers.Add("SOAPAction", soapMessage.SoapAction);
            wr.Credentials = soapMessage.Credentials;
            wr.Method = "POST";
            wr.GetRequestStream().Write(Encoding.UTF8.GetBytes(soapMessage.ContentXml), 0, soapMessage.ContentXml.Length);

            return wr;
        }

        public interface ISoapMessage
        {
            string Uri { get; }
            string ContentXml { get; }
            string SoapAction { get; }
            ICredentials Credentials { get; }
        }
    }
}
