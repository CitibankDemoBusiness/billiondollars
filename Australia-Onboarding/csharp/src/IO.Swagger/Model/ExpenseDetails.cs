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
    /// ExpenseDetails
    /// </summary>
    [DataContract]
        public partial class ExpenseDetails :  IEquatable<ExpenseDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpenseDetails" /> class.
        /// </summary>
        /// <param name="expenseType">Expense type. This is a reference data field. Please use /v1/utilities/referenceData/{expenseType} resource to get valid value of this field with description..</param>
        /// <param name="expenseAmount">Expenditure amount for an applicant.</param>
        /// <param name="frequency">Expense Frequency. This is a reference data field. Please use /v1/utilities/referenceData/{frequency} resource to get valid value of this field with description..</param>
        public ExpenseDetails(string expenseType = default(string), double? expenseAmount = default(double?), string frequency = default(string))
        {
            this.ExpenseType = expenseType;
            this.ExpenseAmount = expenseAmount;
            this.Frequency = frequency;
        }
        
        /// <summary>
        /// Expense type. This is a reference data field. Please use /v1/utilities/referenceData/{expenseType} resource to get valid value of this field with description.
        /// </summary>
        /// <value>Expense type. This is a reference data field. Please use /v1/utilities/referenceData/{expenseType} resource to get valid value of this field with description.</value>
        [DataMember(Name="expenseType", EmitDefaultValue=false)]
        public string ExpenseType { get; set; }

        /// <summary>
        /// Expenditure amount for an applicant
        /// </summary>
        /// <value>Expenditure amount for an applicant</value>
        [DataMember(Name="expenseAmount", EmitDefaultValue=false)]
        public double? ExpenseAmount { get; set; }

        /// <summary>
        /// Expense Frequency. This is a reference data field. Please use /v1/utilities/referenceData/{frequency} resource to get valid value of this field with description.
        /// </summary>
        /// <value>Expense Frequency. This is a reference data field. Please use /v1/utilities/referenceData/{frequency} resource to get valid value of this field with description.</value>
        [DataMember(Name="frequency", EmitDefaultValue=false)]
        public string Frequency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExpenseDetails {\n");
            sb.Append("  ExpenseType: ").Append(ExpenseType).Append("\n");
            sb.Append("  ExpenseAmount: ").Append(ExpenseAmount).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
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
            return this.Equals(input as ExpenseDetails);
        }

        /// <summary>
        /// Returns true if ExpenseDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ExpenseDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExpenseDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExpenseType == input.ExpenseType ||
                    (this.ExpenseType != null &&
                    this.ExpenseType.Equals(input.ExpenseType))
                ) && 
                (
                    this.ExpenseAmount == input.ExpenseAmount ||
                    (this.ExpenseAmount != null &&
                    this.ExpenseAmount.Equals(input.ExpenseAmount))
                ) && 
                (
                    this.Frequency == input.Frequency ||
                    (this.Frequency != null &&
                    this.Frequency.Equals(input.Frequency))
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
                if (this.ExpenseType != null)
                    hashCode = hashCode * 59 + this.ExpenseType.GetHashCode();
                if (this.ExpenseAmount != null)
                    hashCode = hashCode * 59 + this.ExpenseAmount.GetHashCode();
                if (this.Frequency != null)
                    hashCode = hashCode * 59 + this.Frequency.GetHashCode();
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
