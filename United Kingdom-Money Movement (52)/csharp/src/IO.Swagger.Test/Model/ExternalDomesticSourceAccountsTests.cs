/* 
 * Money Movement
 *
 * <P>The Money Movement API allow you to move money from Citi customers account. Transfers can be made to predefined payees by customer and individuals not included in the payee list</P> The segment of API will allow to perform below category of transfers:<br><br><b>Personal Transfer-</b> Allowing customer to initiate the money transfers within customer�s own Citi accounts.<br><br><b>Internal transfer-</b> Allowing customer to initiate the money transfer from customer Citi own accounts to other Citi accounts locally.<br><br><b>External transfer-</b> Allowing customer to initiate the money transfer from customer Citi own accounts to other bank accounts locally.<br><br><b>Bill Payment-</b> Allowing customer to initiate the bill payment from customer Citi own accounts to billing organization.<br><br><b>Citi Global Transfer-</b> Allowing customer to initiate the money transfer from customer Citi own accounts to other Citi bank accounts across various Countries.<br><br><b>SEPA Transfer-</b> Allowing customer to initiate money transfer to other European bank accounts within the SEPA territory.<br><br><b>Cross border transfer-</b> Allowing customer to initiate money transfer from customer own account to cross border bank accounts.<br>
 *
 * OpenAPI spec version: 1.0.0e
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
    ///  Class for testing ExternalDomesticSourceAccounts
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ExternalDomesticSourceAccountsTests
    {
        // TODO uncomment below to declare an instance variable for ExternalDomesticSourceAccounts
        //private ExternalDomesticSourceAccounts instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ExternalDomesticSourceAccounts
            //instance = new ExternalDomesticSourceAccounts();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ExternalDomesticSourceAccounts
        /// </summary>
        [Test]
        public void ExternalDomesticSourceAccountsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ExternalDomesticSourceAccounts
            //Assert.IsInstanceOfType<ExternalDomesticSourceAccounts> (instance, "variable 'instance' is a ExternalDomesticSourceAccounts");
        }


        /// <summary>
        /// Test the property 'SourceAccountId'
        /// </summary>
        [Test]
        public void SourceAccountIdTest()
        {
            // TODO unit test for the property 'SourceAccountId'
        }
        /// <summary>
        /// Test the property 'DisplaySourceAccountNumber'
        /// </summary>
        [Test]
        public void DisplaySourceAccountNumberTest()
        {
            // TODO unit test for the property 'DisplaySourceAccountNumber'
        }
        /// <summary>
        /// Test the property 'SourceAccountCurrencyCode'
        /// </summary>
        [Test]
        public void SourceAccountCurrencyCodeTest()
        {
            // TODO unit test for the property 'SourceAccountCurrencyCode'
        }
        /// <summary>
        /// Test the property 'AccountGroup'
        /// </summary>
        [Test]
        public void AccountGroupTest()
        {
            // TODO unit test for the property 'AccountGroup'
        }
        /// <summary>
        /// Test the property 'AvailableBalance'
        /// </summary>
        [Test]
        public void AvailableBalanceTest()
        {
            // TODO unit test for the property 'AvailableBalance'
        }
        /// <summary>
        /// Test the property 'NextPaymentAmount'
        /// </summary>
        [Test]
        public void NextPaymentAmountTest()
        {
            // TODO unit test for the property 'NextPaymentAmount'
        }
        /// <summary>
        /// Test the property 'AccountNickName'
        /// </summary>
        [Test]
        public void AccountNickNameTest()
        {
            // TODO unit test for the property 'AccountNickName'
        }
        /// <summary>
        /// Test the property 'ProductName'
        /// </summary>
        [Test]
        public void ProductNameTest()
        {
            // TODO unit test for the property 'ProductName'
        }

    }

}
