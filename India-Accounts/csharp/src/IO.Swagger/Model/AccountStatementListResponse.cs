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
    /// AccountStatementListResponse
    /// </summary>
    [DataContract]
        public partial class AccountStatementListResponse :  IEquatable<AccountStatementListResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountStatementListResponse" /> class.
        /// </summary>
        /// <param name="statementList">statementList.</param>
        /// <param name="nextStartIndex">The next start index that indicates the next set of records to be fetched, if there are available. Typically, this value should be populated if the first response has the value of nextStartIndex..</param>
        public AccountStatementListResponse(List<StatementList> statementList = default(List<StatementList>), string nextStartIndex = default(string))
        {
            this.StatementList = statementList;
            this.NextStartIndex = nextStartIndex;
        }
        
        /// <summary>
        /// Gets or Sets StatementList
        /// </summary>
        [DataMember(Name="statementList", EmitDefaultValue=false)]
        public List<StatementList> StatementList { get; set; }

        /// <summary>
        /// The next start index that indicates the next set of records to be fetched, if there are available. Typically, this value should be populated if the first response has the value of nextStartIndex.
        /// </summary>
        /// <value>The next start index that indicates the next set of records to be fetched, if there are available. Typically, this value should be populated if the first response has the value of nextStartIndex.</value>
        [DataMember(Name="nextStartIndex", EmitDefaultValue=false)]
        public string NextStartIndex { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountStatementListResponse {\n");
            sb.Append("  StatementList: ").Append(StatementList).Append("\n");
            sb.Append("  NextStartIndex: ").Append(NextStartIndex).Append("\n");
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
            return this.Equals(input as AccountStatementListResponse);
        }

        /// <summary>
        /// Returns true if AccountStatementListResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountStatementListResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountStatementListResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StatementList == input.StatementList ||
                    this.StatementList != null &&
                    input.StatementList != null &&
                    this.StatementList.SequenceEqual(input.StatementList)
                ) && 
                (
                    this.NextStartIndex == input.NextStartIndex ||
                    (this.NextStartIndex != null &&
                    this.NextStartIndex.Equals(input.NextStartIndex))
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
                if (this.StatementList != null)
                    hashCode = hashCode * 59 + this.StatementList.GetHashCode();
                if (this.NextStartIndex != null)
                    hashCode = hashCode * 59 + this.NextStartIndex.GetHashCode();
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
