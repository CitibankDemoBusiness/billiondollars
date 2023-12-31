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
    /// LoanPaymentSchedule
    /// </summary>
    [DataContract]
        public partial class LoanPaymentSchedule :  IEquatable<LoanPaymentSchedule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoanPaymentSchedule" /> class.
        /// </summary>
        /// <param name="installmentNumber">The installment number of the total number of installments.</param>
        /// <param name="principalAmount">The portion of the principal amount paid for the loan..</param>
        /// <param name="installmentInterestAmount">The interest amount to be paid as installment.</param>
        /// <param name="installmentAmount">Installment amount to be payed by customer in order to repay the loan..</param>
        /// <param name="installmentDate">Date of installment in ISO 8601 date format YYYY-MM-DD.</param>
        public LoanPaymentSchedule(int? installmentNumber = default(int?), double? principalAmount = default(double?), double? installmentInterestAmount = default(double?), double? installmentAmount = default(double?), DateTime? installmentDate = default(DateTime?))
        {
            this.InstallmentNumber = installmentNumber;
            this.PrincipalAmount = principalAmount;
            this.InstallmentInterestAmount = installmentInterestAmount;
            this.InstallmentAmount = installmentAmount;
            this.InstallmentDate = installmentDate;
        }
        
        /// <summary>
        /// The installment number of the total number of installments
        /// </summary>
        /// <value>The installment number of the total number of installments</value>
        [DataMember(Name="installmentNumber", EmitDefaultValue=false)]
        public int? InstallmentNumber { get; set; }

        /// <summary>
        /// The portion of the principal amount paid for the loan.
        /// </summary>
        /// <value>The portion of the principal amount paid for the loan.</value>
        [DataMember(Name="principalAmount", EmitDefaultValue=false)]
        public double? PrincipalAmount { get; set; }

        /// <summary>
        /// The interest amount to be paid as installment
        /// </summary>
        /// <value>The interest amount to be paid as installment</value>
        [DataMember(Name="installmentInterestAmount", EmitDefaultValue=false)]
        public double? InstallmentInterestAmount { get; set; }

        /// <summary>
        /// Installment amount to be payed by customer in order to repay the loan.
        /// </summary>
        /// <value>Installment amount to be payed by customer in order to repay the loan.</value>
        [DataMember(Name="installmentAmount", EmitDefaultValue=false)]
        public double? InstallmentAmount { get; set; }

        /// <summary>
        /// Date of installment in ISO 8601 date format YYYY-MM-DD
        /// </summary>
        /// <value>Date of installment in ISO 8601 date format YYYY-MM-DD</value>
        [DataMember(Name="installmentDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? InstallmentDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanPaymentSchedule {\n");
            sb.Append("  InstallmentNumber: ").Append(InstallmentNumber).Append("\n");
            sb.Append("  PrincipalAmount: ").Append(PrincipalAmount).Append("\n");
            sb.Append("  InstallmentInterestAmount: ").Append(InstallmentInterestAmount).Append("\n");
            sb.Append("  InstallmentAmount: ").Append(InstallmentAmount).Append("\n");
            sb.Append("  InstallmentDate: ").Append(InstallmentDate).Append("\n");
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
            return this.Equals(input as LoanPaymentSchedule);
        }

        /// <summary>
        /// Returns true if LoanPaymentSchedule instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanPaymentSchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanPaymentSchedule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstallmentNumber == input.InstallmentNumber ||
                    (this.InstallmentNumber != null &&
                    this.InstallmentNumber.Equals(input.InstallmentNumber))
                ) && 
                (
                    this.PrincipalAmount == input.PrincipalAmount ||
                    (this.PrincipalAmount != null &&
                    this.PrincipalAmount.Equals(input.PrincipalAmount))
                ) && 
                (
                    this.InstallmentInterestAmount == input.InstallmentInterestAmount ||
                    (this.InstallmentInterestAmount != null &&
                    this.InstallmentInterestAmount.Equals(input.InstallmentInterestAmount))
                ) && 
                (
                    this.InstallmentAmount == input.InstallmentAmount ||
                    (this.InstallmentAmount != null &&
                    this.InstallmentAmount.Equals(input.InstallmentAmount))
                ) && 
                (
                    this.InstallmentDate == input.InstallmentDate ||
                    (this.InstallmentDate != null &&
                    this.InstallmentDate.Equals(input.InstallmentDate))
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
                if (this.InstallmentNumber != null)
                    hashCode = hashCode * 59 + this.InstallmentNumber.GetHashCode();
                if (this.PrincipalAmount != null)
                    hashCode = hashCode * 59 + this.PrincipalAmount.GetHashCode();
                if (this.InstallmentInterestAmount != null)
                    hashCode = hashCode * 59 + this.InstallmentInterestAmount.GetHashCode();
                if (this.InstallmentAmount != null)
                    hashCode = hashCode * 59 + this.InstallmentAmount.GetHashCode();
                if (this.InstallmentDate != null)
                    hashCode = hashCode * 59 + this.InstallmentDate.GetHashCode();
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
