/* 
 * ShipEngine
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ShipEngine.ApiClient.Model
{
    /// <summary>
    ///     Weight
    /// </summary>
    [DataContract]
    public class Weight : IEquatable<Weight>, IValidatableObject
    {
        /// <summary>
        ///     This is a stringified version of ShipEngine.Core.DTO.Measurement.WeightUnits
        /// </summary>
        /// <value>This is a stringified version of ShipEngine.Core.DTO.Measurement.WeightUnits</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnitEnum
        {
            /// <summary>
            ///     Enum Pound for "pound"
            /// </summary>
            [EnumMember(Value = "pound")] Pound,

            /// <summary>
            ///     Enum Ounce for "ounce"
            /// </summary>
            [EnumMember(Value = "ounce")] Ounce,

            /// <summary>
            ///     Enum Gram for "gram"
            /// </summary>
            [EnumMember(Value = "gram")] Gram,

            /// <summary>
            ///     Enum Kilogram for "kilogram"
            /// </summary>
            [EnumMember(Value = "kilogram")] Kilogram
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Weight" /> class.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="unit">This is a stringified version of ShipEngine.Core.DTO.Measurement.WeightUnits.</param>
        public Weight(decimal? value = default(decimal?), UnitEnum? unit = default(UnitEnum?))
        {
            Value = value;
            Unit = unit;
        }

        /// <summary>
        ///     This is a stringified version of ShipEngine.Core.DTO.Measurement.WeightUnits
        /// </summary>
        /// <value>This is a stringified version of ShipEngine.Core.DTO.Measurement.WeightUnits</value>
        [DataMember(Name = "unit", EmitDefaultValue = false)]
        public UnitEnum? Unit { get; set; }

        /// <summary>
        ///     Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public decimal? Value { get; set; }

        /// <summary>
        ///     Returns true if Weight instances are equal
        /// </summary>
        /// <param name="other">Instance of Weight to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Weight other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
            {
                return false;
            }

            return
                (
                    Value == other.Value ||
                    Value != null &&
                    Value.Equals(other.Value)
                ) &&
                (
                    Unit == other.Unit ||
                    Unit != null &&
                    Unit.Equals(other.Unit)
                );
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Weight {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        ///     Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return Equals(obj as Weight);
        }

        /// <summary>
        ///     Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                var hash = 41;
                // Suitable nullity checks etc, of course :)
                if (Value != null)
                {
                    hash = hash * 59 + Value.GetHashCode();
                }
                if (Unit != null)
                {
                    hash = hash * 59 + Unit.GetHashCode();
                }
                return hash;
            }
        }
    }
}