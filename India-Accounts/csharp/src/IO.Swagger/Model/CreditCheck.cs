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
    /// CreditCheck
    /// </summary>
    [DataContract]
        public partial class CreditCheck :  IEquatable<CreditCheck>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditCheck" /> class.
        /// </summary>
        /// <param name="tenor">Tenure of loan in months. (required).</param>
        /// <param name="maximumEligibleLoanAmount">Maximum Eligible Loan amount corresponding to each tenure. (required).</param>
        /// <param name="annualPercentageRate">Compounded annual interest rate..</param>
        public CreditCheck(decimal? tenor = default(decimal?), double? maximumEligibleLoanAmount = default(double?), double? annualPercentageRate = default(double?))
        {
            // to ensure "tenor" is required (not null)
            if (tenor == null)
            {
                throw new InvalidDataException("tenor is a required property for CreditCheck and cannot be null");
            }
            else
            {
                this.Tenor = tenor;
            }
            // to ensure "maximumEligibleLoanAmount" is required (not null)
            if (maximumEligibleLoanAmount == null)
            {
                throw new InvalidDataException("maximumEligibleLoanAmount is a required property for CreditCheck and cannot be null");
            }
            else
            {
                this.MaximumEligibleLoanAmount = maximumEligibleLoanAmount;
            }
            this.AnnualPercentageRate = annualPercentageRate;
        }
        
        /// <summary>
        /// Tenure of loan in months.
        /// </summary>
        /// <value>Tenure of loan in months.</value>
        [DataMember(Name="tenor", EmitDefaultValue=false)]
        public decimal? Tenor { get; set; }

        /// <summary>
        /// Maximum Eligible Loan amount corresponding to each tenure.
        /// </summary>
        /// <value>Maximum Eligible Loan amount corresponding to each tenure.</value>
        [DataMember(Name="maximumEligibleLoanAmount", EmitDefaultValue=false)]
        public double? MaximumEligibleLoanAmount { get; set; }

        /// <summary>
        /// Compounded annual interest rate.
        /// </summary>
        /// <value>Compounded annual interest rate.</value>
        [DataMember(Name="annualPercentageRate", EmitDefaultValue=false)]
        public double? AnnualPercentageRate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreditCheck {\n");
            sb.Append("  Tenor: ").Append(Tenor).Append("\n");
            sb.Append("  MaximumEligibleLoanAmount: ").Append(MaximumEligibleLoanAmount).Append("\n");
            sb.Append("  AnnualPercentageRate: ").Append(AnnualPercentageRate).Append("\n");
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
            return this.Equals(input as CreditCheck);
        }

        /// <summary>
        /// Returns true if CreditCheck instances are equal
        /// </summary>
        /// <param name="input">Instance of CreditCheck to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreditCheck input)
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
                    this.MaximumEligibleLoanAmount == input.MaximumEligibleLoanAmount ||
                    (this.MaximumEligibleLoanAmount != null &&
                    this.MaximumEligibleLoanAmount.Equals(input.MaximumEligibleLoanAmount))
                ) && 
                (
                    this.AnnualPercentageRate == input.AnnualPercentageRate ||
                    (this.AnnualPercentageRate != null &&
                    this.AnnualPercentageRate.Equals(input.AnnualPercentageRate))
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
                if (this.MaximumEligibleLoanAmount != null)
                    hashCode = hashCode * 59 + this.MaximumEligibleLoanAmount.GetHashCode();
                if (this.AnnualPercentageRate != null)
                    hashCode = hashCode * 59 + this.AnnualPercentageRate.GetHashCode();
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