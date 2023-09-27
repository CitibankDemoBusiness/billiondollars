/* 
 * Accounts
 *
 * The Accounts API allows you to retrieve account and transaction data for Citi Customers who have authorized your app. In most cases, you'll want to request a summary of all accounts first, which will return basic account information and accountIds. Once you have this information, you can request additional account details and/or transactions.
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
    ///  Class for testing LoanEligibilityCheckResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class LoanEligibilityCheckResponseTests
    {
        // TODO uncomment below to declare an instance variable for LoanEligibilityCheckResponse
        //private LoanEligibilityCheckResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of LoanEligibilityCheckResponse
            //instance = new LoanEligibilityCheckResponse();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LoanEligibilityCheckResponse
        /// </summary>
        [Test]
        public void LoanEligibilityCheckResponseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" LoanEligibilityCheckResponse
            //Assert.IsInstanceOfType<LoanEligibilityCheckResponse> (instance, "variable 'instance' is a LoanEligibilityCheckResponse");
        }


        /// <summary>
        /// Test the property 'LoanEligibilityDetails'
        /// </summary>
        [Test]
        public void LoanEligibilityDetailsTest()
        {
            // TODO unit test for the property 'LoanEligibilityDetails'
        }

    }

}
