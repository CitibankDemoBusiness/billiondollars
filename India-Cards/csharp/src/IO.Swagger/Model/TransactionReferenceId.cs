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
    /// TransactionReferenceId
    /// </summary>
    [DataContract]
        public partial class TransactionReferenceId :  IEquatable<TransactionReferenceId>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionReferenceId" /> class.
        /// </summary>
        /// <param name="transactionReferenceId">Reference Id to uniquely identify the transaction. Applicable only for EPP of type TRANSACTION..</param>
        public TransactionReferenceId(string transactionReferenceId = default(string))
        {
            this._TransactionReferenceId = transactionReferenceId;
        }
        
        /// <summary>
        /// Reference Id to uniquely identify the transaction. Applicable only for EPP of type TRANSACTION.
        /// </summary>
        /// <value>Reference Id to uniquely identify the transaction. Applicable only for EPP of type TRANSACTION.</value>
        [DataMember(Name="transactionReferenceId", EmitDefaultValue=false)]
        public string _TransactionReferenceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionReferenceId {\n");
            sb.Append("  _TransactionReferenceId: ").Append(_TransactionReferenceId).Append("\n");
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
            return this.Equals(input as TransactionReferenceId);
        }

        /// <summary>
        /// Returns true if TransactionReferenceId instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionReferenceId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionReferenceId input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._TransactionReferenceId == input._TransactionReferenceId ||
                    (this._TransactionReferenceId != null &&
                    this._TransactionReferenceId.Equals(input._TransactionReferenceId))
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
                if (this._TransactionReferenceId != null)
                    hashCode = hashCode * 59 + this._TransactionReferenceId.GetHashCode();
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
