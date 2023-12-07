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
    /// AdhocExtDmstcTransferPreprocessRequest
    /// </summary>
    [DataContract]
        public partial class AdhocExtDmstcTransferPreprocessRequest :  IEquatable<AdhocExtDmstcTransferPreprocessRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdhocExtDmstcTransferPreprocessRequest" /> class.
        /// </summary>
        /// <param name="sourceAccountId">The source account identifier in encrypted format.Typically, this is not displayed to the customer. (required).</param>
        /// <param name="payeeAccountDetails">payeeAccountDetails.</param>
        /// <param name="transactionAmount">The transaction amount (required).</param>
        /// <param name="transactionCurrencyCode">The currency code for the transaction amount in ISO 4217 format..</param>
        /// <param name="chargeBearer">Field to identify charge bearer.The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/utilities/referenceData/{chargeBearer} resource to get valid value of this field with description. (required).</param>
        /// <param name="paymentMethod">The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/utilities/referenceData/{paymentMethod} resource to get valid value of this field with description. (required).</param>
        /// <param name="paymentType">The payment type.This is a reference data field. Please use /v1/utilities/referenceData/{paymentType} resource to get valid value of this field with description..</param>
        /// <param name="fxDealReferenceNumber">Fx deal reference number.</param>
        /// <param name="paymentScheduleType">The payment schedule type. This is a reference data. Please use /v1/utilities/referenceData/{paymentScheduleType} resource to get valid value of this field..</param>
        /// <param name="futureDatedTransaction">futureDatedTransaction.</param>
        /// <param name="standingInstruction">standingInstruction.</param>
        /// <param name="taxPaymentDetails">taxPaymentDetails.</param>
        /// <param name="remarks">Payment notes. Free text from screen.</param>
        /// <param name="transferPurpose">Purpose of transfer. Applicable if paymentMethod is GIRO, FAST. This is a reference data field.This is a reference data field. Please use /v1/utilities/referenceData/{transferPurpose} resource to get valid value of this field with description..</param>
        public AdhocExtDmstcTransferPreprocessRequest(string sourceAccountId = default(string), PayeeAccountDetailsAdhocExtTransferPreprocess payeeAccountDetails = default(PayeeAccountDetailsAdhocExtTransferPreprocess), double? transactionAmount = default(double?), string transactionCurrencyCode = default(string), string chargeBearer = default(string), string paymentMethod = default(string), string paymentType = default(string), string fxDealReferenceNumber = default(string), string paymentScheduleType = default(string), FutureDatedTransaction futureDatedTransaction = default(FutureDatedTransaction), StandingInstruction standingInstruction = default(StandingInstruction), TaxPaymentDetails taxPaymentDetails = default(TaxPaymentDetails), string remarks = default(string), string transferPurpose = default(string))
        {
            // to ensure "sourceAccountId" is required (not null)
            if (sourceAccountId == null)
            {
                throw new InvalidDataException("sourceAccountId is a required property for AdhocExtDmstcTransferPreprocessRequest and cannot be null");
            }
            else
            {
                this.SourceAccountId = sourceAccountId;
            }
            // to ensure "transactionAmount" is required (not null)
            if (transactionAmount == null)
            {
                throw new InvalidDataException("transactionAmount is a required property for AdhocExtDmstcTransferPreprocessRequest and cannot be null");
            }
            else
            {
                this.TransactionAmount = transactionAmount;
            }
            // to ensure "chargeBearer" is required (not null)
            if (chargeBearer == null)
            {
                throw new InvalidDataException("chargeBearer is a required property for AdhocExtDmstcTransferPreprocessRequest and cannot be null");
            }
            else
            {
                this.ChargeBearer = chargeBearer;
            }
            // to ensure "paymentMethod" is required (not null)
            if (paymentMethod == null)
            {
                throw new InvalidDataException("paymentMethod is a required property for AdhocExtDmstcTransferPreprocessRequest and cannot be null");
            }
            else
            {
                this.PaymentMethod = paymentMethod;
            }
            this.PayeeAccountDetails = payeeAccountDetails;
            this.TransactionCurrencyCode = transactionCurrencyCode;
            this.PaymentType = paymentType;
            this.FxDealReferenceNumber = fxDealReferenceNumber;
            this.PaymentScheduleType = paymentScheduleType;
            this.FutureDatedTransaction = futureDatedTransaction;
            this.StandingInstruction = standingInstruction;
            this.TaxPaymentDetails = taxPaymentDetails;
            this.Remarks = remarks;
            this.TransferPurpose = transferPurpose;
        }
        
        /// <summary>
        /// The source account identifier in encrypted format.Typically, this is not displayed to the customer.
        /// </summary>
        /// <value>The source account identifier in encrypted format.Typically, this is not displayed to the customer.</value>
        [DataMember(Name="sourceAccountId", EmitDefaultValue=false)]
        public string SourceAccountId { get; set; }

        /// <summary>
        /// Gets or Sets PayeeAccountDetails
        /// </summary>
        [DataMember(Name="payeeAccountDetails", EmitDefaultValue=false)]
        public PayeeAccountDetailsAdhocExtTransferPreprocess PayeeAccountDetails { get; set; }

        /// <summary>
        /// The transaction amount
        /// </summary>
        /// <value>The transaction amount</value>
        [DataMember(Name="transactionAmount", EmitDefaultValue=false)]
        public double? TransactionAmount { get; set; }

        /// <summary>
        /// The currency code for the transaction amount in ISO 4217 format.
        /// </summary>
        /// <value>The currency code for the transaction amount in ISO 4217 format.</value>
        [DataMember(Name="transactionCurrencyCode", EmitDefaultValue=false)]
        public string TransactionCurrencyCode { get; set; }

        /// <summary>
        /// Field to identify charge bearer.The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/utilities/referenceData/{chargeBearer} resource to get valid value of this field with description.
        /// </summary>
        /// <value>Field to identify charge bearer.The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/utilities/referenceData/{chargeBearer} resource to get valid value of this field with description.</value>
        [DataMember(Name="chargeBearer", EmitDefaultValue=false)]
        public string ChargeBearer { get; set; }

        /// <summary>
        /// The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/utilities/referenceData/{paymentMethod} resource to get valid value of this field with description.
        /// </summary>
        /// <value>The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/utilities/referenceData/{paymentMethod} resource to get valid value of this field with description.</value>
        [DataMember(Name="paymentMethod", EmitDefaultValue=false)]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// The payment type.This is a reference data field. Please use /v1/utilities/referenceData/{paymentType} resource to get valid value of this field with description.
        /// </summary>
        /// <value>The payment type.This is a reference data field. Please use /v1/utilities/referenceData/{paymentType} resource to get valid value of this field with description.</value>
        [DataMember(Name="paymentType", EmitDefaultValue=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// Fx deal reference number
        /// </summary>
        /// <value>Fx deal reference number</value>
        [DataMember(Name="fxDealReferenceNumber", EmitDefaultValue=false)]
        public string FxDealReferenceNumber { get; set; }

        /// <summary>
        /// The payment schedule type. This is a reference data. Please use /v1/utilities/referenceData/{paymentScheduleType} resource to get valid value of this field.
        /// </summary>
        /// <value>The payment schedule type. This is a reference data. Please use /v1/utilities/referenceData/{paymentScheduleType} resource to get valid value of this field.</value>
        [DataMember(Name="paymentScheduleType", EmitDefaultValue=false)]
        public string PaymentScheduleType { get; set; }

        /// <summary>
        /// Gets or Sets FutureDatedTransaction
        /// </summary>
        [DataMember(Name="futureDatedTransaction", EmitDefaultValue=false)]
        public FutureDatedTransaction FutureDatedTransaction { get; set; }

        /// <summary>
        /// Gets or Sets StandingInstruction
        /// </summary>
        [DataMember(Name="standingInstruction", EmitDefaultValue=false)]
        public StandingInstruction StandingInstruction { get; set; }

        /// <summary>
        /// Gets or Sets TaxPaymentDetails
        /// </summary>
        [DataMember(Name="taxPaymentDetails", EmitDefaultValue=false)]
        public TaxPaymentDetails TaxPaymentDetails { get; set; }

        /// <summary>
        /// Payment notes. Free text from screen
        /// </summary>
        /// <value>Payment notes. Free text from screen</value>
        [DataMember(Name="remarks", EmitDefaultValue=false)]
        public string Remarks { get; set; }

        /// <summary>
        /// Purpose of transfer. Applicable if paymentMethod is GIRO, FAST. This is a reference data field.This is a reference data field. Please use /v1/utilities/referenceData/{transferPurpose} resource to get valid value of this field with description.
        /// </summary>
        /// <value>Purpose of transfer. Applicable if paymentMethod is GIRO, FAST. This is a reference data field.This is a reference data field. Please use /v1/utilities/referenceData/{transferPurpose} resource to get valid value of this field with description.</value>
        [DataMember(Name="transferPurpose", EmitDefaultValue=false)]
        public string TransferPurpose { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdhocExtDmstcTransferPreprocessRequest {\n");
            sb.Append("  SourceAccountId: ").Append(SourceAccountId).Append("\n");
            sb.Append("  PayeeAccountDetails: ").Append(PayeeAccountDetails).Append("\n");
            sb.Append("  TransactionAmount: ").Append(TransactionAmount).Append("\n");
            sb.Append("  TransactionCurrencyCode: ").Append(TransactionCurrencyCode).Append("\n");
            sb.Append("  ChargeBearer: ").Append(ChargeBearer).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  PaymentType: ").Append(PaymentType).Append("\n");
            sb.Append("  FxDealReferenceNumber: ").Append(FxDealReferenceNumber).Append("\n");
            sb.Append("  PaymentScheduleType: ").Append(PaymentScheduleType).Append("\n");
            sb.Append("  FutureDatedTransaction: ").Append(FutureDatedTransaction).Append("\n");
            sb.Append("  StandingInstruction: ").Append(StandingInstruction).Append("\n");
            sb.Append("  TaxPaymentDetails: ").Append(TaxPaymentDetails).Append("\n");
            sb.Append("  Remarks: ").Append(Remarks).Append("\n");
            sb.Append("  TransferPurpose: ").Append(TransferPurpose).Append("\n");
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
            return this.Equals(input as AdhocExtDmstcTransferPreprocessRequest);
        }

        /// <summary>
        /// Returns true if AdhocExtDmstcTransferPreprocessRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AdhocExtDmstcTransferPreprocessRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdhocExtDmstcTransferPreprocessRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourceAccountId == input.SourceAccountId ||
                    (this.SourceAccountId != null &&
                    this.SourceAccountId.Equals(input.SourceAccountId))
                ) && 
                (
                    this.PayeeAccountDetails == input.PayeeAccountDetails ||
                    (this.PayeeAccountDetails != null &&
                    this.PayeeAccountDetails.Equals(input.PayeeAccountDetails))
                ) && 
                (
                    this.TransactionAmount == input.TransactionAmount ||
                    (this.TransactionAmount != null &&
                    this.TransactionAmount.Equals(input.TransactionAmount))
                ) && 
                (
                    this.TransactionCurrencyCode == input.TransactionCurrencyCode ||
                    (this.TransactionCurrencyCode != null &&
                    this.TransactionCurrencyCode.Equals(input.TransactionCurrencyCode))
                ) && 
                (
                    this.ChargeBearer == input.ChargeBearer ||
                    (this.ChargeBearer != null &&
                    this.ChargeBearer.Equals(input.ChargeBearer))
                ) && 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) && 
                (
                    this.PaymentType == input.PaymentType ||
                    (this.PaymentType != null &&
                    this.PaymentType.Equals(input.PaymentType))
                ) && 
                (
                    this.FxDealReferenceNumber == input.FxDealReferenceNumber ||
                    (this.FxDealReferenceNumber != null &&
                    this.FxDealReferenceNumber.Equals(input.FxDealReferenceNumber))
                ) && 
                (
                    this.PaymentScheduleType == input.PaymentScheduleType ||
                    (this.PaymentScheduleType != null &&
                    this.PaymentScheduleType.Equals(input.PaymentScheduleType))
                ) && 
                (
                    this.FutureDatedTransaction == input.FutureDatedTransaction ||
                    (this.FutureDatedTransaction != null &&
                    this.FutureDatedTransaction.Equals(input.FutureDatedTransaction))
                ) && 
                (
                    this.StandingInstruction == input.StandingInstruction ||
                    (this.StandingInstruction != null &&
                    this.StandingInstruction.Equals(input.StandingInstruction))
                ) && 
                (
                    this.TaxPaymentDetails == input.TaxPaymentDetails ||
                    (this.TaxPaymentDetails != null &&
                    this.TaxPaymentDetails.Equals(input.TaxPaymentDetails))
                ) && 
                (
                    this.Remarks == input.Remarks ||
                    (this.Remarks != null &&
                    this.Remarks.Equals(input.Remarks))
                ) && 
                (
                    this.TransferPurpose == input.TransferPurpose ||
                    (this.TransferPurpose != null &&
                    this.TransferPurpose.Equals(input.TransferPurpose))
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
                if (this.SourceAccountId != null)
                    hashCode = hashCode * 59 + this.SourceAccountId.GetHashCode();
                if (this.PayeeAccountDetails != null)
                    hashCode = hashCode * 59 + this.PayeeAccountDetails.GetHashCode();
                if (this.TransactionAmount != null)
                    hashCode = hashCode * 59 + this.TransactionAmount.GetHashCode();
                if (this.TransactionCurrencyCode != null)
                    hashCode = hashCode * 59 + this.TransactionCurrencyCode.GetHashCode();
                if (this.ChargeBearer != null)
                    hashCode = hashCode * 59 + this.ChargeBearer.GetHashCode();
                if (this.PaymentMethod != null)
                    hashCode = hashCode * 59 + this.PaymentMethod.GetHashCode();
                if (this.PaymentType != null)
                    hashCode = hashCode * 59 + this.PaymentType.GetHashCode();
                if (this.FxDealReferenceNumber != null)
                    hashCode = hashCode * 59 + this.FxDealReferenceNumber.GetHashCode();
                if (this.PaymentScheduleType != null)
                    hashCode = hashCode * 59 + this.PaymentScheduleType.GetHashCode();
                if (this.FutureDatedTransaction != null)
                    hashCode = hashCode * 59 + this.FutureDatedTransaction.GetHashCode();
                if (this.StandingInstruction != null)
                    hashCode = hashCode * 59 + this.StandingInstruction.GetHashCode();
                if (this.TaxPaymentDetails != null)
                    hashCode = hashCode * 59 + this.TaxPaymentDetails.GetHashCode();
                if (this.Remarks != null)
                    hashCode = hashCode * 59 + this.Remarks.GetHashCode();
                if (this.TransferPurpose != null)
                    hashCode = hashCode * 59 + this.TransferPurpose.GetHashCode();
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
