/* 
 * YouLend Third Party Instant Settlement API
 *
 * Through this API you can can create Instant Settlement transactions with YouLend
 *
 * The version of the OpenAPI document: v1.0
 * Contact: mark.ufland@youlend.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = YL.Web.Api.ThirdParty.InstantSettlement.Client.Client.OpenAPIDateConverter;

namespace YL.Web.Api.ThirdParty.InstantSettlement.Client.Model
{
    /// <summary>
    /// Model for viewing details of an Instant Settlement transaction
    /// </summary>
    [DataContract]
    public partial class InstantSettlementTransactionModel :  IEquatable<InstantSettlementTransactionModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstantSettlementTransactionModel" /> class.
        /// </summary>
        /// <param name="instantSettlementId">Gets or sets the Instant Settlement Id.</param>
        /// <param name="instantSettlementTransactionNumber">Gets or sets the Instant Settlement Number.</param>
        /// <param name="status">Gets or sets the status of the loan (i.e. unfunded, funded or repaid).</param>
        /// <param name="dateCreated">Gets or sets the date the loan was created.</param>
        /// <param name="dateFunded">Gets or sets the date the loan was funded.</param>
        /// <param name="dateRepaid">Gets or sets the date the loan was repaid.</param>
        /// <param name="currentAmount">Gets or sets the current amount outstanding for the loan.</param>
        /// <param name="fundedAmount">Gets or sets the originally funded amount for the loan.</param>
        /// <param name="amount">Gets or sets the amount requested for funding for the loan.</param>
        public InstantSettlementTransactionModel(Guid instantSettlementId = default(Guid), int instantSettlementTransactionNumber = default(int), string status = default(string), DateTime dateCreated = default(DateTime), DateTime dateFunded = default(DateTime), DateTime dateRepaid = default(DateTime), double currentAmount = default(double), double fundedAmount = default(double), double amount = default(double))
        {
            this.InstantSettlementId = instantSettlementId;
            this.InstantSettlementTransactionNumber = instantSettlementTransactionNumber;
            this.Status = status;
            this.DateCreated = dateCreated;
            this.DateFunded = dateFunded;
            this.DateRepaid = dateRepaid;
            this.CurrentAmount = currentAmount;
            this.FundedAmount = fundedAmount;
            this.Amount = amount;
        }
        
        /// <summary>
        /// Gets or sets the Instant Settlement Id
        /// </summary>
        /// <value>Gets or sets the Instant Settlement Id</value>
        [DataMember(Name="instantSettlementId", EmitDefaultValue=false)]
        public Guid InstantSettlementId { get; set; }

        /// <summary>
        /// Gets or sets the Instant Settlement Number
        /// </summary>
        /// <value>Gets or sets the Instant Settlement Number</value>
        [DataMember(Name="instantSettlementTransactionNumber", EmitDefaultValue=false)]
        public int InstantSettlementTransactionNumber { get; set; }

        /// <summary>
        /// Gets or sets the status of the loan (i.e. unfunded, funded or repaid)
        /// </summary>
        /// <value>Gets or sets the status of the loan (i.e. unfunded, funded or repaid)</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the date the loan was created
        /// </summary>
        /// <value>Gets or sets the date the loan was created</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Gets or sets the date the loan was funded
        /// </summary>
        /// <value>Gets or sets the date the loan was funded</value>
        [DataMember(Name="dateFunded", EmitDefaultValue=false)]
        public DateTime DateFunded { get; set; }

        /// <summary>
        /// Gets or sets the date the loan was repaid
        /// </summary>
        /// <value>Gets or sets the date the loan was repaid</value>
        [DataMember(Name="dateRepaid", EmitDefaultValue=false)]
        public DateTime DateRepaid { get; set; }

        /// <summary>
        /// Gets or sets the current amount outstanding for the loan
        /// </summary>
        /// <value>Gets or sets the current amount outstanding for the loan</value>
        [DataMember(Name="currentAmount", EmitDefaultValue=false)]
        public double CurrentAmount { get; set; }

        /// <summary>
        /// Gets or sets the originally funded amount for the loan
        /// </summary>
        /// <value>Gets or sets the originally funded amount for the loan</value>
        [DataMember(Name="fundedAmount", EmitDefaultValue=false)]
        public double FundedAmount { get; set; }

        /// <summary>
        /// Gets or sets the amount requested for funding for the loan
        /// </summary>
        /// <value>Gets or sets the amount requested for funding for the loan</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public double Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstantSettlementTransactionModel {\n");
            sb.Append("  InstantSettlementId: ").Append(InstantSettlementId).Append("\n");
            sb.Append("  InstantSettlementTransactionNumber: ").Append(InstantSettlementTransactionNumber).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateFunded: ").Append(DateFunded).Append("\n");
            sb.Append("  DateRepaid: ").Append(DateRepaid).Append("\n");
            sb.Append("  CurrentAmount: ").Append(CurrentAmount).Append("\n");
            sb.Append("  FundedAmount: ").Append(FundedAmount).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
            return this.Equals(input as InstantSettlementTransactionModel);
        }

        /// <summary>
        /// Returns true if InstantSettlementTransactionModel instances are equal
        /// </summary>
        /// <param name="input">Instance of InstantSettlementTransactionModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstantSettlementTransactionModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstantSettlementId == input.InstantSettlementId ||
                    (this.InstantSettlementId != null &&
                    this.InstantSettlementId.Equals(input.InstantSettlementId))
                ) && 
                (
                    this.InstantSettlementTransactionNumber == input.InstantSettlementTransactionNumber ||
                    this.InstantSettlementTransactionNumber.Equals(input.InstantSettlementTransactionNumber)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.DateCreated == input.DateCreated ||
                    (this.DateCreated != null &&
                    this.DateCreated.Equals(input.DateCreated))
                ) && 
                (
                    this.DateFunded == input.DateFunded ||
                    (this.DateFunded != null &&
                    this.DateFunded.Equals(input.DateFunded))
                ) && 
                (
                    this.DateRepaid == input.DateRepaid ||
                    (this.DateRepaid != null &&
                    this.DateRepaid.Equals(input.DateRepaid))
                ) && 
                (
                    this.CurrentAmount == input.CurrentAmount ||
                    this.CurrentAmount.Equals(input.CurrentAmount)
                ) && 
                (
                    this.FundedAmount == input.FundedAmount ||
                    this.FundedAmount.Equals(input.FundedAmount)
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
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
                if (this.InstantSettlementId != null)
                    hashCode = hashCode * 59 + this.InstantSettlementId.GetHashCode();
                hashCode = hashCode * 59 + this.InstantSettlementTransactionNumber.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.DateCreated != null)
                    hashCode = hashCode * 59 + this.DateCreated.GetHashCode();
                if (this.DateFunded != null)
                    hashCode = hashCode * 59 + this.DateFunded.GetHashCode();
                if (this.DateRepaid != null)
                    hashCode = hashCode * 59 + this.DateRepaid.GetHashCode();
                hashCode = hashCode * 59 + this.CurrentAmount.GetHashCode();
                hashCode = hashCode * 59 + this.FundedAmount.GetHashCode();
                hashCode = hashCode * 59 + this.Amount.GetHashCode();
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
