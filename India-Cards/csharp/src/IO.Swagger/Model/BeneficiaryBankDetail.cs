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
    /// BeneficiaryBankDetail
    /// </summary>
    [DataContract]
        public partial class BeneficiaryBankDetail :  IEquatable<BeneficiaryBankDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BeneficiaryBankDetail" /> class.
        /// </summary>
        /// <param name="beneficiaryBankCode">Bank Code of the Beneficiary Account Number.</param>
        /// <param name="accountNumber">Customers Account Number with the Bank.   An account number is the primary identifier for ownership of an account, whether a checking account or savings account or credit card account or investment account, or a loan account..</param>
        /// <param name="beneficiaryBranchCode">Branch Code of the Beneficiary Account Number.</param>
        /// <param name="bankName">Name of the bank where the branch is associated.</param>
        /// <param name="beneficiaryName">Beneficiary Name.</param>
        public BeneficiaryBankDetail(string beneficiaryBankCode = default(string), string accountNumber = default(string), string beneficiaryBranchCode = default(string), string bankName = default(string), string beneficiaryName = default(string))
        {
            this.BeneficiaryBankCode = beneficiaryBankCode;
            this.AccountNumber = accountNumber;
            this.BeneficiaryBranchCode = beneficiaryBranchCode;
            this.BankName = bankName;
            this.BeneficiaryName = beneficiaryName;
        }
        
        /// <summary>
        /// Bank Code of the Beneficiary Account Number
        /// </summary>
        /// <value>Bank Code of the Beneficiary Account Number</value>
        [DataMember(Name="beneficiaryBankCode", EmitDefaultValue=false)]
        public string BeneficiaryBankCode { get; set; }

        /// <summary>
        /// Customers Account Number with the Bank.   An account number is the primary identifier for ownership of an account, whether a checking account or savings account or credit card account or investment account, or a loan account.
        /// </summary>
        /// <value>Customers Account Number with the Bank.   An account number is the primary identifier for ownership of an account, whether a checking account or savings account or credit card account or investment account, or a loan account.</value>
        [DataMember(Name="accountNumber", EmitDefaultValue=false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Branch Code of the Beneficiary Account Number
        /// </summary>
        /// <value>Branch Code of the Beneficiary Account Number</value>
        [DataMember(Name="beneficiaryBranchCode", EmitDefaultValue=false)]
        public string BeneficiaryBranchCode { get; set; }

        /// <summary>
        /// Name of the bank where the branch is associated
        /// </summary>
        /// <value>Name of the bank where the branch is associated</value>
        [DataMember(Name="bankName", EmitDefaultValue=false)]
        public string BankName { get; set; }

        /// <summary>
        /// Beneficiary Name
        /// </summary>
        /// <value>Beneficiary Name</value>
        [DataMember(Name="beneficiaryName", EmitDefaultValue=false)]
        public string BeneficiaryName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BeneficiaryBankDetail {\n");
            sb.Append("  BeneficiaryBankCode: ").Append(BeneficiaryBankCode).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  BeneficiaryBranchCode: ").Append(BeneficiaryBranchCode).Append("\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  BeneficiaryName: ").Append(BeneficiaryName).Append("\n");
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
            return this.Equals(input as BeneficiaryBankDetail);
        }

        /// <summary>
        /// Returns true if BeneficiaryBankDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of BeneficiaryBankDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BeneficiaryBankDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BeneficiaryBankCode == input.BeneficiaryBankCode ||
                    (this.BeneficiaryBankCode != null &&
                    this.BeneficiaryBankCode.Equals(input.BeneficiaryBankCode))
                ) && 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.BeneficiaryBranchCode == input.BeneficiaryBranchCode ||
                    (this.BeneficiaryBranchCode != null &&
                    this.BeneficiaryBranchCode.Equals(input.BeneficiaryBranchCode))
                ) && 
                (
                    this.BankName == input.BankName ||
                    (this.BankName != null &&
                    this.BankName.Equals(input.BankName))
                ) && 
                (
                    this.BeneficiaryName == input.BeneficiaryName ||
                    (this.BeneficiaryName != null &&
                    this.BeneficiaryName.Equals(input.BeneficiaryName))
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
                if (this.BeneficiaryBankCode != null)
                    hashCode = hashCode * 59 + this.BeneficiaryBankCode.GetHashCode();
                if (this.AccountNumber != null)
                    hashCode = hashCode * 59 + this.AccountNumber.GetHashCode();
                if (this.BeneficiaryBranchCode != null)
                    hashCode = hashCode * 59 + this.BeneficiaryBranchCode.GetHashCode();
                if (this.BankName != null)
                    hashCode = hashCode * 59 + this.BankName.GetHashCode();
                if (this.BeneficiaryName != null)
                    hashCode = hashCode * 59 + this.BeneficiaryName.GetHashCode();
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
