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
    ///  Class for testing ExternalDomesticDetails
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ExternalDomesticDetailsTests
    {
        // TODO uncomment below to declare an instance variable for ExternalDomesticDetails
        //private ExternalDomesticDetails instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ExternalDomesticDetails
            //instance = new ExternalDomesticDetails();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ExternalDomesticDetails
        /// </summary>
        [Test]
        public void ExternalDomesticDetailsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ExternalDomesticDetails
            //Assert.IsInstanceOfType<ExternalDomesticDetails> (instance, "variable 'instance' is a ExternalDomesticDetails");
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
        /// Test the property 'TransferCurrencyIndicator'
        /// </summary>
        [Test]
        public void TransferCurrencyIndicatorTest()
        {
            // TODO unit test for the property 'TransferCurrencyIndicator'
        }
        /// <summary>
        /// Test the property 'ChargeBearer'
        /// </summary>
        [Test]
        public void ChargeBearerTest()
        {
            // TODO unit test for the property 'ChargeBearer'
        }
        /// <summary>
        /// Test the property 'PaymentMethod'
        /// </summary>
        [Test]
        public void PaymentMethodTest()
        {
            // TODO unit test for the property 'PaymentMethod'
        }
        /// <summary>
        /// Test the property 'TransactionAmount'
        /// </summary>
        [Test]
        public void TransactionAmountTest()
        {
            // TODO unit test for the property 'TransactionAmount'
        }
        /// <summary>
        /// Test the property 'PaymentType'
        /// </summary>
        [Test]
        public void PaymentTypeTest()
        {
            // TODO unit test for the property 'PaymentType'
        }
        /// <summary>
        /// Test the property 'ForeignExchangeReferenceNumber'
        /// </summary>
        [Test]
        public void ForeignExchangeReferenceNumberTest()
        {
            // TODO unit test for the property 'ForeignExchangeReferenceNumber'
        }
        /// <summary>
        /// Test the property 'PaymentScheduleType'
        /// </summary>
        [Test]
        public void PaymentScheduleTypeTest()
        {
            // TODO unit test for the property 'PaymentScheduleType'
        }
        /// <summary>
        /// Test the property 'PayeeAccountDetails'
        /// </summary>
        [Test]
        public void PayeeAccountDetailsTest()
        {
            // TODO unit test for the property 'PayeeAccountDetails'
        }
        /// <summary>
        /// Test the property 'Remarks'
        /// </summary>
        [Test]
        public void RemarksTest()
        {
            // TODO unit test for the property 'Remarks'
        }
        /// <summary>
        /// Test the property 'TransferPurpose'
        /// </summary>
        [Test]
        public void TransferPurposeTest()
        {
            // TODO unit test for the property 'TransferPurpose'
        }

    }

}
