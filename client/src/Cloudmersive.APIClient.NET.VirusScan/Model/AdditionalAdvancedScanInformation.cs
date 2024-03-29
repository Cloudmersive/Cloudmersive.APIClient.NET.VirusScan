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
    /// Additional non-threat content verification information
    /// </summary>
    [DataContract]
    public partial class AdditionalAdvancedScanInformation :  IEquatable<AdditionalAdvancedScanInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalAdvancedScanInformation" /> class.
        /// </summary>
        /// <param name="containsJSON">True if the input file contains JSON data, false otherwise; this is not a threat signal.</param>
        /// <param name="containsXML">True if the input file contains XML data, false otherwise; this is not a threat signal.</param>
        /// <param name="containsImage">True if the input file contains an image.</param>
        /// <param name="relevantSubfileName">Relevant subfile name in an archive format for identified threats, if any.</param>
        public AdditionalAdvancedScanInformation(bool? containsJSON = default(bool?), bool? containsXML = default(bool?), bool? containsImage = default(bool?), string relevantSubfileName = default(string))
        {
            this.ContainsJSON = containsJSON;
            this.ContainsXML = containsXML;
            this.ContainsImage = containsImage;
            this.RelevantSubfileName = relevantSubfileName;
        }
        
        /// <summary>
        /// True if the input file contains JSON data, false otherwise; this is not a threat signal
        /// </summary>
        /// <value>True if the input file contains JSON data, false otherwise; this is not a threat signal</value>
        [DataMember(Name="ContainsJSON", EmitDefaultValue=false)]
        public bool? ContainsJSON { get; set; }

        /// <summary>
        /// True if the input file contains XML data, false otherwise; this is not a threat signal
        /// </summary>
        /// <value>True if the input file contains XML data, false otherwise; this is not a threat signal</value>
        [DataMember(Name="ContainsXML", EmitDefaultValue=false)]
        public bool? ContainsXML { get; set; }

        /// <summary>
        /// True if the input file contains an image
        /// </summary>
        /// <value>True if the input file contains an image</value>
        [DataMember(Name="ContainsImage", EmitDefaultValue=false)]
        public bool? ContainsImage { get; set; }

        /// <summary>
        /// Relevant subfile name in an archive format for identified threats, if any
        /// </summary>
        /// <value>Relevant subfile name in an archive format for identified threats, if any</value>
        [DataMember(Name="RelevantSubfileName", EmitDefaultValue=false)]
        public string RelevantSubfileName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalAdvancedScanInformation {\n");
            sb.Append("  ContainsJSON: ").Append(ContainsJSON).Append("\n");
            sb.Append("  ContainsXML: ").Append(ContainsXML).Append("\n");
            sb.Append("  ContainsImage: ").Append(ContainsImage).Append("\n");
            sb.Append("  RelevantSubfileName: ").Append(RelevantSubfileName).Append("\n");
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
            return this.Equals(input as AdditionalAdvancedScanInformation);
        }

        /// <summary>
        /// Returns true if AdditionalAdvancedScanInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalAdvancedScanInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalAdvancedScanInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContainsJSON == input.ContainsJSON ||
                    (this.ContainsJSON != null &&
                    this.ContainsJSON.Equals(input.ContainsJSON))
                ) && 
                (
                    this.ContainsXML == input.ContainsXML ||
                    (this.ContainsXML != null &&
                    this.ContainsXML.Equals(input.ContainsXML))
                ) && 
                (
                    this.ContainsImage == input.ContainsImage ||
                    (this.ContainsImage != null &&
                    this.ContainsImage.Equals(input.ContainsImage))
                ) && 
                (
                    this.RelevantSubfileName == input.RelevantSubfileName ||
                    (this.RelevantSubfileName != null &&
                    this.RelevantSubfileName.Equals(input.RelevantSubfileName))
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
                if (this.ContainsJSON != null)
                    hashCode = hashCode * 59 + this.ContainsJSON.GetHashCode();
                if (this.ContainsXML != null)
                    hashCode = hashCode * 59 + this.ContainsXML.GetHashCode();
                if (this.ContainsImage != null)
                    hashCode = hashCode * 59 + this.ContainsImage.GetHashCode();
                if (this.RelevantSubfileName != null)
                    hashCode = hashCode * 59 + this.RelevantSubfileName.GetHashCode();
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
