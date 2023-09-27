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
    /// ApplicationAddSelfDeclaration
    /// </summary>
    [DataContract]
        public partial class ApplicationAddSelfDeclaration :  IEquatable<ApplicationAddSelfDeclaration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationAddSelfDeclaration" /> class.
        /// </summary>
        /// <param name="totalActiveCreditCardLimitAmount">Total credit limit of all the credit cards the applicant is holding.</param>
        /// <param name="anticipatedIncomeDecreaseCode">Anticipated income decrease code. Valid values: Yes and No.</param>
        /// <param name="loanTakenIndicator">To indicate if any loan is outstanding.Valid values: true and false.</param>
        /// <param name="monthlyRepaymentForAllExtLoans">Customer declaration for his/her total monthly repayment amount for all the external loans..</param>
        public ApplicationAddSelfDeclaration(double? totalActiveCreditCardLimitAmount = default(double?), string anticipatedIncomeDecreaseCode = default(string), bool? loanTakenIndicator = default(bool?), double? monthlyRepaymentForAllExtLoans = default(double?))
        {
            this.TotalActiveCreditCardLimitAmount = totalActiveCreditCardLimitAmount;
            this.AnticipatedIncomeDecreaseCode = anticipatedIncomeDecreaseCode;
            this.LoanTakenIndicator = loanTakenIndicator;
            this.MonthlyRepaymentForAllExtLoans = monthlyRepaymentForAllExtLoans;
        }
        
        /// <summary>
        /// Total credit limit of all the credit cards the applicant is holding
        /// </summary>
        /// <value>Total credit limit of all the credit cards the applicant is holding</value>
        [DataMember(Name="totalActiveCreditCardLimitAmount", EmitDefaultValue=false)]
        public double? TotalActiveCreditCardLimitAmount { get; set; }

        /// <summary>
        /// Anticipated income decrease code. Valid values: Yes and No
        /// </summary>
        /// <value>Anticipated income decrease code. Valid values: Yes and No</value>
        [DataMember(Name="anticipatedIncomeDecreaseCode", EmitDefaultValue=false)]
        public string AnticipatedIncomeDecreaseCode { get; set; }

        /// <summary>
        /// To indicate if any loan is outstanding.Valid values: true and false
        /// </summary>
        /// <value>To indicate if any loan is outstanding.Valid values: true and false</value>
        [DataMember(Name="loanTakenIndicator", EmitDefaultValue=false)]
        public bool? LoanTakenIndicator { get; set; }

        /// <summary>
        /// Customer declaration for his/her total monthly repayment amount for all the external loans.
        /// </summary>
        /// <value>Customer declaration for his/her total monthly repayment amount for all the external loans.</value>
        [DataMember(Name="monthlyRepaymentForAllExtLoans", EmitDefaultValue=false)]
        public double? MonthlyRepaymentForAllExtLoans { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationAddSelfDeclaration {\n");
            sb.Append("  TotalActiveCreditCardLimitAmount: ").Append(TotalActiveCreditCardLimitAmount).Append("\n");
            sb.Append("  AnticipatedIncomeDecreaseCode: ").Append(AnticipatedIncomeDecreaseCode).Append("\n");
            sb.Append("  LoanTakenIndicator: ").Append(LoanTakenIndicator).Append("\n");
            sb.Append("  MonthlyRepaymentForAllExtLoans: ").Append(MonthlyRepaymentForAllExtLoans).Append("\n");
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
            return this.Equals(input as ApplicationAddSelfDeclaration);
        }

        /// <summary>
        /// Returns true if ApplicationAddSelfDeclaration instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationAddSelfDeclaration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationAddSelfDeclaration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalActiveCreditCardLimitAmount == input.TotalActiveCreditCardLimitAmount ||
                    (this.TotalActiveCreditCardLimitAmount != null &&
                    this.TotalActiveCreditCardLimitAmount.Equals(input.TotalActiveCreditCardLimitAmount))
                ) && 
                (
                    this.AnticipatedIncomeDecreaseCode == input.AnticipatedIncomeDecreaseCode ||
                    (this.AnticipatedIncomeDecreaseCode != null &&
                    this.AnticipatedIncomeDecreaseCode.Equals(input.AnticipatedIncomeDecreaseCode))
                ) && 
                (
                    this.LoanTakenIndicator == input.LoanTakenIndicator ||
                    (this.LoanTakenIndicator != null &&
                    this.LoanTakenIndicator.Equals(input.LoanTakenIndicator))
                ) && 
                (
                    this.MonthlyRepaymentForAllExtLoans == input.MonthlyRepaymentForAllExtLoans ||
                    (this.MonthlyRepaymentForAllExtLoans != null &&
                    this.MonthlyRepaymentForAllExtLoans.Equals(input.MonthlyRepaymentForAllExtLoans))
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
                if (this.TotalActiveCreditCardLimitAmount != null)
                    hashCode = hashCode * 59 + this.TotalActiveCreditCardLimitAmount.GetHashCode();
                if (this.AnticipatedIncomeDecreaseCode != null)
                    hashCode = hashCode * 59 + this.AnticipatedIncomeDecreaseCode.GetHashCode();
                if (this.LoanTakenIndicator != null)
                    hashCode = hashCode * 59 + this.LoanTakenIndicator.GetHashCode();
                if (this.MonthlyRepaymentForAllExtLoans != null)
                    hashCode = hashCode * 59 + this.MonthlyRepaymentForAllExtLoans.GetHashCode();
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
