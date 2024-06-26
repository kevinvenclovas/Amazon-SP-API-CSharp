﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Orders
{
    /// <summary>
    /// The reason for rejecting the order&#39;s regulated information. Not present if the order isn&#39;t rejected.
    /// </summary>
    [DataContract]
    public partial class RejectionReason : IEquatable<RejectionReason>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RejectionReason" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public RejectionReason() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RejectionReason" /> class.
        /// </summary>
        /// <param name="rejectionReasonId">The unique identifier for the rejection reason. (required).</param>
        /// <param name="rejectionReasonDescription">The description of this rejection reason. (required).</param>
        public RejectionReason(string rejectionReasonId = default(string), string rejectionReasonDescription = default(string))
        {
            // to ensure "rejectionReasonId" is required (not null)
            if (rejectionReasonId == null)
            {
                throw new InvalidDataException("rejectionReasonId is a required property for RejectionReason and cannot be null");
            }
            else
            {
                this.RejectionReasonId = rejectionReasonId;
            }
            // to ensure "rejectionReasonDescription" is required (not null)
            if (rejectionReasonDescription == null)
            {
                throw new InvalidDataException("rejectionReasonDescription is a required property for RejectionReason and cannot be null");
            }
            else
            {
                this.RejectionReasonDescription = rejectionReasonDescription;
            }
        }

        /// <summary>
        /// The unique identifier for the rejection reason.
        /// </summary>
        /// <value>The unique identifier for the rejection reason.</value>
        [DataMember(Name = "RejectionReasonId", EmitDefaultValue = false)]
        public string RejectionReasonId { get; set; }

        /// <summary>
        /// The description of this rejection reason.
        /// </summary>
        /// <value>The description of this rejection reason.</value>
        [DataMember(Name = "RejectionReasonDescription", EmitDefaultValue = false)]
        public string RejectionReasonDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RejectionReason {\n");
            sb.Append("  RejectionReasonId: ").Append(RejectionReasonId).Append("\n");
            sb.Append("  RejectionReasonDescription: ").Append(RejectionReasonDescription).Append("\n");
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
            return this.Equals(input as RejectionReason);
        }

        /// <summary>
        /// Returns true if RejectionReason instances are equal
        /// </summary>
        /// <param name="input">Instance of RejectionReason to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RejectionReason input)
        {
            if (input == null)
                return false;

            return
                (
                    this.RejectionReasonId == input.RejectionReasonId ||
                    (this.RejectionReasonId != null &&
                    this.RejectionReasonId.Equals(input.RejectionReasonId))
                ) &&
                (
                    this.RejectionReasonDescription == input.RejectionReasonDescription ||
                    (this.RejectionReasonDescription != null &&
                    this.RejectionReasonDescription.Equals(input.RejectionReasonDescription))
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
                if (this.RejectionReasonId != null)
                    hashCode = hashCode * 59 + this.RejectionReasonId.GetHashCode();
                if (this.RejectionReasonDescription != null)
                    hashCode = hashCode * 59 + this.RejectionReasonDescription.GetHashCode();
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