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
    /// DestinationAccount
    /// </summary>
    [DataContract]
        public partial class DestinationAccount :  IEquatable<DestinationAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinationAccount" /> class.
        /// </summary>
        /// <param name="displayDestinationAccountNumber">A masked destination account number that can be displayed to the customer. (required).</param>
        /// <param name="destinationAccountAvailableBalance">Available balance amount in destination account (required).</param>
        /// <param name="destinationCurrencyCode">Currency code of the destination account in  ISO 4217 format..</param>
        public DestinationAccount(string displayDestinationAccountNumber = default(string), double? destinationAccountAvailableBalance = default(double?), string destinationCurrencyCode = default(string))
        {
            // to ensure "displayDestinationAccountNumber" is required (not null)
            if (displayDestinationAccountNumber == null)
            {
                throw new InvalidDataException("displayDestinationAccountNumber is a required property for DestinationAccount and cannot be null");
            }
            else
            {
                this.DisplayDestinationAccountNumber = displayDestinationAccountNumber;
            }
            // to ensure "destinationAccountAvailableBalance" is required (not null)
            if (destinationAccountAvailableBalance == null)
            {
                throw new InvalidDataException("destinationAccountAvailableBalance is a required property for DestinationAccount and cannot be null");
            }
            else
            {
                this.DestinationAccountAvailableBalance = destinationAccountAvailableBalance;
            }
            this.DestinationCurrencyCode = destinationCurrencyCode;
        }
        
        /// <summary>
        /// A masked destination account number that can be displayed to the customer.
        /// </summary>
        /// <value>A masked destination account number that can be displayed to the customer.</value>
        [DataMember(Name="displayDestinationAccountNumber", EmitDefaultValue=false)]
        public string DisplayDestinationAccountNumber { get; set; }

        /// <summary>
        /// Available balance amount in destination account
        /// </summary>
        /// <value>Available balance amount in destination account</value>
        [DataMember(Name="destinationAccountAvailableBalance", EmitDefaultValue=false)]
        public double? DestinationAccountAvailableBalance { get; set; }

        /// <summary>
        /// Currency code of the destination account in  ISO 4217 format.
        /// </summary>
        /// <value>Currency code of the destination account in  ISO 4217 format.</value>
        [DataMember(Name="destinationCurrencyCode", EmitDefaultValue=false)]
        public string DestinationCurrencyCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinationAccount {\n");
            sb.Append("  DisplayDestinationAccountNumber: ").Append(DisplayDestinationAccountNumber).Append("\n");
            sb.Append("  DestinationAccountAvailableBalance: ").Append(DestinationAccountAvailableBalance).Append("\n");
            sb.Append("  DestinationCurrencyCode: ").Append(DestinationCurrencyCode).Append("\n");
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
            return this.Equals(input as DestinationAccount);
        }

        /// <summary>
        /// Returns true if DestinationAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinationAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinationAccount input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisplayDestinationAccountNumber == input.DisplayDestinationAccountNumber ||
                    (this.DisplayDestinationAccountNumber != null &&
                    this.DisplayDestinationAccountNumber.Equals(input.DisplayDestinationAccountNumber))
                ) && 
                (
                    this.DestinationAccountAvailableBalance == input.DestinationAccountAvailableBalance ||
                    (this.DestinationAccountAvailableBalance != null &&
                    this.DestinationAccountAvailableBalance.Equals(input.DestinationAccountAvailableBalance))
                ) && 
                (
                    this.DestinationCurrencyCode == input.DestinationCurrencyCode ||
                    (this.DestinationCurrencyCode != null &&
                    this.DestinationCurrencyCode.Equals(input.DestinationCurrencyCode))
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
                if (this.DisplayDestinationAccountNumber != null)
                    hashCode = hashCode * 59 + this.DisplayDestinationAccountNumber.GetHashCode();
                if (this.DestinationAccountAvailableBalance != null)
                    hashCode = hashCode * 59 + this.DestinationAccountAvailableBalance.GetHashCode();
                if (this.DestinationCurrencyCode != null)
                    hashCode = hashCode * 59 + this.DestinationCurrencyCode.GetHashCode();
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
