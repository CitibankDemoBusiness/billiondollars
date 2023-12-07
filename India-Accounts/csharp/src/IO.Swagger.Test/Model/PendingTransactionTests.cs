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
    ///  Class for testing PendingTransaction
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class PendingTransactionTests
    {
        // TODO uncomment below to declare an instance variable for PendingTransaction
        //private PendingTransaction instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of PendingTransaction
            //instance = new PendingTransaction();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PendingTransaction
        /// </summary>
        [Test]
        public void PendingTransactionInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" PendingTransaction
            //Assert.IsInstanceOfType<PendingTransaction> (instance, "variable 'instance' is a PendingTransaction");
        }


        /// <summary>
        /// Test the property 'TransactionDate'
        /// </summary>
        [Test]
        public void TransactionDateTest()
        {
            // TODO unit test for the property 'TransactionDate'
        }
        /// <summary>
        /// Test the property 'TransactionDescription'
        /// </summary>
        [Test]
        public void TransactionDescriptionTest()
        {
            // TODO unit test for the property 'TransactionDescription'
        }
        /// <summary>
        /// Test the property 'TransactionAuthorizationCode'
        /// </summary>
        [Test]
        public void TransactionAuthorizationCodeTest()
        {
            // TODO unit test for the property 'TransactionAuthorizationCode'
        }
        /// <summary>
        /// Test the property 'TransactionReferenceId'
        /// </summary>
        [Test]
        public void TransactionReferenceIdTest()
        {
            // TODO unit test for the property 'TransactionReferenceId'
        }
        /// <summary>
        /// Test the property 'MerchantName'
        /// </summary>
        [Test]
        public void MerchantNameTest()
        {
            // TODO unit test for the property 'MerchantName'
        }
        /// <summary>
        /// Test the property 'TransactionAmount'
        /// </summary>
        [Test]
        public void TransactionAmountTest()
        {
            // TODO unit test for the property 'TransactionAmount'
        }

    }

}
