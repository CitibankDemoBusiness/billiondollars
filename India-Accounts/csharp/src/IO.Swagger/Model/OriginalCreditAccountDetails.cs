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
    /// OriginalCreditAccountDetails
    /// </summary>
    [DataContract]
        public partial class OriginalCreditAccountDetails :  IEquatable<OriginalCreditAccountDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OriginalCreditAccountDetails" /> class.
        /// </summary>
        /// <param name="displayAccountNumber">A masked account number that can be displayed to the customer.</param>
        /// <param name="bankName">Name of the bank..</param>
        /// <param name="bankCode">The bank code of the payee account.</param>
        public OriginalCreditAccountDetails(string displayAccountNumber = default(string), string bankName = default(string), string bankCode = default(string))
        {
            this.DisplayAccountNumber = displayAccountNumber;
            this.BankName = bankName;
            this.BankCode = bankCode;
        }
        
        /// <summary>
        /// A masked account number that can be displayed to the customer
        /// </summary>
        /// <value>A masked account number that can be displayed to the customer</value>
        [DataMember(Name="displayAccountNumber", EmitDefaultValue=false)]
        public string DisplayAccountNumber { get; set; }

        /// <summary>
        /// Name of the bank.
        /// </summary>
        /// <value>Name of the bank.</value>
        [DataMember(Name="bankName", EmitDefaultValue=false)]
        public string BankName { get; set; }

        /// <summary>
        /// The bank code of the payee account
        /// </summary>
        /// <value>The bank code of the payee account</value>
        [DataMember(Name="bankCode", EmitDefaultValue=false)]
        public string BankCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OriginalCreditAccountDetails {\n");
            sb.Append("  DisplayAccountNumber: ").Append(DisplayAccountNumber).Append("\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  BankCode: ").Append(BankCode).Append("\n");
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
            return this.Equals(input as OriginalCreditAccountDetails);
        }

        /// <summary>
        /// Returns true if OriginalCreditAccountDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of OriginalCreditAccountDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OriginalCreditAccountDetails input)
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
                    this.BankName == input.BankName ||
                    (this.BankName != null &&
                    this.BankName.Equals(input.BankName))
                ) && 
                (
                    this.BankCode == input.BankCode ||
                    (this.BankCode != null &&
                    this.BankCode.Equals(input.BankCode))
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
                if (this.BankName != null)
                    hashCode = hashCode * 59 + this.BankName.GetHashCode();
                if (this.BankCode != null)
                    hashCode = hashCode * 59 + this.BankCode.GetHashCode();
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
