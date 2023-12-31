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
    /// UpdateApplicationProcessingPartnerMembershipValidationRequest
    /// </summary>
    [DataContract]
        public partial class UpdateApplicationProcessingPartnerMembershipValidationRequest :  IEquatable<UpdateApplicationProcessingPartnerMembershipValidationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateApplicationProcessingPartnerMembershipValidationRequest" /> class.
        /// </summary>
        /// <param name="membershipInformation">membershipInformation.</param>
        /// <param name="salesAgentDetails">salesAgentDetails.</param>
        /// <param name="product">product.</param>
        /// <param name="consentDetails">consentDetails.</param>
        public UpdateApplicationProcessingPartnerMembershipValidationRequest(MembershipInformation membershipInformation = default(MembershipInformation), SalesAgentDetails salesAgentDetails = default(SalesAgentDetails), Product product = default(Product), List<ConsentDetails> consentDetails = default(List<ConsentDetails>))
        {
            this.MembershipInformation = membershipInformation;
            this.SalesAgentDetails = salesAgentDetails;
            this.Product = product;
            this.ConsentDetails = consentDetails;
        }
        
        /// <summary>
        /// Gets or Sets MembershipInformation
        /// </summary>
        [DataMember(Name="membershipInformation", EmitDefaultValue=false)]
        public MembershipInformation MembershipInformation { get; set; }

        /// <summary>
        /// Gets or Sets SalesAgentDetails
        /// </summary>
        [DataMember(Name="salesAgentDetails", EmitDefaultValue=false)]
        public SalesAgentDetails SalesAgentDetails { get; set; }

        /// <summary>
        /// Gets or Sets Product
        /// </summary>
        [DataMember(Name="product", EmitDefaultValue=false)]
        public Product Product { get; set; }

        /// <summary>
        /// Gets or Sets ConsentDetails
        /// </summary>
        [DataMember(Name="consentDetails", EmitDefaultValue=false)]
        public List<ConsentDetails> ConsentDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateApplicationProcessingPartnerMembershipValidationRequest {\n");
            sb.Append("  MembershipInformation: ").Append(MembershipInformation).Append("\n");
            sb.Append("  SalesAgentDetails: ").Append(SalesAgentDetails).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  ConsentDetails: ").Append(ConsentDetails).Append("\n");
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
            return this.Equals(input as UpdateApplicationProcessingPartnerMembershipValidationRequest);
        }

        /// <summary>
        /// Returns true if UpdateApplicationProcessingPartnerMembershipValidationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateApplicationProcessingPartnerMembershipValidationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateApplicationProcessingPartnerMembershipValidationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MembershipInformation == input.MembershipInformation ||
                    (this.MembershipInformation != null &&
                    this.MembershipInformation.Equals(input.MembershipInformation))
                ) && 
                (
                    this.SalesAgentDetails == input.SalesAgentDetails ||
                    (this.SalesAgentDetails != null &&
                    this.SalesAgentDetails.Equals(input.SalesAgentDetails))
                ) && 
                (
                    this.Product == input.Product ||
                    (this.Product != null &&
                    this.Product.Equals(input.Product))
                ) && 
                (
                    this.ConsentDetails == input.ConsentDetails ||
                    this.ConsentDetails != null &&
                    input.ConsentDetails != null &&
                    this.ConsentDetails.SequenceEqual(input.ConsentDetails)
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
                if (this.MembershipInformation != null)
                    hashCode = hashCode * 59 + this.MembershipInformation.GetHashCode();
                if (this.SalesAgentDetails != null)
                    hashCode = hashCode * 59 + this.SalesAgentDetails.GetHashCode();
                if (this.Product != null)
                    hashCode = hashCode * 59 + this.Product.GetHashCode();
                if (this.ConsentDetails != null)
                    hashCode = hashCode * 59 + this.ConsentDetails.GetHashCode();
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
