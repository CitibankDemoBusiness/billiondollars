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
    ///  Class for testing AccountInfo
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AccountInfoTests
    {
        // TODO uncomment below to declare an instance variable for AccountInfo
        //private AccountInfo instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of AccountInfo
            //instance = new AccountInfo();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AccountInfo
        /// </summary>
        [Test]
        public void AccountInfoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" AccountInfo
            //Assert.IsInstanceOfType<AccountInfo> (instance, "variable 'instance' is a AccountInfo");
        }


        /// <summary>
        /// Test the property 'AccountId'
        /// </summary>
        [Test]
        public void AccountIdTest()
        {
            // TODO unit test for the property 'AccountId'
        }

    }

}
