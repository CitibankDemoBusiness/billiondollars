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
    /// ResetAtmPinRequest
    /// </summary>
    [DataContract]
        public partial class ResetAtmPinRequest :  IEquatable<ResetAtmPinRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResetAtmPinRequest" /> class.
        /// </summary>
        /// <param name="cardId">Unique Id of the card in encrypted format. (required).</param>
        /// <param name="newPin">New pin in encrypted format. (required).</param>
        /// <param name="encryptionType">Type of the encryption. This is a reference data field. Please use /v1/apac/utilities/referenceData/{encryptionType} resource to get valid value of this field with description..</param>
        /// <param name="keyDeviceId">Label to identify the HSM keys used to encrypt ATM PIN..</param>
        /// <param name="keyGenerationId">It is the generation ID of the HSM Keys referred for encryption of ATM PIN..</param>
        public ResetAtmPinRequest(string cardId = default(string), string newPin = default(string), string encryptionType = default(string), string keyDeviceId = default(string), string keyGenerationId = default(string))
        {
            // to ensure "cardId" is required (not null)
            if (cardId == null)
            {
                throw new InvalidDataException("cardId is a required property for ResetAtmPinRequest and cannot be null");
            }
            else
            {
                this.CardId = cardId;
            }
            // to ensure "newPin" is required (not null)
            if (newPin == null)
            {
                throw new InvalidDataException("newPin is a required property for ResetAtmPinRequest and cannot be null");
            }
            else
            {
                this.NewPin = newPin;
            }
            this.EncryptionType = encryptionType;
            this.KeyDeviceId = keyDeviceId;
            this.KeyGenerationId = keyGenerationId;
        }
        
        /// <summary>
        /// Unique Id of the card in encrypted format.
        /// </summary>
        /// <value>Unique Id of the card in encrypted format.</value>
        [DataMember(Name="cardId", EmitDefaultValue=false)]
        public string CardId { get; set; }

        /// <summary>
        /// New pin in encrypted format.
        /// </summary>
        /// <value>New pin in encrypted format.</value>
        [DataMember(Name="newPin", EmitDefaultValue=false)]
        public string NewPin { get; set; }

        /// <summary>
        /// Type of the encryption. This is a reference data field. Please use /v1/apac/utilities/referenceData/{encryptionType} resource to get valid value of this field with description.
        /// </summary>
        /// <value>Type of the encryption. This is a reference data field. Please use /v1/apac/utilities/referenceData/{encryptionType} resource to get valid value of this field with description.</value>
        [DataMember(Name="encryptionType", EmitDefaultValue=false)]
        public string EncryptionType { get; set; }

        /// <summary>
        /// Label to identify the HSM keys used to encrypt ATM PIN.
        /// </summary>
        /// <value>Label to identify the HSM keys used to encrypt ATM PIN.</value>
        [DataMember(Name="keyDeviceId", EmitDefaultValue=false)]
        public string KeyDeviceId { get; set; }

        /// <summary>
        /// It is the generation ID of the HSM Keys referred for encryption of ATM PIN.
        /// </summary>
        /// <value>It is the generation ID of the HSM Keys referred for encryption of ATM PIN.</value>
        [DataMember(Name="keyGenerationId", EmitDefaultValue=false)]
        public string KeyGenerationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResetAtmPinRequest {\n");
            sb.Append("  CardId: ").Append(CardId).Append("\n");
            sb.Append("  NewPin: ").Append(NewPin).Append("\n");
            sb.Append("  EncryptionType: ").Append(EncryptionType).Append("\n");
            sb.Append("  KeyDeviceId: ").Append(KeyDeviceId).Append("\n");
            sb.Append("  KeyGenerationId: ").Append(KeyGenerationId).Append("\n");
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
            return this.Equals(input as ResetAtmPinRequest);
        }

        /// <summary>
        /// Returns true if ResetAtmPinRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ResetAtmPinRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResetAtmPinRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CardId == input.CardId ||
                    (this.CardId != null &&
                    this.CardId.Equals(input.CardId))
                ) && 
                (
                    this.NewPin == input.NewPin ||
                    (this.NewPin != null &&
                    this.NewPin.Equals(input.NewPin))
                ) && 
                (
                    this.EncryptionType == input.EncryptionType ||
                    (this.EncryptionType != null &&
                    this.EncryptionType.Equals(input.EncryptionType))
                ) && 
                (
                    this.KeyDeviceId == input.KeyDeviceId ||
                    (this.KeyDeviceId != null &&
                    this.KeyDeviceId.Equals(input.KeyDeviceId))
                ) && 
                (
                    this.KeyGenerationId == input.KeyGenerationId ||
                    (this.KeyGenerationId != null &&
                    this.KeyGenerationId.Equals(input.KeyGenerationId))
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
                if (this.CardId != null)
                    hashCode = hashCode * 59 + this.CardId.GetHashCode();
                if (this.NewPin != null)
                    hashCode = hashCode * 59 + this.NewPin.GetHashCode();
                if (this.EncryptionType != null)
                    hashCode = hashCode * 59 + this.EncryptionType.GetHashCode();
                if (this.KeyDeviceId != null)
                    hashCode = hashCode * 59 + this.KeyDeviceId.GetHashCode();
                if (this.KeyGenerationId != null)
                    hashCode = hashCode * 59 + this.KeyGenerationId.GetHashCode();
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
