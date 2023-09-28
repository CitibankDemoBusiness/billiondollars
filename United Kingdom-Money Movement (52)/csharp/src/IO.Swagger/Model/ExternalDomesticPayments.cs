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
    /// ExternalDomesticPayments
    /// </summary>
    [DataContract]
        public partial class ExternalDomesticPayments :  IEquatable<ExternalDomesticPayments>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalDomesticPayments" /> class.
        /// </summary>
        /// <param name="transactionAmount">Transaction Amount (required).</param>
        /// <param name="transferCurrencyIndicator">Indicator to specify whether the transfer is in source or destination account currency.The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/utilities/referenceData/{transferCurrencyIndicator} resource to get valid value of this field with description.\&quot;, (required).</param>
        /// <param name="payeeId">The payee identifier in encrypted format.Typically, this is not displayed to the customer. (required).</param>
        /// <param name="chargeBearer">Field to identify charge bearer.The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/utilities/referenceData/{chargeBearer} resource to get valid value of this field with description.\&quot;, (required).</param>
        /// <param name="paymentMethod">The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/utilities/referenceData/{paymentMethod} resource to get valid value of this field with description.\&quot;, (required).</param>
        /// <param name="fxDealReferenceNumber">Fx deal reference number.</param>
        /// <param name="remarks">Payment notes. Free text from screen\&quot;.</param>
        /// <param name="transferPurpose">Purpose of transfer. Applicable if paymentMethod is GIRO, FAST. This is a reference data field.This is a reference data field. Please use /v1/utilities/referenceData/{transferPurpose} resource to get valid value of this field with description..</param>
        /// <param name="transferSubPurpose">Sub Purpose Of Transfer.</param>
        /// <param name="paymentScheduleType">From various Option Support - CVT table. - Immediate -  FutureDated ( Date Selection ) - Future Dated Recurring ( Date Selection and Frequency - Last Date ) for Poland only Immediate and One Time Future Dated.</param>
        /// <param name="futureDatedTransaction">futureDatedTransaction.</param>
        /// <param name="standingInstruction">standingInstruction.</param>
        /// <param name="anticipatoryPaymentFlag">anticipatory paymentFlag.</param>
        /// <param name="uniquePaymentId">this is free text unique value. This is end to end identification ID.</param>
        public ExternalDomesticPayments(double? transactionAmount = default(double?), string transferCurrencyIndicator = default(string), string payeeId = default(string), string chargeBearer = default(string), string paymentMethod = default(string), string fxDealReferenceNumber = default(string), string remarks = default(string), string transferPurpose = default(string), string transferSubPurpose = default(string), string paymentScheduleType = default(string), FutureDatedTransaction futureDatedTransaction = default(FutureDatedTransaction), StandingInstruction standingInstruction = default(StandingInstruction), bool? anticipatoryPaymentFlag = default(bool?), string uniquePaymentId = default(string))
        {
            // to ensure "transactionAmount" is required (not null)
            if (transactionAmount == null)
            {
                throw new InvalidDataException("transactionAmount is a required property for ExternalDomesticPayments and cannot be null");
            }
            else
            {
                this.TransactionAmount = transactionAmount;
            }
            // to ensure "transferCurrencyIndicator" is required (not null)
            if (transferCurrencyIndicator == null)
            {
                throw new InvalidDataException("transferCurrencyIndicator is a required property for ExternalDomesticPayments and cannot be null");
            }
            else
            {
                this.TransferCurrencyIndicator = transferCurrencyIndicator;
            }
            // to ensure "payeeId" is required (not null)
            if (payeeId == null)
            {
                throw new InvalidDataException("payeeId is a required property for ExternalDomesticPayments and cannot be null");
            }
            else
            {
                this.PayeeId = payeeId;
            }
            // to ensure "chargeBearer" is required (not null)
            if (chargeBearer == null)
            {
                throw new InvalidDataException("chargeBearer is a required property for ExternalDomesticPayments and cannot be null");
            }
            else
            {
                this.ChargeBearer = chargeBearer;
            }
            // to ensure "paymentMethod" is required (not null)
            if (paymentMethod == null)
            {
                throw new InvalidDataException("paymentMethod is a required property for ExternalDomesticPayments and cannot be null");
            }
            else
            {
                this.PaymentMethod = paymentMethod;
            }
            this.FxDealReferenceNumber = fxDealReferenceNumber;
            this.Remarks = remarks;
            this.TransferPurpose = transferPurpose;
            this.TransferSubPurpose = transferSubPurpose;
            this.PaymentScheduleType = paymentScheduleType;
            this.FutureDatedTransaction = futureDatedTransaction;
            this.StandingInstruction = standingInstruction;
            this.AnticipatoryPaymentFlag = anticipatoryPaymentFlag;
            this.UniquePaymentId = uniquePaymentId;
        }
        
        /// <summary>
        /// Transaction Amount
        /// </summary>
        /// <value>Transaction Amount</value>
        [DataMember(Name="transactionAmount", EmitDefaultValue=false)]
        public double? TransactionAmount { get; set; }

        /// <summary>
        /// Indicator to specify whether the transfer is in source or destination account currency.The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/utilities/referenceData/{transferCurrencyIndicator} resource to get valid value of this field with description.\&quot;,
        /// </summary>
        /// <value>Indicator to specify whether the transfer is in source or destination account currency.The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/utilities/referenceData/{transferCurrencyIndicator} resource to get valid value of this field with description.\&quot;,</value>
        [DataMember(Name="transferCurrencyIndicator", EmitDefaultValue=false)]
        public string TransferCurrencyIndicator { get; set; }

        /// <summary>
        /// The payee identifier in encrypted format.Typically, this is not displayed to the customer.
        /// </summary>
        /// <value>The payee identifier in encrypted format.Typically, this is not displayed to the customer.</value>
        [DataMember(Name="payeeId", EmitDefaultValue=false)]
        public string PayeeId { get; set; }

        /// <summary>
        /// Field to identify charge bearer.The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/utilities/referenceData/{chargeBearer} resource to get valid value of this field with description.\&quot;,
        /// </summary>
        /// <value>Field to identify charge bearer.The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/utilities/referenceData/{chargeBearer} resource to get valid value of this field with description.\&quot;,</value>
        [DataMember(Name="chargeBearer", EmitDefaultValue=false)]
        public string ChargeBearer { get; set; }

        /// <summary>
        /// The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/utilities/referenceData/{paymentMethod} resource to get valid value of this field with description.\&quot;,
        /// </summary>
        /// <value>The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/utilities/referenceData/{paymentMethod} resource to get valid value of this field with description.\&quot;,</value>
        [DataMember(Name="paymentMethod", EmitDefaultValue=false)]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Fx deal reference number
        /// </summary>
        /// <value>Fx deal reference number</value>
        [DataMember(Name="fxDealReferenceNumber", EmitDefaultValue=false)]
        public string FxDealReferenceNumber { get; set; }

        /// <summary>
        /// Payment notes. Free text from screen\&quot;
        /// </summary>
        /// <value>Payment notes. Free text from screen\&quot;</value>
        [DataMember(Name="remarks", EmitDefaultValue=false)]
        public string Remarks { get; set; }

        /// <summary>
        /// Purpose of transfer. Applicable if paymentMethod is GIRO, FAST. This is a reference data field.This is a reference data field. Please use /v1/utilities/referenceData/{transferPurpose} resource to get valid value of this field with description.
        /// </summary>
        /// <value>Purpose of transfer. Applicable if paymentMethod is GIRO, FAST. This is a reference data field.This is a reference data field. Please use /v1/utilities/referenceData/{transferPurpose} resource to get valid value of this field with description.</value>
        [DataMember(Name="transferPurpose", EmitDefaultValue=false)]
        public string TransferPurpose { get; set; }

        /// <summary>
        /// Sub Purpose Of Transfer
        /// </summary>
        /// <value>Sub Purpose Of Transfer</value>
        [DataMember(Name="transferSubPurpose", EmitDefaultValue=false)]
        public string TransferSubPurpose { get; set; }

        /// <summary>
        /// From various Option Support - CVT table. - Immediate -  FutureDated ( Date Selection ) - Future Dated Recurring ( Date Selection and Frequency - Last Date ) for Poland only Immediate and One Time Future Dated
        /// </summary>
        /// <value>From various Option Support - CVT table. - Immediate -  FutureDated ( Date Selection ) - Future Dated Recurring ( Date Selection and Frequency - Last Date ) for Poland only Immediate and One Time Future Dated</value>
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
        /// anticipatory paymentFlag
        /// </summary>
        /// <value>anticipatory paymentFlag</value>
        [DataMember(Name="anticipatoryPaymentFlag", EmitDefaultValue=false)]
        public bool? AnticipatoryPaymentFlag { get; set; }

        /// <summary>
        /// this is free text unique value. This is end to end identification ID
        /// </summary>
        /// <value>this is free text unique value. This is end to end identification ID</value>
        [DataMember(Name="uniquePaymentId", EmitDefaultValue=false)]
        public string UniquePaymentId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalDomesticPayments {\n");
            sb.Append("  TransactionAmount: ").Append(TransactionAmount).Append("\n");
            sb.Append("  TransferCurrencyIndicator: ").Append(TransferCurrencyIndicator).Append("\n");
            sb.Append("  PayeeId: ").Append(PayeeId).Append("\n");
            sb.Append("  ChargeBearer: ").Append(ChargeBearer).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  FxDealReferenceNumber: ").Append(FxDealReferenceNumber).Append("\n");
            sb.Append("  Remarks: ").Append(Remarks).Append("\n");
            sb.Append("  TransferPurpose: ").Append(TransferPurpose).Append("\n");
            sb.Append("  TransferSubPurpose: ").Append(TransferSubPurpose).Append("\n");
            sb.Append("  PaymentScheduleType: ").Append(PaymentScheduleType).Append("\n");
            sb.Append("  FutureDatedTransaction: ").Append(FutureDatedTransaction).Append("\n");
            sb.Append("  StandingInstruction: ").Append(StandingInstruction).Append("\n");
            sb.Append("  AnticipatoryPaymentFlag: ").Append(AnticipatoryPaymentFlag).Append("\n");
            sb.Append("  UniquePaymentId: ").Append(UniquePaymentId).Append("\n");
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
            return this.Equals(input as ExternalDomesticPayments);
        }

        /// <summary>
        /// Returns true if ExternalDomesticPayments instances are equal
        /// </summary>
        /// <param name="input">Instance of ExternalDomesticPayments to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalDomesticPayments input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TransactionAmount == input.TransactionAmount ||
                    (this.TransactionAmount != null &&
                    this.TransactionAmount.Equals(input.TransactionAmount))
                ) && 
                (
                    this.TransferCurrencyIndicator == input.TransferCurrencyIndicator ||
                    (this.TransferCurrencyIndicator != null &&
                    this.TransferCurrencyIndicator.Equals(input.TransferCurrencyIndicator))
                ) && 
                (
                    this.PayeeId == input.PayeeId ||
                    (this.PayeeId != null &&
                    this.PayeeId.Equals(input.PayeeId))
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
                    this.FxDealReferenceNumber == input.FxDealReferenceNumber ||
                    (this.FxDealReferenceNumber != null &&
                    this.FxDealReferenceNumber.Equals(input.FxDealReferenceNumber))
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
                ) && 
                (
                    this.TransferSubPurpose == input.TransferSubPurpose ||
                    (this.TransferSubPurpose != null &&
                    this.TransferSubPurpose.Equals(input.TransferSubPurpose))
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
                    this.AnticipatoryPaymentFlag == input.AnticipatoryPaymentFlag ||
                    (this.AnticipatoryPaymentFlag != null &&
                    this.AnticipatoryPaymentFlag.Equals(input.AnticipatoryPaymentFlag))
                ) && 
                (
                    this.UniquePaymentId == input.UniquePaymentId ||
                    (this.UniquePaymentId != null &&
                    this.UniquePaymentId.Equals(input.UniquePaymentId))
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
                if (this.TransactionAmount != null)
                    hashCode = hashCode * 59 + this.TransactionAmount.GetHashCode();
                if (this.TransferCurrencyIndicator != null)
                    hashCode = hashCode * 59 + this.TransferCurrencyIndicator.GetHashCode();
                if (this.PayeeId != null)
                    hashCode = hashCode * 59 + this.PayeeId.GetHashCode();
                if (this.ChargeBearer != null)
                    hashCode = hashCode * 59 + this.ChargeBearer.GetHashCode();
                if (this.PaymentMethod != null)
                    hashCode = hashCode * 59 + this.PaymentMethod.GetHashCode();
                if (this.FxDealReferenceNumber != null)
                    hashCode = hashCode * 59 + this.FxDealReferenceNumber.GetHashCode();
                if (this.Remarks != null)
                    hashCode = hashCode * 59 + this.Remarks.GetHashCode();
                if (this.TransferPurpose != null)
                    hashCode = hashCode * 59 + this.TransferPurpose.GetHashCode();
                if (this.TransferSubPurpose != null)
                    hashCode = hashCode * 59 + this.TransferSubPurpose.GetHashCode();
                if (this.PaymentScheduleType != null)
                    hashCode = hashCode * 59 + this.PaymentScheduleType.GetHashCode();
                if (this.FutureDatedTransaction != null)
                    hashCode = hashCode * 59 + this.FutureDatedTransaction.GetHashCode();
                if (this.StandingInstruction != null)
                    hashCode = hashCode * 59 + this.StandingInstruction.GetHashCode();
                if (this.AnticipatoryPaymentFlag != null)
                    hashCode = hashCode * 59 + this.AnticipatoryPaymentFlag.GetHashCode();
                if (this.UniquePaymentId != null)
                    hashCode = hashCode * 59 + this.UniquePaymentId.GetHashCode();
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