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
    /// CountrySpecificAddress
    /// </summary>
    [DataContract]
        public partial class CountrySpecificAddress :  IEquatable<CountrySpecificAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CountrySpecificAddress" /> class.
        /// </summary>
        /// <param name="unitNumber">Applicants unit Number.</param>
        /// <param name="floorNumber">Applicants floor Number.</param>
        /// <param name="blockNumber">Applicants block Number.</param>
        /// <param name="buildingName">Applicants building Name.</param>
        /// <param name="streetNumber">Applicants street Number.</param>
        /// <param name="streetName">Applicants street Name.</param>
        /// <param name="streetType">Applicants street Type.Please use /v1/utilities/referenceData/{streetType} resource to get valid value of this field with description..</param>
        /// <param name="town">Applicants town.</param>
        public CountrySpecificAddress(string unitNumber = default(string), string floorNumber = default(string), string blockNumber = default(string), string buildingName = default(string), string streetNumber = default(string), string streetName = default(string), string streetType = default(string), string town = default(string))
        {
            this.UnitNumber = unitNumber;
            this.FloorNumber = floorNumber;
            this.BlockNumber = blockNumber;
            this.BuildingName = buildingName;
            this.StreetNumber = streetNumber;
            this.StreetName = streetName;
            this.StreetType = streetType;
            this.Town = town;
        }
        
        /// <summary>
        /// Applicants unit Number
        /// </summary>
        /// <value>Applicants unit Number</value>
        [DataMember(Name="unitNumber", EmitDefaultValue=false)]
        public string UnitNumber { get; set; }

        /// <summary>
        /// Applicants floor Number
        /// </summary>
        /// <value>Applicants floor Number</value>
        [DataMember(Name="floorNumber", EmitDefaultValue=false)]
        public string FloorNumber { get; set; }

        /// <summary>
        /// Applicants block Number
        /// </summary>
        /// <value>Applicants block Number</value>
        [DataMember(Name="blockNumber", EmitDefaultValue=false)]
        public string BlockNumber { get; set; }

        /// <summary>
        /// Applicants building Name
        /// </summary>
        /// <value>Applicants building Name</value>
        [DataMember(Name="buildingName", EmitDefaultValue=false)]
        public string BuildingName { get; set; }

        /// <summary>
        /// Applicants street Number
        /// </summary>
        /// <value>Applicants street Number</value>
        [DataMember(Name="streetNumber", EmitDefaultValue=false)]
        public string StreetNumber { get; set; }

        /// <summary>
        /// Applicants street Name
        /// </summary>
        /// <value>Applicants street Name</value>
        [DataMember(Name="streetName", EmitDefaultValue=false)]
        public string StreetName { get; set; }

        /// <summary>
        /// Applicants street Type.Please use /v1/utilities/referenceData/{streetType} resource to get valid value of this field with description.
        /// </summary>
        /// <value>Applicants street Type.Please use /v1/utilities/referenceData/{streetType} resource to get valid value of this field with description.</value>
        [DataMember(Name="streetType", EmitDefaultValue=false)]
        public string StreetType { get; set; }

        /// <summary>
        /// Applicants town
        /// </summary>
        /// <value>Applicants town</value>
        [DataMember(Name="town", EmitDefaultValue=false)]
        public string Town { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CountrySpecificAddress {\n");
            sb.Append("  UnitNumber: ").Append(UnitNumber).Append("\n");
            sb.Append("  FloorNumber: ").Append(FloorNumber).Append("\n");
            sb.Append("  BlockNumber: ").Append(BlockNumber).Append("\n");
            sb.Append("  BuildingName: ").Append(BuildingName).Append("\n");
            sb.Append("  StreetNumber: ").Append(StreetNumber).Append("\n");
            sb.Append("  StreetName: ").Append(StreetName).Append("\n");
            sb.Append("  StreetType: ").Append(StreetType).Append("\n");
            sb.Append("  Town: ").Append(Town).Append("\n");
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
            return this.Equals(input as CountrySpecificAddress);
        }

        /// <summary>
        /// Returns true if CountrySpecificAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of CountrySpecificAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CountrySpecificAddress input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UnitNumber == input.UnitNumber ||
                    (this.UnitNumber != null &&
                    this.UnitNumber.Equals(input.UnitNumber))
                ) && 
                (
                    this.FloorNumber == input.FloorNumber ||
                    (this.FloorNumber != null &&
                    this.FloorNumber.Equals(input.FloorNumber))
                ) && 
                (
                    this.BlockNumber == input.BlockNumber ||
                    (this.BlockNumber != null &&
                    this.BlockNumber.Equals(input.BlockNumber))
                ) && 
                (
                    this.BuildingName == input.BuildingName ||
                    (this.BuildingName != null &&
                    this.BuildingName.Equals(input.BuildingName))
                ) && 
                (
                    this.StreetNumber == input.StreetNumber ||
                    (this.StreetNumber != null &&
                    this.StreetNumber.Equals(input.StreetNumber))
                ) && 
                (
                    this.StreetName == input.StreetName ||
                    (this.StreetName != null &&
                    this.StreetName.Equals(input.StreetName))
                ) && 
                (
                    this.StreetType == input.StreetType ||
                    (this.StreetType != null &&
                    this.StreetType.Equals(input.StreetType))
                ) && 
                (
                    this.Town == input.Town ||
                    (this.Town != null &&
                    this.Town.Equals(input.Town))
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
                if (this.UnitNumber != null)
                    hashCode = hashCode * 59 + this.UnitNumber.GetHashCode();
                if (this.FloorNumber != null)
                    hashCode = hashCode * 59 + this.FloorNumber.GetHashCode();
                if (this.BlockNumber != null)
                    hashCode = hashCode * 59 + this.BlockNumber.GetHashCode();
                if (this.BuildingName != null)
                    hashCode = hashCode * 59 + this.BuildingName.GetHashCode();
                if (this.StreetNumber != null)
                    hashCode = hashCode * 59 + this.StreetNumber.GetHashCode();
                if (this.StreetName != null)
                    hashCode = hashCode * 59 + this.StreetName.GetHashCode();
                if (this.StreetType != null)
                    hashCode = hashCode * 59 + this.StreetType.GetHashCode();
                if (this.Town != null)
                    hashCode = hashCode * 59 + this.Town.GetHashCode();
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
