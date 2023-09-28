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
    /// LoanBookingPreLoginRequest
    /// </summary>
    [DataContract]
        public partial class LoanBookingPreLoginRequest :  IEquatable<LoanBookingPreLoginRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoanBookingPreLoginRequest" /> class.
        /// </summary>
        /// <param name="loanAmount">Requested Loan Amount (required).</param>
        /// <param name="tenor">Tenure of loan. (required).</param>
        /// <param name="disbursementOption">This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description. (required).</param>
        /// <param name="disbursementAccountId">The account Id of the account to which Loan amount is to be disbursed..</param>
        /// <param name="payeeId">Unique identifier associated with the payee.Typically, this is not displayed to the customer..</param>
        /// <param name="birthYear">Year of birth of customer.</param>
        /// <param name="purposeOfLoan">This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{PurposeOfLoan} resource to get valid value of this field with description..</param>
        /// <param name="bankDetails">bankDetails.</param>
        public LoanBookingPreLoginRequest(double? loanAmount = default(double?), int? tenor = default(int?), string disbursementOption = default(string), string disbursementAccountId = default(string), string payeeId = default(string), decimal? birthYear = default(decimal?), string purposeOfLoan = default(string), BankDetails bankDetails = default(BankDetails))
        {
            // to ensure "loanAmount" is required (not null)
            if (loanAmount == null)
            {
                throw new InvalidDataException("loanAmount is a required property for LoanBookingPreLoginRequest and cannot be null");
            }
            else
            {
                this.LoanAmount = loanAmount;
            }
            // to ensure "tenor" is required (not null)
            if (tenor == null)
            {
                throw new InvalidDataException("tenor is a required property for LoanBookingPreLoginRequest and cannot be null");
            }
            else
            {
                this.Tenor = tenor;
            }
            // to ensure "disbursementOption" is required (not null)
            if (disbursementOption == null)
            {
                throw new InvalidDataException("disbursementOption is a required property for LoanBookingPreLoginRequest and cannot be null");
            }
            else
            {
                this.DisbursementOption = disbursementOption;
            }
            this.DisbursementAccountId = disbursementAccountId;
            this.PayeeId = payeeId;
            this.BirthYear = birthYear;
            this.PurposeOfLoan = purposeOfLoan;
            this.BankDetails = bankDetails;
        }
        
        /// <summary>
        /// Requested Loan Amount
        /// </summary>
        /// <value>Requested Loan Amount</value>
        [DataMember(Name="loanAmount", EmitDefaultValue=false)]
        public double? LoanAmount { get; set; }

        /// <summary>
        /// Tenure of loan.
        /// </summary>
        /// <value>Tenure of loan.</value>
        [DataMember(Name="tenor", EmitDefaultValue=false)]
        public int? Tenor { get; set; }

        /// <summary>
        /// This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description.
        /// </summary>
        /// <value>This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description.</value>
        [DataMember(Name="disbursementOption", EmitDefaultValue=false)]
        public string DisbursementOption { get; set; }

        /// <summary>
        /// The account Id of the account to which Loan amount is to be disbursed.
        /// </summary>
        /// <value>The account Id of the account to which Loan amount is to be disbursed.</value>
        [DataMember(Name="disbursementAccountId", EmitDefaultValue=false)]
        public string DisbursementAccountId { get; set; }

        /// <summary>
        /// Unique identifier associated with the payee.Typically, this is not displayed to the customer.
        /// </summary>
        /// <value>Unique identifier associated with the payee.Typically, this is not displayed to the customer.</value>
        [DataMember(Name="payeeId", EmitDefaultValue=false)]
        public string PayeeId { get; set; }

        /// <summary>
        /// Year of birth of customer
        /// </summary>
        /// <value>Year of birth of customer</value>
        [DataMember(Name="birthYear", EmitDefaultValue=false)]
        public decimal? BirthYear { get; set; }

        /// <summary>
        /// This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{PurposeOfLoan} resource to get valid value of this field with description.
        /// </summary>
        /// <value>This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{PurposeOfLoan} resource to get valid value of this field with description.</value>
        [DataMember(Name="purposeOfLoan", EmitDefaultValue=false)]
        public string PurposeOfLoan { get; set; }

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
            sb.Append("class LoanBookingPreLoginRequest {\n");
            sb.Append("  LoanAmount: ").Append(LoanAmount).Append("\n");
            sb.Append("  Tenor: ").Append(Tenor).Append("\n");
            sb.Append("  DisbursementOption: ").Append(DisbursementOption).Append("\n");
            sb.Append("  DisbursementAccountId: ").Append(DisbursementAccountId).Append("\n");
            sb.Append("  PayeeId: ").Append(PayeeId).Append("\n");
            sb.Append("  BirthYear: ").Append(BirthYear).Append("\n");
            sb.Append("  PurposeOfLoan: ").Append(PurposeOfLoan).Append("\n");
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
            return this.Equals(input as LoanBookingPreLoginRequest);
        }

        /// <summary>
        /// Returns true if LoanBookingPreLoginRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanBookingPreLoginRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanBookingPreLoginRequest input)
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
                    this.DisbursementOption == input.DisbursementOption ||
                    (this.DisbursementOption != null &&
                    this.DisbursementOption.Equals(input.DisbursementOption))
                ) && 
                (
                    this.DisbursementAccountId == input.DisbursementAccountId ||
                    (this.DisbursementAccountId != null &&
                    this.DisbursementAccountId.Equals(input.DisbursementAccountId))
                ) && 
                (
                    this.PayeeId == input.PayeeId ||
                    (this.PayeeId != null &&
                    this.PayeeId.Equals(input.PayeeId))
                ) && 
                (
                    this.BirthYear == input.BirthYear ||
                    (this.BirthYear != null &&
                    this.BirthYear.Equals(input.BirthYear))
                ) && 
                (
                    this.PurposeOfLoan == input.PurposeOfLoan ||
                    (this.PurposeOfLoan != null &&
                    this.PurposeOfLoan.Equals(input.PurposeOfLoan))
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
                if (this.Tenor != null)
                    hashCode = hashCode * 59 + this.Tenor.GetHashCode();
                if (this.DisbursementOption != null)
                    hashCode = hashCode * 59 + this.DisbursementOption.GetHashCode();
                if (this.DisbursementAccountId != null)
                    hashCode = hashCode * 59 + this.DisbursementAccountId.GetHashCode();
                if (this.PayeeId != null)
                    hashCode = hashCode * 59 + this.PayeeId.GetHashCode();
                if (this.BirthYear != null)
                    hashCode = hashCode * 59 + this.BirthYear.GetHashCode();
                if (this.PurposeOfLoan != null)
                    hashCode = hashCode * 59 + this.PurposeOfLoan.GetHashCode();
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