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
    /// AdhocInternalDmstcTransferPreprocessWithAddPayeeResponse
    /// </summary>
    [DataContract]
        public partial class AdhocInternalDmstcTransferPreprocessWithAddPayeeResponse :  IEquatable<AdhocInternalDmstcTransferPreprocessWithAddPayeeResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdhocInternalDmstcTransferPreprocessWithAddPayeeResponse" /> class.
        /// </summary>
        /// <param name="controlFlowId">Control flow Id (required).</param>
        /// <param name="debitDetails">debitDetails.</param>
        /// <param name="creditDetails">creditDetails.</param>
        /// <param name="foreignExchangeRate">Exchange rate.</param>
        /// <param name="forexType">This is an indicator if exchange rate received from host is Counter or Live. This is a reference data field. Please use /v1/apac/utilities/referenceData/{forexType} resource to get valid value of this field with description..</param>
        /// <param name="forexConversionIndicator">This is the indicator if FX rate sent in response is computed on one Unit of Source Currency to Destination currency or one Unit of Destination Currency to Source Currency.This is a reference data field. Please use /v1/apac/utilities/referenceData/{forexConversionIndicator} resource to get valid value of this field with description..</param>
        /// <param name="transactionFee">Transaction fee.</param>
        /// <param name="feeCurrencyCode">Fee currency code in  ISO 4217 format..</param>
        /// <param name="localCurrencyTransactionFee">This is the transactionFee in local currency.</param>
        /// <param name="localCurrencyCode">Local currency code in ISO 4217 Format..</param>
        public AdhocInternalDmstcTransferPreprocessWithAddPayeeResponse(string controlFlowId = default(string), DebitDetails debitDetails = default(DebitDetails), CreditDetails creditDetails = default(CreditDetails), double? foreignExchangeRate = default(double?), string forexType = default(string), string forexConversionIndicator = default(string), double? transactionFee = default(double?), string feeCurrencyCode = default(string), double? localCurrencyTransactionFee = default(double?), string localCurrencyCode = default(string))
        {
            // to ensure "controlFlowId" is required (not null)
            if (controlFlowId == null)
            {
                throw new InvalidDataException("controlFlowId is a required property for AdhocInternalDmstcTransferPreprocessWithAddPayeeResponse and cannot be null");
            }
            else
            {
                this.ControlFlowId = controlFlowId;
            }
            this.DebitDetails = debitDetails;
            this.CreditDetails = creditDetails;
            this.ForeignExchangeRate = foreignExchangeRate;
            this.ForexType = forexType;
            this.ForexConversionIndicator = forexConversionIndicator;
            this.TransactionFee = transactionFee;
            this.FeeCurrencyCode = feeCurrencyCode;
            this.LocalCurrencyTransactionFee = localCurrencyTransactionFee;
            this.LocalCurrencyCode = localCurrencyCode;
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
        /// Exchange rate
        /// </summary>
        /// <value>Exchange rate</value>
        [DataMember(Name="foreignExchangeRate", EmitDefaultValue=false)]
        public double? ForeignExchangeRate { get; set; }

        /// <summary>
        /// This is an indicator if exchange rate received from host is Counter or Live. This is a reference data field. Please use /v1/apac/utilities/referenceData/{forexType} resource to get valid value of this field with description.
        /// </summary>
        /// <value>This is an indicator if exchange rate received from host is Counter or Live. This is a reference data field. Please use /v1/apac/utilities/referenceData/{forexType} resource to get valid value of this field with description.</value>
        [DataMember(Name="forexType", EmitDefaultValue=false)]
        public string ForexType { get; set; }

        /// <summary>
        /// This is the indicator if FX rate sent in response is computed on one Unit of Source Currency to Destination currency or one Unit of Destination Currency to Source Currency.This is a reference data field. Please use /v1/apac/utilities/referenceData/{forexConversionIndicator} resource to get valid value of this field with description.
        /// </summary>
        /// <value>This is the indicator if FX rate sent in response is computed on one Unit of Source Currency to Destination currency or one Unit of Destination Currency to Source Currency.This is a reference data field. Please use /v1/apac/utilities/referenceData/{forexConversionIndicator} resource to get valid value of this field with description.</value>
        [DataMember(Name="forexConversionIndicator", EmitDefaultValue=false)]
        public string ForexConversionIndicator { get; set; }

        /// <summary>
        /// Transaction fee
        /// </summary>
        /// <value>Transaction fee</value>
        [DataMember(Name="transactionFee", EmitDefaultValue=false)]
        public double? TransactionFee { get; set; }

        /// <summary>
        /// Fee currency code in  ISO 4217 format.
        /// </summary>
        /// <value>Fee currency code in  ISO 4217 format.</value>
        [DataMember(Name="feeCurrencyCode", EmitDefaultValue=false)]
        public string FeeCurrencyCode { get; set; }

        /// <summary>
        /// This is the transactionFee in local currency
        /// </summary>
        /// <value>This is the transactionFee in local currency</value>
        [DataMember(Name="localCurrencyTransactionFee", EmitDefaultValue=false)]
        public double? LocalCurrencyTransactionFee { get; set; }

        /// <summary>
        /// Local currency code in ISO 4217 Format.
        /// </summary>
        /// <value>Local currency code in ISO 4217 Format.</value>
        [DataMember(Name="localCurrencyCode", EmitDefaultValue=false)]
        public string LocalCurrencyCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdhocInternalDmstcTransferPreprocessWithAddPayeeResponse {\n");
            sb.Append("  ControlFlowId: ").Append(ControlFlowId).Append("\n");
            sb.Append("  DebitDetails: ").Append(DebitDetails).Append("\n");
            sb.Append("  CreditDetails: ").Append(CreditDetails).Append("\n");
            sb.Append("  ForeignExchangeRate: ").Append(ForeignExchangeRate).Append("\n");
            sb.Append("  ForexType: ").Append(ForexType).Append("\n");
            sb.Append("  ForexConversionIndicator: ").Append(ForexConversionIndicator).Append("\n");
            sb.Append("  TransactionFee: ").Append(TransactionFee).Append("\n");
            sb.Append("  FeeCurrencyCode: ").Append(FeeCurrencyCode).Append("\n");
            sb.Append("  LocalCurrencyTransactionFee: ").Append(LocalCurrencyTransactionFee).Append("\n");
            sb.Append("  LocalCurrencyCode: ").Append(LocalCurrencyCode).Append("\n");
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
            return this.Equals(input as AdhocInternalDmstcTransferPreprocessWithAddPayeeResponse);
        }

        /// <summary>
        /// Returns true if AdhocInternalDmstcTransferPreprocessWithAddPayeeResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AdhocInternalDmstcTransferPreprocessWithAddPayeeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdhocInternalDmstcTransferPreprocessWithAddPayeeResponse input)
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
                    this.ForexType == input.ForexType ||
                    (this.ForexType != null &&
                    this.ForexType.Equals(input.ForexType))
                ) && 
                (
                    this.ForexConversionIndicator == input.ForexConversionIndicator ||
                    (this.ForexConversionIndicator != null &&
                    this.ForexConversionIndicator.Equals(input.ForexConversionIndicator))
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
                ) && 
                (
                    this.LocalCurrencyTransactionFee == input.LocalCurrencyTransactionFee ||
                    (this.LocalCurrencyTransactionFee != null &&
                    this.LocalCurrencyTransactionFee.Equals(input.LocalCurrencyTransactionFee))
                ) && 
                (
                    this.LocalCurrencyCode == input.LocalCurrencyCode ||
                    (this.LocalCurrencyCode != null &&
                    this.LocalCurrencyCode.Equals(input.LocalCurrencyCode))
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
                if (this.ForexType != null)
                    hashCode = hashCode * 59 + this.ForexType.GetHashCode();
                if (this.ForexConversionIndicator != null)
                    hashCode = hashCode * 59 + this.ForexConversionIndicator.GetHashCode();
                if (this.TransactionFee != null)
                    hashCode = hashCode * 59 + this.TransactionFee.GetHashCode();
                if (this.FeeCurrencyCode != null)
                    hashCode = hashCode * 59 + this.FeeCurrencyCode.GetHashCode();
                if (this.LocalCurrencyTransactionFee != null)
                    hashCode = hashCode * 59 + this.LocalCurrencyTransactionFee.GetHashCode();
                if (this.LocalCurrencyCode != null)
                    hashCode = hashCode * 59 + this.LocalCurrencyCode.GetHashCode();
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
