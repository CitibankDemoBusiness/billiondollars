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
    /// ExecutePaymentInitiationTransactionMultipleTransfersAsyncRequest
    /// </summary>
    [DataContract]
        public partial class ExecutePaymentInitiationTransactionMultipleTransfersAsyncRequest :  IEquatable<ExecutePaymentInitiationTransactionMultipleTransfersAsyncRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutePaymentInitiationTransactionMultipleTransfersAsyncRequest" /> class.
        /// </summary>
        /// <param name="bundleId">This is bundle id or unique identifier for bulk transfers.</param>
        /// <param name="totalTransferAmount">This is total transfer amount.</param>
        /// <param name="typeOfTransfers">This is type of transfers.</param>
        /// <param name="sourceAccountId">The source account identifier in encrypted format.Typically, this is not displayed to the customer..</param>
        /// <param name="internalDomesticPayments">internalDomesticPayments.</param>
        /// <param name="externalDomesticPayments">externalDomesticPayments.</param>
        public ExecutePaymentInitiationTransactionMultipleTransfersAsyncRequest(string bundleId = default(string), double? totalTransferAmount = default(double?), string typeOfTransfers = default(string), string sourceAccountId = default(string), List<InternalDomesticPayments> internalDomesticPayments = default(List<InternalDomesticPayments>), List<ExternalDomesticPayments> externalDomesticPayments = default(List<ExternalDomesticPayments>))
        {
            this.BundleId = bundleId;
            this.TotalTransferAmount = totalTransferAmount;
            this.TypeOfTransfers = typeOfTransfers;
            this.SourceAccountId = sourceAccountId;
            this.InternalDomesticPayments = internalDomesticPayments;
            this.ExternalDomesticPayments = externalDomesticPayments;
        }
        
        /// <summary>
        /// This is bundle id or unique identifier for bulk transfers
        /// </summary>
        /// <value>This is bundle id or unique identifier for bulk transfers</value>
        [DataMember(Name="bundleId", EmitDefaultValue=false)]
        public string BundleId { get; set; }

        /// <summary>
        /// This is total transfer amount
        /// </summary>
        /// <value>This is total transfer amount</value>
        [DataMember(Name="totalTransferAmount", EmitDefaultValue=false)]
        public double? TotalTransferAmount { get; set; }

        /// <summary>
        /// This is type of transfers
        /// </summary>
        /// <value>This is type of transfers</value>
        [DataMember(Name="typeOfTransfers", EmitDefaultValue=false)]
        public string TypeOfTransfers { get; set; }

        /// <summary>
        /// The source account identifier in encrypted format.Typically, this is not displayed to the customer.
        /// </summary>
        /// <value>The source account identifier in encrypted format.Typically, this is not displayed to the customer.</value>
        [DataMember(Name="sourceAccountId", EmitDefaultValue=false)]
        public string SourceAccountId { get; set; }

        /// <summary>
        /// Gets or Sets InternalDomesticPayments
        /// </summary>
        [DataMember(Name="internalDomesticPayments", EmitDefaultValue=false)]
        public List<InternalDomesticPayments> InternalDomesticPayments { get; set; }

        /// <summary>
        /// Gets or Sets ExternalDomesticPayments
        /// </summary>
        [DataMember(Name="externalDomesticPayments", EmitDefaultValue=false)]
        public List<ExternalDomesticPayments> ExternalDomesticPayments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecutePaymentInitiationTransactionMultipleTransfersAsyncRequest {\n");
            sb.Append("  BundleId: ").Append(BundleId).Append("\n");
            sb.Append("  TotalTransferAmount: ").Append(TotalTransferAmount).Append("\n");
            sb.Append("  TypeOfTransfers: ").Append(TypeOfTransfers).Append("\n");
            sb.Append("  SourceAccountId: ").Append(SourceAccountId).Append("\n");
            sb.Append("  InternalDomesticPayments: ").Append(InternalDomesticPayments).Append("\n");
            sb.Append("  ExternalDomesticPayments: ").Append(ExternalDomesticPayments).Append("\n");
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
            return this.Equals(input as ExecutePaymentInitiationTransactionMultipleTransfersAsyncRequest);
        }

        /// <summary>
        /// Returns true if ExecutePaymentInitiationTransactionMultipleTransfersAsyncRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ExecutePaymentInitiationTransactionMultipleTransfersAsyncRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExecutePaymentInitiationTransactionMultipleTransfersAsyncRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BundleId == input.BundleId ||
                    (this.BundleId != null &&
                    this.BundleId.Equals(input.BundleId))
                ) && 
                (
                    this.TotalTransferAmount == input.TotalTransferAmount ||
                    (this.TotalTransferAmount != null &&
                    this.TotalTransferAmount.Equals(input.TotalTransferAmount))
                ) && 
                (
                    this.TypeOfTransfers == input.TypeOfTransfers ||
                    (this.TypeOfTransfers != null &&
                    this.TypeOfTransfers.Equals(input.TypeOfTransfers))
                ) && 
                (
                    this.SourceAccountId == input.SourceAccountId ||
                    (this.SourceAccountId != null &&
                    this.SourceAccountId.Equals(input.SourceAccountId))
                ) && 
                (
                    this.InternalDomesticPayments == input.InternalDomesticPayments ||
                    this.InternalDomesticPayments != null &&
                    input.InternalDomesticPayments != null &&
                    this.InternalDomesticPayments.SequenceEqual(input.InternalDomesticPayments)
                ) && 
                (
                    this.ExternalDomesticPayments == input.ExternalDomesticPayments ||
                    this.ExternalDomesticPayments != null &&
                    input.ExternalDomesticPayments != null &&
                    this.ExternalDomesticPayments.SequenceEqual(input.ExternalDomesticPayments)
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
                if (this.BundleId != null)
                    hashCode = hashCode * 59 + this.BundleId.GetHashCode();
                if (this.TotalTransferAmount != null)
                    hashCode = hashCode * 59 + this.TotalTransferAmount.GetHashCode();
                if (this.TypeOfTransfers != null)
                    hashCode = hashCode * 59 + this.TypeOfTransfers.GetHashCode();
                if (this.SourceAccountId != null)
                    hashCode = hashCode * 59 + this.SourceAccountId.GetHashCode();
                if (this.InternalDomesticPayments != null)
                    hashCode = hashCode * 59 + this.InternalDomesticPayments.GetHashCode();
                if (this.ExternalDomesticPayments != null)
                    hashCode = hashCode * 59 + this.ExternalDomesticPayments.GetHashCode();
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
