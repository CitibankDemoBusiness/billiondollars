/* 
 * Onboarding
 *
 * The Onboarding API allows you to initiate the basic account opening process for new customers. The resources allow you to present eligible products, send applications for screening and submit a new application for one or more products. The resources also allow you to submit supporting documents. Application status can be checked at any point in the process, with decisioning happening in real time.
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
    /// ApplicationInquiryLoanSpecificRecommendations
    /// </summary>
    [DataContract]
        public partial class ApplicationInquiryLoanSpecificRecommendations :  IEquatable<ApplicationInquiryLoanSpecificRecommendations>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationInquiryLoanSpecificRecommendations" /> class.
        /// </summary>
        /// <param name="loanAmount">Recommended loan amount..</param>
        /// <param name="tenor">Tenor for the loan repayment.This is a reference data field. Please use /v1/apac/utilities/referenceData/{tenor} resource to get valid values of this field with descriptions..</param>
        /// <param name="interestRate">The rate of interest applicable for the product.</param>
        /// <param name="handlingFee">One-time processing fee..</param>
        /// <param name="installmentAmount">Instalment amount to be paid..</param>
        /// <param name="annualPercentageRate">Applicable Annual Percentage Rate.</param>
        /// <param name="totalPrincipalAmount">Total principal to be paid by customer.</param>
        /// <param name="totalInterestAmount">Total interest amount to be paid by applicant..</param>
        /// <param name="totalInstallmentAmount">Total instalment amount to be paid by customer.</param>
        /// <param name="repaymentScheduleIssueDate">Repayment schedule start date in ISO 8601 date format YYYY-MM-DD.</param>
        /// <param name="repaymentSchedule">repaymentSchedule.</param>
        public ApplicationInquiryLoanSpecificRecommendations(double? loanAmount = default(double?), string tenor = default(string), double? interestRate = default(double?), double? handlingFee = default(double?), double? installmentAmount = default(double?), double? annualPercentageRate = default(double?), double? totalPrincipalAmount = default(double?), double? totalInterestAmount = default(double?), double? totalInstallmentAmount = default(double?), DateTime? repaymentScheduleIssueDate = default(DateTime?), List<ApplicationInquiryRepaymentSchedule> repaymentSchedule = default(List<ApplicationInquiryRepaymentSchedule>))
        {
            this.LoanAmount = loanAmount;
            this.Tenor = tenor;
            this.InterestRate = interestRate;
            this.HandlingFee = handlingFee;
            this.InstallmentAmount = installmentAmount;
            this.AnnualPercentageRate = annualPercentageRate;
            this.TotalPrincipalAmount = totalPrincipalAmount;
            this.TotalInterestAmount = totalInterestAmount;
            this.TotalInstallmentAmount = totalInstallmentAmount;
            this.RepaymentScheduleIssueDate = repaymentScheduleIssueDate;
            this.RepaymentSchedule = repaymentSchedule;
        }
        
        /// <summary>
        /// Recommended loan amount.
        /// </summary>
        /// <value>Recommended loan amount.</value>
        [DataMember(Name="loanAmount", EmitDefaultValue=false)]
        public double? LoanAmount { get; set; }

        /// <summary>
        /// Tenor for the loan repayment.This is a reference data field. Please use /v1/apac/utilities/referenceData/{tenor} resource to get valid values of this field with descriptions.
        /// </summary>
        /// <value>Tenor for the loan repayment.This is a reference data field. Please use /v1/apac/utilities/referenceData/{tenor} resource to get valid values of this field with descriptions.</value>
        [DataMember(Name="tenor", EmitDefaultValue=false)]
        public string Tenor { get; set; }

        /// <summary>
        /// The rate of interest applicable for the product
        /// </summary>
        /// <value>The rate of interest applicable for the product</value>
        [DataMember(Name="interestRate", EmitDefaultValue=false)]
        public double? InterestRate { get; set; }

        /// <summary>
        /// One-time processing fee.
        /// </summary>
        /// <value>One-time processing fee.</value>
        [DataMember(Name="handlingFee", EmitDefaultValue=false)]
        public double? HandlingFee { get; set; }

        /// <summary>
        /// Instalment amount to be paid.
        /// </summary>
        /// <value>Instalment amount to be paid.</value>
        [DataMember(Name="installmentAmount", EmitDefaultValue=false)]
        public double? InstallmentAmount { get; set; }

        /// <summary>
        /// Applicable Annual Percentage Rate
        /// </summary>
        /// <value>Applicable Annual Percentage Rate</value>
        [DataMember(Name="annualPercentageRate", EmitDefaultValue=false)]
        public double? AnnualPercentageRate { get; set; }

        /// <summary>
        /// Total principal to be paid by customer
        /// </summary>
        /// <value>Total principal to be paid by customer</value>
        [DataMember(Name="totalPrincipalAmount", EmitDefaultValue=false)]
        public double? TotalPrincipalAmount { get; set; }

        /// <summary>
        /// Total interest amount to be paid by applicant.
        /// </summary>
        /// <value>Total interest amount to be paid by applicant.</value>
        [DataMember(Name="totalInterestAmount", EmitDefaultValue=false)]
        public double? TotalInterestAmount { get; set; }

        /// <summary>
        /// Total instalment amount to be paid by customer
        /// </summary>
        /// <value>Total instalment amount to be paid by customer</value>
        [DataMember(Name="totalInstallmentAmount", EmitDefaultValue=false)]
        public double? TotalInstallmentAmount { get; set; }

        /// <summary>
        /// Repayment schedule start date in ISO 8601 date format YYYY-MM-DD
        /// </summary>
        /// <value>Repayment schedule start date in ISO 8601 date format YYYY-MM-DD</value>
        [DataMember(Name="repaymentScheduleIssueDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? RepaymentScheduleIssueDate { get; set; }

        /// <summary>
        /// Gets or Sets RepaymentSchedule
        /// </summary>
        [DataMember(Name="repaymentSchedule", EmitDefaultValue=false)]
        public List<ApplicationInquiryRepaymentSchedule> RepaymentSchedule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationInquiryLoanSpecificRecommendations {\n");
            sb.Append("  LoanAmount: ").Append(LoanAmount).Append("\n");
            sb.Append("  Tenor: ").Append(Tenor).Append("\n");
            sb.Append("  InterestRate: ").Append(InterestRate).Append("\n");
            sb.Append("  HandlingFee: ").Append(HandlingFee).Append("\n");
            sb.Append("  InstallmentAmount: ").Append(InstallmentAmount).Append("\n");
            sb.Append("  AnnualPercentageRate: ").Append(AnnualPercentageRate).Append("\n");
            sb.Append("  TotalPrincipalAmount: ").Append(TotalPrincipalAmount).Append("\n");
            sb.Append("  TotalInterestAmount: ").Append(TotalInterestAmount).Append("\n");
            sb.Append("  TotalInstallmentAmount: ").Append(TotalInstallmentAmount).Append("\n");
            sb.Append("  RepaymentScheduleIssueDate: ").Append(RepaymentScheduleIssueDate).Append("\n");
            sb.Append("  RepaymentSchedule: ").Append(RepaymentSchedule).Append("\n");
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
            return this.Equals(input as ApplicationInquiryLoanSpecificRecommendations);
        }

        /// <summary>
        /// Returns true if ApplicationInquiryLoanSpecificRecommendations instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationInquiryLoanSpecificRecommendations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationInquiryLoanSpecificRecommendations input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LoanAmount == input.LoanAmount ||
                    (this.LoanAmount != null &&
                    this.LoanAmount.Equals(input.LoanAmount))
                ) && 
                (
                    this.Tenor == input.Tenor ||
                    (this.Tenor != null &&
                    this.Tenor.Equals(input.Tenor))
                ) && 
                (
                    this.InterestRate == input.InterestRate ||
                    (this.InterestRate != null &&
                    this.InterestRate.Equals(input.InterestRate))
                ) && 
                (
                    this.HandlingFee == input.HandlingFee ||
                    (this.HandlingFee != null &&
                    this.HandlingFee.Equals(input.HandlingFee))
                ) && 
                (
                    this.InstallmentAmount == input.InstallmentAmount ||
                    (this.InstallmentAmount != null &&
                    this.InstallmentAmount.Equals(input.InstallmentAmount))
                ) && 
                (
                    this.AnnualPercentageRate == input.AnnualPercentageRate ||
                    (this.AnnualPercentageRate != null &&
                    this.AnnualPercentageRate.Equals(input.AnnualPercentageRate))
                ) && 
                (
                    this.TotalPrincipalAmount == input.TotalPrincipalAmount ||
                    (this.TotalPrincipalAmount != null &&
                    this.TotalPrincipalAmount.Equals(input.TotalPrincipalAmount))
                ) && 
                (
                    this.TotalInterestAmount == input.TotalInterestAmount ||
                    (this.TotalInterestAmount != null &&
                    this.TotalInterestAmount.Equals(input.TotalInterestAmount))
                ) && 
                (
                    this.TotalInstallmentAmount == input.TotalInstallmentAmount ||
                    (this.TotalInstallmentAmount != null &&
                    this.TotalInstallmentAmount.Equals(input.TotalInstallmentAmount))
                ) && 
                (
                    this.RepaymentScheduleIssueDate == input.RepaymentScheduleIssueDate ||
                    (this.RepaymentScheduleIssueDate != null &&
                    this.RepaymentScheduleIssueDate.Equals(input.RepaymentScheduleIssueDate))
                ) && 
                (
                    this.RepaymentSchedule == input.RepaymentSchedule ||
                    this.RepaymentSchedule != null &&
                    input.RepaymentSchedule != null &&
                    this.RepaymentSchedule.SequenceEqual(input.RepaymentSchedule)
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
                if (this.LoanAmount != null)
                    hashCode = hashCode * 59 + this.LoanAmount.GetHashCode();
                if (this.Tenor != null)
                    hashCode = hashCode * 59 + this.Tenor.GetHashCode();
                if (this.InterestRate != null)
                    hashCode = hashCode * 59 + this.InterestRate.GetHashCode();
                if (this.HandlingFee != null)
                    hashCode = hashCode * 59 + this.HandlingFee.GetHashCode();
                if (this.InstallmentAmount != null)
                    hashCode = hashCode * 59 + this.InstallmentAmount.GetHashCode();
                if (this.AnnualPercentageRate != null)
                    hashCode = hashCode * 59 + this.AnnualPercentageRate.GetHashCode();
                if (this.TotalPrincipalAmount != null)
                    hashCode = hashCode * 59 + this.TotalPrincipalAmount.GetHashCode();
                if (this.TotalInterestAmount != null)
                    hashCode = hashCode * 59 + this.TotalInterestAmount.GetHashCode();
                if (this.TotalInstallmentAmount != null)
                    hashCode = hashCode * 59 + this.TotalInstallmentAmount.GetHashCode();
                if (this.RepaymentScheduleIssueDate != null)
                    hashCode = hashCode * 59 + this.RepaymentScheduleIssueDate.GetHashCode();
                if (this.RepaymentSchedule != null)
                    hashCode = hashCode * 59 + this.RepaymentSchedule.GetHashCode();
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
