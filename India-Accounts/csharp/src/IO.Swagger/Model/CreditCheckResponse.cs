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
    /// CreditCheckResponse
    /// </summary>
    [DataContract]
        public partial class CreditCheckResponse :  IEquatable<CreditCheckResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditCheckResponse" /> class.
        /// </summary>
        /// <param name="creditCheck">creditCheck (required).</param>
        public CreditCheckResponse(List<CreditCheck> creditCheck = default(List<CreditCheck>))
        {
            // to ensure "creditCheck" is required (not null)
            if (creditCheck == null)
            {
                throw new InvalidDataException("creditCheck is a required property for CreditCheckResponse and cannot be null");
            }
            else
            {
                this.CreditCheck = creditCheck;
            }
        }
        
        /// <summary>
        /// Gets or Sets CreditCheck
        /// </summary>
        [DataMember(Name="creditCheck", EmitDefaultValue=false)]
        public List<CreditCheck> CreditCheck { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreditCheckResponse {\n");
            sb.Append("  CreditCheck: ").Append(CreditCheck).Append("\n");
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
            return this.Equals(input as CreditCheckResponse);
        }

        /// <summary>
        /// Returns true if CreditCheckResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreditCheckResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreditCheckResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreditCheck == input.CreditCheck ||
                    this.CreditCheck != null &&
                    input.CreditCheck != null &&
                    this.CreditCheck.SequenceEqual(input.CreditCheck)
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
                if (this.CreditCheck != null)
                    hashCode = hashCode * 59 + this.CreditCheck.GetHashCode();
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
