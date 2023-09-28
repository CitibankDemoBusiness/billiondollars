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
    /// InitiateCreditChargeCardFulfillmentArrangementCreditPlanEppLoanCreationRequest
    /// </summary>
    [DataContract]
        public partial class InitiateCreditChargeCardFulfillmentArrangementCreditPlanEppLoanCreationRequest :  IEquatable<InitiateCreditChargeCardFulfillmentArrangementCreditPlanEppLoanCreationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InitiateCreditChargeCardFulfillmentArrangementCreditPlanEppLoanCreationRequest" /> class.
        /// </summary>
        /// <param name="transactionId">Transaction ID of the debit card transaction for which LOP booking will be done on the credit card.</param>
        /// <param name="loanAmount">Eligible Loan amount (required).</param>
        /// <param name="loanTenor">Tenure for the Loan (required).</param>
        public InitiateCreditChargeCardFulfillmentArrangementCreditPlanEppLoanCreationRequest(string transactionId = default(string), double? loanAmount = default(double?), int? loanTenor = default(int?))
        {
            // to ensure "loanAmount" is required (not null)
            if (loanAmount == null)
            {
                throw new InvalidDataException("loanAmount is a required property for InitiateCreditChargeCardFulfillmentArrangementCreditPlanEppLoanCreationRequest and cannot be null");
            }
            else
            {
                this.LoanAmount = loanAmount;
            }
            // to ensure "loanTenor" is required (not null)
            if (loanTenor == null)
            {
                throw new InvalidDataException("loanTenor is a required property for InitiateCreditChargeCardFulfillmentArrangementCreditPlanEppLoanCreationRequest and cannot be null");
            }
            else
            {
                this.LoanTenor = loanTenor;
            }
            this.TransactionId = transactionId;
        }
        
        /// <summary>
        /// Transaction ID of the debit card transaction for which LOP booking will be done on the credit card
        /// </summary>
        /// <value>Transaction ID of the debit card transaction for which LOP booking will be done on the credit card</value>
        [DataMember(Name="transactionId", EmitDefaultValue=false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Eligible Loan amount
        /// </summary>
        /// <value>Eligible Loan amount</value>
        [DataMember(Name="loanAmount", EmitDefaultValue=false)]
        public double? LoanAmount { get; set; }

        /// <summary>
        /// Tenure for the Loan
        /// </summary>
        /// <value>Tenure for the Loan</value>
        [DataMember(Name="loanTenor", EmitDefaultValue=false)]
        public int? LoanTenor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InitiateCreditChargeCardFulfillmentArrangementCreditPlanEppLoanCreationRequest {\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  LoanAmount: ").Append(LoanAmount).Append("\n");
            sb.Append("  LoanTenor: ").Append(LoanTenor).Append("\n");
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
            return this.Equals(input as InitiateCreditChargeCardFulfillmentArrangementCreditPlanEppLoanCreationRequest);
        }

        /// <summary>
        /// Returns true if InitiateCreditChargeCardFulfillmentArrangementCreditPlanEppLoanCreationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of InitiateCreditChargeCardFulfillmentArrangementCreditPlanEppLoanCreationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InitiateCreditChargeCardFulfillmentArrangementCreditPlanEppLoanCreationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.LoanAmount == input.LoanAmount ||
                    (this.LoanAmount != null &&
                    this.LoanAmount.Equals(input.LoanAmount))
                ) && 
                (
                    this.LoanTenor == input.LoanTenor ||
                    (this.LoanTenor != null &&
                    this.LoanTenor.Equals(input.LoanTenor))
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
                if (this.TransactionId != null)
                    hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                if (this.LoanAmount != null)
                    hashCode = hashCode * 59 + this.LoanAmount.GetHashCode();
                if (this.LoanTenor != null)
                    hashCode = hashCode * 59 + this.LoanTenor.GetHashCode();
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