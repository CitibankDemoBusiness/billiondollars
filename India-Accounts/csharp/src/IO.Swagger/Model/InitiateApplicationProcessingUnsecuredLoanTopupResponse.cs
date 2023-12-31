/* 
 * Accounts
 *
 * The Accounts API allows you to retrieve account and transaction data for Citi Customers who have authorized your app. In most cases, you'll want to request a summary of all accounts first, which will return basic account information and accountIds. Once you have this information, you can request additional account details and/or transactions.
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
    /// InitiateApplicationProcessingUnsecuredLoanTopupResponse
    /// </summary>
    [DataContract]
        public partial class InitiateApplicationProcessingUnsecuredLoanTopupResponse :  IEquatable<InitiateApplicationProcessingUnsecuredLoanTopupResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InitiateApplicationProcessingUnsecuredLoanTopupResponse" /> class.
        /// </summary>
        /// <param name="applicationId">Unique identifier for the application (required).</param>
        public InitiateApplicationProcessingUnsecuredLoanTopupResponse(string applicationId = default(string))
        {
            // to ensure "applicationId" is required (not null)
            if (applicationId == null)
            {
                throw new InvalidDataException("applicationId is a required property for InitiateApplicationProcessingUnsecuredLoanTopupResponse and cannot be null");
            }
            else
            {
                this.ApplicationId = applicationId;
            }
        }
        
        /// <summary>
        /// Unique identifier for the application
        /// </summary>
        /// <value>Unique identifier for the application</value>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InitiateApplicationProcessingUnsecuredLoanTopupResponse {\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
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
            return this.Equals(input as InitiateApplicationProcessingUnsecuredLoanTopupResponse);
        }

        /// <summary>
        /// Returns true if InitiateApplicationProcessingUnsecuredLoanTopupResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of InitiateApplicationProcessingUnsecuredLoanTopupResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InitiateApplicationProcessingUnsecuredLoanTopupResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
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
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
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
