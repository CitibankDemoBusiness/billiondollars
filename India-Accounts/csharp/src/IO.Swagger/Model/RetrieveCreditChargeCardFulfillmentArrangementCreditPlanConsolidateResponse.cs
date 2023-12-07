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
    /// RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse
    /// </summary>
    [DataContract]
        public partial class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse :  IEquatable<RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse" /> class.
        /// </summary>
        /// <param name="newLoanReferenceId">Unique refrence number associated with the loan. (required).</param>
        /// <param name="nextInstallmentAmount">Amount of money borrower has to pay as next installment..</param>
        /// <param name="nextInstallmentPrincipalAmount">Amount of money that contributes to principal component in next installment..</param>
        /// <param name="interestRate">Rate of Interest.Interest rate is the amount charged, expressed as a percentage of principal, by a lender to a borrower for the use of assets. Interest rates are typically noted on an annual basis, known as the annual percentage rate (APR)..</param>
        /// <param name="totalInterestAmount">Total amount of money that a borrower will have to pay as interest for amount borrowed..</param>
        /// <param name="loanBookingFee">Amount to be paid as fee for loan booking..</param>
        public RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse(string newLoanReferenceId = default(string), double? nextInstallmentAmount = default(double?), double? nextInstallmentPrincipalAmount = default(double?), double? interestRate = default(double?), double? totalInterestAmount = default(double?), double? loanBookingFee = default(double?))
        {
            // to ensure "newLoanReferenceId" is required (not null)
            if (newLoanReferenceId == null)
            {
                throw new InvalidDataException("newLoanReferenceId is a required property for RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse and cannot be null");
            }
            else
            {
                this.NewLoanReferenceId = newLoanReferenceId;
            }
            this.NextInstallmentAmount = nextInstallmentAmount;
            this.NextInstallmentPrincipalAmount = nextInstallmentPrincipalAmount;
            this.InterestRate = interestRate;
            this.TotalInterestAmount = totalInterestAmount;
            this.LoanBookingFee = loanBookingFee;
        }
        
        /// <summary>
        /// Unique refrence number associated with the loan.
        /// </summary>
        /// <value>Unique refrence number associated with the loan.</value>
        [DataMember(Name="newLoanReferenceId", EmitDefaultValue=false)]
        public string NewLoanReferenceId { get; set; }

        /// <summary>
        /// Amount of money borrower has to pay as next installment.
        /// </summary>
        /// <value>Amount of money borrower has to pay as next installment.</value>
        [DataMember(Name="nextInstallmentAmount", EmitDefaultValue=false)]
        public double? NextInstallmentAmount { get; set; }

        /// <summary>
        /// Amount of money that contributes to principal component in next installment.
        /// </summary>
        /// <value>Amount of money that contributes to principal component in next installment.</value>
        [DataMember(Name="nextInstallmentPrincipalAmount", EmitDefaultValue=false)]
        public double? NextInstallmentPrincipalAmount { get; set; }

        /// <summary>
        /// Rate of Interest.Interest rate is the amount charged, expressed as a percentage of principal, by a lender to a borrower for the use of assets. Interest rates are typically noted on an annual basis, known as the annual percentage rate (APR).
        /// </summary>
        /// <value>Rate of Interest.Interest rate is the amount charged, expressed as a percentage of principal, by a lender to a borrower for the use of assets. Interest rates are typically noted on an annual basis, known as the annual percentage rate (APR).</value>
        [DataMember(Name="interestRate", EmitDefaultValue=false)]
        public double? InterestRate { get; set; }

        /// <summary>
        /// Total amount of money that a borrower will have to pay as interest for amount borrowed.
        /// </summary>
        /// <value>Total amount of money that a borrower will have to pay as interest for amount borrowed.</value>
        [DataMember(Name="totalInterestAmount", EmitDefaultValue=false)]
        public double? TotalInterestAmount { get; set; }

        /// <summary>
        /// Amount to be paid as fee for loan booking.
        /// </summary>
        /// <value>Amount to be paid as fee for loan booking.</value>
        [DataMember(Name="loanBookingFee", EmitDefaultValue=false)]
        public double? LoanBookingFee { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse {\n");
            sb.Append("  NewLoanReferenceId: ").Append(NewLoanReferenceId).Append("\n");
            sb.Append("  NextInstallmentAmount: ").Append(NextInstallmentAmount).Append("\n");
            sb.Append("  NextInstallmentPrincipalAmount: ").Append(NextInstallmentPrincipalAmount).Append("\n");
            sb.Append("  InterestRate: ").Append(InterestRate).Append("\n");
            sb.Append("  TotalInterestAmount: ").Append(TotalInterestAmount).Append("\n");
            sb.Append("  LoanBookingFee: ").Append(LoanBookingFee).Append("\n");
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
            return this.Equals(input as RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse);
        }

        /// <summary>
        /// Returns true if RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NewLoanReferenceId == input.NewLoanReferenceId ||
                    (this.NewLoanReferenceId != null &&
                    this.NewLoanReferenceId.Equals(input.NewLoanReferenceId))
                ) && 
                (
                    this.NextInstallmentAmount == input.NextInstallmentAmount ||
                    (this.NextInstallmentAmount != null &&
                    this.NextInstallmentAmount.Equals(input.NextInstallmentAmount))
                ) && 
                (
                    this.NextInstallmentPrincipalAmount == input.NextInstallmentPrincipalAmount ||
                    (this.NextInstallmentPrincipalAmount != null &&
                    this.NextInstallmentPrincipalAmount.Equals(input.NextInstallmentPrincipalAmount))
                ) && 
                (
                    this.InterestRate == input.InterestRate ||
                    (this.InterestRate != null &&
                    this.InterestRate.Equals(input.InterestRate))
                ) && 
                (
                    this.TotalInterestAmount == input.TotalInterestAmount ||
                    (this.TotalInterestAmount != null &&
                    this.TotalInterestAmount.Equals(input.TotalInterestAmount))
                ) && 
                (
                    this.LoanBookingFee == input.LoanBookingFee ||
                    (this.LoanBookingFee != null &&
                    this.LoanBookingFee.Equals(input.LoanBookingFee))
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
                if (this.NewLoanReferenceId != null)
                    hashCode = hashCode * 59 + this.NewLoanReferenceId.GetHashCode();
                if (this.NextInstallmentAmount != null)
                    hashCode = hashCode * 59 + this.NextInstallmentAmount.GetHashCode();
                if (this.NextInstallmentPrincipalAmount != null)
                    hashCode = hashCode * 59 + this.NextInstallmentPrincipalAmount.GetHashCode();
                if (this.InterestRate != null)
                    hashCode = hashCode * 59 + this.InterestRate.GetHashCode();
                if (this.TotalInterestAmount != null)
                    hashCode = hashCode * 59 + this.TotalInterestAmount.GetHashCode();
                if (this.LoanBookingFee != null)
                    hashCode = hashCode * 59 + this.LoanBookingFee.GetHashCode();
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
