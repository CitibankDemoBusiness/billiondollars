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
    /// LoanBookingConfirmationResponse
    /// </summary>
    [DataContract]
        public partial class LoanBookingConfirmationResponse :  IEquatable<LoanBookingConfirmationResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoanBookingConfirmationResponse" /> class.
        /// </summary>
        /// <param name="loanReferenceId">Reference Id to uniquely identify the loan. (required).</param>
        public LoanBookingConfirmationResponse(string loanReferenceId = default(string))
        {
            // to ensure "loanReferenceId" is required (not null)
            if (loanReferenceId == null)
            {
                throw new InvalidDataException("loanReferenceId is a required property for LoanBookingConfirmationResponse and cannot be null");
            }
            else
            {
                this.LoanReferenceId = loanReferenceId;
            }
        }
        
        /// <summary>
        /// Reference Id to uniquely identify the loan.
        /// </summary>
        /// <value>Reference Id to uniquely identify the loan.</value>
        [DataMember(Name="loanReferenceId", EmitDefaultValue=false)]
        public string LoanReferenceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanBookingConfirmationResponse {\n");
            sb.Append("  LoanReferenceId: ").Append(LoanReferenceId).Append("\n");
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
            return this.Equals(input as LoanBookingConfirmationResponse);
        }

        /// <summary>
        /// Returns true if LoanBookingConfirmationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanBookingConfirmationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanBookingConfirmationResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LoanReferenceId == input.LoanReferenceId ||
                    (this.LoanReferenceId != null &&
                    this.LoanReferenceId.Equals(input.LoanReferenceId))
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
                if (this.LoanReferenceId != null)
                    hashCode = hashCode * 59 + this.LoanReferenceId.GetHashCode();
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
