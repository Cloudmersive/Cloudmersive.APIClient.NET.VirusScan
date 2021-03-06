/* 
 * virusapi
 *
 * The Cloudmersive Virus Scan API lets you scan files and content for viruses and identify security issues with content.
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
using SwaggerDateConverter = Cloudmersive.APIClient.NET.VirusScan.Client.SwaggerDateConverter;

namespace Cloudmersive.APIClient.NET.VirusScan.Model
{
    /// <summary>
    /// Result of running a virus scan
    /// </summary>
    [DataContract]
    public partial class VirusScanResult :  IEquatable<VirusScanResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VirusScanResult" /> class.
        /// </summary>
        /// <param name="cleanResult">True if the scan contained no viruses, false otherwise.</param>
        /// <param name="foundViruses">Array of viruses found, if any.</param>
        public VirusScanResult(bool? cleanResult = default(bool?), List<VirusFound> foundViruses = default(List<VirusFound>))
        {
            this.CleanResult = cleanResult;
            this.FoundViruses = foundViruses;
        }
        
        /// <summary>
        /// True if the scan contained no viruses, false otherwise
        /// </summary>
        /// <value>True if the scan contained no viruses, false otherwise</value>
        [DataMember(Name="CleanResult", EmitDefaultValue=false)]
        public bool? CleanResult { get; set; }

        /// <summary>
        /// Array of viruses found, if any
        /// </summary>
        /// <value>Array of viruses found, if any</value>
        [DataMember(Name="FoundViruses", EmitDefaultValue=false)]
        public List<VirusFound> FoundViruses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VirusScanResult {\n");
            sb.Append("  CleanResult: ").Append(CleanResult).Append("\n");
            sb.Append("  FoundViruses: ").Append(FoundViruses).Append("\n");
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
            return this.Equals(input as VirusScanResult);
        }

        /// <summary>
        /// Returns true if VirusScanResult instances are equal
        /// </summary>
        /// <param name="input">Instance of VirusScanResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VirusScanResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CleanResult == input.CleanResult ||
                    (this.CleanResult != null &&
                    this.CleanResult.Equals(input.CleanResult))
                ) && 
                (
                    this.FoundViruses == input.FoundViruses ||
                    this.FoundViruses != null &&
                    this.FoundViruses.SequenceEqual(input.FoundViruses)
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
                if (this.CleanResult != null)
                    hashCode = hashCode * 59 + this.CleanResult.GetHashCode();
                if (this.FoundViruses != null)
                    hashCode = hashCode * 59 + this.FoundViruses.GetHashCode();
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
