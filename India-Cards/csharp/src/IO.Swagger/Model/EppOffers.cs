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
    /// EppOffers
    /// </summary>
    [DataContract]
        public partial class EppOffers :  IEquatable<EppOffers>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EppOffers" /> class.
        /// </summary>
        /// <param name="tenor">Tenure of loan in months. (required).</param>
        /// <param name="effectiveInterestRate">The interest rate applicable on loan amount. (required).</param>
        /// <param name="annualPercentageRate">Interest rate for a whole year. This includes any fees or additional cost associated..</param>
        /// <param name="installmentAmount">Installment amount to be paid by customer in order to repay the loan. (required).</param>
        /// <param name="oneTimeProcessingFeeIndicator">One time processing fee indicator. Valid values : PERCENTAGE, FIXED_AMOUNT. This is a reference data field. Please use /v1/apac/utilities/referenceData/{oneTimeProcessingFeeIndicator} resource to get valid value of this field with description..</param>
        /// <param name="oneTimeProcessingFeeAmount">Fee charged as part of one time processing..</param>
        /// <param name="oneTimeProcessingFeePercentage">Percentage of one time processing fee charged..</param>
        /// <param name="offerIndicator">This is to indicate if the offer is rate/fee/hybrid based. This is a reference data field. Please use /v1/utilities/referenceData/{offerIndicator} resource to get valid value of this field with description. (required).</param>
        /// <param name="totalInterestAmount">This is the total interest amount for the loan account..</param>
        /// <param name="totalRepaymentAmount">This is the total amount to be paid back which includes principal, interest and any fees incurred..</param>
        /// <param name="monthlyServicingFeeAmount">This the applicable monthly servicing/maintenance fee for administrating the loan which is included in the monthly installment amount..</param>
        /// <param name="interestCalculationMethod">Interest calculation method. This is a reference data field. Please use /v1/utilities/referenceData/{interestCalculationMethod} resource to get valid value of this field with description..</param>
        public EppOffers(decimal? tenor = default(decimal?), double? effectiveInterestRate = default(double?), double? annualPercentageRate = default(double?), double? installmentAmount = default(double?), string oneTimeProcessingFeeIndicator = default(string), double? oneTimeProcessingFeeAmount = default(double?), double? oneTimeProcessingFeePercentage = default(double?), string offerIndicator = default(string), double? totalInterestAmount = default(double?), double? totalRepaymentAmount = default(double?), double? monthlyServicingFeeAmount = default(double?), string interestCalculationMethod = default(string))
        {
            // to ensure "tenor" is required (not null)
            if (tenor == null)
            {
                throw new InvalidDataException("tenor is a required property for EppOffers and cannot be null");
            }
            else
            {
                this.Tenor = tenor;
            }
            // to ensure "effectiveInterestRate" is required (not null)
            if (effectiveInterestRate == null)
            {
                throw new InvalidDataException("effectiveInterestRate is a required property for EppOffers and cannot be null");
            }
            else
            {
                this.EffectiveInterestRate = effectiveInterestRate;
            }
            // to ensure "installmentAmount" is required (not null)
            if (installmentAmount == null)
            {
                throw new InvalidDataException("installmentAmount is a required property for EppOffers and cannot be null");
            }
            else
            {
                this.InstallmentAmount = installmentAmount;
            }
            // to ensure "offerIndicator" is required (not null)
            if (offerIndicator == null)
            {
                throw new InvalidDataException("offerIndicator is a required property for EppOffers and cannot be null");
            }
            else
            {
                this.OfferIndicator = offerIndicator;
            }
            this.AnnualPercentageRate = annualPercentageRate;
            this.OneTimeProcessingFeeIndicator = oneTimeProcessingFeeIndicator;
            this.OneTimeProcessingFeeAmount = oneTimeProcessingFeeAmount;
            this.OneTimeProcessingFeePercentage = oneTimeProcessingFeePercentage;
            this.TotalInterestAmount = totalInterestAmount;
            this.TotalRepaymentAmount = totalRepaymentAmount;
            this.MonthlyServicingFeeAmount = monthlyServicingFeeAmount;
            this.InterestCalculationMethod = interestCalculationMethod;
        }
        
        /// <summary>
        /// Tenure of loan in months.
        /// </summary>
        /// <value>Tenure of loan in months.</value>
        [DataMember(Name="tenor", EmitDefaultValue=false)]
        public decimal? Tenor { get; set; }

        /// <summary>
        /// The interest rate applicable on loan amount.
        /// </summary>
        /// <value>The interest rate applicable on loan amount.</value>
        [DataMember(Name="effectiveInterestRate", EmitDefaultValue=false)]
        public double? EffectiveInterestRate { get; set; }

        /// <summary>
        /// Interest rate for a whole year. This includes any fees or additional cost associated.
        /// </summary>
        /// <value>Interest rate for a whole year. This includes any fees or additional cost associated.</value>
        [DataMember(Name="annualPercentageRate", EmitDefaultValue=false)]
        public double? AnnualPercentageRate { get; set; }

        /// <summary>
        /// Installment amount to be paid by customer in order to repay the loan.
        /// </summary>
        /// <value>Installment amount to be paid by customer in order to repay the loan.</value>
        [DataMember(Name="installmentAmount", EmitDefaultValue=false)]
        public double? InstallmentAmount { get; set; }

        /// <summary>
        /// One time processing fee indicator. Valid values : PERCENTAGE, FIXED_AMOUNT. This is a reference data field. Please use /v1/apac/utilities/referenceData/{oneTimeProcessingFeeIndicator} resource to get valid value of this field with description.
        /// </summary>
        /// <value>One time processing fee indicator. Valid values : PERCENTAGE, FIXED_AMOUNT. This is a reference data field. Please use /v1/apac/utilities/referenceData/{oneTimeProcessingFeeIndicator} resource to get valid value of this field with description.</value>
        [DataMember(Name="oneTimeProcessingFeeIndicator", EmitDefaultValue=false)]
        public string OneTimeProcessingFeeIndicator { get; set; }

        /// <summary>
        /// Fee charged as part of one time processing.
        /// </summary>
        /// <value>Fee charged as part of one time processing.</value>
        [DataMember(Name="oneTimeProcessingFeeAmount", EmitDefaultValue=false)]
        public double? OneTimeProcessingFeeAmount { get; set; }

        /// <summary>
        /// Percentage of one time processing fee charged.
        /// </summary>
        /// <value>Percentage of one time processing fee charged.</value>
        [DataMember(Name="oneTimeProcessingFeePercentage", EmitDefaultValue=false)]
        public double? OneTimeProcessingFeePercentage { get; set; }

        /// <summary>
        /// This is to indicate if the offer is rate/fee/hybrid based. This is a reference data field. Please use /v1/utilities/referenceData/{offerIndicator} resource to get valid value of this field with description.
        /// </summary>
        /// <value>This is to indicate if the offer is rate/fee/hybrid based. This is a reference data field. Please use /v1/utilities/referenceData/{offerIndicator} resource to get valid value of this field with description.</value>
        [DataMember(Name="offerIndicator", EmitDefaultValue=false)]
        public string OfferIndicator { get; set; }

        /// <summary>
        /// This is the total interest amount for the loan account.
        /// </summary>
        /// <value>This is the total interest amount for the loan account.</value>
        [DataMember(Name="totalInterestAmount", EmitDefaultValue=false)]
        public double? TotalInterestAmount { get; set; }

        /// <summary>
        /// This is the total amount to be paid back which includes principal, interest and any fees incurred.
        /// </summary>
        /// <value>This is the total amount to be paid back which includes principal, interest and any fees incurred.</value>
        [DataMember(Name="totalRepaymentAmount", EmitDefaultValue=false)]
        public double? TotalRepaymentAmount { get; set; }

        /// <summary>
        /// This the applicable monthly servicing/maintenance fee for administrating the loan which is included in the monthly installment amount.
        /// </summary>
        /// <value>This the applicable monthly servicing/maintenance fee for administrating the loan which is included in the monthly installment amount.</value>
        [DataMember(Name="monthlyServicingFeeAmount", EmitDefaultValue=false)]
        public double? MonthlyServicingFeeAmount { get; set; }

        /// <summary>
        /// Interest calculation method. This is a reference data field. Please use /v1/utilities/referenceData/{interestCalculationMethod} resource to get valid value of this field with description.
        /// </summary>
        /// <value>Interest calculation method. This is a reference data field. Please use /v1/utilities/referenceData/{interestCalculationMethod} resource to get valid value of this field with description.</value>
        [DataMember(Name="interestCalculationMethod", EmitDefaultValue=false)]
        public string InterestCalculationMethod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EppOffers {\n");
            sb.Append("  Tenor: ").Append(Tenor).Append("\n");
            sb.Append("  EffectiveInterestRate: ").Append(EffectiveInterestRate).Append("\n");
            sb.Append("  AnnualPercentageRate: ").Append(AnnualPercentageRate).Append("\n");
            sb.Append("  InstallmentAmount: ").Append(InstallmentAmount).Append("\n");
            sb.Append("  OneTimeProcessingFeeIndicator: ").Append(OneTimeProcessingFeeIndicator).Append("\n");
            sb.Append("  OneTimeProcessingFeeAmount: ").Append(OneTimeProcessingFeeAmount).Append("\n");
            sb.Append("  OneTimeProcessingFeePercentage: ").Append(OneTimeProcessingFeePercentage).Append("\n");
            sb.Append("  OfferIndicator: ").Append(OfferIndicator).Append("\n");
            sb.Append("  TotalInterestAmount: ").Append(TotalInterestAmount).Append("\n");
            sb.Append("  TotalRepaymentAmount: ").Append(TotalRepaymentAmount).Append("\n");
            sb.Append("  MonthlyServicingFeeAmount: ").Append(MonthlyServicingFeeAmount).Append("\n");
            sb.Append("  InterestCalculationMethod: ").Append(InterestCalculationMethod).Append("\n");
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
            return this.Equals(input as EppOffers);
        }

        /// <summary>
        /// Returns true if EppOffers instances are equal
        /// </summary>
        /// <param name="input">Instance of EppOffers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EppOffers input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Tenor == input.Tenor ||
                    (this.Tenor != null &&
                    this.Tenor.Equals(input.Tenor))
                ) && 
                (
                    this.EffectiveInterestRate == input.EffectiveInterestRate ||
                    (this.EffectiveInterestRate != null &&
                    this.EffectiveInterestRate.Equals(input.EffectiveInterestRate))
                ) && 
                (
                    this.AnnualPercentageRate == input.AnnualPercentageRate ||
                    (this.AnnualPercentageRate != null &&
                    this.AnnualPercentageRate.Equals(input.AnnualPercentageRate))
                ) && 
                (
                    this.InstallmentAmount == input.InstallmentAmount ||
                    (this.InstallmentAmount != null &&
                    this.InstallmentAmount.Equals(input.InstallmentAmount))
                ) && 
                (
                    this.OneTimeProcessingFeeIndicator == input.OneTimeProcessingFeeIndicator ||
                    (this.OneTimeProcessingFeeIndicator != null &&
                    this.OneTimeProcessingFeeIndicator.Equals(input.OneTimeProcessingFeeIndicator))
                ) && 
                (
                    this.OneTimeProcessingFeeAmount == input.OneTimeProcessingFeeAmount ||
                    (this.OneTimeProcessingFeeAmount != null &&
                    this.OneTimeProcessingFeeAmount.Equals(input.OneTimeProcessingFeeAmount))
                ) && 
                (
                    this.OneTimeProcessingFeePercentage == input.OneTimeProcessingFeePercentage ||
                    (this.OneTimeProcessingFeePercentage != null &&
                    this.OneTimeProcessingFeePercentage.Equals(input.OneTimeProcessingFeePercentage))
                ) && 
                (
                    this.OfferIndicator == input.OfferIndicator ||
                    (this.OfferIndicator != null &&
                    this.OfferIndicator.Equals(input.OfferIndicator))
                ) && 
                (
                    this.TotalInterestAmount == input.TotalInterestAmount ||
                    (this.TotalInterestAmount != null &&
                    this.TotalInterestAmount.Equals(input.TotalInterestAmount))
                ) && 
                (
                    this.TotalRepaymentAmount == input.TotalRepaymentAmount ||
                    (this.TotalRepaymentAmount != null &&
                    this.TotalRepaymentAmount.Equals(input.TotalRepaymentAmount))
                ) && 
                (
                    this.MonthlyServicingFeeAmount == input.MonthlyServicingFeeAmount ||
                    (this.MonthlyServicingFeeAmount != null &&
                    this.MonthlyServicingFeeAmount.Equals(input.MonthlyServicingFeeAmount))
                ) && 
                (
                    this.InterestCalculationMethod == input.InterestCalculationMethod ||
                    (this.InterestCalculationMethod != null &&
                    this.InterestCalculationMethod.Equals(input.InterestCalculationMethod))
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
                if (this.Tenor != null)
                    hashCode = hashCode * 59 + this.Tenor.GetHashCode();
                if (this.EffectiveInterestRate != null)
                    hashCode = hashCode * 59 + this.EffectiveInterestRate.GetHashCode();
                if (this.AnnualPercentageRate != null)
                    hashCode = hashCode * 59 + this.AnnualPercentageRate.GetHashCode();
                if (this.InstallmentAmount != null)
                    hashCode = hashCode * 59 + this.InstallmentAmount.GetHashCode();
                if (this.OneTimeProcessingFeeIndicator != null)
                    hashCode = hashCode * 59 + this.OneTimeProcessingFeeIndicator.GetHashCode();
                if (this.OneTimeProcessingFeeAmount != null)
                    hashCode = hashCode * 59 + this.OneTimeProcessingFeeAmount.GetHashCode();
                if (this.OneTimeProcessingFeePercentage != null)
                    hashCode = hashCode * 59 + this.OneTimeProcessingFeePercentage.GetHashCode();
                if (this.OfferIndicator != null)
                    hashCode = hashCode * 59 + this.OfferIndicator.GetHashCode();
                if (this.TotalInterestAmount != null)
                    hashCode = hashCode * 59 + this.TotalInterestAmount.GetHashCode();
                if (this.TotalRepaymentAmount != null)
                    hashCode = hashCode * 59 + this.TotalRepaymentAmount.GetHashCode();
                if (this.MonthlyServicingFeeAmount != null)
                    hashCode = hashCode * 59 + this.MonthlyServicingFeeAmount.GetHashCode();
                if (this.InterestCalculationMethod != null)
                    hashCode = hashCode * 59 + this.InterestCalculationMethod.GetHashCode();
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
