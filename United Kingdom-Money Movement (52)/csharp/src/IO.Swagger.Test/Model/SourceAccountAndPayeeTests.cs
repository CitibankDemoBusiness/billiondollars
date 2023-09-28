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
    ///  Class for testing SourceAccountAndPayee
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class SourceAccountAndPayeeTests
    {
        // TODO uncomment below to declare an instance variable for SourceAccountAndPayee
        //private SourceAccountAndPayee instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of SourceAccountAndPayee
            //instance = new SourceAccountAndPayee();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SourceAccountAndPayee
        /// </summary>
        [Test]
        public void SourceAccountAndPayeeInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" SourceAccountAndPayee
            //Assert.IsInstanceOfType<SourceAccountAndPayee> (instance, "variable 'instance' is a SourceAccountAndPayee");
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
        /// Test the property 'SourceAccounts'
        /// </summary>
        [Test]
        public void SourceAccountsTest()
        {
            // TODO unit test for the property 'SourceAccounts'
        }
        /// <summary>
        /// Test the property 'PayeeSourceAccountCombinations'
        /// </summary>
        [Test]
        public void PayeeSourceAccountCombinationsTest()
        {
            // TODO unit test for the property 'PayeeSourceAccountCombinations'
        }

    }

}