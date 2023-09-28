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
    /// RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest
    /// </summary>
    [DataContract]
        public partial class RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest :  IEquatable<RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest" /> class.
        /// </summary>
        /// <param name="tokenizedCardNumber">Tokenized card number (required).</param>
        /// <param name="corporateOfficerDetails">corporateOfficerDetails.</param>
        /// <param name="transactionType">transactionType. This is a reference data field. Please use /v1/utilities/referenceData/{transactionType} resource to get possible values of this field with descriptions (required).</param>
        /// <param name="pendingAuthorizationTransaction">pendingAuthorizationTransaction.</param>
        /// <param name="historyAndIntradayTransaction">historyAndIntradayTransaction.</param>
        public RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest(string tokenizedCardNumber = default(string), CorporateOfficerDetails corporateOfficerDetails = default(CorporateOfficerDetails), string transactionType = default(string), PendingAuthorizationTransaction pendingAuthorizationTransaction = default(PendingAuthorizationTransaction), HistoryAndIntradayTransaction historyAndIntradayTransaction = default(HistoryAndIntradayTransaction))
        {
            // to ensure "tokenizedCardNumber" is required (not null)
            if (tokenizedCardNumber == null)
            {
                throw new InvalidDataException("tokenizedCardNumber is a required property for RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest and cannot be null");
            }
            else
            {
                this.TokenizedCardNumber = tokenizedCardNumber;
            }
            // to ensure "transactionType" is required (not null)
            if (transactionType == null)
            {
                throw new InvalidDataException("transactionType is a required property for RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest and cannot be null");
            }
            else
            {
                this.TransactionType = transactionType;
            }
            this.CorporateOfficerDetails = corporateOfficerDetails;
            this.PendingAuthorizationTransaction = pendingAuthorizationTransaction;
            this.HistoryAndIntradayTransaction = historyAndIntradayTransaction;
        }
        
        /// <summary>
        /// Tokenized card number
        /// </summary>
        /// <value>Tokenized card number</value>
        [DataMember(Name="tokenizedCardNumber", EmitDefaultValue=false)]
        public string TokenizedCardNumber { get; set; }

        /// <summary>
        /// Gets or Sets CorporateOfficerDetails
        /// </summary>
        [DataMember(Name="corporateOfficerDetails", EmitDefaultValue=false)]
        public CorporateOfficerDetails CorporateOfficerDetails { get; set; }

        /// <summary>
        /// transactionType. This is a reference data field. Please use /v1/utilities/referenceData/{transactionType} resource to get possible values of this field with descriptions
        /// </summary>
        /// <value>transactionType. This is a reference data field. Please use /v1/utilities/referenceData/{transactionType} resource to get possible values of this field with descriptions</value>
        [DataMember(Name="transactionType", EmitDefaultValue=false)]
        public string TransactionType { get; set; }

        /// <summary>
        /// Gets or Sets PendingAuthorizationTransaction
        /// </summary>
        [DataMember(Name="pendingAuthorizationTransaction", EmitDefaultValue=false)]
        public PendingAuthorizationTransaction PendingAuthorizationTransaction { get; set; }

        /// <summary>
        /// Gets or Sets HistoryAndIntradayTransaction
        /// </summary>
        [DataMember(Name="historyAndIntradayTransaction", EmitDefaultValue=false)]
        public HistoryAndIntradayTransaction HistoryAndIntradayTransaction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest {\n");
            sb.Append("  TokenizedCardNumber: ").Append(TokenizedCardNumber).Append("\n");
            sb.Append("  CorporateOfficerDetails: ").Append(CorporateOfficerDetails).Append("\n");
            sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
            sb.Append("  PendingAuthorizationTransaction: ").Append(PendingAuthorizationTransaction).Append("\n");
            sb.Append("  HistoryAndIntradayTransaction: ").Append(HistoryAndIntradayTransaction).Append("\n");
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
            return this.Equals(input as RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest);
        }

        /// <summary>
        /// Returns true if RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TokenizedCardNumber == input.TokenizedCardNumber ||
                    (this.TokenizedCardNumber != null &&
                    this.TokenizedCardNumber.Equals(input.TokenizedCardNumber))
                ) && 
                (
                    this.CorporateOfficerDetails == input.CorporateOfficerDetails ||
                    (this.CorporateOfficerDetails != null &&
                    this.CorporateOfficerDetails.Equals(input.CorporateOfficerDetails))
                ) && 
                (
                    this.TransactionType == input.TransactionType ||
                    (this.TransactionType != null &&
                    this.TransactionType.Equals(input.TransactionType))
                ) && 
                (
                    this.PendingAuthorizationTransaction == input.PendingAuthorizationTransaction ||
                    (this.PendingAuthorizationTransaction != null &&
                    this.PendingAuthorizationTransaction.Equals(input.PendingAuthorizationTransaction))
                ) && 
                (
                    this.HistoryAndIntradayTransaction == input.HistoryAndIntradayTransaction ||
                    (this.HistoryAndIntradayTransaction != null &&
                    this.HistoryAndIntradayTransaction.Equals(input.HistoryAndIntradayTransaction))
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
                if (this.TokenizedCardNumber != null)
                    hashCode = hashCode * 59 + this.TokenizedCardNumber.GetHashCode();
                if (this.CorporateOfficerDetails != null)
                    hashCode = hashCode * 59 + this.CorporateOfficerDetails.GetHashCode();
                if (this.TransactionType != null)
                    hashCode = hashCode * 59 + this.TransactionType.GetHashCode();
                if (this.PendingAuthorizationTransaction != null)
                    hashCode = hashCode * 59 + this.PendingAuthorizationTransaction.GetHashCode();
                if (this.HistoryAndIntradayTransaction != null)
                    hashCode = hashCode * 59 + this.HistoryAndIntradayTransaction.GetHashCode();
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