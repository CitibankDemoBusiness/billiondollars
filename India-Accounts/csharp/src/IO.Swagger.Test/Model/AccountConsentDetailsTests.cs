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
    ///  Class for testing AccountConsentDetails
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AccountConsentDetailsTests
    {
        // TODO uncomment below to declare an instance variable for AccountConsentDetails
        //private AccountConsentDetails instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of AccountConsentDetails
            //instance = new AccountConsentDetails();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AccountConsentDetails
        /// </summary>
        [Test]
        public void AccountConsentDetailsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" AccountConsentDetails
            //Assert.IsInstanceOfType<AccountConsentDetails> (instance, "variable 'instance' is a AccountConsentDetails");
        }


        /// <summary>
        /// Test the property 'ConsentType'
        /// </summary>
        [Test]
        public void ConsentTypeTest()
        {
            // TODO unit test for the property 'ConsentType'
        }
        /// <summary>
        /// Test the property 'ConsentGivenFlag'
        /// </summary>
        [Test]
        public void ConsentGivenFlagTest()
        {
            // TODO unit test for the property 'ConsentGivenFlag'
        }
        /// <summary>
        /// Test the property 'ConsentUpdateDate'
        /// </summary>
        [Test]
        public void ConsentUpdateDateTest()
        {
            // TODO unit test for the property 'ConsentUpdateDate'
        }
        /// <summary>
        /// Test the property 'CardId'
        /// </summary>
        [Test]
        public void CardIdTest()
        {
            // TODO unit test for the property 'CardId'
        }

    }

}
