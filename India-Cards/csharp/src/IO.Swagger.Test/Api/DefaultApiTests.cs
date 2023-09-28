/* 
 * Cards
 *
 * The Cards API allows you to perform actions on the actual credit cards of the Citi Customer who authorized your app.
 *
 * OpenAPI spec version: 1.0.0
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
    ///  Class for testing DefaultApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DefaultApiTests
    {
        private DefaultApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DefaultApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DefaultApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DefaultApi
            //Assert.IsInstanceOfType(typeof(DefaultApi), instance, "instance is a DefaultApi");
        }

        /// <summary>
        /// Test V1CardsCardIdActivationsCardActivationCodePut
        /// </summary>
        [Test]
        public void V1CardsCardIdActivationsCardActivationCodePutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uuid = null;
            //string clientId = null;
            //string authorization = null;
            //string cardId = null;
            //string cardActivationCode = null;
            //CardUsageRequest body = null;
            //instance.V1CardsCardIdActivationsCardActivationCodePut(uuid, clientId, authorization, cardId, cardActivationCode, body);
            
        }
        /// <summary>
        /// Test V1CardsCardIdLostStolenPut
        /// </summary>
        [Test]
        public void V1CardsCardIdLostStolenPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ReportLostStolenCardRequest body = null;
            //string uuid = null;
            //string accept = null;
            //string clientId = null;
            //string contentType = null;
            //string authorization = null;
            //string cardId = null;
            //var response = instance.V1CardsCardIdLostStolenPut(body, uuid, accept, clientId, contentType, authorization, cardId);
            //Assert.IsInstanceOf<ReportLostStolenCardResponse> (response, "response is ReportLostStolenCardResponse");
        }
        /// <summary>
        /// Test V1CardsCardIdOverseasUsagePut
        /// </summary>
        [Test]
        public void V1CardsCardIdOverseasUsagePutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OverseasCardUsageRequest body = null;
            //string uuid = null;
            //string accept = null;
            //string clientId = null;
            //string contentType = null;
            //string authorization = null;
            //string cardId = null;
            //instance.V1CardsCardIdOverseasUsagePut(body, uuid, accept, clientId, contentType, authorization, cardId);
            
        }
        /// <summary>
        /// Test V1CardsGet
        /// </summary>
        [Test]
        public void V1CardsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string clientId = null;
            //string uuid = null;
            //string accept = null;
            //string cardFunction = null;
            //var response = instance.V1CardsGet(authorization, clientId, uuid, accept, cardFunction);
            //Assert.IsInstanceOf<CardListingResponse> (response, "response is CardListingResponse");
        }
        /// <summary>
        /// Test V1CreditCardsCardIdSupplementaryApplicationsPost
        /// </summary>
        [Test]
        public void V1CreditCardsCardIdSupplementaryApplicationsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string uuid = null;
            //string clientId = null;
            //string cardId = null;
            //SupplementaryCardRequest body = null;
            //var response = instance.V1CreditCardsCardIdSupplementaryApplicationsPost(authorization, uuid, clientId, cardId, body);
            //Assert.IsInstanceOf<SupplementaryCardResponse> (response, "response is SupplementaryCardResponse");
        }
        /// <summary>
        /// Test V1CreditCardsCreditLimitsPost
        /// </summary>
        [Test]
        public void V1CreditCardsCreditLimitsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreditLimitIncreaseRequest body = null;
            //string uuid = null;
            //string accept = null;
            //string clientId = null;
            //string contentType = null;
            //string authorization = null;
            //var response = instance.V1CreditCardsCreditLimitsPost(body, uuid, accept, clientId, contentType, authorization);
            //Assert.IsInstanceOf<CreditLimitIncreaseResponse> (response, "response is CreditLimitIncreaseResponse");
        }
    }

}