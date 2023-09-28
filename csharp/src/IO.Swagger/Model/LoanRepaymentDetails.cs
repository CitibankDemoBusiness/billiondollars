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
    /// LoanRepaymentDetails
    /// </summary>
    [DataContract]
        public partial class LoanRepaymentDetails :  IEquatable<LoanRepaymentDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoanRepaymentDetails" /> class.
        /// </summary>
        /// <param name="loanAmount">Requested disbursement amount.</param>
        /// <param name="loanRepaymentMethod">Loan repayment method for the unsecured loan selected by the applicant Ex:SI,PDC,UAE Exchange,Direct Debit,Manual Direct Debit Please use /v1/utilities/referenceData/{loanRepaymentMethod} resource to get valid value of this field with description..</param>
        /// <param name="paymentAccountNumber">Payment account number associated with the bank   through which the loan repayment is carried out  by the applicant.</param>
        /// <param name="accountReferenceKey">Account reference key to link account in a customer session,.</param>
        /// <param name="accountNickName">The nick name of the account assigned by the customer.</param>
        /// <param name="bankDetails">bankDetails.</param>
        public LoanRepaymentDetails(double? loanAmount = default(double?), string loanRepaymentMethod = default(string), string paymentAccountNumber = default(string), string accountReferenceKey = default(string), string accountNickName = default(string), BankDetails bankDetails = default(BankDetails))
        {
            this.LoanAmount = loanAmount;
            this.LoanRepaymentMethod = loanRepaymentMethod;
            this.PaymentAccountNumber = paymentAccountNumber;
            this.AccountReferenceKey = accountReferenceKey;
            this.AccountNickName = accountNickName;
            this.BankDetails = bankDetails;
        }
        
        /// <summary>
        /// Requested disbursement amount
        /// </summary>
        /// <value>Requested disbursement amount</value>
        [DataMember(Name="loanAmount", EmitDefaultValue=false)]
        public double? LoanAmount { get; set; }

        /// <summary>
        /// Loan repayment method for the unsecured loan selected by the applicant Ex:SI,PDC,UAE Exchange,Direct Debit,Manual Direct Debit Please use /v1/utilities/referenceData/{loanRepaymentMethod} resource to get valid value of this field with description.
        /// </summary>
        /// <value>Loan repayment method for the unsecured loan selected by the applicant Ex:SI,PDC,UAE Exchange,Direct Debit,Manual Direct Debit Please use /v1/utilities/referenceData/{loanRepaymentMethod} resource to get valid value of this field with description.</value>
        [DataMember(Name="loanRepaymentMethod", EmitDefaultValue=false)]
        public string LoanRepaymentMethod { get; set; }

        /// <summary>
        /// Payment account number associated with the bank   through which the loan repayment is carried out  by the applicant
        /// </summary>
        /// <value>Payment account number associated with the bank   through which the loan repayment is carried out  by the applicant</value>
        [DataMember(Name="paymentAccountNumber", EmitDefaultValue=false)]
        public string PaymentAccountNumber { get; set; }

        /// <summary>
        /// Account reference key to link account in a customer session,
        /// </summary>
        /// <value>Account reference key to link account in a customer session,</value>
        [DataMember(Name="accountReferenceKey", EmitDefaultValue=false)]
        public string AccountReferenceKey { get; set; }

        /// <summary>
        /// The nick name of the account assigned by the customer
        /// </summary>
        /// <value>The nick name of the account assigned by the customer</value>
        [DataMember(Name="accountNickName", EmitDefaultValue=false)]
        public string AccountNickName { get; set; }

        /// <summary>
        /// Gets or Sets BankDetails
        /// </summary>
        [DataMember(Name="bankDetails", EmitDefaultValue=false)]
        public BankDetails BankDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanRepaymentDetails {\n");
            sb.Append("  LoanAmount: ").Append(LoanAmount).Append("\n");
            sb.Append("  LoanRepaymentMethod: ").Append(LoanRepaymentMethod).Append("\n");
            sb.Append("  PaymentAccountNumber: ").Append(PaymentAccountNumber).Append("\n");
            sb.Append("  AccountReferenceKey: ").Append(AccountReferenceKey).Append("\n");
            sb.Append("  AccountNickName: ").Append(AccountNickName).Append("\n");
            sb.Append("  BankDetails: ").Append(BankDetails).Append("\n");
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
            return this.Equals(input as LoanRepaymentDetails);
        }

        /// <summary>
        /// Returns true if LoanRepaymentDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanRepaymentDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanRepaymentDetails input)
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
                    this.LoanRepaymentMethod == input.LoanRepaymentMethod ||
                    (this.LoanRepaymentMethod != null &&
                    this.LoanRepaymentMethod.Equals(input.LoanRepaymentMethod))
                ) && 
                (
                    this.PaymentAccountNumber == input.PaymentAccountNumber ||
                    (this.PaymentAccountNumber != null &&
                    this.PaymentAccountNumber.Equals(input.PaymentAccountNumber))
                ) && 
                (
                    this.AccountReferenceKey == input.AccountReferenceKey ||
                    (this.AccountReferenceKey != null &&
                    this.AccountReferenceKey.Equals(input.AccountReferenceKey))
                ) && 
                (
                    this.AccountNickName == input.AccountNickName ||
                    (this.AccountNickName != null &&
                    this.AccountNickName.Equals(input.AccountNickName))
                ) && 
                (
                    this.BankDetails == input.BankDetails ||
                    (this.BankDetails != null &&
                    this.BankDetails.Equals(input.BankDetails))
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
                if (this.LoanRepaymentMethod != null)
                    hashCode = hashCode * 59 + this.LoanRepaymentMethod.GetHashCode();
                if (this.PaymentAccountNumber != null)
                    hashCode = hashCode * 59 + this.PaymentAccountNumber.GetHashCode();
                if (this.AccountReferenceKey != null)
                    hashCode = hashCode * 59 + this.AccountReferenceKey.GetHashCode();
                if (this.AccountNickName != null)
                    hashCode = hashCode * 59 + this.AccountNickName.GetHashCode();
                if (this.BankDetails != null)
                    hashCode = hashCode * 59 + this.BankDetails.GetHashCode();
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