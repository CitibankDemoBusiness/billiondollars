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
    ///  Class for testing PaymentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PaymentsApiTests
    {
        private PaymentsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PaymentsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PaymentsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PaymentsApi
            //Assert.IsInstanceOfType(typeof(PaymentsApi), instance, "instance is a PaymentsApi");
        }

        /// <summary>
        /// Test ExecutePaymentInitiationTransactionMultipleTransfersAsync
        /// </summary>
        [Test]
        public void ExecutePaymentInitiationTransactionMultipleTransfersAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ExecutePaymentInitiationTransactionMultipleTransfersAsyncRequest body = null;
            //string authorization = null;
            //string uuid = null;
            //string accept = null;
            //string clientId = null;
            //string contentType = null;
            //string clientDetails = null;
            //var response = instance.ExecutePaymentInitiationTransactionMultipleTransfersAsync(body, authorization, uuid, accept, clientId, contentType, clientDetails);
            //Assert.IsInstanceOf<ExecutePaymentInitiationTransactionMultipleTransfersAsyncResponse> (response, "response is ExecutePaymentInitiationTransactionMultipleTransfersAsyncResponse");
        }
        /// <summary>
        /// Test ExecutePaymentInitiationTransactionMultipleTransfersConfirmationAsync
        /// </summary>
        [Test]
        public void ExecutePaymentInitiationTransactionMultipleTransfersConfirmationAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ExecutePaymentInitiationTransactionMultipleTransfersConfirmationAsyncRequest body = null;
            //string authorization = null;
            //string uuid = null;
            //string accept = null;
            //string clientId = null;
            //string contentType = null;
            //string clientDetails = null;
            //var response = instance.ExecutePaymentInitiationTransactionMultipleTransfersConfirmationAsync(body, authorization, uuid, accept, clientId, contentType, clientDetails);
            //Assert.IsInstanceOf<ExecutePaymentInitiationTransactionMultipleTransfersConfirmationAsyncResponse> (response, "response is ExecutePaymentInitiationTransactionMultipleTransfersConfirmationAsyncResponse");
        }
        /// <summary>
        /// Test RetrievePaymentInitiationTransactionRepeatingPayments
        /// </summary>
        [Test]
        public void RetrievePaymentInitiationTransactionRepeatingPaymentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string uuid = null;
            //string accept = null;
            //string clientId = null;
            //string paymentType = null;
            //string nextStartIndex = null;
            //string clientDetails = null;
            //var response = instance.RetrievePaymentInitiationTransactionRepeatingPayments(authorization, uuid, accept, clientId, paymentType, nextStartIndex, clientDetails);
            //Assert.IsInstanceOf<RetrievePaymentInitiationTransactionRepeatingPaymentsResponse> (response, "response is RetrievePaymentInitiationTransactionRepeatingPaymentsResponse");
        }
        /// <summary>
        /// Test TerminatePaymentInitiationTransactionRepeatingPayments
        /// </summary>
        [Test]
        public void TerminatePaymentInitiationTransactionRepeatingPaymentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string uuid = null;
            //string accept = null;
            //string clientId = null;
            //string contentType = null;
            //string accountId = null;
            //string transactionReferenceId = null;
            //string clientDetails = null;
            //instance.TerminatePaymentInitiationTransactionRepeatingPayments(authorization, uuid, accept, clientId, contentType, accountId, transactionReferenceId, clientDetails);
            
        }
        /// <summary>
        /// Test UpdatePaymentInitiationTransactionRepeatingPayments
        /// </summary>
        [Test]
        public void UpdatePaymentInitiationTransactionRepeatingPaymentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdatePaymentInitiationTransactionRepeatingPaymentsRequest body = null;
            //string authorization = null;
            //string uuid = null;
            //string accept = null;
            //string clientId = null;
            //string contentType = null;
            //string clientDetails = null;
            //instance.UpdatePaymentInitiationTransactionRepeatingPayments(body, authorization, uuid, accept, clientId, contentType, clientDetails);
            
        }
        /// <summary>
        /// Test UpdatePaymentInitiationTransactionRepeatingPaymentsConfirmation
        /// </summary>
        [Test]
        public void UpdatePaymentInitiationTransactionRepeatingPaymentsConfirmationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdatePaymentInitiationTransactionRepeatingPaymentsConfirmationRequest body = null;
            //string authorization = null;
            //string uuid = null;
            //string accept = null;
            //string clientId = null;
            //string contentType = null;
            //string clientDetails = null;
            //var response = instance.UpdatePaymentInitiationTransactionRepeatingPaymentsConfirmation(body, authorization, uuid, accept, clientId, contentType, clientDetails);
            //Assert.IsInstanceOf<UpdatePaymentInitiationTransactionRepeatingPaymentsConfirmationResponse> (response, "response is UpdatePaymentInitiationTransactionRepeatingPaymentsConfirmationResponse");
        }
        /// <summary>
        /// Test UpdatePaymentInitiationTransactionRepeatingPaymentsPreprocess
        /// </summary>
        [Test]
        public void UpdatePaymentInitiationTransactionRepeatingPaymentsPreprocessTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdatePaymentInitiationTransactionRepeatingPaymentsPreprocessRequest body = null;
            //string authorization = null;
            //string uuid = null;
            //string accept = null;
            //string clientId = null;
            //string contentType = null;
            //string clientDetails = null;
            //var response = instance.UpdatePaymentInitiationTransactionRepeatingPaymentsPreprocess(body, authorization, uuid, accept, clientId, contentType, clientDetails);
            //Assert.IsInstanceOf<UpdatePaymentInitiationTransactionRepeatingPaymentsPreprocessResponse> (response, "response is UpdatePaymentInitiationTransactionRepeatingPaymentsPreprocessResponse");
        }
    }

}