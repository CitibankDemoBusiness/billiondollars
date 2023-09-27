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
    /// AccountSummary
    /// </summary>
    [DataContract]
        public partial class AccountSummary :  IEquatable<AccountSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountSummary" /> class.
        /// </summary>
        /// <param name="checkingAccountSummary">checkingAccountSummary.</param>
        /// <param name="savingsAccountSummary">savingsAccountSummary.</param>
        /// <param name="creditCardAccountSummary">creditCardAccountSummary.</param>
        /// <param name="readyCreditAccountSummary">readyCreditAccountSummary.</param>
        /// <param name="loanAccountSummary">loanAccountSummary.</param>
        /// <param name="mutualFundAccountSummary">mutualFundAccountSummary.</param>
        /// <param name="securitiesBrokerageAccountSummary">securitiesBrokerageAccountSummary.</param>
        /// <param name="callDepositAccountSummary">callDepositAccountSummary.</param>
        /// <param name="premiumDepositAccountSummary">premiumDepositAccountSummary.</param>
        /// <param name="timeDepositAccountSummary">timeDepositAccountSummary.</param>
        public AccountSummary(CheckingAccountSummary checkingAccountSummary = default(CheckingAccountSummary), SavingsAccountSummary savingsAccountSummary = default(SavingsAccountSummary), CreditCardAccountSummary creditCardAccountSummary = default(CreditCardAccountSummary), ReadyCreditAccountSummary readyCreditAccountSummary = default(ReadyCreditAccountSummary), LoanAccountSummary loanAccountSummary = default(LoanAccountSummary), MutualFundAccountSummary mutualFundAccountSummary = default(MutualFundAccountSummary), SecuritiesBrokerageAccountSummary securitiesBrokerageAccountSummary = default(SecuritiesBrokerageAccountSummary), CallDepositAccountSummary callDepositAccountSummary = default(CallDepositAccountSummary), PremiumDepositAccountSummary premiumDepositAccountSummary = default(PremiumDepositAccountSummary), TimeDepositAccountSummary timeDepositAccountSummary = default(TimeDepositAccountSummary))
        {
            this.CheckingAccountSummary = checkingAccountSummary;
            this.SavingsAccountSummary = savingsAccountSummary;
            this.CreditCardAccountSummary = creditCardAccountSummary;
            this.ReadyCreditAccountSummary = readyCreditAccountSummary;
            this.LoanAccountSummary = loanAccountSummary;
            this.MutualFundAccountSummary = mutualFundAccountSummary;
            this.SecuritiesBrokerageAccountSummary = securitiesBrokerageAccountSummary;
            this.CallDepositAccountSummary = callDepositAccountSummary;
            this.PremiumDepositAccountSummary = premiumDepositAccountSummary;
            this.TimeDepositAccountSummary = timeDepositAccountSummary;
        }
        
        /// <summary>
        /// Gets or Sets CheckingAccountSummary
        /// </summary>
        [DataMember(Name="checkingAccountSummary", EmitDefaultValue=false)]
        public CheckingAccountSummary CheckingAccountSummary { get; set; }

        /// <summary>
        /// Gets or Sets SavingsAccountSummary
        /// </summary>
        [DataMember(Name="savingsAccountSummary", EmitDefaultValue=false)]
        public SavingsAccountSummary SavingsAccountSummary { get; set; }

        /// <summary>
        /// Gets or Sets CreditCardAccountSummary
        /// </summary>
        [DataMember(Name="creditCardAccountSummary", EmitDefaultValue=false)]
        public CreditCardAccountSummary CreditCardAccountSummary { get; set; }

        /// <summary>
        /// Gets or Sets ReadyCreditAccountSummary
        /// </summary>
        [DataMember(Name="readyCreditAccountSummary", EmitDefaultValue=false)]
        public ReadyCreditAccountSummary ReadyCreditAccountSummary { get; set; }

        /// <summary>
        /// Gets or Sets LoanAccountSummary
        /// </summary>
        [DataMember(Name="loanAccountSummary", EmitDefaultValue=false)]
        public LoanAccountSummary LoanAccountSummary { get; set; }

        /// <summary>
        /// Gets or Sets MutualFundAccountSummary
        /// </summary>
        [DataMember(Name="mutualFundAccountSummary", EmitDefaultValue=false)]
        public MutualFundAccountSummary MutualFundAccountSummary { get; set; }

        /// <summary>
        /// Gets or Sets SecuritiesBrokerageAccountSummary
        /// </summary>
        [DataMember(Name="securitiesBrokerageAccountSummary", EmitDefaultValue=false)]
        public SecuritiesBrokerageAccountSummary SecuritiesBrokerageAccountSummary { get; set; }

        /// <summary>
        /// Gets or Sets CallDepositAccountSummary
        /// </summary>
        [DataMember(Name="callDepositAccountSummary", EmitDefaultValue=false)]
        public CallDepositAccountSummary CallDepositAccountSummary { get; set; }

        /// <summary>
        /// Gets or Sets PremiumDepositAccountSummary
        /// </summary>
        [DataMember(Name="premiumDepositAccountSummary", EmitDefaultValue=false)]
        public PremiumDepositAccountSummary PremiumDepositAccountSummary { get; set; }

        /// <summary>
        /// Gets or Sets TimeDepositAccountSummary
        /// </summary>
        [DataMember(Name="timeDepositAccountSummary", EmitDefaultValue=false)]
        public TimeDepositAccountSummary TimeDepositAccountSummary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountSummary {\n");
            sb.Append("  CheckingAccountSummary: ").Append(CheckingAccountSummary).Append("\n");
            sb.Append("  SavingsAccountSummary: ").Append(SavingsAccountSummary).Append("\n");
            sb.Append("  CreditCardAccountSummary: ").Append(CreditCardAccountSummary).Append("\n");
            sb.Append("  ReadyCreditAccountSummary: ").Append(ReadyCreditAccountSummary).Append("\n");
            sb.Append("  LoanAccountSummary: ").Append(LoanAccountSummary).Append("\n");
            sb.Append("  MutualFundAccountSummary: ").Append(MutualFundAccountSummary).Append("\n");
            sb.Append("  SecuritiesBrokerageAccountSummary: ").Append(SecuritiesBrokerageAccountSummary).Append("\n");
            sb.Append("  CallDepositAccountSummary: ").Append(CallDepositAccountSummary).Append("\n");
            sb.Append("  PremiumDepositAccountSummary: ").Append(PremiumDepositAccountSummary).Append("\n");
            sb.Append("  TimeDepositAccountSummary: ").Append(TimeDepositAccountSummary).Append("\n");
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
            return this.Equals(input as AccountSummary);
        }

        /// <summary>
        /// Returns true if AccountSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CheckingAccountSummary == input.CheckingAccountSummary ||
                    (this.CheckingAccountSummary != null &&
                    this.CheckingAccountSummary.Equals(input.CheckingAccountSummary))
                ) && 
                (
                    this.SavingsAccountSummary == input.SavingsAccountSummary ||
                    (this.SavingsAccountSummary != null &&
                    this.SavingsAccountSummary.Equals(input.SavingsAccountSummary))
                ) && 
                (
                    this.CreditCardAccountSummary == input.CreditCardAccountSummary ||
                    (this.CreditCardAccountSummary != null &&
                    this.CreditCardAccountSummary.Equals(input.CreditCardAccountSummary))
                ) && 
                (
                    this.ReadyCreditAccountSummary == input.ReadyCreditAccountSummary ||
                    (this.ReadyCreditAccountSummary != null &&
                    this.ReadyCreditAccountSummary.Equals(input.ReadyCreditAccountSummary))
                ) && 
                (
                    this.LoanAccountSummary == input.LoanAccountSummary ||
                    (this.LoanAccountSummary != null &&
                    this.LoanAccountSummary.Equals(input.LoanAccountSummary))
                ) && 
                (
                    this.MutualFundAccountSummary == input.MutualFundAccountSummary ||
                    (this.MutualFundAccountSummary != null &&
                    this.MutualFundAccountSummary.Equals(input.MutualFundAccountSummary))
                ) && 
                (
                    this.SecuritiesBrokerageAccountSummary == input.SecuritiesBrokerageAccountSummary ||
                    (this.SecuritiesBrokerageAccountSummary != null &&
                    this.SecuritiesBrokerageAccountSummary.Equals(input.SecuritiesBrokerageAccountSummary))
                ) && 
                (
                    this.CallDepositAccountSummary == input.CallDepositAccountSummary ||
                    (this.CallDepositAccountSummary != null &&
                    this.CallDepositAccountSummary.Equals(input.CallDepositAccountSummary))
                ) && 
                (
                    this.PremiumDepositAccountSummary == input.PremiumDepositAccountSummary ||
                    (this.PremiumDepositAccountSummary != null &&
                    this.PremiumDepositAccountSummary.Equals(input.PremiumDepositAccountSummary))
                ) && 
                (
                    this.TimeDepositAccountSummary == input.TimeDepositAccountSummary ||
                    (this.TimeDepositAccountSummary != null &&
                    this.TimeDepositAccountSummary.Equals(input.TimeDepositAccountSummary))
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
                if (this.CheckingAccountSummary != null)
                    hashCode = hashCode * 59 + this.CheckingAccountSummary.GetHashCode();
                if (this.SavingsAccountSummary != null)
                    hashCode = hashCode * 59 + this.SavingsAccountSummary.GetHashCode();
                if (this.CreditCardAccountSummary != null)
                    hashCode = hashCode * 59 + this.CreditCardAccountSummary.GetHashCode();
                if (this.ReadyCreditAccountSummary != null)
                    hashCode = hashCode * 59 + this.ReadyCreditAccountSummary.GetHashCode();
                if (this.LoanAccountSummary != null)
                    hashCode = hashCode * 59 + this.LoanAccountSummary.GetHashCode();
                if (this.MutualFundAccountSummary != null)
                    hashCode = hashCode * 59 + this.MutualFundAccountSummary.GetHashCode();
                if (this.SecuritiesBrokerageAccountSummary != null)
                    hashCode = hashCode * 59 + this.SecuritiesBrokerageAccountSummary.GetHashCode();
                if (this.CallDepositAccountSummary != null)
                    hashCode = hashCode * 59 + this.CallDepositAccountSummary.GetHashCode();
                if (this.PremiumDepositAccountSummary != null)
                    hashCode = hashCode * 59 + this.PremiumDepositAccountSummary.GetHashCode();
                if (this.TimeDepositAccountSummary != null)
                    hashCode = hashCode * 59 + this.TimeDepositAccountSummary.GetHashCode();
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
