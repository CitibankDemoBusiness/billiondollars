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
    /// Transactions
    /// </summary>
    [DataContract]
        public partial class Transactions :  IEquatable<Transactions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Transactions" /> class.
        /// </summary>
        /// <param name="displayCardNumber">A masked card number that can be displayed to the customer (required).</param>
        /// <param name="cardHolderType">Indicator to specify whether the card is primary or supplementary.This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardHolderType} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values..</param>
        /// <param name="transactionDate">The transaction date in ISO 8601 format YYYY-MM-DD.</param>
        /// <param name="transactionPostingDate">The transaction posting date in ISO 8601 format YYYY-MM-DD.</param>
        /// <param name="merchantName">The merchant name with which this transaction was made..</param>
        /// <param name="transactionCode">The transaction code.</param>
        /// <param name="transactionDescription">Transaction description from the merchant, POS or bank..</param>
        /// <param name="transactionType">The type of transaction. This is a reference data field. Please use /v1/apac/utilities/referenceData/{transactionType} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values..</param>
        /// <param name="foreignTransactionAmount">The transaction amount in the foreign currency.</param>
        /// <param name="foreignCurrencyCode">The foreign currency code of the transaction in ISO 4217 format.</param>
        /// <param name="transactionAmount">Transaction amount in local currency.</param>
        /// <param name="currencyCode">The currency code of the transaction in ISO 4217 format.</param>
        /// <param name="eligibleForEqualPaymentPlan">The EPP allowed indicator. This is a reference data field. Please use /v1/apac/utilities/referenceData/{eligibleForEqualPaymentPlan} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values..</param>
        /// <param name="transactionReferenceId">The unique transaction reference Id used to identify this transaction from all the other transactions,.</param>
        public Transactions(string displayCardNumber = default(string), string cardHolderType = default(string), DateTime? transactionDate = default(DateTime?), DateTime? transactionPostingDate = default(DateTime?), string merchantName = default(string), string transactionCode = default(string), string transactionDescription = default(string), string transactionType = default(string), double? foreignTransactionAmount = default(double?), string foreignCurrencyCode = default(string), double? transactionAmount = default(double?), string currencyCode = default(string), string eligibleForEqualPaymentPlan = default(string), string transactionReferenceId = default(string))
        {
            // to ensure "displayCardNumber" is required (not null)
            if (displayCardNumber == null)
            {
                throw new InvalidDataException("displayCardNumber is a required property for Transactions and cannot be null");
            }
            else
            {
                this.DisplayCardNumber = displayCardNumber;
            }
            this.CardHolderType = cardHolderType;
            this.TransactionDate = transactionDate;
            this.TransactionPostingDate = transactionPostingDate;
            this.MerchantName = merchantName;
            this.TransactionCode = transactionCode;
            this.TransactionDescription = transactionDescription;
            this.TransactionType = transactionType;
            this.ForeignTransactionAmount = foreignTransactionAmount;
            this.ForeignCurrencyCode = foreignCurrencyCode;
            this.TransactionAmount = transactionAmount;
            this.CurrencyCode = currencyCode;
            this.EligibleForEqualPaymentPlan = eligibleForEqualPaymentPlan;
            this.TransactionReferenceId = transactionReferenceId;
        }
        
        /// <summary>
        /// A masked card number that can be displayed to the customer
        /// </summary>
        /// <value>A masked card number that can be displayed to the customer</value>
        [DataMember(Name="displayCardNumber", EmitDefaultValue=false)]
        public string DisplayCardNumber { get; set; }

        /// <summary>
        /// Indicator to specify whether the card is primary or supplementary.This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardHolderType} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
        /// </summary>
        /// <value>Indicator to specify whether the card is primary or supplementary.This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardHolderType} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.</value>
        [DataMember(Name="cardHolderType", EmitDefaultValue=false)]
        public string CardHolderType { get; set; }

        /// <summary>
        /// The transaction date in ISO 8601 format YYYY-MM-DD
        /// </summary>
        /// <value>The transaction date in ISO 8601 format YYYY-MM-DD</value>
        [DataMember(Name="transactionDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? TransactionDate { get; set; }

        /// <summary>
        /// The transaction posting date in ISO 8601 format YYYY-MM-DD
        /// </summary>
        /// <value>The transaction posting date in ISO 8601 format YYYY-MM-DD</value>
        [DataMember(Name="transactionPostingDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? TransactionPostingDate { get; set; }

        /// <summary>
        /// The merchant name with which this transaction was made.
        /// </summary>
        /// <value>The merchant name with which this transaction was made.</value>
        [DataMember(Name="merchantName", EmitDefaultValue=false)]
        public string MerchantName { get; set; }

        /// <summary>
        /// The transaction code
        /// </summary>
        /// <value>The transaction code</value>
        [DataMember(Name="transactionCode", EmitDefaultValue=false)]
        public string TransactionCode { get; set; }

        /// <summary>
        /// Transaction description from the merchant, POS or bank.
        /// </summary>
        /// <value>Transaction description from the merchant, POS or bank.</value>
        [DataMember(Name="transactionDescription", EmitDefaultValue=false)]
        public string TransactionDescription { get; set; }

        /// <summary>
        /// The type of transaction. This is a reference data field. Please use /v1/apac/utilities/referenceData/{transactionType} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
        /// </summary>
        /// <value>The type of transaction. This is a reference data field. Please use /v1/apac/utilities/referenceData/{transactionType} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.</value>
        [DataMember(Name="transactionType", EmitDefaultValue=false)]
        public string TransactionType { get; set; }

        /// <summary>
        /// The transaction amount in the foreign currency
        /// </summary>
        /// <value>The transaction amount in the foreign currency</value>
        [DataMember(Name="foreignTransactionAmount", EmitDefaultValue=false)]
        public double? ForeignTransactionAmount { get; set; }

        /// <summary>
        /// The foreign currency code of the transaction in ISO 4217 format
        /// </summary>
        /// <value>The foreign currency code of the transaction in ISO 4217 format</value>
        [DataMember(Name="foreignCurrencyCode", EmitDefaultValue=false)]
        public string ForeignCurrencyCode { get; set; }

        /// <summary>
        /// Transaction amount in local currency
        /// </summary>
        /// <value>Transaction amount in local currency</value>
        [DataMember(Name="transactionAmount", EmitDefaultValue=false)]
        public double? TransactionAmount { get; set; }

        /// <summary>
        /// The currency code of the transaction in ISO 4217 format
        /// </summary>
        /// <value>The currency code of the transaction in ISO 4217 format</value>
        [DataMember(Name="currencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The EPP allowed indicator. This is a reference data field. Please use /v1/apac/utilities/referenceData/{eligibleForEqualPaymentPlan} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
        /// </summary>
        /// <value>The EPP allowed indicator. This is a reference data field. Please use /v1/apac/utilities/referenceData/{eligibleForEqualPaymentPlan} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.</value>
        [DataMember(Name="eligibleForEqualPaymentPlan", EmitDefaultValue=false)]
        public string EligibleForEqualPaymentPlan { get; set; }

        /// <summary>
        /// The unique transaction reference Id used to identify this transaction from all the other transactions,
        /// </summary>
        /// <value>The unique transaction reference Id used to identify this transaction from all the other transactions,</value>
        [DataMember(Name="transactionReferenceId", EmitDefaultValue=false)]
        public string TransactionReferenceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Transactions {\n");
            sb.Append("  DisplayCardNumber: ").Append(DisplayCardNumber).Append("\n");
            sb.Append("  CardHolderType: ").Append(CardHolderType).Append("\n");
            sb.Append("  TransactionDate: ").Append(TransactionDate).Append("\n");
            sb.Append("  TransactionPostingDate: ").Append(TransactionPostingDate).Append("\n");
            sb.Append("  MerchantName: ").Append(MerchantName).Append("\n");
            sb.Append("  TransactionCode: ").Append(TransactionCode).Append("\n");
            sb.Append("  TransactionDescription: ").Append(TransactionDescription).Append("\n");
            sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
            sb.Append("  ForeignTransactionAmount: ").Append(ForeignTransactionAmount).Append("\n");
            sb.Append("  ForeignCurrencyCode: ").Append(ForeignCurrencyCode).Append("\n");
            sb.Append("  TransactionAmount: ").Append(TransactionAmount).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  EligibleForEqualPaymentPlan: ").Append(EligibleForEqualPaymentPlan).Append("\n");
            sb.Append("  TransactionReferenceId: ").Append(TransactionReferenceId).Append("\n");
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
            return this.Equals(input as Transactions);
        }

        /// <summary>
        /// Returns true if Transactions instances are equal
        /// </summary>
        /// <param name="input">Instance of Transactions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Transactions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisplayCardNumber == input.DisplayCardNumber ||
                    (this.DisplayCardNumber != null &&
                    this.DisplayCardNumber.Equals(input.DisplayCardNumber))
                ) && 
                (
                    this.CardHolderType == input.CardHolderType ||
                    (this.CardHolderType != null &&
                    this.CardHolderType.Equals(input.CardHolderType))
                ) && 
                (
                    this.TransactionDate == input.TransactionDate ||
                    (this.TransactionDate != null &&
                    this.TransactionDate.Equals(input.TransactionDate))
                ) && 
                (
                    this.TransactionPostingDate == input.TransactionPostingDate ||
                    (this.TransactionPostingDate != null &&
                    this.TransactionPostingDate.Equals(input.TransactionPostingDate))
                ) && 
                (
                    this.MerchantName == input.MerchantName ||
                    (this.MerchantName != null &&
                    this.MerchantName.Equals(input.MerchantName))
                ) && 
                (
                    this.TransactionCode == input.TransactionCode ||
                    (this.TransactionCode != null &&
                    this.TransactionCode.Equals(input.TransactionCode))
                ) && 
                (
                    this.TransactionDescription == input.TransactionDescription ||
                    (this.TransactionDescription != null &&
                    this.TransactionDescription.Equals(input.TransactionDescription))
                ) && 
                (
                    this.TransactionType == input.TransactionType ||
                    (this.TransactionType != null &&
                    this.TransactionType.Equals(input.TransactionType))
                ) && 
                (
                    this.ForeignTransactionAmount == input.ForeignTransactionAmount ||
                    (this.ForeignTransactionAmount != null &&
                    this.ForeignTransactionAmount.Equals(input.ForeignTransactionAmount))
                ) && 
                (
                    this.ForeignCurrencyCode == input.ForeignCurrencyCode ||
                    (this.ForeignCurrencyCode != null &&
                    this.ForeignCurrencyCode.Equals(input.ForeignCurrencyCode))
                ) && 
                (
                    this.TransactionAmount == input.TransactionAmount ||
                    (this.TransactionAmount != null &&
                    this.TransactionAmount.Equals(input.TransactionAmount))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.EligibleForEqualPaymentPlan == input.EligibleForEqualPaymentPlan ||
                    (this.EligibleForEqualPaymentPlan != null &&
                    this.EligibleForEqualPaymentPlan.Equals(input.EligibleForEqualPaymentPlan))
                ) && 
                (
                    this.TransactionReferenceId == input.TransactionReferenceId ||
                    (this.TransactionReferenceId != null &&
                    this.TransactionReferenceId.Equals(input.TransactionReferenceId))
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
                if (this.DisplayCardNumber != null)
                    hashCode = hashCode * 59 + this.DisplayCardNumber.GetHashCode();
                if (this.CardHolderType != null)
                    hashCode = hashCode * 59 + this.CardHolderType.GetHashCode();
                if (this.TransactionDate != null)
                    hashCode = hashCode * 59 + this.TransactionDate.GetHashCode();
                if (this.TransactionPostingDate != null)
                    hashCode = hashCode * 59 + this.TransactionPostingDate.GetHashCode();
                if (this.MerchantName != null)
                    hashCode = hashCode * 59 + this.MerchantName.GetHashCode();
                if (this.TransactionCode != null)
                    hashCode = hashCode * 59 + this.TransactionCode.GetHashCode();
                if (this.TransactionDescription != null)
                    hashCode = hashCode * 59 + this.TransactionDescription.GetHashCode();
                if (this.TransactionType != null)
                    hashCode = hashCode * 59 + this.TransactionType.GetHashCode();
                if (this.ForeignTransactionAmount != null)
                    hashCode = hashCode * 59 + this.ForeignTransactionAmount.GetHashCode();
                if (this.ForeignCurrencyCode != null)
                    hashCode = hashCode * 59 + this.ForeignCurrencyCode.GetHashCode();
                if (this.TransactionAmount != null)
                    hashCode = hashCode * 59 + this.TransactionAmount.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.EligibleForEqualPaymentPlan != null)
                    hashCode = hashCode * 59 + this.EligibleForEqualPaymentPlan.GetHashCode();
                if (this.TransactionReferenceId != null)
                    hashCode = hashCode * 59 + this.TransactionReferenceId.GetHashCode();
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
