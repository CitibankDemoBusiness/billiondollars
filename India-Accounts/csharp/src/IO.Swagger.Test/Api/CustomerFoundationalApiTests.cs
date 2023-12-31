/* 
 * Accounts
 *
 * The Accounts API allows you to retrieve account and transaction data for Citi Customers who have authorized your app. In most cases, you'll want to request a summary of all accounts first, which will return basic account information and accountIds. Once you have this information, you can request additional account details and/or transactions.
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
    ///  Class for testing CustomerFoundationalApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CustomerFoundationalApiTests
    {
        private CustomerFoundationalApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CustomerFoundationalApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CustomerFoundationalApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CustomerFoundationalApi
            //Assert.IsInstanceOfType(typeof(CustomerFoundationalApi), instance, "instance is a CustomerFoundationalApi");
        }

        /// <summary>
        /// Test EvaluateCustomerEligibilityAssessmentCheckPreLogin
        /// </summary>
        [Test]
        public void EvaluateCustomerEligibilityAssessmentCheckPreLoginTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string uuid = null;
            //string accept = null;
            //string clientId = null;
            //string offerId = null;
            //string clientDetails = null;
            //decimal? loanAmount = null;
            //var response = instance.EvaluateCustomerEligibilityAssessmentCheckPreLogin(authorization, uuid, accept, clientId, offerId, clientDetails, loanAmount);
            //Assert.IsInstanceOf<EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse> (response, "response is EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse");
        }
    }

}
