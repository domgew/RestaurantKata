/*
 * Billing
 *
 * Keeps track of ordered items in the restaurant and offers a guest a possibility to pay their bills with different payment methods. 
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Api.Billing.Model
{
    /// <summary>
    /// PaidBill
    /// </summary>
    [DataContract(Name = "paidBill")]
    public partial class PaidBill : IEquatable<PaidBill>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaidBill" /> class.
        /// </summary>
        /// <param name="bill">bill.</param>
        /// <param name="paidOrders">Lists the orders and items that have been paid by this bill.</param>
        public PaidBill(int bill = default(int), List<PaidOrder> paidOrders = default(List<PaidOrder>))
        {
            this.Bill = bill;
            this.PaidOrders = paidOrders;
        }

        /// <summary>
        /// Gets or Sets Bill
        /// </summary>
        [DataMember(Name = "bill", EmitDefaultValue = false)]
        public int Bill { get; set; }

        /// <summary>
        /// Lists the orders and items that have been paid by this bill
        /// </summary>
        /// <value>Lists the orders and items that have been paid by this bill</value>
        [DataMember(Name = "paidOrders", EmitDefaultValue = false)]
        public List<PaidOrder> PaidOrders { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaidBill {\n");
            sb.Append("  Bill: ").Append(Bill).Append("\n");
            sb.Append("  PaidOrders: ").Append(PaidOrders).Append("\n");
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
            return this.Equals(input as PaidBill);
        }

        /// <summary>
        /// Returns true if PaidBill instances are equal
        /// </summary>
        /// <param name="input">Instance of PaidBill to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaidBill input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Bill == input.Bill ||
                    this.Bill.Equals(input.Bill)
                ) && 
                (
                    this.PaidOrders == input.PaidOrders ||
                    this.PaidOrders != null &&
                    input.PaidOrders != null &&
                    this.PaidOrders.SequenceEqual(input.PaidOrders)
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
                hashCode = hashCode * 59 + this.Bill.GetHashCode();
                if (this.PaidOrders != null)
                    hashCode = hashCode * 59 + this.PaidOrders.GetHashCode();
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
            // Bill (int) minimum
            if(this.Bill < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Bill, must be a value greater than or equal to 0.", new [] { "Bill" });
            }

            yield break;
        }
    }

}
