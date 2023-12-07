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
    ///  Class for testing RewardsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class RewardsApiTests
    {
        private RewardsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RewardsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RewardsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' RewardsApi
            //Assert.IsInstanceOfType(typeof(RewardsApi), instance, "instance is a RewardsApi");
        }

        /// <summary>
        /// Test V1CreditCardsRewardsPointBalanceSearchPost
        /// </summary>
        [Test]
        public void V1CreditCardsRewardsPointBalanceSearchPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RewardsInquiryRequest body = null;
            //string authorization = null;
            //string uuid = null;
            //string accept = null;
            //string clientId = null;
            //string contentType = null;
            //string clientDetails = null;
            //var response = instance.V1CreditCardsRewardsPointBalanceSearchPost(body, authorization, uuid, accept, clientId, contentType, clientDetails);
            //Assert.IsInstanceOf<RewardsInquiryResponse> (response, "response is RewardsInquiryResponse");
        }
    }

}
