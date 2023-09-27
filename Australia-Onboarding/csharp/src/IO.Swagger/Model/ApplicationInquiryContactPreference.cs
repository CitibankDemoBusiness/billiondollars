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
    /// ApplicationInquiryContactPreference
    /// </summary>
    [DataContract]
        public partial class ApplicationInquiryContactPreference :  IEquatable<ApplicationInquiryContactPreference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationInquiryContactPreference" /> class.
        /// </summary>
        /// <param name="sendSmsAdviceFlag">Applicant&#x27;s subscription for receiving advices through SMS. Valid values: true and false.</param>
        /// <param name="sendEmailAdviceFlag">Applicant&#x27;s subscription for receiving advices through email. Valid values: true and false.</param>
        /// <param name="preferredMailingAddress">Preferred Mailing Address by applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use preferredMailingAddress field name as the referenceCode parameter to retrieve the values..</param>
        /// <param name="eStatementEnrollmentFlag">Applicant&#x27;s subscription for receiving statement over email. Valid values: true and false.</param>
        public ApplicationInquiryContactPreference(bool? sendSmsAdviceFlag = default(bool?), bool? sendEmailAdviceFlag = default(bool?), string preferredMailingAddress = default(string), bool? eStatementEnrollmentFlag = default(bool?))
        {
            this.SendSmsAdviceFlag = sendSmsAdviceFlag;
            this.SendEmailAdviceFlag = sendEmailAdviceFlag;
            this.PreferredMailingAddress = preferredMailingAddress;
            this.EStatementEnrollmentFlag = eStatementEnrollmentFlag;
        }
        
        /// <summary>
        /// Applicant&#x27;s subscription for receiving advices through SMS. Valid values: true and false
        /// </summary>
        /// <value>Applicant&#x27;s subscription for receiving advices through SMS. Valid values: true and false</value>
        [DataMember(Name="sendSmsAdviceFlag", EmitDefaultValue=false)]
        public bool? SendSmsAdviceFlag { get; set; }

        /// <summary>
        /// Applicant&#x27;s subscription for receiving advices through email. Valid values: true and false
        /// </summary>
        /// <value>Applicant&#x27;s subscription for receiving advices through email. Valid values: true and false</value>
        [DataMember(Name="sendEmailAdviceFlag", EmitDefaultValue=false)]
        public bool? SendEmailAdviceFlag { get; set; }

        /// <summary>
        /// Preferred Mailing Address by applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use preferredMailingAddress field name as the referenceCode parameter to retrieve the values.
        /// </summary>
        /// <value>Preferred Mailing Address by applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use preferredMailingAddress field name as the referenceCode parameter to retrieve the values.</value>
        [DataMember(Name="preferredMailingAddress", EmitDefaultValue=false)]
        public string PreferredMailingAddress { get; set; }

        /// <summary>
        /// Applicant&#x27;s subscription for receiving statement over email. Valid values: true and false
        /// </summary>
        /// <value>Applicant&#x27;s subscription for receiving statement over email. Valid values: true and false</value>
        [DataMember(Name="eStatementEnrollmentFlag", EmitDefaultValue=false)]
        public bool? EStatementEnrollmentFlag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationInquiryContactPreference {\n");
            sb.Append("  SendSmsAdviceFlag: ").Append(SendSmsAdviceFlag).Append("\n");
            sb.Append("  SendEmailAdviceFlag: ").Append(SendEmailAdviceFlag).Append("\n");
            sb.Append("  PreferredMailingAddress: ").Append(PreferredMailingAddress).Append("\n");
            sb.Append("  EStatementEnrollmentFlag: ").Append(EStatementEnrollmentFlag).Append("\n");
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
            return this.Equals(input as ApplicationInquiryContactPreference);
        }

        /// <summary>
        /// Returns true if ApplicationInquiryContactPreference instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationInquiryContactPreference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationInquiryContactPreference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SendSmsAdviceFlag == input.SendSmsAdviceFlag ||
                    (this.SendSmsAdviceFlag != null &&
                    this.SendSmsAdviceFlag.Equals(input.SendSmsAdviceFlag))
                ) && 
                (
                    this.SendEmailAdviceFlag == input.SendEmailAdviceFlag ||
                    (this.SendEmailAdviceFlag != null &&
                    this.SendEmailAdviceFlag.Equals(input.SendEmailAdviceFlag))
                ) && 
                (
                    this.PreferredMailingAddress == input.PreferredMailingAddress ||
                    (this.PreferredMailingAddress != null &&
                    this.PreferredMailingAddress.Equals(input.PreferredMailingAddress))
                ) && 
                (
                    this.EStatementEnrollmentFlag == input.EStatementEnrollmentFlag ||
                    (this.EStatementEnrollmentFlag != null &&
                    this.EStatementEnrollmentFlag.Equals(input.EStatementEnrollmentFlag))
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
                if (this.SendSmsAdviceFlag != null)
                    hashCode = hashCode * 59 + this.SendSmsAdviceFlag.GetHashCode();
                if (this.SendEmailAdviceFlag != null)
                    hashCode = hashCode * 59 + this.SendEmailAdviceFlag.GetHashCode();
                if (this.PreferredMailingAddress != null)
                    hashCode = hashCode * 59 + this.PreferredMailingAddress.GetHashCode();
                if (this.EStatementEnrollmentFlag != null)
                    hashCode = hashCode * 59 + this.EStatementEnrollmentFlag.GetHashCode();
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
