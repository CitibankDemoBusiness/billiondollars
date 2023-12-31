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
    /// ExternalDomesticPayeeSourceAccountCombinations
    /// </summary>
    [DataContract]
        public partial class ExternalDomesticPayeeSourceAccountCombinations :  IEquatable<ExternalDomesticPayeeSourceAccountCombinations>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalDomesticPayeeSourceAccountCombinations" /> class.
        /// </summary>
        /// <param name="payeeId">Unique identifier associated with the payee. Typically, this is not displayed to the customer. (required).</param>
        /// <param name="displayPayeeAccountNumber">The display account number of the destination account. (required).</param>
        /// <param name="payeeAccountCurrencyCode">The currency code of the payee account in ISO 4217 format (required).</param>
        /// <param name="payeeNickName">Payee account nick name (required).</param>
        /// <param name="bankDetails">bankDetails (required).</param>
        /// <param name="paymentMethods">paymentMethods (required).</param>
        /// <param name="sourceAccountIds">sourceAccountIds (required).</param>
        public ExternalDomesticPayeeSourceAccountCombinations(string payeeId = default(string), string displayPayeeAccountNumber = default(string), string payeeAccountCurrencyCode = default(string), string payeeNickName = default(string), BankDetails bankDetails = default(BankDetails), List<PaymentMethod> paymentMethods = default(List<PaymentMethod>), List<SourceAccountIds> sourceAccountIds = default(List<SourceAccountIds>))
        {
            // to ensure "payeeId" is required (not null)
            if (payeeId == null)
            {
                throw new InvalidDataException("payeeId is a required property for ExternalDomesticPayeeSourceAccountCombinations and cannot be null");
            }
            else
            {
                this.PayeeId = payeeId;
            }
            // to ensure "displayPayeeAccountNumber" is required (not null)
            if (displayPayeeAccountNumber == null)
            {
                throw new InvalidDataException("displayPayeeAccountNumber is a required property for ExternalDomesticPayeeSourceAccountCombinations and cannot be null");
            }
            else
            {
                this.DisplayPayeeAccountNumber = displayPayeeAccountNumber;
            }
            // to ensure "payeeAccountCurrencyCode" is required (not null)
            if (payeeAccountCurrencyCode == null)
            {
                throw new InvalidDataException("payeeAccountCurrencyCode is a required property for ExternalDomesticPayeeSourceAccountCombinations and cannot be null");
            }
            else
            {
                this.PayeeAccountCurrencyCode = payeeAccountCurrencyCode;
            }
            // to ensure "payeeNickName" is required (not null)
            if (payeeNickName == null)
            {
                throw new InvalidDataException("payeeNickName is a required property for ExternalDomesticPayeeSourceAccountCombinations and cannot be null");
            }
            else
            {
                this.PayeeNickName = payeeNickName;
            }
            // to ensure "bankDetails" is required (not null)
            if (bankDetails == null)
            {
                throw new InvalidDataException("bankDetails is a required property for ExternalDomesticPayeeSourceAccountCombinations and cannot be null");
            }
            else
            {
                this.BankDetails = bankDetails;
            }
            // to ensure "paymentMethods" is required (not null)
            if (paymentMethods == null)
            {
                throw new InvalidDataException("paymentMethods is a required property for ExternalDomesticPayeeSourceAccountCombinations and cannot be null");
            }
            else
            {
                this.PaymentMethods = paymentMethods;
            }
            // to ensure "sourceAccountIds" is required (not null)
            if (sourceAccountIds == null)
            {
                throw new InvalidDataException("sourceAccountIds is a required property for ExternalDomesticPayeeSourceAccountCombinations and cannot be null");
            }
            else
            {
                this.SourceAccountIds = sourceAccountIds;
            }
        }
        
        /// <summary>
        /// Unique identifier associated with the payee. Typically, this is not displayed to the customer.
        /// </summary>
        /// <value>Unique identifier associated with the payee. Typically, this is not displayed to the customer.</value>
        [DataMember(Name="payeeId", EmitDefaultValue=false)]
        public string PayeeId { get; set; }

        /// <summary>
        /// The display account number of the destination account.
        /// </summary>
        /// <value>The display account number of the destination account.</value>
        [DataMember(Name="displayPayeeAccountNumber", EmitDefaultValue=false)]
        public string DisplayPayeeAccountNumber { get; set; }

        /// <summary>
        /// The currency code of the payee account in ISO 4217 format
        /// </summary>
        /// <value>The currency code of the payee account in ISO 4217 format</value>
        [DataMember(Name="payeeAccountCurrencyCode", EmitDefaultValue=false)]
        public string PayeeAccountCurrencyCode { get; set; }

        /// <summary>
        /// Payee account nick name
        /// </summary>
        /// <value>Payee account nick name</value>
        [DataMember(Name="payeeNickName", EmitDefaultValue=false)]
        public string PayeeNickName { get; set; }

        /// <summary>
        /// Gets or Sets BankDetails
        /// </summary>
        [DataMember(Name="bankDetails", EmitDefaultValue=false)]
        public BankDetails BankDetails { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethods
        /// </summary>
        [DataMember(Name="paymentMethods", EmitDefaultValue=false)]
        public List<PaymentMethod> PaymentMethods { get; set; }

        /// <summary>
        /// Gets or Sets SourceAccountIds
        /// </summary>
        [DataMember(Name="sourceAccountIds", EmitDefaultValue=false)]
        public List<SourceAccountIds> SourceAccountIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalDomesticPayeeSourceAccountCombinations {\n");
            sb.Append("  PayeeId: ").Append(PayeeId).Append("\n");
            sb.Append("  DisplayPayeeAccountNumber: ").Append(DisplayPayeeAccountNumber).Append("\n");
            sb.Append("  PayeeAccountCurrencyCode: ").Append(PayeeAccountCurrencyCode).Append("\n");
            sb.Append("  PayeeNickName: ").Append(PayeeNickName).Append("\n");
            sb.Append("  BankDetails: ").Append(BankDetails).Append("\n");
            sb.Append("  PaymentMethods: ").Append(PaymentMethods).Append("\n");
            sb.Append("  SourceAccountIds: ").Append(SourceAccountIds).Append("\n");
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
            return this.Equals(input as ExternalDomesticPayeeSourceAccountCombinations);
        }

        /// <summary>
        /// Returns true if ExternalDomesticPayeeSourceAccountCombinations instances are equal
        /// </summary>
        /// <param name="input">Instance of ExternalDomesticPayeeSourceAccountCombinations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalDomesticPayeeSourceAccountCombinations input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PayeeId == input.PayeeId ||
                    (this.PayeeId != null &&
                    this.PayeeId.Equals(input.PayeeId))
                ) && 
                (
                    this.DisplayPayeeAccountNumber == input.DisplayPayeeAccountNumber ||
                    (this.DisplayPayeeAccountNumber != null &&
                    this.DisplayPayeeAccountNumber.Equals(input.DisplayPayeeAccountNumber))
                ) && 
                (
                    this.PayeeAccountCurrencyCode == input.PayeeAccountCurrencyCode ||
                    (this.PayeeAccountCurrencyCode != null &&
                    this.PayeeAccountCurrencyCode.Equals(input.PayeeAccountCurrencyCode))
                ) && 
                (
                    this.PayeeNickName == input.PayeeNickName ||
                    (this.PayeeNickName != null &&
                    this.PayeeNickName.Equals(input.PayeeNickName))
                ) && 
                (
                    this.BankDetails == input.BankDetails ||
                    (this.BankDetails != null &&
                    this.BankDetails.Equals(input.BankDetails))
                ) && 
                (
                    this.PaymentMethods == input.PaymentMethods ||
                    this.PaymentMethods != null &&
                    input.PaymentMethods != null &&
                    this.PaymentMethods.SequenceEqual(input.PaymentMethods)
                ) && 
                (
                    this.SourceAccountIds == input.SourceAccountIds ||
                    this.SourceAccountIds != null &&
                    input.SourceAccountIds != null &&
                    this.SourceAccountIds.SequenceEqual(input.SourceAccountIds)
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
                if (this.PayeeId != null)
                    hashCode = hashCode * 59 + this.PayeeId.GetHashCode();
                if (this.DisplayPayeeAccountNumber != null)
                    hashCode = hashCode * 59 + this.DisplayPayeeAccountNumber.GetHashCode();
                if (this.PayeeAccountCurrencyCode != null)
                    hashCode = hashCode * 59 + this.PayeeAccountCurrencyCode.GetHashCode();
                if (this.PayeeNickName != null)
                    hashCode = hashCode * 59 + this.PayeeNickName.GetHashCode();
                if (this.BankDetails != null)
                    hashCode = hashCode * 59 + this.BankDetails.GetHashCode();
                if (this.PaymentMethods != null)
                    hashCode = hashCode * 59 + this.PaymentMethods.GetHashCode();
                if (this.SourceAccountIds != null)
                    hashCode = hashCode * 59 + this.SourceAccountIds.GetHashCode();
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
