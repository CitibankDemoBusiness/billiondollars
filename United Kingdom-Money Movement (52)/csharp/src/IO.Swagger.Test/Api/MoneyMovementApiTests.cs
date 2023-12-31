/* 
 * Money Movement
 *
 * <P>The Money Movement API allow you to move money from Citi customers account. Transfers can be made to predefined payees by customer and individuals not included in the payee list</P> The segment of API will allow to perform below category of transfers:<br><br><b>Personal Transfer-</b> Allowing customer to initiate the money transfers within customer�s own Citi accounts.<br><br><b>Internal transfer-</b> Allowing customer to initiate the money transfer from customer Citi own accounts to other Citi accounts locally.<br><br><b>External transfer-</b> Allowing customer to initiate the money transfer from customer Citi own accounts to other bank accounts locally.<br><br><b>Bill Payment-</b> Allowing customer to initiate the bill payment from customer Citi own accounts to billing organization.<br><br><b>Citi Global Transfer-</b> Allowing customer to initiate the money transfer from customer Citi own accounts to other Citi bank accounts across various Countries.<br><br><b>SEPA Transfer-</b> Allowing customer to initiate money transfer to other European bank accounts within the SEPA territory.<br><br><b>Cross border transfer-</b> Allowing customer to initiate money transfer from customer own account to cross border bank accounts.<br>
 *
 * OpenAPI spec version: 1.0.0e
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing MoneyMovementApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class MoneyMovementApiTests
    {
        private MoneyMovementApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MoneyMovementApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MoneyMovementApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' MoneyMovementApi
            //Assert.IsInstanceOfType(typeof(MoneyMovementApi), instance, "instance is a MoneyMovementApi");
        }

        /// <summary>
        /// Test AccountProxyTransfers
        /// </summary>
        [Test]
        public void AccountProxyTransfersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AccountProxyTransfersRequest body = null;
            //string authorization = null;
            //string uuid = null;
            //string accept = null;
            //string clientId = null;
            //string contentType = null;
            //string clientDetails = null;
            //var response = instance.AccountProxyTransfers(body, authorization, uuid, accept, clientId, contentType, clientDetails);
            //Assert.IsInstanceOf<AccountProxyTransfersResponse> (response, "response is AccountProxyTransfersResponse");
        }
        /// <summary>
        /// Test AccountProxyTransfersConfirmation
        /// </summary>
        [Test]
        public void AccountProxyTransfersConfirmationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AccountProxyTransfersConfirmationRequest body = null;
            //string authorization = null;
            //string uuid = null;
            //string accept = null;
            //string clientId = null;
            //string contentType = null;
            //string clientDetails = null;
            //var response = instance.AccountProxyTransfersConfirmation(body, authorization, uuid, accept, clientId, contentType, clientDetails);
            //Assert.IsInstanceOf<AccountProxyTransfersConfirmationResponse> (response, "response is AccountProxyTransfersConfirmationResponse");
        }
        /// <summary>
        /// Test AccountProxyTransfersPreprocess
        /// </summary>
        [Test]
        public void AccountProxyTransfersPreprocessTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AccountProxyTransfersPreprocessRequest body = null;
            //string authorization = null;
            //string uuid = null;
            //string accept = null;
            //string clientId = null;
            //string contentType = null;
            //string clientDetails = null;
            //var response = instance.AccountProxyTransfersPreprocess(body, authorization, uuid, accept, clientId, contentType, clientDetails);
            //Assert.IsInstanceOf<AccountProxyTransfersPreprocessResponse> (response, "response is AccountProxyTransfersPreprocessResponse");
        }
        /// <summary>
        /// Test AccountProxyTransfersSourceAccountEligibility
        /// </summary>
        [Test]
        public void AccountProxyTransfersSourceAccountEligibilityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string uuid = null;
            //string accept = null;
            //string clientId = null;
            //string proxyPaymentType = null;
            //string clientDetails = null;
            //string nextStartIndex = null;
            //var response = instance.AccountProxyTransfersSourceAccountEligibility(authorization, uuid, accept, clientId, proxyPaymentType, clientDetails, nextStartIndex);
            //Assert.IsInstanceOf<AccountProxyTransfersSourceAccountEligibilityResponse> (response, "response is AccountProxyTransfersSourceAccountEligibilityResponse");
        }
        /// <summary>
        /// Test AdhocAccountProxyTransfersPreprocessWithAddPayee
        /// </summary>
        [Test]
        public void AdhocAccountProxyTransfersPreprocessWithAddPayeeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AdhocAccountProxyTransfersPreprocessWithAddPayeeRequest body = null;
            //string authorization = null;
            //string uuid = null;
            //string accept = null;
            //string clientId = null;
            //string contentType = null;
            //string clientDetails = null;
            //var response = instance.AdhocAccountProxyTransfersPreprocessWithAddPayee(body, authorization, uuid, accept, clientId, contentType, clientDetails);
            //Assert.IsInstanceOf<AdhocAccountProxyTransfersPreprocessWithAddPayeeResponse> (response, "response is AdhocAccountProxyTransfersPreprocessWithAddPayeeResponse");
        }
        /// <summary>
        /// Test BillDetailsInquiry
        /// </summary>
        [Test]
        public void BillDetailsInquiryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string uuid = null;
            //string accept = null;
            //string clientId = null;
            //string payeeId = null;
            //string clientDetails = null;
            //var response = instance.BillDetailsInquiry(authorization, uuid, accept, clientId, payeeId, clientDetails);
            //Assert.IsInstanceOf<BillDetailsInquiryResponse> (response, "response is BillDetailsInquiryResponse");
        }
        /// <summary>
        /// Test V1MoneyMovementDestinationCountriesGet
        /// </summary>
        [Test]
        public void V1MoneyMovementDestinationCountriesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string uuid = null;
            //string accept = null;
            //string clientId = null;
            //string clientDetails = null;
            //string nextStartIndex = null;
            //var response = instance.V1MoneyMovementDestinationCountriesGet(authorization, uuid, accept, clientId, clientDetails, nextStartIndex);
            //Assert.IsInstanceOf<DestinationListResponse> (response, "response is DestinationListResponse");
        }
        /// <summary>
        /// Test V1MoneyMovementExternalDomesticTransfersConfirmationPost
        /// </summary>
        [Test]
        public void V1MoneyMovementExternalDomesticTransfersConfirmationPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ExternalDomesticTransferConfirmationRequest body = null;
            //string authorization = null;
            //string uuid = null;
            //string accept = null;
            //string clientId = null;
            //string contentType = null;
            //string clientDetails = null;
            //var response = instance.V1MoneyMovementExternalDomesticTransfersConfirmationPost(body, authorization, uuid, accept, clientId, contentType, clientDetails);
            //Assert.IsInstanceOf<ExternalDomesticTransferConfirmationResponse> (response, "response is ExternalDomesticTransferConfirmationResponse");
        }
        /// <summary>
        /// Test V1MoneyMovementExternalDomesticTransfersPreprocessAdhocWithPayeeCreationPost
        /// </summary>
        [Test]
        public void V1MoneyMovementExternalDomesticTransfersPreprocessAdhocWithPayeeCreationPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AdhocExtDmstcTransferPreprocessWithAddPayeeRequest body = null;
            //string authorization = null;
            //string uuid = null;
            //string accept = null;
            //string clientId = null;
            //string contentType = null;
            //string clientDetails = null;
            //var response = instance.V1MoneyMovementExternalDomesticTransfersPreprocessAdhocWithPayeeCreationPost(body, authorization, uuid, accept, clientId, contentType, clientDetails);
            //Assert.IsInstanceOf<AdhocExtDmstcTransferPreprocessWithAddPayeeResponse> (response, "response is AdhocExtDmstcTransferPreprocessWithAddPayeeResponse");
        }
        /// <summary>
        /// Test V1MoneyMovementExternalDomesticTransfersPreprocessPost
        /// </summary>
        [Test]
        public void V1MoneyMovementExternalDomesticTransfersPreprocessPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PreprocessFundTransferRequest body = null;
            //string authorization = null;
            //string uuid = null;
            //string accept = null;
            //string clientId = null;
            //string contentType = null;
            //string clientDetails = null;
            //var response = instance.V1MoneyMovementExternalDomesticTransfersPreprocessPost(body, authorization, uuid, accept, clientId, contentType, clientDetails);
            //Assert.IsInstanceOf<PreprocessForFundTransferResponse> (response, "response is PreprocessForFundTransferResponse");
        }
        /// <summary>
        /// Test V1MoneyMovementInternalDomesticTransfersConfirmationPost
        /// </summary>
        [Test]
        public void V1MoneyMovementInternalDomesticTransfersConfirmationPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InternalDomesticTransferConfirmationRequest body = null;
            //string authorization = null;
            //string uuid = null;
            //string accept = null;
            //string clientId = null;
            //string contentType = null;
            //string clientDetails = null;
            //var response = instance.V1MoneyMovementInternalDomesticTransfersConfirmationPost(body, authorization, uuid, accept, clientId, contentType, clientDetails);
            //Assert.IsInstanceOf<InternalDomesticTransferConfirmationResponse> (response, "response is InternalDomesticTransferConfirmationResponse");
        }
        /// <summary>
        /// Test V1MoneyMovementInternalDomesticTransfersPreprocessAdhocWithPayeeCreationPost
        /// </summary>
        [Test]
        public void V1MoneyMovementInternalDomesticTransfersPreprocessAdhocWithPayeeCreationPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AdhocInternalDmstcTransferPreprocessWithAddPayeeRequest body = null;
            //string authorization = null;
            //string uuid = null;
            //string accept = null;
            //string clientId = null;
            //string contentType = null;
            //string clientDetails = null;
            //var response = instance.V1MoneyMovementInternalDomesticTransfersPreprocessAdhocWithPayeeCreationPost(body, authorization, uuid, accept, clientId, contentType, clientDetails);
            //Assert.IsInstanceOf<AdhocInternalDmstcTransferPreprocessWithAddPayeeResponse> (response, "response is AdhocInternalDmstcTransferPreprocessWithAddPayeeResponse");
        }
        /// <summary>
        /// Test V1MoneyMovementPayeesPayeeIdDetailsGet
        /// </summary>
        [Test]
        public void V1MoneyMovementPayeesPayeeIdDetailsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string uuid = null;
            //string accept = null;
            //string clientId = null;
            //string payeeId = null;
            //string clientDetails = null;
            //var response = instance.V1MoneyMovementPayeesPayeeIdDetailsGet(authorization, uuid, accept, clientId, payeeId, clientDetails);
            //Assert.IsInstanceOf<PayeeDetailsResponse> (response, "response is PayeeDetailsResponse");
        }
        /// <summary>
        /// Test V1MoneyMovementPersonalDomesticTransfersConfirmationPost
        /// </summary>
        [Test]
        public void V1MoneyMovementPersonalDomesticTransfersConfirmationPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PersonalDomesticTransferConfirmationRequest body = null;
            //string authorization = null;
            //string uuid = null;
            //string accept = null;
            //string clientId = null;
            //string contentType = null;
            //string clientDetails = null;
            //var response = instance.V1MoneyMovementPersonalDomesticTransfersConfirmationPost(body, authorization, uuid, accept, clientId, contentType, clientDetails);
            //Assert.IsInstanceOf<PersonalDomesticTransferConfirmationResponse> (response, "response is PersonalDomesticTransferConfirmationResponse");
        }
    }

}
