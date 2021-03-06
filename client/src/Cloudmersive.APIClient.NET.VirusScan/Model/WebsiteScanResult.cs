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
    /// Result of running a website scan
    /// </summary>
    [DataContract]
    public partial class WebsiteScanResult :  IEquatable<WebsiteScanResult>, IValidatableObject
    {
        /// <summary>
        /// Type of threat returned; can be None, Malware, ForcedDownload or Phishing
        /// </summary>
        /// <value>Type of threat returned; can be None, Malware, ForcedDownload or Phishing</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum WebsiteThreatTypeEnum
        {
            
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,
            
            /// <summary>
            /// Enum Malware for value: Malware
            /// </summary>
            [EnumMember(Value = "Malware")]
            Malware = 2,
            
            /// <summary>
            /// Enum Phishing for value: Phishing
            /// </summary>
            [EnumMember(Value = "Phishing")]
            Phishing = 3,
            
            /// <summary>
            /// Enum ForcedDownload for value: ForcedDownload
            /// </summary>
            [EnumMember(Value = "ForcedDownload")]
            ForcedDownload = 4,
            
            /// <summary>
            /// Enum UnableToConnect for value: UnableToConnect
            /// </summary>
            [EnumMember(Value = "UnableToConnect")]
            UnableToConnect = 5
        }

        /// <summary>
        /// Type of threat returned; can be None, Malware, ForcedDownload or Phishing
        /// </summary>
        /// <value>Type of threat returned; can be None, Malware, ForcedDownload or Phishing</value>
        [DataMember(Name="WebsiteThreatType", EmitDefaultValue=false)]
        public WebsiteThreatTypeEnum? WebsiteThreatType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsiteScanResult" /> class.
        /// </summary>
        /// <param name="cleanResult">True if the scan contained no threats, false otherwise.</param>
        /// <param name="websiteThreatType">Type of threat returned; can be None, Malware, ForcedDownload or Phishing.</param>
        /// <param name="foundViruses">Array of viruses found, if any.</param>
        /// <param name="websiteHttpResponseCode">The remote server URL HTTP reasponse code; useful for debugging issues with scanning; typically if the remote server returns a 200 or 300-series code this means a successful response, while a 400 or 500 series code would represent an error returned from the remote server for the provided URL..</param>
        public WebsiteScanResult(bool? cleanResult = default(bool?), WebsiteThreatTypeEnum? websiteThreatType = default(WebsiteThreatTypeEnum?), List<VirusFound> foundViruses = default(List<VirusFound>), int? websiteHttpResponseCode = default(int?))
        {
            this.CleanResult = cleanResult;
            this.WebsiteThreatType = websiteThreatType;
            this.FoundViruses = foundViruses;
            this.WebsiteHttpResponseCode = websiteHttpResponseCode;
        }
        
        /// <summary>
        /// True if the scan contained no threats, false otherwise
        /// </summary>
        /// <value>True if the scan contained no threats, false otherwise</value>
        [DataMember(Name="CleanResult", EmitDefaultValue=false)]
        public bool? CleanResult { get; set; }


        /// <summary>
        /// Array of viruses found, if any
        /// </summary>
        /// <value>Array of viruses found, if any</value>
        [DataMember(Name="FoundViruses", EmitDefaultValue=false)]
        public List<VirusFound> FoundViruses { get; set; }

        /// <summary>
        /// The remote server URL HTTP reasponse code; useful for debugging issues with scanning; typically if the remote server returns a 200 or 300-series code this means a successful response, while a 400 or 500 series code would represent an error returned from the remote server for the provided URL.
        /// </summary>
        /// <value>The remote server URL HTTP reasponse code; useful for debugging issues with scanning; typically if the remote server returns a 200 or 300-series code this means a successful response, while a 400 or 500 series code would represent an error returned from the remote server for the provided URL.</value>
        [DataMember(Name="WebsiteHttpResponseCode", EmitDefaultValue=false)]
        public int? WebsiteHttpResponseCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebsiteScanResult {\n");
            sb.Append("  CleanResult: ").Append(CleanResult).Append("\n");
            sb.Append("  WebsiteThreatType: ").Append(WebsiteThreatType).Append("\n");
            sb.Append("  FoundViruses: ").Append(FoundViruses).Append("\n");
            sb.Append("  WebsiteHttpResponseCode: ").Append(WebsiteHttpResponseCode).Append("\n");
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
            return this.Equals(input as WebsiteScanResult);
        }

        /// <summary>
        /// Returns true if WebsiteScanResult instances are equal
        /// </summary>
        /// <param name="input">Instance of WebsiteScanResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebsiteScanResult input)
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
                    this.WebsiteThreatType == input.WebsiteThreatType ||
                    (this.WebsiteThreatType != null &&
                    this.WebsiteThreatType.Equals(input.WebsiteThreatType))
                ) && 
                (
                    this.FoundViruses == input.FoundViruses ||
                    this.FoundViruses != null &&
                    this.FoundViruses.SequenceEqual(input.FoundViruses)
                ) && 
                (
                    this.WebsiteHttpResponseCode == input.WebsiteHttpResponseCode ||
                    (this.WebsiteHttpResponseCode != null &&
                    this.WebsiteHttpResponseCode.Equals(input.WebsiteHttpResponseCode))
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
                if (this.WebsiteThreatType != null)
                    hashCode = hashCode * 59 + this.WebsiteThreatType.GetHashCode();
                if (this.FoundViruses != null)
                    hashCode = hashCode * 59 + this.FoundViruses.GetHashCode();
                if (this.WebsiteHttpResponseCode != null)
                    hashCode = hashCode * 59 + this.WebsiteHttpResponseCode.GetHashCode();
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
