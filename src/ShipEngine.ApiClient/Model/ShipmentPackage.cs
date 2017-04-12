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

namespace ShipEngine.ApiClient.Model
{
    /// <summary>
    ///     Used as a package that is part of a Shipment, every Shipment must have at least one package.
    /// </summary>
    [DataContract]
    public class ShipmentPackage : IEquatable<ShipmentPackage>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ShipmentPackage" /> class.
        /// </summary>
        /// <param name="packageCode">PackageCode.</param>
        /// <param name="weight">Weight.</param>
        /// <param name="dimensions">Dimensions.</param>
        /// <param name="insuredValue">InsuredValue.</param>
        public ShipmentPackage(string packageCode = default(string), Weight weight = default(Weight),
            Dimensions dimensions = default(Dimensions), MoneyDTO insuredValue = default(MoneyDTO))
        {
            PackageCode = packageCode;
            Weight = weight;
            Dimensions = dimensions;
            InsuredValue = insuredValue;
        }

        /// <summary>
        ///     Gets or Sets PackageCode
        /// </summary>
        [DataMember(Name = "package_code", EmitDefaultValue = false)]
        public string PackageCode { get; set; }

        /// <summary>
        ///     Gets or Sets Weight
        /// </summary>
        [DataMember(Name = "weight", EmitDefaultValue = false)]
        public Weight Weight { get; set; }

        /// <summary>
        ///     Gets or Sets Dimensions
        /// </summary>
        [DataMember(Name = "dimensions", EmitDefaultValue = false)]
        public Dimensions Dimensions { get; set; }

        /// <summary>
        ///     Gets or Sets InsuredValue
        /// </summary>
        [DataMember(Name = "insured_value", EmitDefaultValue = false)]
        public MoneyDTO InsuredValue { get; set; }

        /// <summary>
        ///     Returns true if ShipmentPackage instances are equal
        /// </summary>
        /// <param name="other">Instance of ShipmentPackage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipmentPackage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
            {
                return false;
            }

            return
                (
                    PackageCode == other.PackageCode ||
                    PackageCode != null &&
                    PackageCode.Equals(other.PackageCode)
                ) &&
                (
                    Equals(Weight, other.Weight) ||
                    Weight != null &&
                    Weight.Equals(other.Weight)
                ) &&
                (
                    Equals(Dimensions, other.Dimensions) ||
                    Dimensions != null &&
                    Dimensions.Equals(other.Dimensions)
                ) &&
                (
                    Equals(InsuredValue, other.InsuredValue) ||
                    InsuredValue != null &&
                    InsuredValue.Equals(other.InsuredValue)
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
            sb.Append("class ShipmentPackage {\n");
            sb.Append("  PackageCode: ").Append(PackageCode).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("  InsuredValue: ").Append(InsuredValue).Append("\n");
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
            return Equals(obj as ShipmentPackage);
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
                if (PackageCode != null)
                {
                    hash = hash * 59 + PackageCode.GetHashCode();
                }
                if (Weight != null)
                {
                    hash = hash * 59 + Weight.GetHashCode();
                }
                if (Dimensions != null)
                {
                    hash = hash * 59 + Dimensions.GetHashCode();
                }
                if (InsuredValue != null)
                {
                    hash = hash * 59 + InsuredValue.GetHashCode();
                }
                return hash;
            }
        }
    }
}