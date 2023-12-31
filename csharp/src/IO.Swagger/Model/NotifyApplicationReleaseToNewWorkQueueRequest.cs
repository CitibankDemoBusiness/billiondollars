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
    /// NotifyApplicationReleaseToNewWorkQueueRequest
    /// </summary>
    [DataContract]
        public partial class NotifyApplicationReleaseToNewWorkQueueRequest :  IEquatable<NotifyApplicationReleaseToNewWorkQueueRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotifyApplicationReleaseToNewWorkQueueRequest" /> class.
        /// </summary>
        /// <param name="applicationId">Unique identifier for the application (required).</param>
        /// <param name="autoReleasePoint">A trigger point of case that able to be released to next queue (required).</param>
        /// <param name="controlFlowId">Control flow id is used to control the flow for subsequent requests in the session. (required).</param>
        public NotifyApplicationReleaseToNewWorkQueueRequest(string applicationId = default(string), string autoReleasePoint = default(string), string controlFlowId = default(string))
        {
            // to ensure "applicationId" is required (not null)
            if (applicationId == null)
            {
                throw new InvalidDataException("applicationId is a required property for NotifyApplicationReleaseToNewWorkQueueRequest and cannot be null");
            }
            else
            {
                this.ApplicationId = applicationId;
            }
            // to ensure "autoReleasePoint" is required (not null)
            if (autoReleasePoint == null)
            {
                throw new InvalidDataException("autoReleasePoint is a required property for NotifyApplicationReleaseToNewWorkQueueRequest and cannot be null");
            }
            else
            {
                this.AutoReleasePoint = autoReleasePoint;
            }
            // to ensure "controlFlowId" is required (not null)
            if (controlFlowId == null)
            {
                throw new InvalidDataException("controlFlowId is a required property for NotifyApplicationReleaseToNewWorkQueueRequest and cannot be null");
            }
            else
            {
                this.ControlFlowId = controlFlowId;
            }
        }
        
        /// <summary>
        /// Unique identifier for the application
        /// </summary>
        /// <value>Unique identifier for the application</value>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// A trigger point of case that able to be released to next queue
        /// </summary>
        /// <value>A trigger point of case that able to be released to next queue</value>
        [DataMember(Name="autoReleasePoint", EmitDefaultValue=false)]
        public string AutoReleasePoint { get; set; }

        /// <summary>
        /// Control flow id is used to control the flow for subsequent requests in the session.
        /// </summary>
        /// <value>Control flow id is used to control the flow for subsequent requests in the session.</value>
        [DataMember(Name="controlFlowId", EmitDefaultValue=false)]
        public string ControlFlowId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotifyApplicationReleaseToNewWorkQueueRequest {\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  AutoReleasePoint: ").Append(AutoReleasePoint).Append("\n");
            sb.Append("  ControlFlowId: ").Append(ControlFlowId).Append("\n");
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
            return this.Equals(input as NotifyApplicationReleaseToNewWorkQueueRequest);
        }

        /// <summary>
        /// Returns true if NotifyApplicationReleaseToNewWorkQueueRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of NotifyApplicationReleaseToNewWorkQueueRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotifyApplicationReleaseToNewWorkQueueRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.AutoReleasePoint == input.AutoReleasePoint ||
                    (this.AutoReleasePoint != null &&
                    this.AutoReleasePoint.Equals(input.AutoReleasePoint))
                ) && 
                (
                    this.ControlFlowId == input.ControlFlowId ||
                    (this.ControlFlowId != null &&
                    this.ControlFlowId.Equals(input.ControlFlowId))
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
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.AutoReleasePoint != null)
                    hashCode = hashCode * 59 + this.AutoReleasePoint.GetHashCode();
                if (this.ControlFlowId != null)
                    hashCode = hashCode * 59 + this.ControlFlowId.GetHashCode();
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
