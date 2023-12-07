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
    /// PartnerCardListingResponse
    /// </summary>
    [DataContract]
        public partial class PartnerCardListingResponse :  IEquatable<PartnerCardListingResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartnerCardListingResponse" /> class.
        /// </summary>
        /// <param name="partnerCardDetails">partnerCardDetails.</param>
        public PartnerCardListingResponse(List<PartnerCardDetails> partnerCardDetails = default(List<PartnerCardDetails>))
        {
            this.PartnerCardDetails = partnerCardDetails;
        }
        
        /// <summary>
        /// Gets or Sets PartnerCardDetails
        /// </summary>
        [DataMember(Name="partnerCardDetails", EmitDefaultValue=false)]
        public List<PartnerCardDetails> PartnerCardDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PartnerCardListingResponse {\n");
            sb.Append("  PartnerCardDetails: ").Append(PartnerCardDetails).Append("\n");
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
            return this.Equals(input as PartnerCardListingResponse);
        }

        /// <summary>
        /// Returns true if PartnerCardListingResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PartnerCardListingResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PartnerCardListingResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PartnerCardDetails == input.PartnerCardDetails ||
                    this.PartnerCardDetails != null &&
                    input.PartnerCardDetails != null &&
                    this.PartnerCardDetails.SequenceEqual(input.PartnerCardDetails)
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
                if (this.PartnerCardDetails != null)
                    hashCode = hashCode * 59 + this.PartnerCardDetails.GetHashCode();
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
