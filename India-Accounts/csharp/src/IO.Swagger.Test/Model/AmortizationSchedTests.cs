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
    ///  Class for testing AmortizationSched
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AmortizationSchedTests
    {
        // TODO uncomment below to declare an instance variable for AmortizationSched
        //private AmortizationSched instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of AmortizationSched
            //instance = new AmortizationSched();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AmortizationSched
        /// </summary>
        [Test]
        public void AmortizationSchedInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" AmortizationSched
            //Assert.IsInstanceOfType<AmortizationSched> (instance, "variable 'instance' is a AmortizationSched");
        }


        /// <summary>
        /// Test the property 'InstallmentNumber'
        /// </summary>
        [Test]
        public void InstallmentNumberTest()
        {
            // TODO unit test for the property 'InstallmentNumber'
        }
        /// <summary>
        /// Test the property 'InstallmentAmount'
        /// </summary>
        [Test]
        public void InstallmentAmountTest()
        {
            // TODO unit test for the property 'InstallmentAmount'
        }
        /// <summary>
        /// Test the property 'PrincipalAmount'
        /// </summary>
        [Test]
        public void PrincipalAmountTest()
        {
            // TODO unit test for the property 'PrincipalAmount'
        }
        /// <summary>
        /// Test the property 'InstallmentInterestAmount'
        /// </summary>
        [Test]
        public void InstallmentInterestAmountTest()
        {
            // TODO unit test for the property 'InstallmentInterestAmount'
        }

    }

}
