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
    /// PendingAuthorizationTransaction
    /// </summary>
    [DataContract]
        public partial class PendingAuthorizationTransaction :  IEquatable<PendingAuthorizationTransaction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PendingAuthorizationTransaction" /> class.
        /// </summary>
        /// <param name="nextStartIndex">For pagination - the starting index for retrieving the next page/batch of records..</param>
        /// <param name="moreIndicator">This field is used for  pagination, it indicates that more records are available for retrieval..</param>
        public PendingAuthorizationTransaction(string nextStartIndex = default(string), string moreIndicator = default(string))
        {
            this.NextStartIndex = nextStartIndex;
            this.MoreIndicator = moreIndicator;
        }
        
        /// <summary>
        /// For pagination - the starting index for retrieving the next page/batch of records.
        /// </summary>
        /// <value>For pagination - the starting index for retrieving the next page/batch of records.</value>
        [DataMember(Name="nextStartIndex", EmitDefaultValue=false)]
        public string NextStartIndex { get; set; }

        /// <summary>
        /// This field is used for  pagination, it indicates that more records are available for retrieval.
        /// </summary>
        /// <value>This field is used for  pagination, it indicates that more records are available for retrieval.</value>
        [DataMember(Name="moreIndicator", EmitDefaultValue=false)]
        public string MoreIndicator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PendingAuthorizationTransaction {\n");
            sb.Append("  NextStartIndex: ").Append(NextStartIndex).Append("\n");
            sb.Append("  MoreIndicator: ").Append(MoreIndicator).Append("\n");
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
            return this.Equals(input as PendingAuthorizationTransaction);
        }

        /// <summary>
        /// Returns true if PendingAuthorizationTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of PendingAuthorizationTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PendingAuthorizationTransaction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NextStartIndex == input.NextStartIndex ||
                    (this.NextStartIndex != null &&
                    this.NextStartIndex.Equals(input.NextStartIndex))
                ) && 
                (
                    this.MoreIndicator == input.MoreIndicator ||
                    (this.MoreIndicator != null &&
                    this.MoreIndicator.Equals(input.MoreIndicator))
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
                if (this.NextStartIndex != null)
                    hashCode = hashCode * 59 + this.NextStartIndex.GetHashCode();
                if (this.MoreIndicator != null)
                    hashCode = hashCode * 59 + this.MoreIndicator.GetHashCode();
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
