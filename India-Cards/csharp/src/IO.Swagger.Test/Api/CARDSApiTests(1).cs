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
    ///  Class for testing CARDSApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CARDSApiTests
    {
        private CARDSApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CARDSApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CARDSApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CARDSApi
            //Assert.IsInstanceOfType(typeof(CARDSApi), instance, "instance is a CARDSApi");
        }

        /// <summary>
        /// Test NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction
        /// </summary>
        [Test]
        public void NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest body = null;
            //string authorization = null;
            //string uuid = null;
            //string accept = null;
            //string contentType = null;
            //string clientId = null;
            //string clientDetails = null;
            //string acceptLanguage = null;
            //string xJwsSignature = null;
            //instance.NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction(body, authorization, uuid, accept, contentType, clientId, clientDetails, acceptLanguage, xJwsSignature);
            
        }
    }

}
