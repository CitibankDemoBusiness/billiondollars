/* 
 * Onboarding
 *
 * The Onboarding API allows you to initiate the basic account opening process for new customers. The resources allow you to present eligible products, send applications for screening and submit a new application for one or more products. The resources also allow you to submit supporting documents. Application status can be checked at any point in the process, with decisioning happening in real time.
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
    /// UnsecuredApplicationValidateOtpRequest
    /// </summary>
    [DataContract]
        public partial class UnsecuredApplicationValidateOtpRequest :  IEquatable<UnsecuredApplicationValidateOtpRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnsecuredApplicationValidateOtpRequest" /> class.
        /// </summary>
        /// <param name="otpToken">Encrypted OTP Token to be validated (required).</param>
        /// <param name="controlFlowId">Control Flow Id (required).</param>
        public UnsecuredApplicationValidateOtpRequest(string otpToken = default(string), string controlFlowId = default(string))
        {
            // to ensure "otpToken" is required (not null)
            if (otpToken == null)
            {
                throw new InvalidDataException("otpToken is a required property for UnsecuredApplicationValidateOtpRequest and cannot be null");
            }
            else
            {
                this.OtpToken = otpToken;
            }
            // to ensure "controlFlowId" is required (not null)
            if (controlFlowId == null)
            {
                throw new InvalidDataException("controlFlowId is a required property for UnsecuredApplicationValidateOtpRequest and cannot be null");
            }
            else
            {
                this.ControlFlowId = controlFlowId;
            }
        }
        
        /// <summary>
        /// Encrypted OTP Token to be validated
        /// </summary>
        /// <value>Encrypted OTP Token to be validated</value>
        [DataMember(Name="otpToken", EmitDefaultValue=false)]
        public string OtpToken { get; set; }

        /// <summary>
        /// Control Flow Id
        /// </summary>
        /// <value>Control Flow Id</value>
        [DataMember(Name="controlFlowId", EmitDefaultValue=false)]
        public string ControlFlowId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnsecuredApplicationValidateOtpRequest {\n");
            sb.Append("  OtpToken: ").Append(OtpToken).Append("\n");
            sb.Append("  ControlFlowId: ").Append(ControlFlowId).Append("\n");
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
            return this.Equals(input as UnsecuredApplicationValidateOtpRequest);
        }

        /// <summary>
        /// Returns true if UnsecuredApplicationValidateOtpRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UnsecuredApplicationValidateOtpRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnsecuredApplicationValidateOtpRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OtpToken == input.OtpToken ||
                    (this.OtpToken != null &&
                    this.OtpToken.Equals(input.OtpToken))
                ) && 
                (
                    this.ControlFlowId == input.ControlFlowId ||
                    (this.ControlFlowId != null &&
                    this.ControlFlowId.Equals(input.ControlFlowId))
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
                if (this.OtpToken != null)
                    hashCode = hashCode * 59 + this.OtpToken.GetHashCode();
                if (this.ControlFlowId != null)
                    hashCode = hashCode * 59 + this.ControlFlowId.GetHashCode();
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
