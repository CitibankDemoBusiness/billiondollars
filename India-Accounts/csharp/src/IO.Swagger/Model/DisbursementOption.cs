/* 
 * Accounts
 *
 * The Accounts API allows you to retrieve account and transaction data for Citi Customers who have authorized your app. In most cases, you'll want to request a summary of all accounts first, which will return basic account information and accountIds. Once you have this information, you can request additional account details and/or transactions.
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
    /// DisbursementOption
    /// </summary>
    [DataContract]
        public partial class DisbursementOption :  IEquatable<DisbursementOption>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DisbursementOption" /> class.
        /// </summary>
        /// <param name="disbursementOption">Provide the list of the options available to receive the disbursement of loan amount. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description. (required).</param>
        /// <param name="address">address.</param>
        /// <param name="externalBankDetails">externalBankDetails.</param>
        /// <param name="personalAccountDetails">personalAccountDetails.</param>
        /// <param name="payeeAccountDetails">payeeAccountDetails.</param>
        public DisbursementOption(string disbursementOption = default(string), Address address = default(Address), ExternalBankDetails externalBankDetails = default(ExternalBankDetails), List<PersonalAccountDetails> personalAccountDetails = default(List<PersonalAccountDetails>), List<PayeeAccountDetails> payeeAccountDetails = default(List<PayeeAccountDetails>))
        {
            // to ensure "disbursementOption" is required (not null)
            if (disbursementOption == null)
            {
                throw new InvalidDataException("disbursementOption is a required property for DisbursementOption and cannot be null");
            }
            else
            {
                this._DisbursementOption = disbursementOption;
            }
            this.Address = address;
            this.ExternalBankDetails = externalBankDetails;
            this.PersonalAccountDetails = personalAccountDetails;
            this.PayeeAccountDetails = payeeAccountDetails;
        }
        
        /// <summary>
        /// Provide the list of the options available to receive the disbursement of loan amount. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description.
        /// </summary>
        /// <value>Provide the list of the options available to receive the disbursement of loan amount. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description.</value>
        [DataMember(Name="disbursementOption", EmitDefaultValue=false)]
        public string _DisbursementOption { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public Address Address { get; set; }

        /// <summary>
        /// Gets or Sets ExternalBankDetails
        /// </summary>
        [DataMember(Name="externalBankDetails", EmitDefaultValue=false)]
        public ExternalBankDetails ExternalBankDetails { get; set; }

        /// <summary>
        /// Gets or Sets PersonalAccountDetails
        /// </summary>
        [DataMember(Name="personalAccountDetails", EmitDefaultValue=false)]
        public List<PersonalAccountDetails> PersonalAccountDetails { get; set; }

        /// <summary>
        /// Gets or Sets PayeeAccountDetails
        /// </summary>
        [DataMember(Name="payeeAccountDetails", EmitDefaultValue=false)]
        public List<PayeeAccountDetails> PayeeAccountDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisbursementOption {\n");
            sb.Append("  _DisbursementOption: ").Append(_DisbursementOption).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  ExternalBankDetails: ").Append(ExternalBankDetails).Append("\n");
            sb.Append("  PersonalAccountDetails: ").Append(PersonalAccountDetails).Append("\n");
            sb.Append("  PayeeAccountDetails: ").Append(PayeeAccountDetails).Append("\n");
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
            return this.Equals(input as DisbursementOption);
        }

        /// <summary>
        /// Returns true if DisbursementOption instances are equal
        /// </summary>
        /// <param name="input">Instance of DisbursementOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DisbursementOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._DisbursementOption == input._DisbursementOption ||
                    (this._DisbursementOption != null &&
                    this._DisbursementOption.Equals(input._DisbursementOption))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.ExternalBankDetails == input.ExternalBankDetails ||
                    (this.ExternalBankDetails != null &&
                    this.ExternalBankDetails.Equals(input.ExternalBankDetails))
                ) && 
                (
                    this.PersonalAccountDetails == input.PersonalAccountDetails ||
                    this.PersonalAccountDetails != null &&
                    input.PersonalAccountDetails != null &&
                    this.PersonalAccountDetails.SequenceEqual(input.PersonalAccountDetails)
                ) && 
                (
                    this.PayeeAccountDetails == input.PayeeAccountDetails ||
                    this.PayeeAccountDetails != null &&
                    input.PayeeAccountDetails != null &&
                    this.PayeeAccountDetails.SequenceEqual(input.PayeeAccountDetails)
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
                if (this._DisbursementOption != null)
                    hashCode = hashCode * 59 + this._DisbursementOption.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.ExternalBankDetails != null)
                    hashCode = hashCode * 59 + this.ExternalBankDetails.GetHashCode();
                if (this.PersonalAccountDetails != null)
                    hashCode = hashCode * 59 + this.PersonalAccountDetails.GetHashCode();
                if (this.PayeeAccountDetails != null)
                    hashCode = hashCode * 59 + this.PayeeAccountDetails.GetHashCode();
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