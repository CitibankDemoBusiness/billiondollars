/* 
 * Onboarding
 *
 * The Onboarding API allows you to initiate the basic account opening process for new customers. The resources allow you to present eligible products, send applications for screening and submit a new application for one or more products. The resources also allow you to submit supporting documents. Application status can be checked at any point in the process, with decisioning happening in real time.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing ApplicationStatusResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ApplicationStatusResponseTests
    {
        // TODO uncomment below to declare an instance variable for ApplicationStatusResponse
        //private ApplicationStatusResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ApplicationStatusResponse
            //instance = new ApplicationStatusResponse();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ApplicationStatusResponse
        /// </summary>
        [Test]
        public void ApplicationStatusResponseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ApplicationStatusResponse
            //Assert.IsInstanceOfType<ApplicationStatusResponse> (instance, "variable 'instance' is a ApplicationStatusResponse");
        }


        /// <summary>
        /// Test the property 'ApplicationStage'
        /// </summary>
        [Test]
        public void ApplicationStageTest()
        {
            // TODO unit test for the property 'ApplicationStage'
        }
        /// <summary>
        /// Test the property 'IpaExpiryDate'
        /// </summary>
        [Test]
        public void IpaExpiryDateTest()
        {
            // TODO unit test for the property 'IpaExpiryDate'
        }
        /// <summary>
        /// Test the property 'RequestedProductDecision'
        /// </summary>
        [Test]
        public void RequestedProductDecisionTest()
        {
            // TODO unit test for the property 'RequestedProductDecision'
        }
        /// <summary>
        /// Test the property 'CounterOffers'
        /// </summary>
        [Test]
        public void CounterOffersTest()
        {
            // TODO unit test for the property 'CounterOffers'
        }
        /// <summary>
        /// Test the property 'CrossSellOffers'
        /// </summary>
        [Test]
        public void CrossSellOffersTest()
        {
            // TODO unit test for the property 'CrossSellOffers'
        }

    }

}
