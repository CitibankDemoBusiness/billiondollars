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
    /// RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse
    /// </summary>
    [DataContract]
        public partial class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse :  IEquatable<RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse" /> class.
        /// </summary>
        /// <param name="customerName">his refers to the name of the customer (required).</param>
        /// <param name="productCode">A unique code that identifies the product (required).</param>
        /// <param name="serviceChargeAmount">Booking Fees Amount.</param>
        /// <param name="cardId">The customer card identifier in encrypted format.</param>
        /// <param name="productName">The name of the product (required).</param>
        /// <param name="displayCardNumber">A masked Card number that can be displayed to the customer (required).</param>
        /// <param name="pendingTransaction">pendingTransaction.</param>
        /// <param name="statement">statement.</param>
        /// <param name="eppOffers">eppOffers.</param>
        public RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse(string customerName = default(string), string productCode = default(string), string serviceChargeAmount = default(string), string cardId = default(string), string productName = default(string), string displayCardNumber = default(string), PendingTransaction pendingTransaction = default(PendingTransaction), Statement statement = default(Statement), List<EppOffers> eppOffers = default(List<EppOffers>))
        {
            // to ensure "customerName" is required (not null)
            if (customerName == null)
            {
                throw new InvalidDataException("customerName is a required property for RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse and cannot be null");
            }
            else
            {
                this.CustomerName = customerName;
            }
            // to ensure "productCode" is required (not null)
            if (productCode == null)
            {
                throw new InvalidDataException("productCode is a required property for RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse and cannot be null");
            }
            else
            {
                this.ProductCode = productCode;
            }
            // to ensure "productName" is required (not null)
            if (productName == null)
            {
                throw new InvalidDataException("productName is a required property for RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse and cannot be null");
            }
            else
            {
                this.ProductName = productName;
            }
            // to ensure "displayCardNumber" is required (not null)
            if (displayCardNumber == null)
            {
                throw new InvalidDataException("displayCardNumber is a required property for RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse and cannot be null");
            }
            else
            {
                this.DisplayCardNumber = displayCardNumber;
            }
            this.ServiceChargeAmount = serviceChargeAmount;
            this.CardId = cardId;
            this.PendingTransaction = pendingTransaction;
            this.Statement = statement;
            this.EppOffers = eppOffers;
        }
        
        /// <summary>
        /// his refers to the name of the customer
        /// </summary>
        /// <value>his refers to the name of the customer</value>
        [DataMember(Name="customerName", EmitDefaultValue=false)]
        public string CustomerName { get; set; }

        /// <summary>
        /// A unique code that identifies the product
        /// </summary>
        /// <value>A unique code that identifies the product</value>
        [DataMember(Name="productCode", EmitDefaultValue=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// Booking Fees Amount
        /// </summary>
        /// <value>Booking Fees Amount</value>
        [DataMember(Name="serviceChargeAmount", EmitDefaultValue=false)]
        public string ServiceChargeAmount { get; set; }

        /// <summary>
        /// The customer card identifier in encrypted format
        /// </summary>
        /// <value>The customer card identifier in encrypted format</value>
        [DataMember(Name="cardId", EmitDefaultValue=false)]
        public string CardId { get; set; }

        /// <summary>
        /// The name of the product
        /// </summary>
        /// <value>The name of the product</value>
        [DataMember(Name="productName", EmitDefaultValue=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// A masked Card number that can be displayed to the customer
        /// </summary>
        /// <value>A masked Card number that can be displayed to the customer</value>
        [DataMember(Name="displayCardNumber", EmitDefaultValue=false)]
        public string DisplayCardNumber { get; set; }

        /// <summary>
        /// Gets or Sets PendingTransaction
        /// </summary>
        [DataMember(Name="pendingTransaction", EmitDefaultValue=false)]
        public PendingTransaction PendingTransaction { get; set; }

        /// <summary>
        /// Gets or Sets Statement
        /// </summary>
        [DataMember(Name="statement", EmitDefaultValue=false)]
        public Statement Statement { get; set; }

        /// <summary>
        /// Gets or Sets EppOffers
        /// </summary>
        [DataMember(Name="eppOffers", EmitDefaultValue=false)]
        public List<EppOffers> EppOffers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse {\n");
            sb.Append("  CustomerName: ").Append(CustomerName).Append("\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
            sb.Append("  ServiceChargeAmount: ").Append(ServiceChargeAmount).Append("\n");
            sb.Append("  CardId: ").Append(CardId).Append("\n");
            sb.Append("  ProductName: ").Append(ProductName).Append("\n");
            sb.Append("  DisplayCardNumber: ").Append(DisplayCardNumber).Append("\n");
            sb.Append("  PendingTransaction: ").Append(PendingTransaction).Append("\n");
            sb.Append("  Statement: ").Append(Statement).Append("\n");
            sb.Append("  EppOffers: ").Append(EppOffers).Append("\n");
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
            return this.Equals(input as RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse);
        }

        /// <summary>
        /// Returns true if RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CustomerName == input.CustomerName ||
                    (this.CustomerName != null &&
                    this.CustomerName.Equals(input.CustomerName))
                ) && 
                (
                    this.ProductCode == input.ProductCode ||
                    (this.ProductCode != null &&
                    this.ProductCode.Equals(input.ProductCode))
                ) && 
                (
                    this.ServiceChargeAmount == input.ServiceChargeAmount ||
                    (this.ServiceChargeAmount != null &&
                    this.ServiceChargeAmount.Equals(input.ServiceChargeAmount))
                ) && 
                (
                    this.CardId == input.CardId ||
                    (this.CardId != null &&
                    this.CardId.Equals(input.CardId))
                ) && 
                (
                    this.ProductName == input.ProductName ||
                    (this.ProductName != null &&
                    this.ProductName.Equals(input.ProductName))
                ) && 
                (
                    this.DisplayCardNumber == input.DisplayCardNumber ||
                    (this.DisplayCardNumber != null &&
                    this.DisplayCardNumber.Equals(input.DisplayCardNumber))
                ) && 
                (
                    this.PendingTransaction == input.PendingTransaction ||
                    (this.PendingTransaction != null &&
                    this.PendingTransaction.Equals(input.PendingTransaction))
                ) && 
                (
                    this.Statement == input.Statement ||
                    (this.Statement != null &&
                    this.Statement.Equals(input.Statement))
                ) && 
                (
                    this.EppOffers == input.EppOffers ||
                    this.EppOffers != null &&
                    input.EppOffers != null &&
                    this.EppOffers.SequenceEqual(input.EppOffers)
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
                if (this.CustomerName != null)
                    hashCode = hashCode * 59 + this.CustomerName.GetHashCode();
                if (this.ProductCode != null)
                    hashCode = hashCode * 59 + this.ProductCode.GetHashCode();
                if (this.ServiceChargeAmount != null)
                    hashCode = hashCode * 59 + this.ServiceChargeAmount.GetHashCode();
                if (this.CardId != null)
                    hashCode = hashCode * 59 + this.CardId.GetHashCode();
                if (this.ProductName != null)
                    hashCode = hashCode * 59 + this.ProductName.GetHashCode();
                if (this.DisplayCardNumber != null)
                    hashCode = hashCode * 59 + this.DisplayCardNumber.GetHashCode();
                if (this.PendingTransaction != null)
                    hashCode = hashCode * 59 + this.PendingTransaction.GetHashCode();
                if (this.Statement != null)
                    hashCode = hashCode * 59 + this.Statement.GetHashCode();
                if (this.EppOffers != null)
                    hashCode = hashCode * 59 + this.EppOffers.GetHashCode();
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
