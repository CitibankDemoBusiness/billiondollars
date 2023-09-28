/* 
 * Cards
 *
 * The Cards API allows you to perform actions on the actual credit cards of the Citi Customer who authorized your app.
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
    /// InternationalTransaction
    /// </summary>
    [DataContract]
        public partial class InternationalTransaction :  IEquatable<InternationalTransaction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InternationalTransaction" /> class.
        /// </summary>
        /// <param name="atmTransactionLimitToggleIndicator">InternationalSingleATMTransactionLimitToggleFlag.</param>
        /// <param name="atmTransactionLimitAmount">InternationalSingleATMTransactionLimit.</param>
        /// <param name="contactlessTxnLimitToggleIndicator">InternationalSingleContactlessTransactionLimitToggleFlag.</param>
        /// <param name="contactlessTransactionLimitAmount">InternationalSingleContactlessTransactionLimit.</param>
        /// <param name="contactPosTxnLimitToggleIndicator">InternationalSingleContactPOSTransactionLimitToggleFlag.</param>
        /// <param name="contactPosTransactionLimitAmount">InternationalSingleContactPOSTransactionLimit.</param>
        /// <param name="nonPosTxnLimitToggleIndicator">InternationalSingleNonPOSTransactionLimitToggleFlag.</param>
        /// <param name="nonPosTransactionLimitAmount">InternationalSingleNonPOSTransactionLimit.</param>
        public InternationalTransaction(string atmTransactionLimitToggleIndicator = default(string), double? atmTransactionLimitAmount = default(double?), string contactlessTxnLimitToggleIndicator = default(string), double? contactlessTransactionLimitAmount = default(double?), string contactPosTxnLimitToggleIndicator = default(string), double? contactPosTransactionLimitAmount = default(double?), string nonPosTxnLimitToggleIndicator = default(string), double? nonPosTransactionLimitAmount = default(double?))
        {
            this.AtmTransactionLimitToggleIndicator = atmTransactionLimitToggleIndicator;
            this.AtmTransactionLimitAmount = atmTransactionLimitAmount;
            this.ContactlessTxnLimitToggleIndicator = contactlessTxnLimitToggleIndicator;
            this.ContactlessTransactionLimitAmount = contactlessTransactionLimitAmount;
            this.ContactPosTxnLimitToggleIndicator = contactPosTxnLimitToggleIndicator;
            this.ContactPosTransactionLimitAmount = contactPosTransactionLimitAmount;
            this.NonPosTxnLimitToggleIndicator = nonPosTxnLimitToggleIndicator;
            this.NonPosTransactionLimitAmount = nonPosTransactionLimitAmount;
        }
        
        /// <summary>
        /// InternationalSingleATMTransactionLimitToggleFlag
        /// </summary>
        /// <value>InternationalSingleATMTransactionLimitToggleFlag</value>
        [DataMember(Name="atmTransactionLimitToggleIndicator", EmitDefaultValue=false)]
        public string AtmTransactionLimitToggleIndicator { get; set; }

        /// <summary>
        /// InternationalSingleATMTransactionLimit
        /// </summary>
        /// <value>InternationalSingleATMTransactionLimit</value>
        [DataMember(Name="atmTransactionLimitAmount", EmitDefaultValue=false)]
        public double? AtmTransactionLimitAmount { get; set; }

        /// <summary>
        /// InternationalSingleContactlessTransactionLimitToggleFlag
        /// </summary>
        /// <value>InternationalSingleContactlessTransactionLimitToggleFlag</value>
        [DataMember(Name="contactlessTxnLimitToggleIndicator", EmitDefaultValue=false)]
        public string ContactlessTxnLimitToggleIndicator { get; set; }

        /// <summary>
        /// InternationalSingleContactlessTransactionLimit
        /// </summary>
        /// <value>InternationalSingleContactlessTransactionLimit</value>
        [DataMember(Name="contactlessTransactionLimitAmount", EmitDefaultValue=false)]
        public double? ContactlessTransactionLimitAmount { get; set; }

        /// <summary>
        /// InternationalSingleContactPOSTransactionLimitToggleFlag
        /// </summary>
        /// <value>InternationalSingleContactPOSTransactionLimitToggleFlag</value>
        [DataMember(Name="contactPosTxnLimitToggleIndicator", EmitDefaultValue=false)]
        public string ContactPosTxnLimitToggleIndicator { get; set; }

        /// <summary>
        /// InternationalSingleContactPOSTransactionLimit
        /// </summary>
        /// <value>InternationalSingleContactPOSTransactionLimit</value>
        [DataMember(Name="contactPosTransactionLimitAmount", EmitDefaultValue=false)]
        public double? ContactPosTransactionLimitAmount { get; set; }

        /// <summary>
        /// InternationalSingleNonPOSTransactionLimitToggleFlag
        /// </summary>
        /// <value>InternationalSingleNonPOSTransactionLimitToggleFlag</value>
        [DataMember(Name="nonPosTxnLimitToggleIndicator", EmitDefaultValue=false)]
        public string NonPosTxnLimitToggleIndicator { get; set; }

        /// <summary>
        /// InternationalSingleNonPOSTransactionLimit
        /// </summary>
        /// <value>InternationalSingleNonPOSTransactionLimit</value>
        [DataMember(Name="nonPosTransactionLimitAmount", EmitDefaultValue=false)]
        public double? NonPosTransactionLimitAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InternationalTransaction {\n");
            sb.Append("  AtmTransactionLimitToggleIndicator: ").Append(AtmTransactionLimitToggleIndicator).Append("\n");
            sb.Append("  AtmTransactionLimitAmount: ").Append(AtmTransactionLimitAmount).Append("\n");
            sb.Append("  ContactlessTxnLimitToggleIndicator: ").Append(ContactlessTxnLimitToggleIndicator).Append("\n");
            sb.Append("  ContactlessTransactionLimitAmount: ").Append(ContactlessTransactionLimitAmount).Append("\n");
            sb.Append("  ContactPosTxnLimitToggleIndicator: ").Append(ContactPosTxnLimitToggleIndicator).Append("\n");
            sb.Append("  ContactPosTransactionLimitAmount: ").Append(ContactPosTransactionLimitAmount).Append("\n");
            sb.Append("  NonPosTxnLimitToggleIndicator: ").Append(NonPosTxnLimitToggleIndicator).Append("\n");
            sb.Append("  NonPosTransactionLimitAmount: ").Append(NonPosTransactionLimitAmount).Append("\n");
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
            return this.Equals(input as InternationalTransaction);
        }

        /// <summary>
        /// Returns true if InternationalTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of InternationalTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InternationalTransaction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AtmTransactionLimitToggleIndicator == input.AtmTransactionLimitToggleIndicator ||
                    (this.AtmTransactionLimitToggleIndicator != null &&
                    this.AtmTransactionLimitToggleIndicator.Equals(input.AtmTransactionLimitToggleIndicator))
                ) && 
                (
                    this.AtmTransactionLimitAmount == input.AtmTransactionLimitAmount ||
                    (this.AtmTransactionLimitAmount != null &&
                    this.AtmTransactionLimitAmount.Equals(input.AtmTransactionLimitAmount))
                ) && 
                (
                    this.ContactlessTxnLimitToggleIndicator == input.ContactlessTxnLimitToggleIndicator ||
                    (this.ContactlessTxnLimitToggleIndicator != null &&
                    this.ContactlessTxnLimitToggleIndicator.Equals(input.ContactlessTxnLimitToggleIndicator))
                ) && 
                (
                    this.ContactlessTransactionLimitAmount == input.ContactlessTransactionLimitAmount ||
                    (this.ContactlessTransactionLimitAmount != null &&
                    this.ContactlessTransactionLimitAmount.Equals(input.ContactlessTransactionLimitAmount))
                ) && 
                (
                    this.ContactPosTxnLimitToggleIndicator == input.ContactPosTxnLimitToggleIndicator ||
                    (this.ContactPosTxnLimitToggleIndicator != null &&
                    this.ContactPosTxnLimitToggleIndicator.Equals(input.ContactPosTxnLimitToggleIndicator))
                ) && 
                (
                    this.ContactPosTransactionLimitAmount == input.ContactPosTransactionLimitAmount ||
                    (this.ContactPosTransactionLimitAmount != null &&
                    this.ContactPosTransactionLimitAmount.Equals(input.ContactPosTransactionLimitAmount))
                ) && 
                (
                    this.NonPosTxnLimitToggleIndicator == input.NonPosTxnLimitToggleIndicator ||
                    (this.NonPosTxnLimitToggleIndicator != null &&
                    this.NonPosTxnLimitToggleIndicator.Equals(input.NonPosTxnLimitToggleIndicator))
                ) && 
                (
                    this.NonPosTransactionLimitAmount == input.NonPosTransactionLimitAmount ||
                    (this.NonPosTransactionLimitAmount != null &&
                    this.NonPosTransactionLimitAmount.Equals(input.NonPosTransactionLimitAmount))
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
                if (this.AtmTransactionLimitToggleIndicator != null)
                    hashCode = hashCode * 59 + this.AtmTransactionLimitToggleIndicator.GetHashCode();
                if (this.AtmTransactionLimitAmount != null)
                    hashCode = hashCode * 59 + this.AtmTransactionLimitAmount.GetHashCode();
                if (this.ContactlessTxnLimitToggleIndicator != null)
                    hashCode = hashCode * 59 + this.ContactlessTxnLimitToggleIndicator.GetHashCode();
                if (this.ContactlessTransactionLimitAmount != null)
                    hashCode = hashCode * 59 + this.ContactlessTransactionLimitAmount.GetHashCode();
                if (this.ContactPosTxnLimitToggleIndicator != null)
                    hashCode = hashCode * 59 + this.ContactPosTxnLimitToggleIndicator.GetHashCode();
                if (this.ContactPosTransactionLimitAmount != null)
                    hashCode = hashCode * 59 + this.ContactPosTransactionLimitAmount.GetHashCode();
                if (this.NonPosTxnLimitToggleIndicator != null)
                    hashCode = hashCode * 59 + this.NonPosTxnLimitToggleIndicator.GetHashCode();
                if (this.NonPosTransactionLimitAmount != null)
                    hashCode = hashCode * 59 + this.NonPosTransactionLimitAmount.GetHashCode();
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