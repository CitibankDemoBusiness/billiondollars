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
    /// ApplicationUpdateFinancialInformation
    /// </summary>
    [DataContract]
        public partial class ApplicationUpdateFinancialInformation :  IEquatable<ApplicationUpdateFinancialInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationUpdateFinancialInformation" /> class.
        /// </summary>
        /// <param name="hasForeseeableFinancialChanges">Indicates whether any foreseeable changes in customer&#x27;s financial circumstances..</param>
        /// <param name="nonBankDebtObligationFlag">Indicates if the applicant has any loan with any non-banking financial organization..</param>
        /// <param name="expenseDetails">expenseDetails.</param>
        /// <param name="incomeDetails">incomeDetails.</param>
        /// <param name="existingLoanDetails">existingLoanDetails.</param>
        public ApplicationUpdateFinancialInformation(bool? hasForeseeableFinancialChanges = default(bool?), bool? nonBankDebtObligationFlag = default(bool?), List<ApplicationUpdateExpenseDetails> expenseDetails = default(List<ApplicationUpdateExpenseDetails>), List<ApplicationUpdateIncomeDetails> incomeDetails = default(List<ApplicationUpdateIncomeDetails>), List<ApplicationUpdateExistingLoanDetails> existingLoanDetails = default(List<ApplicationUpdateExistingLoanDetails>))
        {
            this.HasForeseeableFinancialChanges = hasForeseeableFinancialChanges;
            this.NonBankDebtObligationFlag = nonBankDebtObligationFlag;
            this.ExpenseDetails = expenseDetails;
            this.IncomeDetails = incomeDetails;
            this.ExistingLoanDetails = existingLoanDetails;
        }
        
        /// <summary>
        /// Indicates whether any foreseeable changes in customer&#x27;s financial circumstances.
        /// </summary>
        /// <value>Indicates whether any foreseeable changes in customer&#x27;s financial circumstances.</value>
        [DataMember(Name="hasForeseeableFinancialChanges", EmitDefaultValue=false)]
        public bool? HasForeseeableFinancialChanges { get; set; }

        /// <summary>
        /// Indicates if the applicant has any loan with any non-banking financial organization.
        /// </summary>
        /// <value>Indicates if the applicant has any loan with any non-banking financial organization.</value>
        [DataMember(Name="nonBankDebtObligationFlag", EmitDefaultValue=false)]
        public bool? NonBankDebtObligationFlag { get; set; }

        /// <summary>
        /// Gets or Sets ExpenseDetails
        /// </summary>
        [DataMember(Name="expenseDetails", EmitDefaultValue=false)]
        public List<ApplicationUpdateExpenseDetails> ExpenseDetails { get; set; }

        /// <summary>
        /// Gets or Sets IncomeDetails
        /// </summary>
        [DataMember(Name="incomeDetails", EmitDefaultValue=false)]
        public List<ApplicationUpdateIncomeDetails> IncomeDetails { get; set; }

        /// <summary>
        /// Gets or Sets ExistingLoanDetails
        /// </summary>
        [DataMember(Name="existingLoanDetails", EmitDefaultValue=false)]
        public List<ApplicationUpdateExistingLoanDetails> ExistingLoanDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationUpdateFinancialInformation {\n");
            sb.Append("  HasForeseeableFinancialChanges: ").Append(HasForeseeableFinancialChanges).Append("\n");
            sb.Append("  NonBankDebtObligationFlag: ").Append(NonBankDebtObligationFlag).Append("\n");
            sb.Append("  ExpenseDetails: ").Append(ExpenseDetails).Append("\n");
            sb.Append("  IncomeDetails: ").Append(IncomeDetails).Append("\n");
            sb.Append("  ExistingLoanDetails: ").Append(ExistingLoanDetails).Append("\n");
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
            return this.Equals(input as ApplicationUpdateFinancialInformation);
        }

        /// <summary>
        /// Returns true if ApplicationUpdateFinancialInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationUpdateFinancialInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationUpdateFinancialInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HasForeseeableFinancialChanges == input.HasForeseeableFinancialChanges ||
                    (this.HasForeseeableFinancialChanges != null &&
                    this.HasForeseeableFinancialChanges.Equals(input.HasForeseeableFinancialChanges))
                ) && 
                (
                    this.NonBankDebtObligationFlag == input.NonBankDebtObligationFlag ||
                    (this.NonBankDebtObligationFlag != null &&
                    this.NonBankDebtObligationFlag.Equals(input.NonBankDebtObligationFlag))
                ) && 
                (
                    this.ExpenseDetails == input.ExpenseDetails ||
                    this.ExpenseDetails != null &&
                    input.ExpenseDetails != null &&
                    this.ExpenseDetails.SequenceEqual(input.ExpenseDetails)
                ) && 
                (
                    this.IncomeDetails == input.IncomeDetails ||
                    this.IncomeDetails != null &&
                    input.IncomeDetails != null &&
                    this.IncomeDetails.SequenceEqual(input.IncomeDetails)
                ) && 
                (
                    this.ExistingLoanDetails == input.ExistingLoanDetails ||
                    this.ExistingLoanDetails != null &&
                    input.ExistingLoanDetails != null &&
                    this.ExistingLoanDetails.SequenceEqual(input.ExistingLoanDetails)
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
                if (this.HasForeseeableFinancialChanges != null)
                    hashCode = hashCode * 59 + this.HasForeseeableFinancialChanges.GetHashCode();
                if (this.NonBankDebtObligationFlag != null)
                    hashCode = hashCode * 59 + this.NonBankDebtObligationFlag.GetHashCode();
                if (this.ExpenseDetails != null)
                    hashCode = hashCode * 59 + this.ExpenseDetails.GetHashCode();
                if (this.IncomeDetails != null)
                    hashCode = hashCode * 59 + this.IncomeDetails.GetHashCode();
                if (this.ExistingLoanDetails != null)
                    hashCode = hashCode * 59 + this.ExistingLoanDetails.GetHashCode();
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
