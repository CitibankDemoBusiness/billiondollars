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
    ///  Class for testing AdhocAccountProxyTransfersPreprocessWithAddPayeeResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AdhocAccountProxyTransfersPreprocessWithAddPayeeResponseTests
    {
        // TODO uncomment below to declare an instance variable for AdhocAccountProxyTransfersPreprocessWithAddPayeeResponse
        //private AdhocAccountProxyTransfersPreprocessWithAddPayeeResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of AdhocAccountProxyTransfersPreprocessWithAddPayeeResponse
            //instance = new AdhocAccountProxyTransfersPreprocessWithAddPayeeResponse();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AdhocAccountProxyTransfersPreprocessWithAddPayeeResponse
        /// </summary>
        [Test]
        public void AdhocAccountProxyTransfersPreprocessWithAddPayeeResponseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" AdhocAccountProxyTransfersPreprocessWithAddPayeeResponse
            //Assert.IsInstanceOfType<AdhocAccountProxyTransfersPreprocessWithAddPayeeResponse> (instance, "variable 'instance' is a AdhocAccountProxyTransfersPreprocessWithAddPayeeResponse");
        }


        /// <summary>
        /// Test the property 'ControlFlowId'
        /// </summary>
        [Test]
        public void ControlFlowIdTest()
        {
            // TODO unit test for the property 'ControlFlowId'
        }
        /// <summary>
        /// Test the property 'DebitDetails'
        /// </summary>
        [Test]
        public void DebitDetailsTest()
        {
            // TODO unit test for the property 'DebitDetails'
        }
        /// <summary>
        /// Test the property 'CreditDetails'
        /// </summary>
        [Test]
        public void CreditDetailsTest()
        {
            // TODO unit test for the property 'CreditDetails'
        }
        /// <summary>
        /// Test the property 'ForeignExchangeRate'
        /// </summary>
        [Test]
        public void ForeignExchangeRateTest()
        {
            // TODO unit test for the property 'ForeignExchangeRate'
        }
        /// <summary>
        /// Test the property 'ForexType'
        /// </summary>
        [Test]
        public void ForexTypeTest()
        {
            // TODO unit test for the property 'ForexType'
        }
        /// <summary>
        /// Test the property 'ForexConversionIndicator'
        /// </summary>
        [Test]
        public void ForexConversionIndicatorTest()
        {
            // TODO unit test for the property 'ForexConversionIndicator'
        }
        /// <summary>
        /// Test the property 'TransactionFee'
        /// </summary>
        [Test]
        public void TransactionFeeTest()
        {
            // TODO unit test for the property 'TransactionFee'
        }
        /// <summary>
        /// Test the property 'FeeCurrencyCode'
        /// </summary>
        [Test]
        public void FeeCurrencyCodeTest()
        {
            // TODO unit test for the property 'FeeCurrencyCode'
        }
        /// <summary>
        /// Test the property 'LocalCurrencyTransactionFee'
        /// </summary>
        [Test]
        public void LocalCurrencyTransactionFeeTest()
        {
            // TODO unit test for the property 'LocalCurrencyTransactionFee'
        }
        /// <summary>
        /// Test the property 'LocalCurrencyCode'
        /// </summary>
        [Test]
        public void LocalCurrencyCodeTest()
        {
            // TODO unit test for the property 'LocalCurrencyCode'
        }
        /// <summary>
        /// Test the property 'TransactionLimitRange'
        /// </summary>
        [Test]
        public void TransactionLimitRangeTest()
        {
            // TODO unit test for the property 'TransactionLimitRange'
        }

    }

}
