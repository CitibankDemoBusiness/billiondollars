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
    ///  Class for testing DisbursementOptions
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class DisbursementOptionsTests
    {
        // TODO uncomment below to declare an instance variable for DisbursementOptions
        //private DisbursementOptions instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of DisbursementOptions
            //instance = new DisbursementOptions();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DisbursementOptions
        /// </summary>
        [Test]
        public void DisbursementOptionsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" DisbursementOptions
            //Assert.IsInstanceOfType<DisbursementOptions> (instance, "variable 'instance' is a DisbursementOptions");
        }


        /// <summary>
        /// Test the property 'DisbursementOption'
        /// </summary>
        [Test]
        public void DisbursementOptionTest()
        {
            // TODO unit test for the property 'DisbursementOption'
        }
        /// <summary>
        /// Test the property 'ExternalBankDetails'
        /// </summary>
        [Test]
        public void ExternalBankDetailsTest()
        {
            // TODO unit test for the property 'ExternalBankDetails'
        }
        /// <summary>
        /// Test the property 'PersonalAccountDetails'
        /// </summary>
        [Test]
        public void PersonalAccountDetailsTest()
        {
            // TODO unit test for the property 'PersonalAccountDetails'
        }
        /// <summary>
        /// Test the property 'PayeeAccountDetails'
        /// </summary>
        [Test]
        public void PayeeAccountDetailsTest()
        {
            // TODO unit test for the property 'PayeeAccountDetails'
        }

    }

}
