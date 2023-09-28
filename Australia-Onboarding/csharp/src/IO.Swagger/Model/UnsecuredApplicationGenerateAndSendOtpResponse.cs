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
    /// UnsecuredApplicationGenerateAndSendOtpResponse
    /// </summary>
    [DataContract]
        public partial class UnsecuredApplicationGenerateAndSendOtpResponse :  IEquatable<UnsecuredApplicationGenerateAndSendOtpResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnsecuredApplicationGenerateAndSendOtpResponse" /> class.
        /// </summary>
        /// <param name="maskedPhoneNumber">The Customers phone number having last four digits unmasked (required).</param>
        public UnsecuredApplicationGenerateAndSendOtpResponse(string maskedPhoneNumber = default(string))
        {
            // to ensure "maskedPhoneNumber" is required (not null)
            if (maskedPhoneNumber == null)
            {
                throw new InvalidDataException("maskedPhoneNumber is a required property for UnsecuredApplicationGenerateAndSendOtpResponse and cannot be null");
            }
            else
            {
                this.MaskedPhoneNumber = maskedPhoneNumber;
            }
        }
        
        /// <summary>
        /// The Customers phone number having last four digits unmasked
        /// </summary>
        /// <value>The Customers phone number having last four digits unmasked</value>
        [DataMember(Name="maskedPhoneNumber", EmitDefaultValue=false)]
        public string MaskedPhoneNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnsecuredApplicationGenerateAndSendOtpResponse {\n");
            sb.Append("  MaskedPhoneNumber: ").Append(MaskedPhoneNumber).Append("\n");
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
            return this.Equals(input as UnsecuredApplicationGenerateAndSendOtpResponse);
        }

        /// <summary>
        /// Returns true if UnsecuredApplicationGenerateAndSendOtpResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of UnsecuredApplicationGenerateAndSendOtpResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnsecuredApplicationGenerateAndSendOtpResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaskedPhoneNumber == input.MaskedPhoneNumber ||
                    (this.MaskedPhoneNumber != null &&
                    this.MaskedPhoneNumber.Equals(input.MaskedPhoneNumber))
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
                if (this.MaskedPhoneNumber != null)
                    hashCode = hashCode * 59 + this.MaskedPhoneNumber.GetHashCode();
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