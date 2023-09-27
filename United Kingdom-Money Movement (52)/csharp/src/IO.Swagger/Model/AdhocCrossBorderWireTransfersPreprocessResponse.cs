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
    /// AdhocCrossBorderWireTransfersPreprocessResponse
    /// </summary>
    [DataContract]
        public partial class AdhocCrossBorderWireTransfersPreprocessResponse :  IEquatable<AdhocCrossBorderWireTransfersPreprocessResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdhocCrossBorderWireTransfersPreprocessResponse" /> class.
        /// </summary>
        /// <param name="controlFlowId">Control flow Id (required).</param>
        /// <param name="debitDetails">debitDetails.</param>
        /// <param name="creditDetails">creditDetails.</param>
        /// <param name="foreignExchangeRate">The exchange rate that is applicable for the particular transfer.  (required).</param>
        /// <param name="transactionFee">The charges that is being charged by the source bank for doing the transfer. (required).</param>
        /// <param name="feeCurrencyCode">Fee currency code in ISO 4217 Format..</param>
        public AdhocCrossBorderWireTransfersPreprocessResponse(string controlFlowId = default(string), DebitDetails debitDetails = default(DebitDetails), CreditDetails creditDetails = default(CreditDetails), double? foreignExchangeRate = default(double?), double? transactionFee = default(double?), string feeCurrencyCode = default(string))
        {
            // to ensure "controlFlowId" is required (not null)
            if (controlFlowId == null)
            {
                throw new InvalidDataException("controlFlowId is a required property for AdhocCrossBorderWireTransfersPreprocessResponse and cannot be null");
            }
            else
            {
                this.ControlFlowId = controlFlowId;
            }
            // to ensure "foreignExchangeRate" is required (not null)
            if (foreignExchangeRate == null)
            {
                throw new InvalidDataException("foreignExchangeRate is a required property for AdhocCrossBorderWireTransfersPreprocessResponse and cannot be null");
            }
            else
            {
                this.ForeignExchangeRate = foreignExchangeRate;
            }
            // to ensure "transactionFee" is required (not null)
            if (transactionFee == null)
            {
                throw new InvalidDataException("transactionFee is a required property for AdhocCrossBorderWireTransfersPreprocessResponse and cannot be null");
            }
            else
            {
                this.TransactionFee = transactionFee;
            }
            this.DebitDetails = debitDetails;
            this.CreditDetails = creditDetails;
            this.FeeCurrencyCode = feeCurrencyCode;
        }
        
        /// <summary>
        /// Control flow Id
        /// </summary>
        /// <value>Control flow Id</value>
        [DataMember(Name="controlFlowId", EmitDefaultValue=false)]
        public string ControlFlowId { get; set; }

        /// <summary>
        /// Gets or Sets DebitDetails
        /// </summary>
        [DataMember(Name="debitDetails", EmitDefaultValue=false)]
        public DebitDetails DebitDetails { get; set; }

        /// <summary>
        /// Gets or Sets CreditDetails
        /// </summary>
        [DataMember(Name="creditDetails", EmitDefaultValue=false)]
        public CreditDetails CreditDetails { get; set; }

        /// <summary>
        /// The exchange rate that is applicable for the particular transfer. 
        /// </summary>
        /// <value>The exchange rate that is applicable for the particular transfer. </value>
        [DataMember(Name="foreignExchangeRate", EmitDefaultValue=false)]
        public double? ForeignExchangeRate { get; set; }

        /// <summary>
        /// The charges that is being charged by the source bank for doing the transfer.
        /// </summary>
        /// <value>The charges that is being charged by the source bank for doing the transfer.</value>
        [DataMember(Name="transactionFee", EmitDefaultValue=false)]
        public double? TransactionFee { get; set; }

        /// <summary>
        /// Fee currency code in ISO 4217 Format.
        /// </summary>
        /// <value>Fee currency code in ISO 4217 Format.</value>
        [DataMember(Name="feeCurrencyCode", EmitDefaultValue=false)]
        public string FeeCurrencyCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdhocCrossBorderWireTransfersPreprocessResponse {\n");
            sb.Append("  ControlFlowId: ").Append(ControlFlowId).Append("\n");
            sb.Append("  DebitDetails: ").Append(DebitDetails).Append("\n");
            sb.Append("  CreditDetails: ").Append(CreditDetails).Append("\n");
            sb.Append("  ForeignExchangeRate: ").Append(ForeignExchangeRate).Append("\n");
            sb.Append("  TransactionFee: ").Append(TransactionFee).Append("\n");
            sb.Append("  FeeCurrencyCode: ").Append(FeeCurrencyCode).Append("\n");
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
            return this.Equals(input as AdhocCrossBorderWireTransfersPreprocessResponse);
        }

        /// <summary>
        /// Returns true if AdhocCrossBorderWireTransfersPreprocessResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AdhocCrossBorderWireTransfersPreprocessResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdhocCrossBorderWireTransfersPreprocessResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ControlFlowId == input.ControlFlowId ||
                    (this.ControlFlowId != null &&
                    this.ControlFlowId.Equals(input.ControlFlowId))
                ) && 
                (
                    this.DebitDetails == input.DebitDetails ||
                    (this.DebitDetails != null &&
                    this.DebitDetails.Equals(input.DebitDetails))
                ) && 
                (
                    this.CreditDetails == input.CreditDetails ||
                    (this.CreditDetails != null &&
                    this.CreditDetails.Equals(input.CreditDetails))
                ) && 
                (
                    this.ForeignExchangeRate == input.ForeignExchangeRate ||
                    (this.ForeignExchangeRate != null &&
                    this.ForeignExchangeRate.Equals(input.ForeignExchangeRate))
                ) && 
                (
                    this.TransactionFee == input.TransactionFee ||
                    (this.TransactionFee != null &&
                    this.TransactionFee.Equals(input.TransactionFee))
                ) && 
                (
                    this.FeeCurrencyCode == input.FeeCurrencyCode ||
                    (this.FeeCurrencyCode != null &&
                    this.FeeCurrencyCode.Equals(input.FeeCurrencyCode))
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
                if (this.ControlFlowId != null)
                    hashCode = hashCode * 59 + this.ControlFlowId.GetHashCode();
                if (this.DebitDetails != null)
                    hashCode = hashCode * 59 + this.DebitDetails.GetHashCode();
                if (this.CreditDetails != null)
                    hashCode = hashCode * 59 + this.CreditDetails.GetHashCode();
                if (this.ForeignExchangeRate != null)
                    hashCode = hashCode * 59 + this.ForeignExchangeRate.GetHashCode();
                if (this.TransactionFee != null)
                    hashCode = hashCode * 59 + this.TransactionFee.GetHashCode();
                if (this.FeeCurrencyCode != null)
                    hashCode = hashCode * 59 + this.FeeCurrencyCode.GetHashCode();
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
