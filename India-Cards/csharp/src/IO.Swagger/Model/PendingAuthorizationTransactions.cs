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
    /// PendingAuthorizationTransactions
    /// </summary>
    [DataContract]
        public partial class PendingAuthorizationTransactions :  IEquatable<PendingAuthorizationTransactions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PendingAuthorizationTransactions" /> class.
        /// </summary>
        /// <param name="numberOfTransactions">Total Number of Transactions.</param>
        /// <param name="moreIndicator">This field indicates that more records are available for retrieval. Y &#x3D; more records are available for retrieval, N &#x3D; no more records are available for retrieval.</param>
        /// <param name="nextStartIndex">This field indicates the starting index for retrieving the next page/batch of records..</param>
        /// <param name="pendingAuthorizationTransactionRecords">pendingAuthorizationTransactionRecords.</param>
        public PendingAuthorizationTransactions(int? numberOfTransactions = default(int?), string moreIndicator = default(string), string nextStartIndex = default(string), List<PendingAuthorizationTransactionRecords> pendingAuthorizationTransactionRecords = default(List<PendingAuthorizationTransactionRecords>))
        {
            this.NumberOfTransactions = numberOfTransactions;
            this.MoreIndicator = moreIndicator;
            this.NextStartIndex = nextStartIndex;
            this.PendingAuthorizationTransactionRecords = pendingAuthorizationTransactionRecords;
        }
        
        /// <summary>
        /// Total Number of Transactions
        /// </summary>
        /// <value>Total Number of Transactions</value>
        [DataMember(Name="numberOfTransactions", EmitDefaultValue=false)]
        public int? NumberOfTransactions { get; set; }

        /// <summary>
        /// This field indicates that more records are available for retrieval. Y &#x3D; more records are available for retrieval, N &#x3D; no more records are available for retrieval
        /// </summary>
        /// <value>This field indicates that more records are available for retrieval. Y &#x3D; more records are available for retrieval, N &#x3D; no more records are available for retrieval</value>
        [DataMember(Name="moreIndicator", EmitDefaultValue=false)]
        public string MoreIndicator { get; set; }

        /// <summary>
        /// This field indicates the starting index for retrieving the next page/batch of records.
        /// </summary>
        /// <value>This field indicates the starting index for retrieving the next page/batch of records.</value>
        [DataMember(Name="nextStartIndex", EmitDefaultValue=false)]
        public string NextStartIndex { get; set; }

        /// <summary>
        /// Gets or Sets PendingAuthorizationTransactionRecords
        /// </summary>
        [DataMember(Name="pendingAuthorizationTransactionRecords", EmitDefaultValue=false)]
        public List<PendingAuthorizationTransactionRecords> PendingAuthorizationTransactionRecords { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PendingAuthorizationTransactions {\n");
            sb.Append("  NumberOfTransactions: ").Append(NumberOfTransactions).Append("\n");
            sb.Append("  MoreIndicator: ").Append(MoreIndicator).Append("\n");
            sb.Append("  NextStartIndex: ").Append(NextStartIndex).Append("\n");
            sb.Append("  PendingAuthorizationTransactionRecords: ").Append(PendingAuthorizationTransactionRecords).Append("\n");
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
            return this.Equals(input as PendingAuthorizationTransactions);
        }

        /// <summary>
        /// Returns true if PendingAuthorizationTransactions instances are equal
        /// </summary>
        /// <param name="input">Instance of PendingAuthorizationTransactions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PendingAuthorizationTransactions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NumberOfTransactions == input.NumberOfTransactions ||
                    (this.NumberOfTransactions != null &&
                    this.NumberOfTransactions.Equals(input.NumberOfTransactions))
                ) && 
                (
                    this.MoreIndicator == input.MoreIndicator ||
                    (this.MoreIndicator != null &&
                    this.MoreIndicator.Equals(input.MoreIndicator))
                ) && 
                (
                    this.NextStartIndex == input.NextStartIndex ||
                    (this.NextStartIndex != null &&
                    this.NextStartIndex.Equals(input.NextStartIndex))
                ) && 
                (
                    this.PendingAuthorizationTransactionRecords == input.PendingAuthorizationTransactionRecords ||
                    this.PendingAuthorizationTransactionRecords != null &&
                    input.PendingAuthorizationTransactionRecords != null &&
                    this.PendingAuthorizationTransactionRecords.SequenceEqual(input.PendingAuthorizationTransactionRecords)
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
                if (this.NumberOfTransactions != null)
                    hashCode = hashCode * 59 + this.NumberOfTransactions.GetHashCode();
                if (this.MoreIndicator != null)
                    hashCode = hashCode * 59 + this.MoreIndicator.GetHashCode();
                if (this.NextStartIndex != null)
                    hashCode = hashCode * 59 + this.NextStartIndex.GetHashCode();
                if (this.PendingAuthorizationTransactionRecords != null)
                    hashCode = hashCode * 59 + this.PendingAuthorizationTransactionRecords.GetHashCode();
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
