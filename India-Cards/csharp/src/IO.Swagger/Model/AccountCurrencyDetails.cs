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
    /// AccountCurrencyDetails
    /// </summary>
    [DataContract]
        public partial class AccountCurrencyDetails :  IEquatable<AccountCurrencyDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountCurrencyDetails" /> class.
        /// </summary>
        /// <param name="displayAccountNumber">A masked account number that can be displayed to the customer.</param>
        /// <param name="accountId">The customer account identifier in encrypted format.</param>
        /// <param name="newAccountOpenedFlag">This field is to indicate if the  account is newly opened or not. (required).</param>
        /// <param name="globalWalletAccountType">Type of account.Type of account.This is a reference data field. Please use /v1/apac/utilities/referenceData/{globalWalletAccountType} resource to get possible values of this field with descriptions..</param>
        /// <param name="enrollmentStatusFlag">Flag to indicate whether new FCY account is enrolled to Multi currency account(Global Wallet)..</param>
        public AccountCurrencyDetails(string displayAccountNumber = default(string), string accountId = default(string), bool? newAccountOpenedFlag = default(bool?), string globalWalletAccountType = default(string), bool? enrollmentStatusFlag = default(bool?))
        {
            // to ensure "newAccountOpenedFlag" is required (not null)
            if (newAccountOpenedFlag == null)
            {
                throw new InvalidDataException("newAccountOpenedFlag is a required property for AccountCurrencyDetails and cannot be null");
            }
            else
            {
                this.NewAccountOpenedFlag = newAccountOpenedFlag;
            }
            this.DisplayAccountNumber = displayAccountNumber;
            this.AccountId = accountId;
            this.GlobalWalletAccountType = globalWalletAccountType;
            this.EnrollmentStatusFlag = enrollmentStatusFlag;
        }
        
        /// <summary>
        /// A masked account number that can be displayed to the customer
        /// </summary>
        /// <value>A masked account number that can be displayed to the customer</value>
        [DataMember(Name="displayAccountNumber", EmitDefaultValue=false)]
        public string DisplayAccountNumber { get; set; }

        /// <summary>
        /// The customer account identifier in encrypted format
        /// </summary>
        /// <value>The customer account identifier in encrypted format</value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// This field is to indicate if the  account is newly opened or not.
        /// </summary>
        /// <value>This field is to indicate if the  account is newly opened or not.</value>
        [DataMember(Name="newAccountOpenedFlag", EmitDefaultValue=false)]
        public bool? NewAccountOpenedFlag { get; set; }

        /// <summary>
        /// Type of account.Type of account.This is a reference data field. Please use /v1/apac/utilities/referenceData/{globalWalletAccountType} resource to get possible values of this field with descriptions.
        /// </summary>
        /// <value>Type of account.Type of account.This is a reference data field. Please use /v1/apac/utilities/referenceData/{globalWalletAccountType} resource to get possible values of this field with descriptions.</value>
        [DataMember(Name="globalWalletAccountType", EmitDefaultValue=false)]
        public string GlobalWalletAccountType { get; set; }

        /// <summary>
        /// Flag to indicate whether new FCY account is enrolled to Multi currency account(Global Wallet).
        /// </summary>
        /// <value>Flag to indicate whether new FCY account is enrolled to Multi currency account(Global Wallet).</value>
        [DataMember(Name="enrollmentStatusFlag", EmitDefaultValue=false)]
        public bool? EnrollmentStatusFlag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountCurrencyDetails {\n");
            sb.Append("  DisplayAccountNumber: ").Append(DisplayAccountNumber).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  NewAccountOpenedFlag: ").Append(NewAccountOpenedFlag).Append("\n");
            sb.Append("  GlobalWalletAccountType: ").Append(GlobalWalletAccountType).Append("\n");
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
            return this.Equals(input as AccountCurrencyDetails);
        }

        /// <summary>
        /// Returns true if AccountCurrencyDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountCurrencyDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountCurrencyDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisplayAccountNumber == input.DisplayAccountNumber ||
                    (this.DisplayAccountNumber != null &&
                    this.DisplayAccountNumber.Equals(input.DisplayAccountNumber))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.NewAccountOpenedFlag == input.NewAccountOpenedFlag ||
                    (this.NewAccountOpenedFlag != null &&
                    this.NewAccountOpenedFlag.Equals(input.NewAccountOpenedFlag))
                ) && 
                (
                    this.GlobalWalletAccountType == input.GlobalWalletAccountType ||
                    (this.GlobalWalletAccountType != null &&
                    this.GlobalWalletAccountType.Equals(input.GlobalWalletAccountType))
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
                if (this.DisplayAccountNumber != null)
                    hashCode = hashCode * 59 + this.DisplayAccountNumber.GetHashCode();
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.NewAccountOpenedFlag != null)
                    hashCode = hashCode * 59 + this.NewAccountOpenedFlag.GetHashCode();
                if (this.GlobalWalletAccountType != null)
                    hashCode = hashCode * 59 + this.GlobalWalletAccountType.GetHashCode();
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
