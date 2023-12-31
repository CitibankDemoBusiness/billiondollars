/* 
 * Cards
 *
 * The Cards API allows you to perform actions on the actual credit cards of the Citi Customer who authorized your app.
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
    /// MultiCurrencyAccountEnrollmentResponse
    /// </summary>
    [DataContract]
        public partial class MultiCurrencyAccountEnrollmentResponse :  IEquatable<MultiCurrencyAccountEnrollmentResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiCurrencyAccountEnrollmentResponse" /> class.
        /// </summary>
        /// <param name="cardId">The customer card identifier in encrypted format (required).</param>
        /// <param name="enrollmentStatusFlag">This field is to indicate if the card is enrolled for multi currency account or not..</param>
        /// <param name="accountDetails">accountDetails.</param>
        public MultiCurrencyAccountEnrollmentResponse(string cardId = default(string), bool? enrollmentStatusFlag = default(bool?), List<AccountDetails> accountDetails = default(List<AccountDetails>))
        {
            // to ensure "cardId" is required (not null)
            if (cardId == null)
            {
                throw new InvalidDataException("cardId is a required property for MultiCurrencyAccountEnrollmentResponse and cannot be null");
            }
            else
            {
                this.CardId = cardId;
            }
            this.EnrollmentStatusFlag = enrollmentStatusFlag;
            this.AccountDetails = accountDetails;
        }
        
        /// <summary>
        /// The customer card identifier in encrypted format
        /// </summary>
        /// <value>The customer card identifier in encrypted format</value>
        [DataMember(Name="cardId", EmitDefaultValue=false)]
        public string CardId { get; set; }

        /// <summary>
        /// This field is to indicate if the card is enrolled for multi currency account or not.
        /// </summary>
        /// <value>This field is to indicate if the card is enrolled for multi currency account or not.</value>
        [DataMember(Name="enrollmentStatusFlag", EmitDefaultValue=false)]
        public bool? EnrollmentStatusFlag { get; set; }

        /// <summary>
        /// Gets or Sets AccountDetails
        /// </summary>
        [DataMember(Name="accountDetails", EmitDefaultValue=false)]
        public List<AccountDetails> AccountDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MultiCurrencyAccountEnrollmentResponse {\n");
            sb.Append("  CardId: ").Append(CardId).Append("\n");
            sb.Append("  EnrollmentStatusFlag: ").Append(EnrollmentStatusFlag).Append("\n");
            sb.Append("  AccountDetails: ").Append(AccountDetails).Append("\n");
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
            return this.Equals(input as MultiCurrencyAccountEnrollmentResponse);
        }

        /// <summary>
        /// Returns true if MultiCurrencyAccountEnrollmentResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MultiCurrencyAccountEnrollmentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MultiCurrencyAccountEnrollmentResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CardId == input.CardId ||
                    (this.CardId != null &&
                    this.CardId.Equals(input.CardId))
                ) && 
                (
                    this.EnrollmentStatusFlag == input.EnrollmentStatusFlag ||
                    (this.EnrollmentStatusFlag != null &&
                    this.EnrollmentStatusFlag.Equals(input.EnrollmentStatusFlag))
                ) && 
                (
                    this.AccountDetails == input.AccountDetails ||
                    this.AccountDetails != null &&
                    input.AccountDetails != null &&
                    this.AccountDetails.SequenceEqual(input.AccountDetails)
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
                if (this.CardId != null)
                    hashCode = hashCode * 59 + this.CardId.GetHashCode();
                if (this.EnrollmentStatusFlag != null)
                    hashCode = hashCode * 59 + this.EnrollmentStatusFlag.GetHashCode();
                if (this.AccountDetails != null)
                    hashCode = hashCode * 59 + this.AccountDetails.GetHashCode();
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
