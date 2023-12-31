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
    /// LoanTopup
    /// </summary>
    [DataContract]
        public partial class LoanTopup :  IEquatable<LoanTopup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoanTopup" /> class.
        /// </summary>
        /// <param name="tenor">Tenor for the loan repayment.This is a reference data field. Please use /v1/utilities/referenceData/{tenor} resource to get valid values of this field with descriptions..</param>
        /// <param name="interestRate">annualPercentageRate -APR.</param>
        /// <param name="installmentAmount">Instalment amount to be paid..</param>
        public LoanTopup(string tenor = default(string), double? interestRate = default(double?), double? installmentAmount = default(double?))
        {
            this.Tenor = tenor;
            this.InterestRate = interestRate;
            this.InstallmentAmount = installmentAmount;
        }
        
        /// <summary>
        /// Tenor for the loan repayment.This is a reference data field. Please use /v1/utilities/referenceData/{tenor} resource to get valid values of this field with descriptions.
        /// </summary>
        /// <value>Tenor for the loan repayment.This is a reference data field. Please use /v1/utilities/referenceData/{tenor} resource to get valid values of this field with descriptions.</value>
        [DataMember(Name="tenor", EmitDefaultValue=false)]
        public string Tenor { get; set; }

        /// <summary>
        /// annualPercentageRate -APR
        /// </summary>
        /// <value>annualPercentageRate -APR</value>
        [DataMember(Name="interestRate", EmitDefaultValue=false)]
        public double? InterestRate { get; set; }

        /// <summary>
        /// Instalment amount to be paid.
        /// </summary>
        /// <value>Instalment amount to be paid.</value>
        [DataMember(Name="installmentAmount", EmitDefaultValue=false)]
        public double? InstallmentAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanTopup {\n");
            sb.Append("  Tenor: ").Append(Tenor).Append("\n");
            sb.Append("  InterestRate: ").Append(InterestRate).Append("\n");
            sb.Append("  InstallmentAmount: ").Append(InstallmentAmount).Append("\n");
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
            return this.Equals(input as LoanTopup);
        }

        /// <summary>
        /// Returns true if LoanTopup instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanTopup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanTopup input)
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
                    this.InterestRate == input.InterestRate ||
                    (this.InterestRate != null &&
                    this.InterestRate.Equals(input.InterestRate))
                ) && 
                (
                    this.InstallmentAmount == input.InstallmentAmount ||
                    (this.InstallmentAmount != null &&
                    this.InstallmentAmount.Equals(input.InstallmentAmount))
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
                if (this.InterestRate != null)
                    hashCode = hashCode * 59 + this.InterestRate.GetHashCode();
                if (this.InstallmentAmount != null)
                    hashCode = hashCode * 59 + this.InstallmentAmount.GetHashCode();
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
