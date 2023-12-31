/* 
 * Onboarding
 *
 * The Onboarding API allows you to initiate the basic account opening process for new customers. The resources allow you to present eligible products, send applications for screening and submit a new application for one or more products. The resources also allow you to submit supporting documents. Application status can be checked at any point in the process, with decisioning happening in real time.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// ECMAdditionalDataUpdate
    /// </summary>
    [DataContract]
        public partial class ECMAdditionalDataUpdate :  IEquatable<ECMAdditionalDataUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ECMAdditionalDataUpdate" /> class.
        /// </summary>
        /// <param name="cashPinFlag">Indicates whether the customer wants a separate cash PIN..</param>
        /// <param name="utilityBillDetails">utilityBillDetails.</param>
        /// <param name="billingCycleDay">Day of each month for the bill payment. This is a reference data field. Please use /v1/utilities/referenceData/{billingCycleDay} resource to get valid value of this field with description..</param>
        /// <param name="applicationReferenceId">Unique reference ID associated with the application.</param>
        /// <param name="printingSerialNumber">This field refers to the unique number for each application to be identified by COLA and printed in PDF form.It enables to identify the customer in case the customer could not complete filling his/her details and was dropped-off in between.</param>
        /// <param name="accountFundSource">Primary source from which this account will be funded. This is a reference data field. Please use /v1/utilities/referenceData/{accountFundSource} resource to get valid value of this field with description..</param>
        /// <param name="mediaId">The media ID will be used to determine which offer/campaign banner was clicked when the customer has submitted the application.</param>
        /// <param name="referralTracking">referralTracking.</param>
        public ECMAdditionalDataUpdate(bool? cashPinFlag = default(bool?), UtilityBillDetails utilityBillDetails = default(UtilityBillDetails), string billingCycleDay = default(string), string applicationReferenceId = default(string), string printingSerialNumber = default(string), string accountFundSource = default(string), string mediaId = default(string), ReferralTracking referralTracking = default(ReferralTracking))
        {
            this.CashPinFlag = cashPinFlag;
            this.UtilityBillDetails = utilityBillDetails;
            this.BillingCycleDay = billingCycleDay;
            this.ApplicationReferenceId = applicationReferenceId;
            this.PrintingSerialNumber = printingSerialNumber;
            this.AccountFundSource = accountFundSource;
            this.MediaId = mediaId;
            this.ReferralTracking = referralTracking;
        }
        
        /// <summary>
        /// Indicates whether the customer wants a separate cash PIN.
        /// </summary>
        /// <value>Indicates whether the customer wants a separate cash PIN.</value>
        [DataMember(Name="cashPinFlag", EmitDefaultValue=false)]
        public bool? CashPinFlag { get; set; }

        /// <summary>
        /// Gets or Sets UtilityBillDetails
        /// </summary>
        [DataMember(Name="utilityBillDetails", EmitDefaultValue=false)]
        public UtilityBillDetails UtilityBillDetails { get; set; }

        /// <summary>
        /// Day of each month for the bill payment. This is a reference data field. Please use /v1/utilities/referenceData/{billingCycleDay} resource to get valid value of this field with description.
        /// </summary>
        /// <value>Day of each month for the bill payment. This is a reference data field. Please use /v1/utilities/referenceData/{billingCycleDay} resource to get valid value of this field with description.</value>
        [DataMember(Name="billingCycleDay", EmitDefaultValue=false)]
        public string BillingCycleDay { get; set; }

        /// <summary>
        /// Unique reference ID associated with the application
        /// </summary>
        /// <value>Unique reference ID associated with the application</value>
        [DataMember(Name="applicationReferenceId", EmitDefaultValue=false)]
        public string ApplicationReferenceId { get; set; }

        /// <summary>
        /// This field refers to the unique number for each application to be identified by COLA and printed in PDF form.It enables to identify the customer in case the customer could not complete filling his/her details and was dropped-off in between
        /// </summary>
        /// <value>This field refers to the unique number for each application to be identified by COLA and printed in PDF form.It enables to identify the customer in case the customer could not complete filling his/her details and was dropped-off in between</value>
        [DataMember(Name="printingSerialNumber", EmitDefaultValue=false)]
        public string PrintingSerialNumber { get; set; }

        /// <summary>
        /// Primary source from which this account will be funded. This is a reference data field. Please use /v1/utilities/referenceData/{accountFundSource} resource to get valid value of this field with description.
        /// </summary>
        /// <value>Primary source from which this account will be funded. This is a reference data field. Please use /v1/utilities/referenceData/{accountFundSource} resource to get valid value of this field with description.</value>
        [DataMember(Name="accountFundSource", EmitDefaultValue=false)]
        public string AccountFundSource { get; set; }

        /// <summary>
        /// The media ID will be used to determine which offer/campaign banner was clicked when the customer has submitted the application
        /// </summary>
        /// <value>The media ID will be used to determine which offer/campaign banner was clicked when the customer has submitted the application</value>
        [DataMember(Name="mediaId", EmitDefaultValue=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// Gets or Sets ReferralTracking
        /// </summary>
        [DataMember(Name="referralTracking", EmitDefaultValue=false)]
        public ReferralTracking ReferralTracking { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ECMAdditionalDataUpdate {\n");
            sb.Append("  CashPinFlag: ").Append(CashPinFlag).Append("\n");
            sb.Append("  UtilityBillDetails: ").Append(UtilityBillDetails).Append("\n");
            sb.Append("  BillingCycleDay: ").Append(BillingCycleDay).Append("\n");
            sb.Append("  ApplicationReferenceId: ").Append(ApplicationReferenceId).Append("\n");
            sb.Append("  PrintingSerialNumber: ").Append(PrintingSerialNumber).Append("\n");
            sb.Append("  AccountFundSource: ").Append(AccountFundSource).Append("\n");
            sb.Append("  MediaId: ").Append(MediaId).Append("\n");
            sb.Append("  ReferralTracking: ").Append(ReferralTracking).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ECMAdditionalDataUpdate);
        }

        /// <summary>
        /// Returns true if ECMAdditionalDataUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of ECMAdditionalDataUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ECMAdditionalDataUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CashPinFlag == input.CashPinFlag ||
                    (this.CashPinFlag != null &&
                    this.CashPinFlag.Equals(input.CashPinFlag))
                ) && 
                (
                    this.UtilityBillDetails == input.UtilityBillDetails ||
                    (this.UtilityBillDetails != null &&
                    this.UtilityBillDetails.Equals(input.UtilityBillDetails))
                ) && 
                (
                    this.BillingCycleDay == input.BillingCycleDay ||
                    (this.BillingCycleDay != null &&
                    this.BillingCycleDay.Equals(input.BillingCycleDay))
                ) && 
                (
                    this.ApplicationReferenceId == input.ApplicationReferenceId ||
                    (this.ApplicationReferenceId != null &&
                    this.ApplicationReferenceId.Equals(input.ApplicationReferenceId))
                ) && 
                (
                    this.PrintingSerialNumber == input.PrintingSerialNumber ||
                    (this.PrintingSerialNumber != null &&
                    this.PrintingSerialNumber.Equals(input.PrintingSerialNumber))
                ) && 
                (
                    this.AccountFundSource == input.AccountFundSource ||
                    (this.AccountFundSource != null &&
                    this.AccountFundSource.Equals(input.AccountFundSource))
                ) && 
                (
                    this.MediaId == input.MediaId ||
                    (this.MediaId != null &&
                    this.MediaId.Equals(input.MediaId))
                ) && 
                (
                    this.ReferralTracking == input.ReferralTracking ||
                    (this.ReferralTracking != null &&
                    this.ReferralTracking.Equals(input.ReferralTracking))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.CashPinFlag != null)
                    hashCode = hashCode * 59 + this.CashPinFlag.GetHashCode();
                if (this.UtilityBillDetails != null)
                    hashCode = hashCode * 59 + this.UtilityBillDetails.GetHashCode();
                if (this.BillingCycleDay != null)
                    hashCode = hashCode * 59 + this.BillingCycleDay.GetHashCode();
                if (this.ApplicationReferenceId != null)
                    hashCode = hashCode * 59 + this.ApplicationReferenceId.GetHashCode();
                if (this.PrintingSerialNumber != null)
                    hashCode = hashCode * 59 + this.PrintingSerialNumber.GetHashCode();
                if (this.AccountFundSource != null)
                    hashCode = hashCode * 59 + this.AccountFundSource.GetHashCode();
                if (this.MediaId != null)
                    hashCode = hashCode * 59 + this.MediaId.GetHashCode();
                if (this.ReferralTracking != null)
                    hashCode = hashCode * 59 + this.ReferralTracking.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
