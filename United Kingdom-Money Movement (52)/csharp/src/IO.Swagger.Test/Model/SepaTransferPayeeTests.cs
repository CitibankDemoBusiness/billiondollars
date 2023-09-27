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
    ///  Class for testing SepaTransferPayee
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class SepaTransferPayeeTests
    {
        // TODO uncomment below to declare an instance variable for SepaTransferPayee
        //private SepaTransferPayee instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of SepaTransferPayee
            //instance = new SepaTransferPayee();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SepaTransferPayee
        /// </summary>
        [Test]
        public void SepaTransferPayeeInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" SepaTransferPayee
            //Assert.IsInstanceOfType<SepaTransferPayee> (instance, "variable 'instance' is a SepaTransferPayee");
        }


        /// <summary>
        /// Test the property 'PayeeName'
        /// </summary>
        [Test]
        public void PayeeNameTest()
        {
            // TODO unit test for the property 'PayeeName'
        }
        /// <summary>
        /// Test the property 'PayeeNickName'
        /// </summary>
        [Test]
        public void PayeeNickNameTest()
        {
            // TODO unit test for the property 'PayeeNickName'
        }
        /// <summary>
        /// Test the property 'PayeeType'
        /// </summary>
        [Test]
        public void PayeeTypeTest()
        {
            // TODO unit test for the property 'PayeeType'
        }
        /// <summary>
        /// Test the property 'PayeeStatus'
        /// </summary>
        [Test]
        public void PayeeStatusTest()
        {
            // TODO unit test for the property 'PayeeStatus'
        }
        /// <summary>
        /// Test the property 'CurrencyCode'
        /// </summary>
        [Test]
        public void CurrencyCodeTest()
        {
            // TODO unit test for the property 'CurrencyCode'
        }
        /// <summary>
        /// Test the property 'PayeeCountryCode'
        /// </summary>
        [Test]
        public void PayeeCountryCodeTest()
        {
            // TODO unit test for the property 'PayeeCountryCode'
        }
        /// <summary>
        /// Test the property 'AccountId'
        /// </summary>
        [Test]
        public void AccountIdTest()
        {
            // TODO unit test for the property 'AccountId'
        }
        /// <summary>
        /// Test the property 'DisplayAccountNumber'
        /// </summary>
        [Test]
        public void DisplayAccountNumberTest()
        {
            // TODO unit test for the property 'DisplayAccountNumber'
        }
        /// <summary>
        /// Test the property 'BeneficiaryBankName'
        /// </summary>
        [Test]
        public void BeneficiaryBankNameTest()
        {
            // TODO unit test for the property 'BeneficiaryBankName'
        }
        /// <summary>
        /// Test the property 'BeneficiaryBankCode'
        /// </summary>
        [Test]
        public void BeneficiaryBankCodeTest()
        {
            // TODO unit test for the property 'BeneficiaryBankCode'
        }
        /// <summary>
        /// Test the property 'PayeeNotes'
        /// </summary>
        [Test]
        public void PayeeNotesTest()
        {
            // TODO unit test for the property 'PayeeNotes'
        }

    }

}
