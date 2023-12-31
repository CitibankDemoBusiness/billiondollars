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
    /// PendingMarketingCampaignOfferDetails
    /// </summary>
    [DataContract]
        public partial class PendingMarketingCampaignOfferDetails :  IEquatable<PendingMarketingCampaignOfferDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PendingMarketingCampaignOfferDetails" /> class.
        /// </summary>
        /// <param name="campaignId">Unique identifier for a specific campaign being offered to the channel.</param>
        /// <param name="waveId">Unique identifier for the promotion under specific campaign being offered to the channel.</param>
        public PendingMarketingCampaignOfferDetails(string campaignId = default(string), string waveId = default(string))
        {
            this.CampaignId = campaignId;
            this.WaveId = waveId;
        }
        
        /// <summary>
        /// Unique identifier for a specific campaign being offered to the channel
        /// </summary>
        /// <value>Unique identifier for a specific campaign being offered to the channel</value>
        [DataMember(Name="campaignId", EmitDefaultValue=false)]
        public string CampaignId { get; set; }

        /// <summary>
        /// Unique identifier for the promotion under specific campaign being offered to the channel
        /// </summary>
        /// <value>Unique identifier for the promotion under specific campaign being offered to the channel</value>
        [DataMember(Name="waveId", EmitDefaultValue=false)]
        public string WaveId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PendingMarketingCampaignOfferDetails {\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  WaveId: ").Append(WaveId).Append("\n");
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
            return this.Equals(input as PendingMarketingCampaignOfferDetails);
        }

        /// <summary>
        /// Returns true if PendingMarketingCampaignOfferDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of PendingMarketingCampaignOfferDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PendingMarketingCampaignOfferDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CampaignId == input.CampaignId ||
                    (this.CampaignId != null &&
                    this.CampaignId.Equals(input.CampaignId))
                ) && 
                (
                    this.WaveId == input.WaveId ||
                    (this.WaveId != null &&
                    this.WaveId.Equals(input.WaveId))
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
                if (this.CampaignId != null)
                    hashCode = hashCode * 59 + this.CampaignId.GetHashCode();
                if (this.WaveId != null)
                    hashCode = hashCode * 59 + this.WaveId.GetHashCode();
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
