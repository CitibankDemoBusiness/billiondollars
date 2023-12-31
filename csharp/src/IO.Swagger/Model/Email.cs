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
    /// Email
    /// </summary>
    [DataContract]
        public partial class Email :  IEquatable<Email>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Email" /> class.
        /// </summary>
        /// <param name="emailAddress">Email ID (required).</param>
        /// <param name="okToEmail">Flag to indicate whether prospect wants to receive emails or not. Valid values: true and false.</param>
        /// <param name="isPrerferredEmailAddress">Indicates whether this email id is preferred email for all communications. Valid values: true and false.</param>
        public Email(string emailAddress = default(string), bool? okToEmail = default(bool?), bool? isPrerferredEmailAddress = default(bool?))
        {
            // to ensure "emailAddress" is required (not null)
            if (emailAddress == null)
            {
                throw new InvalidDataException("emailAddress is a required property for Email and cannot be null");
            }
            else
            {
                this.EmailAddress = emailAddress;
            }
            this.OkToEmail = okToEmail;
            this.IsPrerferredEmailAddress = isPrerferredEmailAddress;
        }
        
        /// <summary>
        /// Email ID
        /// </summary>
        /// <value>Email ID</value>
        [DataMember(Name="emailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Flag to indicate whether prospect wants to receive emails or not. Valid values: true and false
        /// </summary>
        /// <value>Flag to indicate whether prospect wants to receive emails or not. Valid values: true and false</value>
        [DataMember(Name="okToEmail", EmitDefaultValue=false)]
        public bool? OkToEmail { get; set; }

        /// <summary>
        /// Indicates whether this email id is preferred email for all communications. Valid values: true and false
        /// </summary>
        /// <value>Indicates whether this email id is preferred email for all communications. Valid values: true and false</value>
        [DataMember(Name="isPrerferredEmailAddress", EmitDefaultValue=false)]
        public bool? IsPrerferredEmailAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Email {\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  OkToEmail: ").Append(OkToEmail).Append("\n");
            sb.Append("  IsPrerferredEmailAddress: ").Append(IsPrerferredEmailAddress).Append("\n");
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
            return this.Equals(input as Email);
        }

        /// <summary>
        /// Returns true if Email instances are equal
        /// </summary>
        /// <param name="input">Instance of Email to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Email input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.OkToEmail == input.OkToEmail ||
                    (this.OkToEmail != null &&
                    this.OkToEmail.Equals(input.OkToEmail))
                ) && 
                (
                    this.IsPrerferredEmailAddress == input.IsPrerferredEmailAddress ||
                    (this.IsPrerferredEmailAddress != null &&
                    this.IsPrerferredEmailAddress.Equals(input.IsPrerferredEmailAddress))
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
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.OkToEmail != null)
                    hashCode = hashCode * 59 + this.OkToEmail.GetHashCode();
                if (this.IsPrerferredEmailAddress != null)
                    hashCode = hashCode * 59 + this.IsPrerferredEmailAddress.GetHashCode();
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
