/* 
 * Cards
 *
 * The Cards API allows you to perform actions on the actual credit cards of the Citi Customer who authorized your app.
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
    ///  Class for testing ChangeAtmPinRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ChangeAtmPinRequestTests
    {
        // TODO uncomment below to declare an instance variable for ChangeAtmPinRequest
        //private ChangeAtmPinRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ChangeAtmPinRequest
            //instance = new ChangeAtmPinRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ChangeAtmPinRequest
        /// </summary>
        [Test]
        public void ChangeAtmPinRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ChangeAtmPinRequest
            //Assert.IsInstanceOfType<ChangeAtmPinRequest> (instance, "variable 'instance' is a ChangeAtmPinRequest");
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
        /// Test the property 'CardId'
        /// </summary>
        [Test]
        public void CardIdTest()
        {
            // TODO unit test for the property 'CardId'
        }
        /// <summary>
        /// Test the property 'NewPin'
        /// </summary>
        [Test]
        public void NewPinTest()
        {
            // TODO unit test for the property 'NewPin'
        }

    }

}