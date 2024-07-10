/* 
 * Selling Partner API for Fulfillment Inbound
 *
 * The Selling Partner API for Fulfillment Inbound lets you create applications that create and update inbound shipments of inventory to Amazon's fulfillment network.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInbound
{
    /// <summary>
    /// The workflow status for a shipment with an Amazon-partnered carrier.
    /// </summary>
    [DataContract]
    public partial class TransportResult : IEquatable<TransportResult>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets TransportStatus
        /// </summary>
        [DataMember(Name = "TransportStatus", EmitDefaultValue = false)]
        public TransportStatus TransportStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransportResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public TransportResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransportResult" /> class.
        /// </summary>
        /// <param name="transportStatus">transportStatus (required).</param>
        /// <param name="errorCode">An error code that identifies the type of error that occured..</param>
        /// <param name="errorDescription">A message that describes the error condition..</param>
        public TransportResult(TransportStatus transportStatus = default(TransportStatus), string errorCode = default(string), string errorDescription = default(string))
        {
            // to ensure "transportStatus" is required (not null)
            if (transportStatus == null)
            {
                throw new InvalidDataException("transportStatus is a required property for TransportResult and cannot be null");
            }
            else
            {
                this.TransportStatus = transportStatus;
            }
            this.ErrorCode = errorCode;
            this.ErrorDescription = errorDescription;
        }


        /// <summary>
        /// An error code that identifies the type of error that occured.
        /// </summary>
        /// <value>An error code that identifies the type of error that occured.</value>
        [DataMember(Name = "ErrorCode", EmitDefaultValue = false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// A message that describes the error condition.
        /// </summary>
        /// <value>A message that describes the error condition.</value>
        [DataMember(Name = "ErrorDescription", EmitDefaultValue = false)]
        public string ErrorDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransportResult {\n");
            sb.Append("  TransportStatus: ").Append(TransportStatus).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorDescription: ").Append(ErrorDescription).Append("\n");
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
            return this.Equals(input as TransportResult);
        }

        /// <summary>
        /// Returns true if TransportResult instances are equal
        /// </summary>
        /// <param name="input">Instance of TransportResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransportResult input)
        {
            if (input == null)
                return false;

            return
                (
                    this.TransportStatus == input.TransportStatus ||
                    (this.TransportStatus != null &&
                    this.TransportStatus.Equals(input.TransportStatus))
                ) &&
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) &&
                (
                    this.ErrorDescription == input.ErrorDescription ||
                    (this.ErrorDescription != null &&
                    this.ErrorDescription.Equals(input.ErrorDescription))
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
                if (this.TransportStatus != null)
                    hashCode = hashCode * 59 + this.TransportStatus.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorDescription != null)
                    hashCode = hashCode * 59 + this.ErrorDescription.GetHashCode();
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