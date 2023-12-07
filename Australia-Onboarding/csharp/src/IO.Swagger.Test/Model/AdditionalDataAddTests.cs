/* 
 * Onboarding
 *
 * The Onboarding API allows you to initiate the basic account opening process for new customers. The resources allow you to present eligible products, send applications for screening and submit a new application for one or more products. The resources also allow you to submit supporting documents. Application status can be checked at any point in the process, with decisioning happening in real time.
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
    ///  Class for testing AdditionalDataAdd
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AdditionalDataAddTests
    {
        // TODO uncomment below to declare an instance variable for AdditionalDataAdd
        //private AdditionalDataAdd instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of AdditionalDataAdd
            //instance = new AdditionalDataAdd();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AdditionalDataAdd
        /// </summary>
        [Test]
        public void AdditionalDataAddInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" AdditionalDataAdd
            //Assert.IsInstanceOfType<AdditionalDataAdd> (instance, "variable 'instance' is a AdditionalDataAdd");
        }


        /// <summary>
        /// Test the property 'AccountFundSource'
        /// </summary>
        [Test]
        public void AccountFundSourceTest()
        {
            // TODO unit test for the property 'AccountFundSource'
        }
        /// <summary>
        /// Test the property 'NumberOfDependents'
        /// </summary>
        [Test]
        public void NumberOfDependentsTest()
        {
            // TODO unit test for the property 'NumberOfDependents'
        }
        /// <summary>
        /// Test the property 'StaffIndicator'
        /// </summary>
        [Test]
        public void StaffIndicatorTest()
        {
            // TODO unit test for the property 'StaffIndicator'
        }
        /// <summary>
        /// Test the property 'BusinessNature'
        /// </summary>
        [Test]
        public void BusinessNatureTest()
        {
            // TODO unit test for the property 'BusinessNature'
        }
        /// <summary>
        /// Test the property 'EmergencyContactName'
        /// </summary>
        [Test]
        public void EmergencyContactNameTest()
        {
            // TODO unit test for the property 'EmergencyContactName'
        }
        /// <summary>
        /// Test the property 'EmergencyContactSurname'
        /// </summary>
        [Test]
        public void EmergencyContactSurnameTest()
        {
            // TODO unit test for the property 'EmergencyContactSurname'
        }
        /// <summary>
        /// Test the property 'EmergencyContactRelationship'
        /// </summary>
        [Test]
        public void EmergencyContactRelationshipTest()
        {
            // TODO unit test for the property 'EmergencyContactRelationship'
        }
        /// <summary>
        /// Test the property 'EmergencyContactPhoneNumber'
        /// </summary>
        [Test]
        public void EmergencyContactPhoneNumberTest()
        {
            // TODO unit test for the property 'EmergencyContactPhoneNumber'
        }
        /// <summary>
        /// Test the property 'OverLimitConsentFlag'
        /// </summary>
        [Test]
        public void OverLimitConsentFlagTest()
        {
            // TODO unit test for the property 'OverLimitConsentFlag'
        }
        /// <summary>
        /// Test the property 'CountrySpecificGroup'
        /// </summary>
        [Test]
        public void CountrySpecificGroupTest()
        {
            // TODO unit test for the property 'CountrySpecificGroup'
        }
        /// <summary>
        /// Test the property 'PrimaryBankDetails'
        /// </summary>
        [Test]
        public void PrimaryBankDetailsTest()
        {
            // TODO unit test for the property 'PrimaryBankDetails'
        }
        /// <summary>
        /// Test the property 'ReferralGivenName'
        /// </summary>
        [Test]
        public void ReferralGivenNameTest()
        {
            // TODO unit test for the property 'ReferralGivenName'
        }
        /// <summary>
        /// Test the property 'ReferralSurname'
        /// </summary>
        [Test]
        public void ReferralSurnameTest()
        {
            // TODO unit test for the property 'ReferralSurname'
        }
        /// <summary>
        /// Test the property 'ReferralCode'
        /// </summary>
        [Test]
        public void ReferralCodeTest()
        {
            // TODO unit test for the property 'ReferralCode'
        }
        /// <summary>
        /// Test the property 'MediaId'
        /// </summary>
        [Test]
        public void MediaIdTest()
        {
            // TODO unit test for the property 'MediaId'
        }
        /// <summary>
        /// Test the property 'IntroducerId'
        /// </summary>
        [Test]
        public void IntroducerIdTest()
        {
            // TODO unit test for the property 'IntroducerId'
        }
        /// <summary>
        /// Test the property 'RelatedToCitiEmployeeFlag'
        /// </summary>
        [Test]
        public void RelatedToCitiEmployeeFlagTest()
        {
            // TODO unit test for the property 'RelatedToCitiEmployeeFlag'
        }
        /// <summary>
        /// Test the property 'RelatedCitiEmployeeName'
        /// </summary>
        [Test]
        public void RelatedCitiEmployeeNameTest()
        {
            // TODO unit test for the property 'RelatedCitiEmployeeName'
        }
        /// <summary>
        /// Test the property 'RelatedCitiEmployeeDepartment'
        /// </summary>
        [Test]
        public void RelatedCitiEmployeeDepartmentTest()
        {
            // TODO unit test for the property 'RelatedCitiEmployeeDepartment'
        }
        /// <summary>
        /// Test the property 'CreditCardUsagePurpose'
        /// </summary>
        [Test]
        public void CreditCardUsagePurposeTest()
        {
            // TODO unit test for the property 'CreditCardUsagePurpose'
        }
        /// <summary>
        /// Test the property 'CashPinFlag'
        /// </summary>
        [Test]
        public void CashPinFlagTest()
        {
            // TODO unit test for the property 'CashPinFlag'
        }
        /// <summary>
        /// Test the property 'ReferralTracking'
        /// </summary>
        [Test]
        public void ReferralTrackingTest()
        {
            // TODO unit test for the property 'ReferralTracking'
        }
        /// <summary>
        /// Test the property 'UtilityBillDetails'
        /// </summary>
        [Test]
        public void UtilityBillDetailsTest()
        {
            // TODO unit test for the property 'UtilityBillDetails'
        }
        /// <summary>
        /// Test the property 'FeeCode'
        /// </summary>
        [Test]
        public void FeeCodeTest()
        {
            // TODO unit test for the property 'FeeCode'
        }
        /// <summary>
        /// Test the property 'BillingCycleDay'
        /// </summary>
        [Test]
        public void BillingCycleDayTest()
        {
            // TODO unit test for the property 'BillingCycleDay'
        }
        /// <summary>
        /// Test the property 'ApplicationReferenceId'
        /// </summary>
        [Test]
        public void ApplicationReferenceIdTest()
        {
            // TODO unit test for the property 'ApplicationReferenceId'
        }
        /// <summary>
        /// Test the property 'CustomerSegment'
        /// </summary>
        [Test]
        public void CustomerSegmentTest()
        {
            // TODO unit test for the property 'CustomerSegment'
        }
        /// <summary>
        /// Test the property 'PrintingSerialNumber'
        /// </summary>
        [Test]
        public void PrintingSerialNumberTest()
        {
            // TODO unit test for the property 'PrintingSerialNumber'
        }
        /// <summary>
        /// Test the property 'AdditionalInformation'
        /// </summary>
        [Test]
        public void AdditionalInformationTest()
        {
            // TODO unit test for the property 'AdditionalInformation'
        }
        /// <summary>
        /// Test the property 'TradeReferenceDetails'
        /// </summary>
        [Test]
        public void TradeReferenceDetailsTest()
        {
            // TODO unit test for the property 'TradeReferenceDetails'
        }
        /// <summary>
        /// Test the property 'BureauSessionId_'
        /// </summary>
        [Test]
        public void BureauSessionId_Test()
        {
            // TODO unit test for the property 'BureauSessionId_'
        }

    }

}
