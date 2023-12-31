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
    ///  Class for testing CustomerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CustomerApiTests
    {
        private CustomerApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CustomerApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CustomerApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CustomerApi
            //Assert.IsInstanceOfType(typeof(CustomerApi), instance, "instance is a CustomerApi");
        }

        /// <summary>
        /// Test SufficiencyOfFunds
        /// </summary>
        [Test]
        public void SufficiencyOfFundsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string uuid = null;
            //string accept = null;
            //string clientId = null;
            //double? sufficiencyCheckAmount = null;
            //string accountId = null;
            //string currencyCode = null;
            //string clientDetails = null;
            //var response = instance.SufficiencyOfFunds(authorization, uuid, accept, clientId, sufficiencyCheckAmount, accountId, currencyCode, clientDetails);
            //Assert.IsInstanceOf<SufficiencyOfFundsResponse> (response, "response is SufficiencyOfFundsResponse");
        }
    }

}
