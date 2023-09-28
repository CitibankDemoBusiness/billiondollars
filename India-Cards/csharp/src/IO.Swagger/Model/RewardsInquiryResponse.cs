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
    /// RewardsInquiryResponse
    /// </summary>
    [DataContract]
        public partial class RewardsInquiryResponse :  IEquatable<RewardsInquiryResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RewardsInquiryResponse" /> class.
        /// </summary>
        /// <param name="rewardAccounts">rewardAccounts (required).</param>
        public RewardsInquiryResponse(List<RewardAccount> rewardAccounts = default(List<RewardAccount>))
        {
            // to ensure "rewardAccounts" is required (not null)
            if (rewardAccounts == null)
            {
                throw new InvalidDataException("rewardAccounts is a required property for RewardsInquiryResponse and cannot be null");
            }
            else
            {
                this.RewardAccounts = rewardAccounts;
            }
        }
        
        /// <summary>
        /// Gets or Sets RewardAccounts
        /// </summary>
        [DataMember(Name="rewardAccounts", EmitDefaultValue=false)]
        public List<RewardAccount> RewardAccounts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RewardsInquiryResponse {\n");
            sb.Append("  RewardAccounts: ").Append(RewardAccounts).Append("\n");
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
            return this.Equals(input as RewardsInquiryResponse);
        }

        /// <summary>
        /// Returns true if RewardsInquiryResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RewardsInquiryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RewardsInquiryResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RewardAccounts == input.RewardAccounts ||
                    this.RewardAccounts != null &&
                    input.RewardAccounts != null &&
                    this.RewardAccounts.SequenceEqual(input.RewardAccounts)
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
                if (this.RewardAccounts != null)
                    hashCode = hashCode * 59 + this.RewardAccounts.GetHashCode();
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