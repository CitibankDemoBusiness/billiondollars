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
    /// RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest
    /// </summary>
    [DataContract]
        public partial class RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest :  IEquatable<RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest" /> class.
        /// </summary>
        /// <param name="cardDetails">cardDetails.</param>
        /// <param name="originalAuthorizationCode">Authorization Code for Original Transaction (required).</param>
        /// <param name="refundAuthorizationCode">Authorization Code for Refund Transaction (required).</param>
        public RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest(CardDetails cardDetails = default(CardDetails), string originalAuthorizationCode = default(string), string refundAuthorizationCode = default(string))
        {
            // to ensure "originalAuthorizationCode" is required (not null)
            if (originalAuthorizationCode == null)
            {
                throw new InvalidDataException("originalAuthorizationCode is a required property for RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest and cannot be null");
            }
            else
            {
                this.OriginalAuthorizationCode = originalAuthorizationCode;
            }
            // to ensure "refundAuthorizationCode" is required (not null)
            if (refundAuthorizationCode == null)
            {
                throw new InvalidDataException("refundAuthorizationCode is a required property for RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest and cannot be null");
            }
            else
            {
                this.RefundAuthorizationCode = refundAuthorizationCode;
            }
            this.CardDetails = cardDetails;
        }
        
        /// <summary>
        /// Gets or Sets CardDetails
        /// </summary>
        [DataMember(Name="cardDetails", EmitDefaultValue=false)]
        public CardDetails CardDetails { get; set; }

        /// <summary>
        /// Authorization Code for Original Transaction
        /// </summary>
        /// <value>Authorization Code for Original Transaction</value>
        [DataMember(Name="originalAuthorizationCode", EmitDefaultValue=false)]
        public string OriginalAuthorizationCode { get; set; }

        /// <summary>
        /// Authorization Code for Refund Transaction
        /// </summary>
        /// <value>Authorization Code for Refund Transaction</value>
        [DataMember(Name="refundAuthorizationCode", EmitDefaultValue=false)]
        public string RefundAuthorizationCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest {\n");
            sb.Append("  CardDetails: ").Append(CardDetails).Append("\n");
            sb.Append("  OriginalAuthorizationCode: ").Append(OriginalAuthorizationCode).Append("\n");
            sb.Append("  RefundAuthorizationCode: ").Append(RefundAuthorizationCode).Append("\n");
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
            return this.Equals(input as RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest);
        }

        /// <summary>
        /// Returns true if RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CardDetails == input.CardDetails ||
                    (this.CardDetails != null &&
                    this.CardDetails.Equals(input.CardDetails))
                ) && 
                (
                    this.OriginalAuthorizationCode == input.OriginalAuthorizationCode ||
                    (this.OriginalAuthorizationCode != null &&
                    this.OriginalAuthorizationCode.Equals(input.OriginalAuthorizationCode))
                ) && 
                (
                    this.RefundAuthorizationCode == input.RefundAuthorizationCode ||
                    (this.RefundAuthorizationCode != null &&
                    this.RefundAuthorizationCode.Equals(input.RefundAuthorizationCode))
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
                if (this.CardDetails != null)
                    hashCode = hashCode * 59 + this.CardDetails.GetHashCode();
                if (this.OriginalAuthorizationCode != null)
                    hashCode = hashCode * 59 + this.OriginalAuthorizationCode.GetHashCode();
                if (this.RefundAuthorizationCode != null)
                    hashCode = hashCode * 59 + this.RefundAuthorizationCode.GetHashCode();
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