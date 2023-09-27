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
    ///  Class for testing PayeeBankDetailsAdhocCrossBorderWireTransferPreprocess
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class PayeeBankDetailsAdhocCrossBorderWireTransferPreprocessTests
    {
        // TODO uncomment below to declare an instance variable for PayeeBankDetailsAdhocCrossBorderWireTransferPreprocess
        //private PayeeBankDetailsAdhocCrossBorderWireTransferPreprocess instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of PayeeBankDetailsAdhocCrossBorderWireTransferPreprocess
            //instance = new PayeeBankDetailsAdhocCrossBorderWireTransferPreprocess();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PayeeBankDetailsAdhocCrossBorderWireTransferPreprocess
        /// </summary>
        [Test]
        public void PayeeBankDetailsAdhocCrossBorderWireTransferPreprocessInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" PayeeBankDetailsAdhocCrossBorderWireTransferPreprocess
            //Assert.IsInstanceOfType<PayeeBankDetailsAdhocCrossBorderWireTransferPreprocess> (instance, "variable 'instance' is a PayeeBankDetailsAdhocCrossBorderWireTransferPreprocess");
        }


        /// <summary>
        /// Test the property 'PayeeBankName'
        /// </summary>
        [Test]
        public void PayeeBankNameTest()
        {
            // TODO unit test for the property 'PayeeBankName'
        }
        /// <summary>
        /// Test the property 'GlobalBankCode'
        /// </summary>
        [Test]
        public void GlobalBankCodeTest()
        {
            // TODO unit test for the property 'GlobalBankCode'
        }
        /// <summary>
        /// Test the property 'PayeeBankAddress'
        /// </summary>
        [Test]
        public void PayeeBankAddressTest()
        {
            // TODO unit test for the property 'PayeeBankAddress'
        }

    }

}
