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
    /// AccountDetails
    /// </summary>
    [DataContract]
        public partial class AccountDetails :  IEquatable<AccountDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDetails" /> class.
        /// </summary>
        /// <param name="accountId">The customer account identifier in encrypted format (required).</param>
        /// <param name="enrollmentStatusFlag">This field is to indicate if the  account is enrolled for multi currency account or not. (required).</param>
        public AccountDetails(string accountId = default(string), bool? enrollmentStatusFlag = default(bool?))
        {
            // to ensure "accountId" is required (not null)
            if (accountId == null)
            {
                throw new InvalidDataException("accountId is a required property for AccountDetails and cannot be null");
            }
            else
            {
                this.AccountId = accountId;
            }
            // to ensure "enrollmentStatusFlag" is required (not null)
            if (enrollmentStatusFlag == null)
            {
                throw new InvalidDataException("enrollmentStatusFlag is a required property for AccountDetails and cannot be null");
            }
            else
            {
                this.EnrollmentStatusFlag = enrollmentStatusFlag;
            }
        }
        
        /// <summary>
        /// The customer account identifier in encrypted format
        /// </summary>
        /// <value>The customer account identifier in encrypted format</value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// This field is to indicate if the  account is enrolled for multi currency account or not.
        /// </summary>
        /// <value>This field is to indicate if the  account is enrolled for multi currency account or not.</value>
        [DataMember(Name="enrollmentStatusFlag", EmitDefaultValue=false)]
        public bool? EnrollmentStatusFlag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountDetails {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  EnrollmentStatusFlag: ").Append(EnrollmentStatusFlag).Append("\n");
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
            return this.Equals(input as AccountDetails);
        }

        /// <summary>
        /// Returns true if AccountDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.EnrollmentStatusFlag == input.EnrollmentStatusFlag ||
                    (this.EnrollmentStatusFlag != null &&
                    this.EnrollmentStatusFlag.Equals(input.EnrollmentStatusFlag))
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
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.EnrollmentStatusFlag != null)
                    hashCode = hashCode * 59 + this.EnrollmentStatusFlag.GetHashCode();
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
