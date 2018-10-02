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
    /// BrightpearlAccountSettingsRequest
    /// </summary>
    [DataContract]
    public partial class BrightpearlAccountSettingsRequest :  IEquatable<BrightpearlAccountSettingsRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines DataCenterCode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DataCenterCodeEnum
        {
            
            /// <summary>
            /// Enum Use for value: use
            /// </summary>
            [EnumMember(Value = "use")]
            Use = 1,
            
            /// <summary>
            /// Enum Usw for value: usw
            /// </summary>
            [EnumMember(Value = "usw")]
            Usw = 2,
            
            /// <summary>
            /// Enum Eu1 for value: eu1
            /// </summary>
            [EnumMember(Value = "eu1")]
            Eu1 = 3
        }

        /// <summary>
        /// Gets or Sets DataCenterCode
        /// </summary>
        [DataMember(Name="data_center_code", EmitDefaultValue=false)]
        public DataCenterCodeEnum? DataCenterCode { get; set; }
        /// <summary>
        /// Defines WeightUnits
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum WeightUnitsEnum
        {
            
            /// <summary>
            /// Enum Ounces for value: ounces
            /// </summary>
            [EnumMember(Value = "ounces")]
            Ounces = 1,
            
            /// <summary>
            /// Enum Pounds for value: pounds
            /// </summary>
            [EnumMember(Value = "pounds")]
            Pounds = 2,
            
            /// <summary>
            /// Enum Grams for value: grams
            /// </summary>
            [EnumMember(Value = "grams")]
            Grams = 3
        }

        /// <summary>
        /// Gets or Sets WeightUnits
        /// </summary>
        [DataMember(Name="weight_units", EmitDefaultValue=false)]
        public WeightUnitsEnum? WeightUnits { get; set; }
        /// <summary>
        /// Defines ShipAction
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ShipActionEnum
        {
            
            /// <summary>
            /// Enum Pack for value: pack
            /// </summary>
            [EnumMember(Value = "pack")]
            Pack = 1,
            
            /// <summary>
            /// Enum Ship for value: ship
            /// </summary>
            [EnumMember(Value = "ship")]
            Ship = 2
        }

        /// <summary>
        /// Gets or Sets ShipAction
        /// </summary>
        [DataMember(Name="ship_action", EmitDefaultValue=false)]
        public ShipActionEnum? ShipAction { get; set; }
        /// <summary>
        /// Defines GoodsOut
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GoodsOutEnum
        {
            
            /// <summary>
            /// Enum All for value: all
            /// </summary>
            [EnumMember(Value = "all")]
            All = 1,
            
            /// <summary>
            /// Enum Printed for value: printed
            /// </summary>
            [EnumMember(Value = "printed")]
            Printed = 2,
            
            /// <summary>
            /// Enum Picked for value: picked
            /// </summary>
            [EnumMember(Value = "picked")]
            Picked = 3,
            
            /// <summary>
            /// Enum Packed for value: packed
            /// </summary>
            [EnumMember(Value = "packed")]
            Packed = 4
        }

        /// <summary>
        /// Gets or Sets GoodsOut
        /// </summary>
        [DataMember(Name="goods_out", EmitDefaultValue=false)]
        public GoodsOutEnum? GoodsOut { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BrightpearlAccountSettingsRequest" /> class.
        /// </summary>
        /// <param name="automaticallyImportSalesOrders">automaticallyImportSalesOrders.</param>
        /// <param name="channelIds">channelIds.</param>
        /// <param name="accountCode">accountCode.</param>
        /// <param name="dataCenterCode">dataCenterCode.</param>
        /// <param name="weightUnits">weightUnits.</param>
        /// <param name="shipAction">shipAction.</param>
        /// <param name="goodsOut">goodsOut.</param>
        public BrightpearlAccountSettingsRequest(bool? automaticallyImportSalesOrders = default(bool?), string channelIds = default(string), string accountCode = default(string), DataCenterCodeEnum? dataCenterCode = default(DataCenterCodeEnum?), WeightUnitsEnum? weightUnits = default(WeightUnitsEnum?), ShipActionEnum? shipAction = default(ShipActionEnum?), GoodsOutEnum? goodsOut = default(GoodsOutEnum?))
        {
            this.AutomaticallyImportSalesOrders = automaticallyImportSalesOrders;
            this.ChannelIds = channelIds;
            this.AccountCode = accountCode;
            this.DataCenterCode = dataCenterCode;
            this.WeightUnits = weightUnits;
            this.ShipAction = shipAction;
            this.GoodsOut = goodsOut;
        }
        
        /// <summary>
        /// Gets or Sets AutomaticallyImportSalesOrders
        /// </summary>
        [DataMember(Name="automatically_import_sales_orders", EmitDefaultValue=false)]
        public bool? AutomaticallyImportSalesOrders { get; set; }

        /// <summary>
        /// Gets or Sets ChannelIds
        /// </summary>
        [DataMember(Name="channel_ids", EmitDefaultValue=false)]
        public string ChannelIds { get; set; }

        /// <summary>
        /// Gets or Sets AccountCode
        /// </summary>
        [DataMember(Name="account_code", EmitDefaultValue=false)]
        public string AccountCode { get; set; }





        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrightpearlAccountSettingsRequest {\n");
            sb.Append("  AutomaticallyImportSalesOrders: ").Append(AutomaticallyImportSalesOrders).Append("\n");
            sb.Append("  ChannelIds: ").Append(ChannelIds).Append("\n");
            sb.Append("  AccountCode: ").Append(AccountCode).Append("\n");
            sb.Append("  DataCenterCode: ").Append(DataCenterCode).Append("\n");
            sb.Append("  WeightUnits: ").Append(WeightUnits).Append("\n");
            sb.Append("  ShipAction: ").Append(ShipAction).Append("\n");
            sb.Append("  GoodsOut: ").Append(GoodsOut).Append("\n");
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
            return this.Equals(input as BrightpearlAccountSettingsRequest);
        }

        /// <summary>
        /// Returns true if BrightpearlAccountSettingsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BrightpearlAccountSettingsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrightpearlAccountSettingsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AutomaticallyImportSalesOrders == input.AutomaticallyImportSalesOrders ||
                    (this.AutomaticallyImportSalesOrders != null &&
                    this.AutomaticallyImportSalesOrders.Equals(input.AutomaticallyImportSalesOrders))
                ) && 
                (
                    this.ChannelIds == input.ChannelIds ||
                    (this.ChannelIds != null &&
                    this.ChannelIds.Equals(input.ChannelIds))
                ) && 
                (
                    this.AccountCode == input.AccountCode ||
                    (this.AccountCode != null &&
                    this.AccountCode.Equals(input.AccountCode))
                ) && 
                (
                    this.DataCenterCode == input.DataCenterCode ||
                    (this.DataCenterCode != null &&
                    this.DataCenterCode.Equals(input.DataCenterCode))
                ) && 
                (
                    this.WeightUnits == input.WeightUnits ||
                    (this.WeightUnits != null &&
                    this.WeightUnits.Equals(input.WeightUnits))
                ) && 
                (
                    this.ShipAction == input.ShipAction ||
                    (this.ShipAction != null &&
                    this.ShipAction.Equals(input.ShipAction))
                ) && 
                (
                    this.GoodsOut == input.GoodsOut ||
                    (this.GoodsOut != null &&
                    this.GoodsOut.Equals(input.GoodsOut))
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
                if (this.AutomaticallyImportSalesOrders != null)
                    hashCode = hashCode * 59 + this.AutomaticallyImportSalesOrders.GetHashCode();
                if (this.ChannelIds != null)
                    hashCode = hashCode * 59 + this.ChannelIds.GetHashCode();
                if (this.AccountCode != null)
                    hashCode = hashCode * 59 + this.AccountCode.GetHashCode();
                if (this.DataCenterCode != null)
                    hashCode = hashCode * 59 + this.DataCenterCode.GetHashCode();
                if (this.WeightUnits != null)
                    hashCode = hashCode * 59 + this.WeightUnits.GetHashCode();
                if (this.ShipAction != null)
                    hashCode = hashCode * 59 + this.ShipAction.GetHashCode();
                if (this.GoodsOut != null)
                    hashCode = hashCode * 59 + this.GoodsOut.GetHashCode();
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