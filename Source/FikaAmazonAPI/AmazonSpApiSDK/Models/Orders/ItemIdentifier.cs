﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Orders
{
    /// <summary>
    /// Item identifiers used in the context of approvals operations.
    /// </summary>
    [DataContract]
    public partial class ItemIdentifier : IEquatable<ItemIdentifier>, IValidatableObject
    {
        /// <summary>
        /// Defines the type of identifiers allowed to specify a substitution.
        /// </summary>
        /// <value>Defines the type of identifiers allowed to specify a substitution.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IdentifierTypeEnum
        {

            /// <summary>
            /// Enum ASIN for value: ASIN
            /// </summary>
            [EnumMember(Value = "ASIN")]
            ASIN = 1,

            /// <summary>
            /// Enum SELLERSKU for value: SELLER_SKU
            /// </summary>
            [EnumMember(Value = "SELLER_SKU")]
            SELLERSKU = 2,

            /// <summary>
            /// Enum EXTERNALID for value: EXTERNAL_ID
            /// </summary>
            [EnumMember(Value = "EXTERNAL_ID")]
            EXTERNALID = 3
        }

        /// <summary>
        /// Defines the type of identifiers allowed to specify a substitution.
        /// </summary>
        /// <value>Defines the type of identifiers allowed to specify a substitution.</value>
        [DataMember(Name = "IdentifierType", EmitDefaultValue = false)]
        public IdentifierTypeEnum IdentifierType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemIdentifier" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ItemIdentifier() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemIdentifier" /> class.
        /// </summary>
        /// <param name="identifierType">Defines the type of identifiers allowed to specify a substitution. (required).</param>
        /// <param name="identifier">identifier (required).</param>
        public ItemIdentifier(IdentifierTypeEnum identifierType = default(IdentifierTypeEnum), string identifier = default(string))
        {
            // to ensure "identifierType" is required (not null)
            if (identifierType == null)
            {
                throw new InvalidDataException("identifierType is a required property for ItemIdentifier and cannot be null");
            }
            else
            {
                this.IdentifierType = identifierType;
            }
            // to ensure "identifier" is required (not null)
            if (identifier == null)
            {
                throw new InvalidDataException("identifier is a required property for ItemIdentifier and cannot be null");
            }
            else
            {
                this.Identifier = identifier;
            }
        }


        /// <summary>
        /// Gets or Sets Identifier
        /// </summary>
        [DataMember(Name = "Identifier", EmitDefaultValue = false)]
        public string Identifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemIdentifier {\n");
            sb.Append("  IdentifierType: ").Append(IdentifierType).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
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
            return this.Equals(input as ItemIdentifier);
        }

        /// <summary>
        /// Returns true if ItemIdentifier instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemIdentifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemIdentifier input)
        {
            if (input == null)
                return false;

            return
                (
                    this.IdentifierType == input.IdentifierType ||
                    (this.IdentifierType != null &&
                    this.IdentifierType.Equals(input.IdentifierType))
                ) &&
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
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
                if (this.IdentifierType != null)
                    hashCode = hashCode * 59 + this.IdentifierType.GetHashCode();
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
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