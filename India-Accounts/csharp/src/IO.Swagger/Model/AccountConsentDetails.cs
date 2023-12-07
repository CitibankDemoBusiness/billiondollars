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
    /// AccountConsentDetails
    /// </summary>
    [DataContract]
        public partial class AccountConsentDetails :  IEquatable<AccountConsentDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountConsentDetails" /> class.
        /// </summary>
        /// <param name="consentType">ConsentType (required).</param>
        /// <param name="consentGivenFlag">Consent flag. Valid values: true and false (required).</param>
        /// <param name="consentUpdateDate">Consent Updated Date (required).</param>
        /// <param name="cardId">The card id  in encrypted format..</param>
        public AccountConsentDetails(string consentType = default(string), bool? consentGivenFlag = default(bool?), DateTime? consentUpdateDate = default(DateTime?), string cardId = default(string))
        {
            // to ensure "consentType" is required (not null)
            if (consentType == null)
            {
                throw new InvalidDataException("consentType is a required property for AccountConsentDetails and cannot be null");
            }
            else
            {
                this.ConsentType = consentType;
            }
            // to ensure "consentGivenFlag" is required (not null)
            if (consentGivenFlag == null)
            {
                throw new InvalidDataException("consentGivenFlag is a required property for AccountConsentDetails and cannot be null");
            }
            else
            {
                this.ConsentGivenFlag = consentGivenFlag;
            }
            // to ensure "consentUpdateDate" is required (not null)
            if (consentUpdateDate == null)
            {
                throw new InvalidDataException("consentUpdateDate is a required property for AccountConsentDetails and cannot be null");
            }
            else
            {
                this.ConsentUpdateDate = consentUpdateDate;
            }
            this.CardId = cardId;
        }
        
        /// <summary>
        /// ConsentType
        /// </summary>
        /// <value>ConsentType</value>
        [DataMember(Name="consentType", EmitDefaultValue=false)]
        public string ConsentType { get; set; }

        /// <summary>
        /// Consent flag. Valid values: true and false
        /// </summary>
        /// <value>Consent flag. Valid values: true and false</value>
        [DataMember(Name="consentGivenFlag", EmitDefaultValue=false)]
        public bool? ConsentGivenFlag { get; set; }

        /// <summary>
        /// Consent Updated Date
        /// </summary>
        /// <value>Consent Updated Date</value>
        [DataMember(Name="consentUpdateDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? ConsentUpdateDate { get; set; }

        /// <summary>
        /// The card id  in encrypted format.
        /// </summary>
        /// <value>The card id  in encrypted format.</value>
        [DataMember(Name="cardId", EmitDefaultValue=false)]
        public string CardId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountConsentDetails {\n");
            sb.Append("  ConsentType: ").Append(ConsentType).Append("\n");
            sb.Append("  ConsentGivenFlag: ").Append(ConsentGivenFlag).Append("\n");
            sb.Append("  ConsentUpdateDate: ").Append(ConsentUpdateDate).Append("\n");
            sb.Append("  CardId: ").Append(CardId).Append("\n");
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
            return this.Equals(input as AccountConsentDetails);
        }

        /// <summary>
        /// Returns true if AccountConsentDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountConsentDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountConsentDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConsentType == input.ConsentType ||
                    (this.ConsentType != null &&
                    this.ConsentType.Equals(input.ConsentType))
                ) && 
                (
                    this.ConsentGivenFlag == input.ConsentGivenFlag ||
                    (this.ConsentGivenFlag != null &&
                    this.ConsentGivenFlag.Equals(input.ConsentGivenFlag))
                ) && 
                (
                    this.ConsentUpdateDate == input.ConsentUpdateDate ||
                    (this.ConsentUpdateDate != null &&
                    this.ConsentUpdateDate.Equals(input.ConsentUpdateDate))
                ) && 
                (
                    this.CardId == input.CardId ||
                    (this.CardId != null &&
                    this.CardId.Equals(input.CardId))
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
                if (this.ConsentType != null)
                    hashCode = hashCode * 59 + this.ConsentType.GetHashCode();
                if (this.ConsentGivenFlag != null)
                    hashCode = hashCode * 59 + this.ConsentGivenFlag.GetHashCode();
                if (this.ConsentUpdateDate != null)
                    hashCode = hashCode * 59 + this.ConsentUpdateDate.GetHashCode();
                if (this.CardId != null)
                    hashCode = hashCode * 59 + this.CardId.GetHashCode();
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
