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
using SwaggerDateConverter = ShipEngine.ApiClient.Client.SwaggerDateConverter;

namespace ShipEngine.ApiClient.Model
{
    /// <summary>
    /// Carrier
    /// </summary>
    [DataContract]
    public partial class Carrier :  IEquatable<Carrier>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Carrier" /> class.
        /// </summary>
        /// <param name="CarrierId">CarrierId.</param>
        /// <param name="CarrierCode">CarrierCode.</param>
        /// <param name="AccountNumber">AccountNumber.</param>
        /// <param name="RequiresFundedAmount">RequiresFundedAmount.</param>
        /// <param name="Balance">Balance.</param>
        /// <param name="Nickname">Nickname.</param>
        /// <param name="FriendlyName">FriendlyName.</param>
        /// <param name="Primary">Primary.</param>
        /// <param name="Services">Services.</param>
        /// <param name="Packages">Packages.</param>
        /// <param name="Options">Options.</param>
        public Carrier(string CarrierId = default(string), string CarrierCode = default(string), string AccountNumber = default(string), bool? RequiresFundedAmount = default(bool?), double? Balance = default(double?), string Nickname = default(string), string FriendlyName = default(string), bool? Primary = default(bool?), List<Service> Services = default(List<Service>), List<Package> Packages = default(List<Package>), List<CarrierAdvancedOption> Options = default(List<CarrierAdvancedOption>))
        {
            this.CarrierId = CarrierId;
            this.CarrierCode = CarrierCode;
            this.AccountNumber = AccountNumber;
            this.RequiresFundedAmount = RequiresFundedAmount;
            this.Balance = Balance;
            this.Nickname = Nickname;
            this.FriendlyName = FriendlyName;
            this.Primary = Primary;
            this.Services = Services;
            this.Packages = Packages;
            this.Options = Options;
        }
        
        /// <summary>
        /// Gets or Sets CarrierId
        /// </summary>
        [DataMember(Name="carrier_id", EmitDefaultValue=false)]
        public string CarrierId { get; set; }

        /// <summary>
        /// Gets or Sets CarrierCode
        /// </summary>
        [DataMember(Name="carrier_code", EmitDefaultValue=false)]
        public string CarrierCode { get; set; }

        /// <summary>
        /// Gets or Sets AccountNumber
        /// </summary>
        [DataMember(Name="account_number", EmitDefaultValue=false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets RequiresFundedAmount
        /// </summary>
        [DataMember(Name="requires_funded_amount", EmitDefaultValue=false)]
        public bool? RequiresFundedAmount { get; set; }

        /// <summary>
        /// Gets or Sets Balance
        /// </summary>
        [DataMember(Name="balance", EmitDefaultValue=false)]
        public double? Balance { get; set; }

        /// <summary>
        /// Gets or Sets Nickname
        /// </summary>
        [DataMember(Name="nickname", EmitDefaultValue=false)]
        public string Nickname { get; set; }

        /// <summary>
        /// Gets or Sets FriendlyName
        /// </summary>
        [DataMember(Name="friendly_name", EmitDefaultValue=false)]
        public string FriendlyName { get; set; }

        /// <summary>
        /// Gets or Sets Primary
        /// </summary>
        [DataMember(Name="primary", EmitDefaultValue=false)]
        public bool? Primary { get; set; }

        /// <summary>
        /// Gets or Sets Services
        /// </summary>
        [DataMember(Name="services", EmitDefaultValue=false)]
        public List<Service> Services { get; set; }

        /// <summary>
        /// Gets or Sets Packages
        /// </summary>
        [DataMember(Name="packages", EmitDefaultValue=false)]
        public List<Package> Packages { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public List<CarrierAdvancedOption> Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Carrier {\n");
            sb.Append("  CarrierId: ").Append(CarrierId).Append("\n");
            sb.Append("  CarrierCode: ").Append(CarrierCode).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  RequiresFundedAmount: ").Append(RequiresFundedAmount).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  Nickname: ").Append(Nickname).Append("\n");
            sb.Append("  FriendlyName: ").Append(FriendlyName).Append("\n");
            sb.Append("  Primary: ").Append(Primary).Append("\n");
            sb.Append("  Services: ").Append(Services).Append("\n");
            sb.Append("  Packages: ").Append(Packages).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as Carrier);
        }

        /// <summary>
        /// Returns true if Carrier instances are equal
        /// </summary>
        /// <param name="input">Instance of Carrier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Carrier input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CarrierId == input.CarrierId ||
                    (this.CarrierId != null &&
                    this.CarrierId.Equals(input.CarrierId))
                ) && 
                (
                    this.CarrierCode == input.CarrierCode ||
                    (this.CarrierCode != null &&
                    this.CarrierCode.Equals(input.CarrierCode))
                ) && 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.RequiresFundedAmount == input.RequiresFundedAmount ||
                    (this.RequiresFundedAmount != null &&
                    this.RequiresFundedAmount.Equals(input.RequiresFundedAmount))
                ) && 
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
                ) && 
                (
                    this.Nickname == input.Nickname ||
                    (this.Nickname != null &&
                    this.Nickname.Equals(input.Nickname))
                ) && 
                (
                    this.FriendlyName == input.FriendlyName ||
                    (this.FriendlyName != null &&
                    this.FriendlyName.Equals(input.FriendlyName))
                ) && 
                (
                    this.Primary == input.Primary ||
                    (this.Primary != null &&
                    this.Primary.Equals(input.Primary))
                ) && 
                (
                    this.Services == input.Services ||
                    (this.Services != null &&
                    this.Services.SequenceEqual(input.Services))
                ) && 
                (
                    this.Packages == input.Packages ||
                    (this.Packages != null &&
                    this.Packages.SequenceEqual(input.Packages))
                ) && 
                (
                    this.Options == input.Options ||
                    (this.Options != null &&
                    this.Options.SequenceEqual(input.Options))
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
                if (this.CarrierId != null)
                    hashCode = hashCode * 59 + this.CarrierId.GetHashCode();
                if (this.CarrierCode != null)
                    hashCode = hashCode * 59 + this.CarrierCode.GetHashCode();
                if (this.AccountNumber != null)
                    hashCode = hashCode * 59 + this.AccountNumber.GetHashCode();
                if (this.RequiresFundedAmount != null)
                    hashCode = hashCode * 59 + this.RequiresFundedAmount.GetHashCode();
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.Nickname != null)
                    hashCode = hashCode * 59 + this.Nickname.GetHashCode();
                if (this.FriendlyName != null)
                    hashCode = hashCode * 59 + this.FriendlyName.GetHashCode();
                if (this.Primary != null)
                    hashCode = hashCode * 59 + this.Primary.GetHashCode();
                if (this.Services != null)
                    hashCode = hashCode * 59 + this.Services.GetHashCode();
                if (this.Packages != null)
                    hashCode = hashCode * 59 + this.Packages.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
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
