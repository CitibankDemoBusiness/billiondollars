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
    /// AdhocAccountProxyTransfersPreprocessWithAddPayeeRequest
    /// </summary>
    [DataContract]
        public partial class AdhocAccountProxyTransfersPreprocessWithAddPayeeRequest :  IEquatable<AdhocAccountProxyTransfersPreprocessWithAddPayeeRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdhocAccountProxyTransfersPreprocessWithAddPayeeRequest" /> class.
        /// </summary>
        /// <param name="proxyPaymentType">The type of proxy payment.This is a reference data field. Please use /v1/utilities/referenceData/{proxyPaymentType} resource to get valid value of this field with description. (required).</param>
        /// <param name="sourceAccountId">The source account identifier in encrypted format.Typically, this is not displayed to the customer. (required).</param>
        /// <param name="transactionAmount">The transaction amount (required).</param>
        /// <param name="transactionCurrencyCode">The currency code for the transaction amount in ISO 4217 format..</param>
        /// <param name="transferCurrencyIndicator">Indicator to specify whether the transfer is in source or destination account currency.The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/utilities/referenceData/{transferCurrencyIndicator} resource to get valid value of this field with description. (required).</param>
        /// <param name="proxyAccountId">This field is used to refer the proxy account number. (required).</param>
        /// <param name="proxyAccountIdType">This field is used to refer the proxy account number. This is a reference data field. Please use /v1/utilities/referenceData/{proxyAccountIdType} resource to get valid value of this field with description. (required).</param>
        /// <param name="chargeBearer">Field to identify charge bearer.The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/utilities/referenceData/{chargeBearer} resource to get valid value of this field with description. (required).</param>
        /// <param name="billReferenceNumber">Bill payment reference number belongs to merchant..</param>
        /// <param name="remarks">Payment notes. Free text from screen.</param>
        /// <param name="transferPurpose">Purpose of transfer. Applicable if paymentMethod is GIRO, FAST. This is a reference data field.This is a reference data field. Please use /v1/utilities/referenceData/{transferPurpose} resource to get valid value of this field with description..</param>
        /// <param name="payeeNickName">The nick name of the payee assigned by the customer..</param>
        /// <param name="payeeEnrollmentFlag">Flag to indicate the payee must be added to customers registered list of billers..</param>
        /// <param name="bankName">Name of the bank. Applicable only for CNIBPS. Customer can input BankName also on screen to Transfer the fund for proxy registered to Bank instead Default Bank.</param>
        /// <param name="customerName">Name of the customer. Applicable only for CNIBPS. specific to CNIBPS. Customer can input name on screen, which will be validated in IBPS system.</param>
        public AdhocAccountProxyTransfersPreprocessWithAddPayeeRequest(string proxyPaymentType = default(string), string sourceAccountId = default(string), double? transactionAmount = default(double?), string transactionCurrencyCode = default(string), string transferCurrencyIndicator = default(string), string proxyAccountId = default(string), string proxyAccountIdType = default(string), string chargeBearer = default(string), string billReferenceNumber = default(string), string remarks = default(string), string transferPurpose = default(string), string payeeNickName = default(string), bool? payeeEnrollmentFlag = default(bool?), string bankName = default(string), string customerName = default(string))
        {
            // to ensure "proxyPaymentType" is required (not null)
            if (proxyPaymentType == null)
            {
                throw new InvalidDataException("proxyPaymentType is a required property for AdhocAccountProxyTransfersPreprocessWithAddPayeeRequest and cannot be null");
            }
            else
            {
                this.ProxyPaymentType = proxyPaymentType;
            }
            // to ensure "sourceAccountId" is required (not null)
            if (sourceAccountId == null)
            {
                throw new InvalidDataException("sourceAccountId is a required property for AdhocAccountProxyTransfersPreprocessWithAddPayeeRequest and cannot be null");
            }
            else
            {
                this.SourceAccountId = sourceAccountId;
            }
            // to ensure "transactionAmount" is required (not null)
            if (transactionAmount == null)
            {
                throw new InvalidDataException("transactionAmount is a required property for AdhocAccountProxyTransfersPreprocessWithAddPayeeRequest and cannot be null");
            }
            else
            {
                this.TransactionAmount = transactionAmount;
            }
            // to ensure "transferCurrencyIndicator" is required (not null)
            if (transferCurrencyIndicator == null)
            {
                throw new InvalidDataException("transferCurrencyIndicator is a required property for AdhocAccountProxyTransfersPreprocessWithAddPayeeRequest and cannot be null");
            }
            else
            {
                this.TransferCurrencyIndicator = transferCurrencyIndicator;
            }
            // to ensure "proxyAccountId" is required (not null)
            if (proxyAccountId == null)
            {
                throw new InvalidDataException("proxyAccountId is a required property for AdhocAccountProxyTransfersPreprocessWithAddPayeeRequest and cannot be null");
            }
            else
            {
                this.ProxyAccountId = proxyAccountId;
            }
            // to ensure "proxyAccountIdType" is required (not null)
            if (proxyAccountIdType == null)
            {
                throw new InvalidDataException("proxyAccountIdType is a required property for AdhocAccountProxyTransfersPreprocessWithAddPayeeRequest and cannot be null");
            }
            else
            {
                this.ProxyAccountIdType = proxyAccountIdType;
            }
            // to ensure "chargeBearer" is required (not null)
            if (chargeBearer == null)
            {
                throw new InvalidDataException("chargeBearer is a required property for AdhocAccountProxyTransfersPreprocessWithAddPayeeRequest and cannot be null");
            }
            else
            {
                this.ChargeBearer = chargeBearer;
            }
            this.TransactionCurrencyCode = transactionCurrencyCode;
            this.BillReferenceNumber = billReferenceNumber;
            this.Remarks = remarks;
            this.TransferPurpose = transferPurpose;
            this.PayeeNickName = payeeNickName;
            this.PayeeEnrollmentFlag = payeeEnrollmentFlag;
            this.BankName = bankName;
            this.CustomerName = customerName;
        }
        
        /// <summary>
        /// The type of proxy payment.This is a reference data field. Please use /v1/utilities/referenceData/{proxyPaymentType} resource to get valid value of this field with description.
        /// </summary>
        /// <value>The type of proxy payment.This is a reference data field. Please use /v1/utilities/referenceData/{proxyPaymentType} resource to get valid value of this field with description.</value>
        [DataMember(Name="proxyPaymentType", EmitDefaultValue=false)]
        public string ProxyPaymentType { get; set; }

        /// <summary>
        /// The source account identifier in encrypted format.Typically, this is not displayed to the customer.
        /// </summary>
        /// <value>The source account identifier in encrypted format.Typically, this is not displayed to the customer.</value>
        [DataMember(Name="sourceAccountId", EmitDefaultValue=false)]
        public string SourceAccountId { get; set; }

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
        /// Indicator to specify whether the transfer is in source or destination account currency.The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/utilities/referenceData/{transferCurrencyIndicator} resource to get valid value of this field with description.
        /// </summary>
        /// <value>Indicator to specify whether the transfer is in source or destination account currency.The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/utilities/referenceData/{transferCurrencyIndicator} resource to get valid value of this field with description.</value>
        [DataMember(Name="transferCurrencyIndicator", EmitDefaultValue=false)]
        public string TransferCurrencyIndicator { get; set; }

        /// <summary>
        /// This field is used to refer the proxy account number.
        /// </summary>
        /// <value>This field is used to refer the proxy account number.</value>
        [DataMember(Name="proxyAccountId", EmitDefaultValue=false)]
        public string ProxyAccountId { get; set; }

        /// <summary>
        /// This field is used to refer the proxy account number. This is a reference data field. Please use /v1/utilities/referenceData/{proxyAccountIdType} resource to get valid value of this field with description.
        /// </summary>
        /// <value>This field is used to refer the proxy account number. This is a reference data field. Please use /v1/utilities/referenceData/{proxyAccountIdType} resource to get valid value of this field with description.</value>
        [DataMember(Name="proxyAccountIdType", EmitDefaultValue=false)]
        public string ProxyAccountIdType { get; set; }

        /// <summary>
        /// Field to identify charge bearer.The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/utilities/referenceData/{chargeBearer} resource to get valid value of this field with description.
        /// </summary>
        /// <value>Field to identify charge bearer.The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/utilities/referenceData/{chargeBearer} resource to get valid value of this field with description.</value>
        [DataMember(Name="chargeBearer", EmitDefaultValue=false)]
        public string ChargeBearer { get; set; }

        /// <summary>
        /// Bill payment reference number belongs to merchant.
        /// </summary>
        /// <value>Bill payment reference number belongs to merchant.</value>
        [DataMember(Name="billReferenceNumber", EmitDefaultValue=false)]
        public string BillReferenceNumber { get; set; }

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
        /// The nick name of the payee assigned by the customer.
        /// </summary>
        /// <value>The nick name of the payee assigned by the customer.</value>
        [DataMember(Name="payeeNickName", EmitDefaultValue=false)]
        public string PayeeNickName { get; set; }

        /// <summary>
        /// Flag to indicate the payee must be added to customers registered list of billers.
        /// </summary>
        /// <value>Flag to indicate the payee must be added to customers registered list of billers.</value>
        [DataMember(Name="payeeEnrollmentFlag", EmitDefaultValue=false)]
        public bool? PayeeEnrollmentFlag { get; set; }

        /// <summary>
        /// Name of the bank. Applicable only for CNIBPS. Customer can input BankName also on screen to Transfer the fund for proxy registered to Bank instead Default Bank
        /// </summary>
        /// <value>Name of the bank. Applicable only for CNIBPS. Customer can input BankName also on screen to Transfer the fund for proxy registered to Bank instead Default Bank</value>
        [DataMember(Name="bankName", EmitDefaultValue=false)]
        public string BankName { get; set; }

        /// <summary>
        /// Name of the customer. Applicable only for CNIBPS. specific to CNIBPS. Customer can input name on screen, which will be validated in IBPS system
        /// </summary>
        /// <value>Name of the customer. Applicable only for CNIBPS. specific to CNIBPS. Customer can input name on screen, which will be validated in IBPS system</value>
        [DataMember(Name="customerName", EmitDefaultValue=false)]
        public string CustomerName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdhocAccountProxyTransfersPreprocessWithAddPayeeRequest {\n");
            sb.Append("  ProxyPaymentType: ").Append(ProxyPaymentType).Append("\n");
            sb.Append("  SourceAccountId: ").Append(SourceAccountId).Append("\n");
            sb.Append("  TransactionAmount: ").Append(TransactionAmount).Append("\n");
            sb.Append("  TransactionCurrencyCode: ").Append(TransactionCurrencyCode).Append("\n");
            sb.Append("  TransferCurrencyIndicator: ").Append(TransferCurrencyIndicator).Append("\n");
            sb.Append("  ProxyAccountId: ").Append(ProxyAccountId).Append("\n");
            sb.Append("  ProxyAccountIdType: ").Append(ProxyAccountIdType).Append("\n");
            sb.Append("  ChargeBearer: ").Append(ChargeBearer).Append("\n");
            sb.Append("  BillReferenceNumber: ").Append(BillReferenceNumber).Append("\n");
            sb.Append("  Remarks: ").Append(Remarks).Append("\n");
            sb.Append("  TransferPurpose: ").Append(TransferPurpose).Append("\n");
            sb.Append("  PayeeNickName: ").Append(PayeeNickName).Append("\n");
            sb.Append("  PayeeEnrollmentFlag: ").Append(PayeeEnrollmentFlag).Append("\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  CustomerName: ").Append(CustomerName).Append("\n");
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
            return this.Equals(input as AdhocAccountProxyTransfersPreprocessWithAddPayeeRequest);
        }

        /// <summary>
        /// Returns true if AdhocAccountProxyTransfersPreprocessWithAddPayeeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AdhocAccountProxyTransfersPreprocessWithAddPayeeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdhocAccountProxyTransfersPreprocessWithAddPayeeRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProxyPaymentType == input.ProxyPaymentType ||
                    (this.ProxyPaymentType != null &&
                    this.ProxyPaymentType.Equals(input.ProxyPaymentType))
                ) && 
                (
                    this.SourceAccountId == input.SourceAccountId ||
                    (this.SourceAccountId != null &&
                    this.SourceAccountId.Equals(input.SourceAccountId))
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
                    this.TransferCurrencyIndicator == input.TransferCurrencyIndicator ||
                    (this.TransferCurrencyIndicator != null &&
                    this.TransferCurrencyIndicator.Equals(input.TransferCurrencyIndicator))
                ) && 
                (
                    this.ProxyAccountId == input.ProxyAccountId ||
                    (this.ProxyAccountId != null &&
                    this.ProxyAccountId.Equals(input.ProxyAccountId))
                ) && 
                (
                    this.ProxyAccountIdType == input.ProxyAccountIdType ||
                    (this.ProxyAccountIdType != null &&
                    this.ProxyAccountIdType.Equals(input.ProxyAccountIdType))
                ) && 
                (
                    this.ChargeBearer == input.ChargeBearer ||
                    (this.ChargeBearer != null &&
                    this.ChargeBearer.Equals(input.ChargeBearer))
                ) && 
                (
                    this.BillReferenceNumber == input.BillReferenceNumber ||
                    (this.BillReferenceNumber != null &&
                    this.BillReferenceNumber.Equals(input.BillReferenceNumber))
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
                    this.PayeeNickName == input.PayeeNickName ||
                    (this.PayeeNickName != null &&
                    this.PayeeNickName.Equals(input.PayeeNickName))
                ) && 
                (
                    this.PayeeEnrollmentFlag == input.PayeeEnrollmentFlag ||
                    (this.PayeeEnrollmentFlag != null &&
                    this.PayeeEnrollmentFlag.Equals(input.PayeeEnrollmentFlag))
                ) && 
                (
                    this.BankName == input.BankName ||
                    (this.BankName != null &&
                    this.BankName.Equals(input.BankName))
                ) && 
                (
                    this.CustomerName == input.CustomerName ||
                    (this.CustomerName != null &&
                    this.CustomerName.Equals(input.CustomerName))
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
                if (this.ProxyPaymentType != null)
                    hashCode = hashCode * 59 + this.ProxyPaymentType.GetHashCode();
                if (this.SourceAccountId != null)
                    hashCode = hashCode * 59 + this.SourceAccountId.GetHashCode();
                if (this.TransactionAmount != null)
                    hashCode = hashCode * 59 + this.TransactionAmount.GetHashCode();
                if (this.TransactionCurrencyCode != null)
                    hashCode = hashCode * 59 + this.TransactionCurrencyCode.GetHashCode();
                if (this.TransferCurrencyIndicator != null)
                    hashCode = hashCode * 59 + this.TransferCurrencyIndicator.GetHashCode();
                if (this.ProxyAccountId != null)
                    hashCode = hashCode * 59 + this.ProxyAccountId.GetHashCode();
                if (this.ProxyAccountIdType != null)
                    hashCode = hashCode * 59 + this.ProxyAccountIdType.GetHashCode();
                if (this.ChargeBearer != null)
                    hashCode = hashCode * 59 + this.ChargeBearer.GetHashCode();
                if (this.BillReferenceNumber != null)
                    hashCode = hashCode * 59 + this.BillReferenceNumber.GetHashCode();
                if (this.Remarks != null)
                    hashCode = hashCode * 59 + this.Remarks.GetHashCode();
                if (this.TransferPurpose != null)
                    hashCode = hashCode * 59 + this.TransferPurpose.GetHashCode();
                if (this.PayeeNickName != null)
                    hashCode = hashCode * 59 + this.PayeeNickName.GetHashCode();
                if (this.PayeeEnrollmentFlag != null)
                    hashCode = hashCode * 59 + this.PayeeEnrollmentFlag.GetHashCode();
                if (this.BankName != null)
                    hashCode = hashCode * 59 + this.BankName.GetHashCode();
                if (this.CustomerName != null)
                    hashCode = hashCode * 59 + this.CustomerName.GetHashCode();
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
