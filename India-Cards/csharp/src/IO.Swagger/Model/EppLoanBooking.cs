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
    /// EppLoanBooking
    /// </summary>
    [DataContract]
        public partial class EppLoanBooking :  IEquatable<EppLoanBooking>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EppLoanBooking" /> class.
        /// </summary>
        /// <param name="loanAmount">Loan amount for easy payment plan booking. (required).</param>
        /// <param name="referenceId">Reference Id to uniquely identify the transaction. Applicable only for EPP of type TRANSACTION..</param>
        /// <param name="transactionAuthorizationCode">Transaction authorization code is a unique to a sales credit card transaction to indicate that the sale has been authorized..</param>
        public EppLoanBooking(double? loanAmount = default(double?), string referenceId = default(string), string transactionAuthorizationCode = default(string))
        {
            // to ensure "loanAmount" is required (not null)
            if (loanAmount == null)
            {
                throw new InvalidDataException("loanAmount is a required property for EppLoanBooking and cannot be null");
            }
            else
            {
                this.LoanAmount = loanAmount;
            }
            this.ReferenceId = referenceId;
            this.TransactionAuthorizationCode = transactionAuthorizationCode;
        }
        
        /// <summary>
        /// Loan amount for easy payment plan booking.
        /// </summary>
        /// <value>Loan amount for easy payment plan booking.</value>
        [DataMember(Name="loanAmount", EmitDefaultValue=false)]
        public double? LoanAmount { get; set; }

        /// <summary>
        /// Reference Id to uniquely identify the transaction. Applicable only for EPP of type TRANSACTION.
        /// </summary>
        /// <value>Reference Id to uniquely identify the transaction. Applicable only for EPP of type TRANSACTION.</value>
        [DataMember(Name="referenceId", EmitDefaultValue=false)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Transaction authorization code is a unique to a sales credit card transaction to indicate that the sale has been authorized.
        /// </summary>
        /// <value>Transaction authorization code is a unique to a sales credit card transaction to indicate that the sale has been authorized.</value>
        [DataMember(Name="transactionAuthorizationCode", EmitDefaultValue=false)]
        public string TransactionAuthorizationCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EppLoanBooking {\n");
            sb.Append("  LoanAmount: ").Append(LoanAmount).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  TransactionAuthorizationCode: ").Append(TransactionAuthorizationCode).Append("\n");
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
            return this.Equals(input as EppLoanBooking);
        }

        /// <summary>
        /// Returns true if EppLoanBooking instances are equal
        /// </summary>
        /// <param name="input">Instance of EppLoanBooking to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EppLoanBooking input)
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
                    this.ReferenceId == input.ReferenceId ||
                    (this.ReferenceId != null &&
                    this.ReferenceId.Equals(input.ReferenceId))
                ) && 
                (
                    this.TransactionAuthorizationCode == input.TransactionAuthorizationCode ||
                    (this.TransactionAuthorizationCode != null &&
                    this.TransactionAuthorizationCode.Equals(input.TransactionAuthorizationCode))
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
                if (this.ReferenceId != null)
                    hashCode = hashCode * 59 + this.ReferenceId.GetHashCode();
                if (this.TransactionAuthorizationCode != null)
                    hashCode = hashCode * 59 + this.TransactionAuthorizationCode.GetHashCode();
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
