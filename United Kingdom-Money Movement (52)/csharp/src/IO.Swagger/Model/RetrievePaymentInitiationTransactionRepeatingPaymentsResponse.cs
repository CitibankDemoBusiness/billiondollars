/* 
 * Money Movement
 *
 * <P>The Money Movement API allow you to move money from Citi customers account. Transfers can be made to predefined payees by customer and individuals not included in the payee list</P> The segment of API will allow to perform below category of transfers:<br><br><b>Personal Transfer-</b> Allowing customer to initiate the money transfers within customer�s own Citi accounts.<br><br><b>Internal transfer-</b> Allowing customer to initiate the money transfer from customer Citi own accounts to other Citi accounts locally.<br><br><b>External transfer-</b> Allowing customer to initiate the money transfer from customer Citi own accounts to other bank accounts locally.<br><br><b>Bill Payment-</b> Allowing customer to initiate the bill payment from customer Citi own accounts to billing organization.<br><br><b>Citi Global Transfer-</b> Allowing customer to initiate the money transfer from customer Citi own accounts to other Citi bank accounts across various Countries.<br><br><b>SEPA Transfer-</b> Allowing customer to initiate money transfer to other European bank accounts within the SEPA territory.<br><br><b>Cross border transfer-</b> Allowing customer to initiate money transfer from customer own account to cross border bank accounts.<br>
 *
 * OpenAPI spec version: 1.0.0e
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
    /// RetrievePaymentInitiationTransactionRepeatingPaymentsResponse
    /// </summary>
    [DataContract]
        public partial class RetrievePaymentInitiationTransactionRepeatingPaymentsResponse :  IEquatable<RetrievePaymentInitiationTransactionRepeatingPaymentsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetrievePaymentInitiationTransactionRepeatingPaymentsResponse" /> class.
        /// </summary>
        /// <param name="nextStartIndex">The next start index that indicates the next set of records to be fetched, if there are available. Typically, this value should be populated if the first response has the value of nextStartIndex.It is not applicable for the first iteration.</param>
        /// <param name="standingInstructions">standingInstructions.</param>
        public RetrievePaymentInitiationTransactionRepeatingPaymentsResponse(string nextStartIndex = default(string), List<StandingInstructions> standingInstructions = default(List<StandingInstructions>))
        {
            this.NextStartIndex = nextStartIndex;
            this.StandingInstructions = standingInstructions;
        }
        
        /// <summary>
        /// The next start index that indicates the next set of records to be fetched, if there are available. Typically, this value should be populated if the first response has the value of nextStartIndex.It is not applicable for the first iteration
        /// </summary>
        /// <value>The next start index that indicates the next set of records to be fetched, if there are available. Typically, this value should be populated if the first response has the value of nextStartIndex.It is not applicable for the first iteration</value>
        [DataMember(Name="nextStartIndex", EmitDefaultValue=false)]
        public string NextStartIndex { get; set; }

        /// <summary>
        /// Gets or Sets StandingInstructions
        /// </summary>
        [DataMember(Name="standingInstructions", EmitDefaultValue=false)]
        public List<StandingInstructions> StandingInstructions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetrievePaymentInitiationTransactionRepeatingPaymentsResponse {\n");
            sb.Append("  NextStartIndex: ").Append(NextStartIndex).Append("\n");
            sb.Append("  StandingInstructions: ").Append(StandingInstructions).Append("\n");
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
            return this.Equals(input as RetrievePaymentInitiationTransactionRepeatingPaymentsResponse);
        }

        /// <summary>
        /// Returns true if RetrievePaymentInitiationTransactionRepeatingPaymentsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RetrievePaymentInitiationTransactionRepeatingPaymentsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RetrievePaymentInitiationTransactionRepeatingPaymentsResponse input)
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
                    this.StandingInstructions == input.StandingInstructions ||
                    this.StandingInstructions != null &&
                    input.StandingInstructions != null &&
                    this.StandingInstructions.SequenceEqual(input.StandingInstructions)
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
                if (this.StandingInstructions != null)
                    hashCode = hashCode * 59 + this.StandingInstructions.GetHashCode();
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
