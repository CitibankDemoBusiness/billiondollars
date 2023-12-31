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
    /// Security
    /// </summary>
    [DataContract]
        public partial class Security :  IEquatable<Security>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Security" /> class.
        /// </summary>
        /// <param name="securityName">The security name.</param>
        /// <param name="stockCode">Unique code associated with security..</param>
        /// <param name="stockMarketCode">Trading market code for securities..</param>
        /// <param name="marketValueAmount">The current market worth of investment.</param>
        /// <param name="investmentAmount">The investment amount.</param>
        /// <param name="currencyCode">The currency code of the account in ISO 4217 format.</param>
        /// <param name="averageUnitCost">Average unit cost.</param>
        /// <param name="maturityDate">The maturity date in ISO 8601 format YYYY-MM-DD.</param>
        /// <param name="availableUnits">The available units.</param>
        /// <param name="settledUnits">The settled units.</param>
        /// <param name="assignedUnits">The assigned units.</param>
        /// <param name="confirmedUnits">The confirmed units.</param>
        /// <param name="pendingUnits">The pending units.</param>
        /// <param name="blockUnits">The blocked units.</param>
        /// <param name="unrealizedGains">The unrealized gain.</param>
        /// <param name="unrealizedPercentageGain">The unrealized gain in percentage.</param>
        /// <param name="latestPrice">The latest price.</param>
        public Security(string securityName = default(string), string stockCode = default(string), string stockMarketCode = default(string), double? marketValueAmount = default(double?), double? investmentAmount = default(double?), string currencyCode = default(string), double? averageUnitCost = default(double?), DateTime? maturityDate = default(DateTime?), double? availableUnits = default(double?), double? settledUnits = default(double?), double? assignedUnits = default(double?), double? confirmedUnits = default(double?), double? pendingUnits = default(double?), double? blockUnits = default(double?), double? unrealizedGains = default(double?), double? unrealizedPercentageGain = default(double?), double? latestPrice = default(double?))
        {
            this.SecurityName = securityName;
            this.StockCode = stockCode;
            this.StockMarketCode = stockMarketCode;
            this.MarketValueAmount = marketValueAmount;
            this.InvestmentAmount = investmentAmount;
            this.CurrencyCode = currencyCode;
            this.AverageUnitCost = averageUnitCost;
            this.MaturityDate = maturityDate;
            this.AvailableUnits = availableUnits;
            this.SettledUnits = settledUnits;
            this.AssignedUnits = assignedUnits;
            this.ConfirmedUnits = confirmedUnits;
            this.PendingUnits = pendingUnits;
            this.BlockUnits = blockUnits;
            this.UnrealizedGains = unrealizedGains;
            this.UnrealizedPercentageGain = unrealizedPercentageGain;
            this.LatestPrice = latestPrice;
        }
        
        /// <summary>
        /// The security name
        /// </summary>
        /// <value>The security name</value>
        [DataMember(Name="securityName", EmitDefaultValue=false)]
        public string SecurityName { get; set; }

        /// <summary>
        /// Unique code associated with security.
        /// </summary>
        /// <value>Unique code associated with security.</value>
        [DataMember(Name="stockCode", EmitDefaultValue=false)]
        public string StockCode { get; set; }

        /// <summary>
        /// Trading market code for securities.
        /// </summary>
        /// <value>Trading market code for securities.</value>
        [DataMember(Name="stockMarketCode", EmitDefaultValue=false)]
        public string StockMarketCode { get; set; }

        /// <summary>
        /// The current market worth of investment
        /// </summary>
        /// <value>The current market worth of investment</value>
        [DataMember(Name="marketValueAmount", EmitDefaultValue=false)]
        public double? MarketValueAmount { get; set; }

        /// <summary>
        /// The investment amount
        /// </summary>
        /// <value>The investment amount</value>
        [DataMember(Name="investmentAmount", EmitDefaultValue=false)]
        public double? InvestmentAmount { get; set; }

        /// <summary>
        /// The currency code of the account in ISO 4217 format
        /// </summary>
        /// <value>The currency code of the account in ISO 4217 format</value>
        [DataMember(Name="currencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Average unit cost
        /// </summary>
        /// <value>Average unit cost</value>
        [DataMember(Name="averageUnitCost", EmitDefaultValue=false)]
        public double? AverageUnitCost { get; set; }

        /// <summary>
        /// The maturity date in ISO 8601 format YYYY-MM-DD
        /// </summary>
        /// <value>The maturity date in ISO 8601 format YYYY-MM-DD</value>
        [DataMember(Name="maturityDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? MaturityDate { get; set; }

        /// <summary>
        /// The available units
        /// </summary>
        /// <value>The available units</value>
        [DataMember(Name="availableUnits", EmitDefaultValue=false)]
        public double? AvailableUnits { get; set; }

        /// <summary>
        /// The settled units
        /// </summary>
        /// <value>The settled units</value>
        [DataMember(Name="settledUnits", EmitDefaultValue=false)]
        public double? SettledUnits { get; set; }

        /// <summary>
        /// The assigned units
        /// </summary>
        /// <value>The assigned units</value>
        [DataMember(Name="assignedUnits", EmitDefaultValue=false)]
        public double? AssignedUnits { get; set; }

        /// <summary>
        /// The confirmed units
        /// </summary>
        /// <value>The confirmed units</value>
        [DataMember(Name="confirmedUnits", EmitDefaultValue=false)]
        public double? ConfirmedUnits { get; set; }

        /// <summary>
        /// The pending units
        /// </summary>
        /// <value>The pending units</value>
        [DataMember(Name="pendingUnits", EmitDefaultValue=false)]
        public double? PendingUnits { get; set; }

        /// <summary>
        /// The blocked units
        /// </summary>
        /// <value>The blocked units</value>
        [DataMember(Name="blockUnits", EmitDefaultValue=false)]
        public double? BlockUnits { get; set; }

        /// <summary>
        /// The unrealized gain
        /// </summary>
        /// <value>The unrealized gain</value>
        [DataMember(Name="unrealizedGains", EmitDefaultValue=false)]
        public double? UnrealizedGains { get; set; }

        /// <summary>
        /// The unrealized gain in percentage
        /// </summary>
        /// <value>The unrealized gain in percentage</value>
        [DataMember(Name="unrealizedPercentageGain", EmitDefaultValue=false)]
        public double? UnrealizedPercentageGain { get; set; }

        /// <summary>
        /// The latest price
        /// </summary>
        /// <value>The latest price</value>
        [DataMember(Name="latestPrice", EmitDefaultValue=false)]
        public double? LatestPrice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Security {\n");
            sb.Append("  SecurityName: ").Append(SecurityName).Append("\n");
            sb.Append("  StockCode: ").Append(StockCode).Append("\n");
            sb.Append("  StockMarketCode: ").Append(StockMarketCode).Append("\n");
            sb.Append("  MarketValueAmount: ").Append(MarketValueAmount).Append("\n");
            sb.Append("  InvestmentAmount: ").Append(InvestmentAmount).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  AverageUnitCost: ").Append(AverageUnitCost).Append("\n");
            sb.Append("  MaturityDate: ").Append(MaturityDate).Append("\n");
            sb.Append("  AvailableUnits: ").Append(AvailableUnits).Append("\n");
            sb.Append("  SettledUnits: ").Append(SettledUnits).Append("\n");
            sb.Append("  AssignedUnits: ").Append(AssignedUnits).Append("\n");
            sb.Append("  ConfirmedUnits: ").Append(ConfirmedUnits).Append("\n");
            sb.Append("  PendingUnits: ").Append(PendingUnits).Append("\n");
            sb.Append("  BlockUnits: ").Append(BlockUnits).Append("\n");
            sb.Append("  UnrealizedGains: ").Append(UnrealizedGains).Append("\n");
            sb.Append("  UnrealizedPercentageGain: ").Append(UnrealizedPercentageGain).Append("\n");
            sb.Append("  LatestPrice: ").Append(LatestPrice).Append("\n");
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
            return this.Equals(input as Security);
        }

        /// <summary>
        /// Returns true if Security instances are equal
        /// </summary>
        /// <param name="input">Instance of Security to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Security input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SecurityName == input.SecurityName ||
                    (this.SecurityName != null &&
                    this.SecurityName.Equals(input.SecurityName))
                ) && 
                (
                    this.StockCode == input.StockCode ||
                    (this.StockCode != null &&
                    this.StockCode.Equals(input.StockCode))
                ) && 
                (
                    this.StockMarketCode == input.StockMarketCode ||
                    (this.StockMarketCode != null &&
                    this.StockMarketCode.Equals(input.StockMarketCode))
                ) && 
                (
                    this.MarketValueAmount == input.MarketValueAmount ||
                    (this.MarketValueAmount != null &&
                    this.MarketValueAmount.Equals(input.MarketValueAmount))
                ) && 
                (
                    this.InvestmentAmount == input.InvestmentAmount ||
                    (this.InvestmentAmount != null &&
                    this.InvestmentAmount.Equals(input.InvestmentAmount))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.AverageUnitCost == input.AverageUnitCost ||
                    (this.AverageUnitCost != null &&
                    this.AverageUnitCost.Equals(input.AverageUnitCost))
                ) && 
                (
                    this.MaturityDate == input.MaturityDate ||
                    (this.MaturityDate != null &&
                    this.MaturityDate.Equals(input.MaturityDate))
                ) && 
                (
                    this.AvailableUnits == input.AvailableUnits ||
                    (this.AvailableUnits != null &&
                    this.AvailableUnits.Equals(input.AvailableUnits))
                ) && 
                (
                    this.SettledUnits == input.SettledUnits ||
                    (this.SettledUnits != null &&
                    this.SettledUnits.Equals(input.SettledUnits))
                ) && 
                (
                    this.AssignedUnits == input.AssignedUnits ||
                    (this.AssignedUnits != null &&
                    this.AssignedUnits.Equals(input.AssignedUnits))
                ) && 
                (
                    this.ConfirmedUnits == input.ConfirmedUnits ||
                    (this.ConfirmedUnits != null &&
                    this.ConfirmedUnits.Equals(input.ConfirmedUnits))
                ) && 
                (
                    this.PendingUnits == input.PendingUnits ||
                    (this.PendingUnits != null &&
                    this.PendingUnits.Equals(input.PendingUnits))
                ) && 
                (
                    this.BlockUnits == input.BlockUnits ||
                    (this.BlockUnits != null &&
                    this.BlockUnits.Equals(input.BlockUnits))
                ) && 
                (
                    this.UnrealizedGains == input.UnrealizedGains ||
                    (this.UnrealizedGains != null &&
                    this.UnrealizedGains.Equals(input.UnrealizedGains))
                ) && 
                (
                    this.UnrealizedPercentageGain == input.UnrealizedPercentageGain ||
                    (this.UnrealizedPercentageGain != null &&
                    this.UnrealizedPercentageGain.Equals(input.UnrealizedPercentageGain))
                ) && 
                (
                    this.LatestPrice == input.LatestPrice ||
                    (this.LatestPrice != null &&
                    this.LatestPrice.Equals(input.LatestPrice))
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
                if (this.SecurityName != null)
                    hashCode = hashCode * 59 + this.SecurityName.GetHashCode();
                if (this.StockCode != null)
                    hashCode = hashCode * 59 + this.StockCode.GetHashCode();
                if (this.StockMarketCode != null)
                    hashCode = hashCode * 59 + this.StockMarketCode.GetHashCode();
                if (this.MarketValueAmount != null)
                    hashCode = hashCode * 59 + this.MarketValueAmount.GetHashCode();
                if (this.InvestmentAmount != null)
                    hashCode = hashCode * 59 + this.InvestmentAmount.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.AverageUnitCost != null)
                    hashCode = hashCode * 59 + this.AverageUnitCost.GetHashCode();
                if (this.MaturityDate != null)
                    hashCode = hashCode * 59 + this.MaturityDate.GetHashCode();
                if (this.AvailableUnits != null)
                    hashCode = hashCode * 59 + this.AvailableUnits.GetHashCode();
                if (this.SettledUnits != null)
                    hashCode = hashCode * 59 + this.SettledUnits.GetHashCode();
                if (this.AssignedUnits != null)
                    hashCode = hashCode * 59 + this.AssignedUnits.GetHashCode();
                if (this.ConfirmedUnits != null)
                    hashCode = hashCode * 59 + this.ConfirmedUnits.GetHashCode();
                if (this.PendingUnits != null)
                    hashCode = hashCode * 59 + this.PendingUnits.GetHashCode();
                if (this.BlockUnits != null)
                    hashCode = hashCode * 59 + this.BlockUnits.GetHashCode();
                if (this.UnrealizedGains != null)
                    hashCode = hashCode * 59 + this.UnrealizedGains.GetHashCode();
                if (this.UnrealizedPercentageGain != null)
                    hashCode = hashCode * 59 + this.UnrealizedPercentageGain.GetHashCode();
                if (this.LatestPrice != null)
                    hashCode = hashCode * 59 + this.LatestPrice.GetHashCode();
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
