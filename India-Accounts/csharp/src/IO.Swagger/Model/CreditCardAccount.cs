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
    /// CreditCardAccount
    /// </summary>
    [DataContract]
        public partial class CreditCardAccount :  IEquatable<CreditCardAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditCardAccount" /> class.
        /// </summary>
        /// <param name="productName">The name of the product.</param>
        /// <param name="productCode">A unique code that identifies the product.</param>
        /// <param name="displayAccountNumber">A masked account number that can be displayed to the customer (required).</param>
        /// <param name="currencyCode">The currency code of the account in ISO 4217 format.</param>
        /// <param name="outstandingBalance">The amount of money owed..</param>
        /// <param name="lastStatementBalance">The balance on last statement date.</param>
        /// <param name="lastStatementDate">The date of the last statement in ISO 8601 date format YYYY-MM-DD.</param>
        /// <param name="creditUsed">The part of the credit limit already used.</param>
        /// <param name="creditLimit">The maximum amount of credit that extend to a customer.</param>
        /// <param name="availableCredit">The available credit.</param>
        /// <param name="cashAdvanceLimit">Some percentage of credit limit to withdraw cash.</param>
        /// <param name="cashAdvanceAvailableAmount">Cash advance amount available. This will be same as the cash limit if there is no cash advance done. Otherwise, this will be the amount from the cashLimit minus the cash advance amount already used.</param>
        /// <param name="lastPaymentAmount">The amount of the last payment made.</param>
        /// <param name="lastPaymentDate">The date of the last payment in ISO 8601 date format YYYY-MM-DD.</param>
        /// <param name="minimumDueAmount">Minimum due amount for a payment cycle.</param>
        /// <param name="paymentDueDate">The date of the next payment/payment due date in ISO 8601 date format YYYY-MM-DD.</param>
        /// <param name="availablePointBalance">Available reward points on the credit card.</param>
        public CreditCardAccount(string productName = default(string), string productCode = default(string), string displayAccountNumber = default(string), string currencyCode = default(string), double? outstandingBalance = default(double?), double? lastStatementBalance = default(double?), DateTime? lastStatementDate = default(DateTime?), double? creditUsed = default(double?), double? creditLimit = default(double?), double? availableCredit = default(double?), double? cashAdvanceLimit = default(double?), double? cashAdvanceAvailableAmount = default(double?), double? lastPaymentAmount = default(double?), DateTime? lastPaymentDate = default(DateTime?), double? minimumDueAmount = default(double?), DateTime? paymentDueDate = default(DateTime?), decimal? availablePointBalance = default(decimal?))
        {
            // to ensure "displayAccountNumber" is required (not null)
            if (displayAccountNumber == null)
            {
                throw new InvalidDataException("displayAccountNumber is a required property for CreditCardAccount and cannot be null");
            }
            else
            {
                this.DisplayAccountNumber = displayAccountNumber;
            }
            this.ProductName = productName;
            this.ProductCode = productCode;
            this.CurrencyCode = currencyCode;
            this.OutstandingBalance = outstandingBalance;
            this.LastStatementBalance = lastStatementBalance;
            this.LastStatementDate = lastStatementDate;
            this.CreditUsed = creditUsed;
            this.CreditLimit = creditLimit;
            this.AvailableCredit = availableCredit;
            this.CashAdvanceLimit = cashAdvanceLimit;
            this.CashAdvanceAvailableAmount = cashAdvanceAvailableAmount;
            this.LastPaymentAmount = lastPaymentAmount;
            this.LastPaymentDate = lastPaymentDate;
            this.MinimumDueAmount = minimumDueAmount;
            this.PaymentDueDate = paymentDueDate;
            this.AvailablePointBalance = availablePointBalance;
        }
        
        /// <summary>
        /// The name of the product
        /// </summary>
        /// <value>The name of the product</value>
        [DataMember(Name="productName", EmitDefaultValue=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// A unique code that identifies the product
        /// </summary>
        /// <value>A unique code that identifies the product</value>
        [DataMember(Name="productCode", EmitDefaultValue=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// A masked account number that can be displayed to the customer
        /// </summary>
        /// <value>A masked account number that can be displayed to the customer</value>
        [DataMember(Name="displayAccountNumber", EmitDefaultValue=false)]
        public string DisplayAccountNumber { get; set; }

        /// <summary>
        /// The currency code of the account in ISO 4217 format
        /// </summary>
        /// <value>The currency code of the account in ISO 4217 format</value>
        [DataMember(Name="currencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The amount of money owed.
        /// </summary>
        /// <value>The amount of money owed.</value>
        [DataMember(Name="outstandingBalance", EmitDefaultValue=false)]
        public double? OutstandingBalance { get; set; }

        /// <summary>
        /// The balance on last statement date
        /// </summary>
        /// <value>The balance on last statement date</value>
        [DataMember(Name="lastStatementBalance", EmitDefaultValue=false)]
        public double? LastStatementBalance { get; set; }

        /// <summary>
        /// The date of the last statement in ISO 8601 date format YYYY-MM-DD
        /// </summary>
        /// <value>The date of the last statement in ISO 8601 date format YYYY-MM-DD</value>
        [DataMember(Name="lastStatementDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? LastStatementDate { get; set; }

        /// <summary>
        /// The part of the credit limit already used
        /// </summary>
        /// <value>The part of the credit limit already used</value>
        [DataMember(Name="creditUsed", EmitDefaultValue=false)]
        public double? CreditUsed { get; set; }

        /// <summary>
        /// The maximum amount of credit that extend to a customer
        /// </summary>
        /// <value>The maximum amount of credit that extend to a customer</value>
        [DataMember(Name="creditLimit", EmitDefaultValue=false)]
        public double? CreditLimit { get; set; }

        /// <summary>
        /// The available credit
        /// </summary>
        /// <value>The available credit</value>
        [DataMember(Name="availableCredit", EmitDefaultValue=false)]
        public double? AvailableCredit { get; set; }

        /// <summary>
        /// Some percentage of credit limit to withdraw cash
        /// </summary>
        /// <value>Some percentage of credit limit to withdraw cash</value>
        [DataMember(Name="cashAdvanceLimit", EmitDefaultValue=false)]
        public double? CashAdvanceLimit { get; set; }

        /// <summary>
        /// Cash advance amount available. This will be same as the cash limit if there is no cash advance done. Otherwise, this will be the amount from the cashLimit minus the cash advance amount already used
        /// </summary>
        /// <value>Cash advance amount available. This will be same as the cash limit if there is no cash advance done. Otherwise, this will be the amount from the cashLimit minus the cash advance amount already used</value>
        [DataMember(Name="cashAdvanceAvailableAmount", EmitDefaultValue=false)]
        public double? CashAdvanceAvailableAmount { get; set; }

        /// <summary>
        /// The amount of the last payment made
        /// </summary>
        /// <value>The amount of the last payment made</value>
        [DataMember(Name="lastPaymentAmount", EmitDefaultValue=false)]
        public double? LastPaymentAmount { get; set; }

        /// <summary>
        /// The date of the last payment in ISO 8601 date format YYYY-MM-DD
        /// </summary>
        /// <value>The date of the last payment in ISO 8601 date format YYYY-MM-DD</value>
        [DataMember(Name="lastPaymentDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? LastPaymentDate { get; set; }

        /// <summary>
        /// Minimum due amount for a payment cycle
        /// </summary>
        /// <value>Minimum due amount for a payment cycle</value>
        [DataMember(Name="minimumDueAmount", EmitDefaultValue=false)]
        public double? MinimumDueAmount { get; set; }

        /// <summary>
        /// The date of the next payment/payment due date in ISO 8601 date format YYYY-MM-DD
        /// </summary>
        /// <value>The date of the next payment/payment due date in ISO 8601 date format YYYY-MM-DD</value>
        [DataMember(Name="paymentDueDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? PaymentDueDate { get; set; }

        /// <summary>
        /// Available reward points on the credit card
        /// </summary>
        /// <value>Available reward points on the credit card</value>
        [DataMember(Name="availablePointBalance", EmitDefaultValue=false)]
        public decimal? AvailablePointBalance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreditCardAccount {\n");
            sb.Append("  ProductName: ").Append(ProductName).Append("\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
            sb.Append("  DisplayAccountNumber: ").Append(DisplayAccountNumber).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  OutstandingBalance: ").Append(OutstandingBalance).Append("\n");
            sb.Append("  LastStatementBalance: ").Append(LastStatementBalance).Append("\n");
            sb.Append("  LastStatementDate: ").Append(LastStatementDate).Append("\n");
            sb.Append("  CreditUsed: ").Append(CreditUsed).Append("\n");
            sb.Append("  CreditLimit: ").Append(CreditLimit).Append("\n");
            sb.Append("  AvailableCredit: ").Append(AvailableCredit).Append("\n");
            sb.Append("  CashAdvanceLimit: ").Append(CashAdvanceLimit).Append("\n");
            sb.Append("  CashAdvanceAvailableAmount: ").Append(CashAdvanceAvailableAmount).Append("\n");
            sb.Append("  LastPaymentAmount: ").Append(LastPaymentAmount).Append("\n");
            sb.Append("  LastPaymentDate: ").Append(LastPaymentDate).Append("\n");
            sb.Append("  MinimumDueAmount: ").Append(MinimumDueAmount).Append("\n");
            sb.Append("  PaymentDueDate: ").Append(PaymentDueDate).Append("\n");
            sb.Append("  AvailablePointBalance: ").Append(AvailablePointBalance).Append("\n");
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
            return this.Equals(input as CreditCardAccount);
        }

        /// <summary>
        /// Returns true if CreditCardAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of CreditCardAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreditCardAccount input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProductName == input.ProductName ||
                    (this.ProductName != null &&
                    this.ProductName.Equals(input.ProductName))
                ) && 
                (
                    this.ProductCode == input.ProductCode ||
                    (this.ProductCode != null &&
                    this.ProductCode.Equals(input.ProductCode))
                ) && 
                (
                    this.DisplayAccountNumber == input.DisplayAccountNumber ||
                    (this.DisplayAccountNumber != null &&
                    this.DisplayAccountNumber.Equals(input.DisplayAccountNumber))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.OutstandingBalance == input.OutstandingBalance ||
                    (this.OutstandingBalance != null &&
                    this.OutstandingBalance.Equals(input.OutstandingBalance))
                ) && 
                (
                    this.LastStatementBalance == input.LastStatementBalance ||
                    (this.LastStatementBalance != null &&
                    this.LastStatementBalance.Equals(input.LastStatementBalance))
                ) && 
                (
                    this.LastStatementDate == input.LastStatementDate ||
                    (this.LastStatementDate != null &&
                    this.LastStatementDate.Equals(input.LastStatementDate))
                ) && 
                (
                    this.CreditUsed == input.CreditUsed ||
                    (this.CreditUsed != null &&
                    this.CreditUsed.Equals(input.CreditUsed))
                ) && 
                (
                    this.CreditLimit == input.CreditLimit ||
                    (this.CreditLimit != null &&
                    this.CreditLimit.Equals(input.CreditLimit))
                ) && 
                (
                    this.AvailableCredit == input.AvailableCredit ||
                    (this.AvailableCredit != null &&
                    this.AvailableCredit.Equals(input.AvailableCredit))
                ) && 
                (
                    this.CashAdvanceLimit == input.CashAdvanceLimit ||
                    (this.CashAdvanceLimit != null &&
                    this.CashAdvanceLimit.Equals(input.CashAdvanceLimit))
                ) && 
                (
                    this.CashAdvanceAvailableAmount == input.CashAdvanceAvailableAmount ||
                    (this.CashAdvanceAvailableAmount != null &&
                    this.CashAdvanceAvailableAmount.Equals(input.CashAdvanceAvailableAmount))
                ) && 
                (
                    this.LastPaymentAmount == input.LastPaymentAmount ||
                    (this.LastPaymentAmount != null &&
                    this.LastPaymentAmount.Equals(input.LastPaymentAmount))
                ) && 
                (
                    this.LastPaymentDate == input.LastPaymentDate ||
                    (this.LastPaymentDate != null &&
                    this.LastPaymentDate.Equals(input.LastPaymentDate))
                ) && 
                (
                    this.MinimumDueAmount == input.MinimumDueAmount ||
                    (this.MinimumDueAmount != null &&
                    this.MinimumDueAmount.Equals(input.MinimumDueAmount))
                ) && 
                (
                    this.PaymentDueDate == input.PaymentDueDate ||
                    (this.PaymentDueDate != null &&
                    this.PaymentDueDate.Equals(input.PaymentDueDate))
                ) && 
                (
                    this.AvailablePointBalance == input.AvailablePointBalance ||
                    (this.AvailablePointBalance != null &&
                    this.AvailablePointBalance.Equals(input.AvailablePointBalance))
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
                if (this.ProductName != null)
                    hashCode = hashCode * 59 + this.ProductName.GetHashCode();
                if (this.ProductCode != null)
                    hashCode = hashCode * 59 + this.ProductCode.GetHashCode();
                if (this.DisplayAccountNumber != null)
                    hashCode = hashCode * 59 + this.DisplayAccountNumber.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.OutstandingBalance != null)
                    hashCode = hashCode * 59 + this.OutstandingBalance.GetHashCode();
                if (this.LastStatementBalance != null)
                    hashCode = hashCode * 59 + this.LastStatementBalance.GetHashCode();
                if (this.LastStatementDate != null)
                    hashCode = hashCode * 59 + this.LastStatementDate.GetHashCode();
                if (this.CreditUsed != null)
                    hashCode = hashCode * 59 + this.CreditUsed.GetHashCode();
                if (this.CreditLimit != null)
                    hashCode = hashCode * 59 + this.CreditLimit.GetHashCode();
                if (this.AvailableCredit != null)
                    hashCode = hashCode * 59 + this.AvailableCredit.GetHashCode();
                if (this.CashAdvanceLimit != null)
                    hashCode = hashCode * 59 + this.CashAdvanceLimit.GetHashCode();
                if (this.CashAdvanceAvailableAmount != null)
                    hashCode = hashCode * 59 + this.CashAdvanceAvailableAmount.GetHashCode();
                if (this.LastPaymentAmount != null)
                    hashCode = hashCode * 59 + this.LastPaymentAmount.GetHashCode();
                if (this.LastPaymentDate != null)
                    hashCode = hashCode * 59 + this.LastPaymentDate.GetHashCode();
                if (this.MinimumDueAmount != null)
                    hashCode = hashCode * 59 + this.MinimumDueAmount.GetHashCode();
                if (this.PaymentDueDate != null)
                    hashCode = hashCode * 59 + this.PaymentDueDate.GetHashCode();
                if (this.AvailablePointBalance != null)
                    hashCode = hashCode * 59 + this.AvailablePointBalance.GetHashCode();
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
