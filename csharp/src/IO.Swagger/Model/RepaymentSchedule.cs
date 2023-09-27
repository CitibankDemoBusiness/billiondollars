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
    /// RepaymentSchedule
    /// </summary>
    [DataContract]
        public partial class RepaymentSchedule :  IEquatable<RepaymentSchedule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RepaymentSchedule" /> class.
        /// </summary>
        /// <param name="tenorOccurence">Different tenor applicable for repayment.</param>
        /// <param name="paymentDueDate">Payment due date for each instalment in ISO 8601 date format YYYY-MM-DD.</param>
        /// <param name="monthlyInstallmentAmount">Monthly instalment amount for loan taken.</param>
        /// <param name="principalAmount">Principal amount of instalment.</param>
        /// <param name="interestAmount">Interest amount of instalment.</param>
        /// <param name="remainingPrincipalAmount">Remaining Principal Amount after each instalment has been paid by customer.</param>
        public RepaymentSchedule(string tenorOccurence = default(string), DateTime? paymentDueDate = default(DateTime?), double? monthlyInstallmentAmount = default(double?), double? principalAmount = default(double?), double? interestAmount = default(double?), double? remainingPrincipalAmount = default(double?))
        {
            this.TenorOccurence = tenorOccurence;
            this.PaymentDueDate = paymentDueDate;
            this.MonthlyInstallmentAmount = monthlyInstallmentAmount;
            this.PrincipalAmount = principalAmount;
            this.InterestAmount = interestAmount;
            this.RemainingPrincipalAmount = remainingPrincipalAmount;
        }
        
        /// <summary>
        /// Different tenor applicable for repayment
        /// </summary>
        /// <value>Different tenor applicable for repayment</value>
        [DataMember(Name="tenorOccurence", EmitDefaultValue=false)]
        public string TenorOccurence { get; set; }

        /// <summary>
        /// Payment due date for each instalment in ISO 8601 date format YYYY-MM-DD
        /// </summary>
        /// <value>Payment due date for each instalment in ISO 8601 date format YYYY-MM-DD</value>
        [DataMember(Name="paymentDueDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? PaymentDueDate { get; set; }

        /// <summary>
        /// Monthly instalment amount for loan taken
        /// </summary>
        /// <value>Monthly instalment amount for loan taken</value>
        [DataMember(Name="monthlyInstallmentAmount", EmitDefaultValue=false)]
        public double? MonthlyInstallmentAmount { get; set; }

        /// <summary>
        /// Principal amount of instalment
        /// </summary>
        /// <value>Principal amount of instalment</value>
        [DataMember(Name="principalAmount", EmitDefaultValue=false)]
        public double? PrincipalAmount { get; set; }

        /// <summary>
        /// Interest amount of instalment
        /// </summary>
        /// <value>Interest amount of instalment</value>
        [DataMember(Name="interestAmount", EmitDefaultValue=false)]
        public double? InterestAmount { get; set; }

        /// <summary>
        /// Remaining Principal Amount after each instalment has been paid by customer
        /// </summary>
        /// <value>Remaining Principal Amount after each instalment has been paid by customer</value>
        [DataMember(Name="remainingPrincipalAmount", EmitDefaultValue=false)]
        public double? RemainingPrincipalAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepaymentSchedule {\n");
            sb.Append("  TenorOccurence: ").Append(TenorOccurence).Append("\n");
            sb.Append("  PaymentDueDate: ").Append(PaymentDueDate).Append("\n");
            sb.Append("  MonthlyInstallmentAmount: ").Append(MonthlyInstallmentAmount).Append("\n");
            sb.Append("  PrincipalAmount: ").Append(PrincipalAmount).Append("\n");
            sb.Append("  InterestAmount: ").Append(InterestAmount).Append("\n");
            sb.Append("  RemainingPrincipalAmount: ").Append(RemainingPrincipalAmount).Append("\n");
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
            return this.Equals(input as RepaymentSchedule);
        }

        /// <summary>
        /// Returns true if RepaymentSchedule instances are equal
        /// </summary>
        /// <param name="input">Instance of RepaymentSchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RepaymentSchedule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TenorOccurence == input.TenorOccurence ||
                    (this.TenorOccurence != null &&
                    this.TenorOccurence.Equals(input.TenorOccurence))
                ) && 
                (
                    this.PaymentDueDate == input.PaymentDueDate ||
                    (this.PaymentDueDate != null &&
                    this.PaymentDueDate.Equals(input.PaymentDueDate))
                ) && 
                (
                    this.MonthlyInstallmentAmount == input.MonthlyInstallmentAmount ||
                    (this.MonthlyInstallmentAmount != null &&
                    this.MonthlyInstallmentAmount.Equals(input.MonthlyInstallmentAmount))
                ) && 
                (
                    this.PrincipalAmount == input.PrincipalAmount ||
                    (this.PrincipalAmount != null &&
                    this.PrincipalAmount.Equals(input.PrincipalAmount))
                ) && 
                (
                    this.InterestAmount == input.InterestAmount ||
                    (this.InterestAmount != null &&
                    this.InterestAmount.Equals(input.InterestAmount))
                ) && 
                (
                    this.RemainingPrincipalAmount == input.RemainingPrincipalAmount ||
                    (this.RemainingPrincipalAmount != null &&
                    this.RemainingPrincipalAmount.Equals(input.RemainingPrincipalAmount))
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
                if (this.TenorOccurence != null)
                    hashCode = hashCode * 59 + this.TenorOccurence.GetHashCode();
                if (this.PaymentDueDate != null)
                    hashCode = hashCode * 59 + this.PaymentDueDate.GetHashCode();
                if (this.MonthlyInstallmentAmount != null)
                    hashCode = hashCode * 59 + this.MonthlyInstallmentAmount.GetHashCode();
                if (this.PrincipalAmount != null)
                    hashCode = hashCode * 59 + this.PrincipalAmount.GetHashCode();
                if (this.InterestAmount != null)
                    hashCode = hashCode * 59 + this.InterestAmount.GetHashCode();
                if (this.RemainingPrincipalAmount != null)
                    hashCode = hashCode * 59 + this.RemainingPrincipalAmount.GetHashCode();
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
