/* 
 * Money Movement
 *
 * <P>The Money Movement API allow you to move money from Citi customers account. Transfers can be made to predefined payees by customer and individuals not included in the payee list</P> The segment of API will allow to perform below category of transfers:<br><br><b>Personal Transfer-</b> Allowing customer to initiate the money transfers within customer�s own Citi accounts.<br><br><b>Internal transfer-</b> Allowing customer to initiate the money transfer from customer Citi own accounts to other Citi accounts locally.<br><br><b>External transfer-</b> Allowing customer to initiate the money transfer from customer Citi own accounts to other bank accounts locally.<br><br><b>Bill Payment-</b> Allowing customer to initiate the bill payment from customer Citi own accounts to billing organization.<br><br><b>Citi Global Transfer-</b> Allowing customer to initiate the money transfer from customer Citi own accounts to other Citi bank accounts across various Countries.<br><br><b>SEPA Transfer-</b> Allowing customer to initiate money transfer to other European bank accounts within the SEPA territory.<br><br><b>Cross border transfer-</b> Allowing customer to initiate money transfer from customer own account to cross border bank accounts.<br>
 *
 * OpenAPI spec version: 1.0.0e
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
    /// ExecutePaymentInitiationTransactionAdhocMultipleTransferAsyncRequest
    /// </summary>
    [DataContract]
        public partial class ExecutePaymentInitiationTransactionAdhocMultipleTransferAsyncRequest :  IEquatable<ExecutePaymentInitiationTransactionAdhocMultipleTransferAsyncRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutePaymentInitiationTransactionAdhocMultipleTransferAsyncRequest" /> class.
        /// </summary>
        /// <param name="internalDomesticDetails">internalDomesticDetails.</param>
        /// <param name="externalDomesticDetails">externalDomesticDetails.</param>
        /// <param name="crossBorderDetails">crossBorderDetails.</param>
        /// <param name="sepa">sepa.</param>
        public ExecutePaymentInitiationTransactionAdhocMultipleTransferAsyncRequest(InternalDomesticDetails internalDomesticDetails = default(InternalDomesticDetails), ExternalDomesticDetails externalDomesticDetails = default(ExternalDomesticDetails), CrossBorderDetails crossBorderDetails = default(CrossBorderDetails), Sepa sepa = default(Sepa))
        {
            this.InternalDomesticDetails = internalDomesticDetails;
            this.ExternalDomesticDetails = externalDomesticDetails;
            this.CrossBorderDetails = crossBorderDetails;
            this.Sepa = sepa;
        }
        
        /// <summary>
        /// Gets or Sets InternalDomesticDetails
        /// </summary>
        [DataMember(Name="internalDomesticDetails", EmitDefaultValue=false)]
        public InternalDomesticDetails InternalDomesticDetails { get; set; }

        /// <summary>
        /// Gets or Sets ExternalDomesticDetails
        /// </summary>
        [DataMember(Name="externalDomesticDetails", EmitDefaultValue=false)]
        public ExternalDomesticDetails ExternalDomesticDetails { get; set; }

        /// <summary>
        /// Gets or Sets CrossBorderDetails
        /// </summary>
        [DataMember(Name="crossBorderDetails", EmitDefaultValue=false)]
        public CrossBorderDetails CrossBorderDetails { get; set; }

        /// <summary>
        /// Gets or Sets Sepa
        /// </summary>
        [DataMember(Name="sepa", EmitDefaultValue=false)]
        public Sepa Sepa { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecutePaymentInitiationTransactionAdhocMultipleTransferAsyncRequest {\n");
            sb.Append("  InternalDomesticDetails: ").Append(InternalDomesticDetails).Append("\n");
            sb.Append("  ExternalDomesticDetails: ").Append(ExternalDomesticDetails).Append("\n");
            sb.Append("  CrossBorderDetails: ").Append(CrossBorderDetails).Append("\n");
            sb.Append("  Sepa: ").Append(Sepa).Append("\n");
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
            return this.Equals(input as ExecutePaymentInitiationTransactionAdhocMultipleTransferAsyncRequest);
        }

        /// <summary>
        /// Returns true if ExecutePaymentInitiationTransactionAdhocMultipleTransferAsyncRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ExecutePaymentInitiationTransactionAdhocMultipleTransferAsyncRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExecutePaymentInitiationTransactionAdhocMultipleTransferAsyncRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InternalDomesticDetails == input.InternalDomesticDetails ||
                    (this.InternalDomesticDetails != null &&
                    this.InternalDomesticDetails.Equals(input.InternalDomesticDetails))
                ) && 
                (
                    this.ExternalDomesticDetails == input.ExternalDomesticDetails ||
                    (this.ExternalDomesticDetails != null &&
                    this.ExternalDomesticDetails.Equals(input.ExternalDomesticDetails))
                ) && 
                (
                    this.CrossBorderDetails == input.CrossBorderDetails ||
                    (this.CrossBorderDetails != null &&
                    this.CrossBorderDetails.Equals(input.CrossBorderDetails))
                ) && 
                (
                    this.Sepa == input.Sepa ||
                    (this.Sepa != null &&
                    this.Sepa.Equals(input.Sepa))
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
                if (this.InternalDomesticDetails != null)
                    hashCode = hashCode * 59 + this.InternalDomesticDetails.GetHashCode();
                if (this.ExternalDomesticDetails != null)
                    hashCode = hashCode * 59 + this.ExternalDomesticDetails.GetHashCode();
                if (this.CrossBorderDetails != null)
                    hashCode = hashCode * 59 + this.CrossBorderDetails.GetHashCode();
                if (this.Sepa != null)
                    hashCode = hashCode * 59 + this.Sepa.GetHashCode();
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
