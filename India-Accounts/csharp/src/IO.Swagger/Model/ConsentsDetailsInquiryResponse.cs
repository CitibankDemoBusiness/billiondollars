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
    /// ConsentsDetailsInquiryResponse
    /// </summary>
    [DataContract]
        public partial class ConsentsDetailsInquiryResponse :  IEquatable<ConsentsDetailsInquiryResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsentsDetailsInquiryResponse" /> class.
        /// </summary>
        /// <param name="accountConsentDetails">accountConsentDetails.</param>
        public ConsentsDetailsInquiryResponse(List<AccountConsentDetails> accountConsentDetails = default(List<AccountConsentDetails>))
        {
            this.AccountConsentDetails = accountConsentDetails;
        }
        
        /// <summary>
        /// Gets or Sets AccountConsentDetails
        /// </summary>
        [DataMember(Name="accountConsentDetails", EmitDefaultValue=false)]
        public List<AccountConsentDetails> AccountConsentDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsentsDetailsInquiryResponse {\n");
            sb.Append("  AccountConsentDetails: ").Append(AccountConsentDetails).Append("\n");
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
            return this.Equals(input as ConsentsDetailsInquiryResponse);
        }

        /// <summary>
        /// Returns true if ConsentsDetailsInquiryResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ConsentsDetailsInquiryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsentsDetailsInquiryResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountConsentDetails == input.AccountConsentDetails ||
                    this.AccountConsentDetails != null &&
                    input.AccountConsentDetails != null &&
                    this.AccountConsentDetails.SequenceEqual(input.AccountConsentDetails)
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
                if (this.AccountConsentDetails != null)
                    hashCode = hashCode * 59 + this.AccountConsentDetails.GetHashCode();
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
