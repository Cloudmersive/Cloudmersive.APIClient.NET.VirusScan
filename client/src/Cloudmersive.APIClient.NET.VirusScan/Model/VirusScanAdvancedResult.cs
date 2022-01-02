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
    /// Result of running an advanced virus scan
    /// </summary>
    [DataContract]
    public partial class VirusScanAdvancedResult :  IEquatable<VirusScanAdvancedResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VirusScanAdvancedResult" /> class.
        /// </summary>
        /// <param name="cleanResult">True if the scan contained no viruses, false otherwise.</param>
        /// <param name="containsExecutable">True if the scan contained an executable (application code), which can be a significant risk factor.</param>
        /// <param name="containsInvalidFile">True if the scan contained an invalid file (such as a PDF that is not a valid PDF, Word Document that is not a valid Word Document, etc.), which can be a significant risk factor.</param>
        /// <param name="containsScript">True if the scan contained a script (such as a PHP script, Python script, etc.) which can be a significant risk factor.</param>
        /// <param name="containsPasswordProtectedFile">True if the scan contained a password protected or encrypted file, which can be a significant risk factor.</param>
        /// <param name="containsRestrictedFileFormat">True if the uploaded file is of a type that is not allowed based on the optional restrictFileTypes parameter, false otherwise; if restrictFileTypes is not set, this will always be false.</param>
        /// <param name="containsMacros">True if the uploaded file contains embedded Macros of other embedded threats within the document, which can be a significant risk factor.</param>
        /// <param name="containsXmlExternalEntities">True if the uploaded file contains embedded XML External Entity threats of other embedded threats within the document, which can be a significant risk factor.</param>
        /// <param name="containsInsecureDeserialization">True if the uploaded file contains embedded Insecure Deserialization threats of other embedded threats within the document, which can be a significant risk factor.</param>
        /// <param name="containsHtml">True if the uploaded file contains HTML, which can be a significant risk factor.</param>
        /// <param name="verifiedFileFormat">For file format verification-supported file formats, the contents-verified file format of the file.  Null indicates that the file format is not supported for contents verification.  If a Virus or Malware is found, this field will always be set to Null..</param>
        /// <param name="foundViruses">Array of viruses found, if any.</param>
        /// <param name="contentInformation">Contains additional non-threat content verification information.</param>
        public VirusScanAdvancedResult(bool? cleanResult = default(bool?), bool? containsExecutable = default(bool?), bool? containsInvalidFile = default(bool?), bool? containsScript = default(bool?), bool? containsPasswordProtectedFile = default(bool?), bool? containsRestrictedFileFormat = default(bool?), bool? containsMacros = default(bool?), bool? containsXmlExternalEntities = default(bool?), bool? containsInsecureDeserialization = default(bool?), bool? containsHtml = default(bool?), string verifiedFileFormat = default(string), List<VirusFound> foundViruses = default(List<VirusFound>), AdditionalAdvancedScanInformation contentInformation = default(AdditionalAdvancedScanInformation))
        {
            this.CleanResult = cleanResult;
            this.ContainsExecutable = containsExecutable;
            this.ContainsInvalidFile = containsInvalidFile;
            this.ContainsScript = containsScript;
            this.ContainsPasswordProtectedFile = containsPasswordProtectedFile;
            this.ContainsRestrictedFileFormat = containsRestrictedFileFormat;
            this.ContainsMacros = containsMacros;
            this.ContainsXmlExternalEntities = containsXmlExternalEntities;
            this.ContainsInsecureDeserialization = containsInsecureDeserialization;
            this.ContainsHtml = containsHtml;
            this.VerifiedFileFormat = verifiedFileFormat;
            this.FoundViruses = foundViruses;
            this.ContentInformation = contentInformation;
        }
        
        /// <summary>
        /// True if the scan contained no viruses, false otherwise
        /// </summary>
        /// <value>True if the scan contained no viruses, false otherwise</value>
        [DataMember(Name="CleanResult", EmitDefaultValue=false)]
        public bool? CleanResult { get; set; }

        /// <summary>
        /// True if the scan contained an executable (application code), which can be a significant risk factor
        /// </summary>
        /// <value>True if the scan contained an executable (application code), which can be a significant risk factor</value>
        [DataMember(Name="ContainsExecutable", EmitDefaultValue=false)]
        public bool? ContainsExecutable { get; set; }

        /// <summary>
        /// True if the scan contained an invalid file (such as a PDF that is not a valid PDF, Word Document that is not a valid Word Document, etc.), which can be a significant risk factor
        /// </summary>
        /// <value>True if the scan contained an invalid file (such as a PDF that is not a valid PDF, Word Document that is not a valid Word Document, etc.), which can be a significant risk factor</value>
        [DataMember(Name="ContainsInvalidFile", EmitDefaultValue=false)]
        public bool? ContainsInvalidFile { get; set; }

        /// <summary>
        /// True if the scan contained a script (such as a PHP script, Python script, etc.) which can be a significant risk factor
        /// </summary>
        /// <value>True if the scan contained a script (such as a PHP script, Python script, etc.) which can be a significant risk factor</value>
        [DataMember(Name="ContainsScript", EmitDefaultValue=false)]
        public bool? ContainsScript { get; set; }

        /// <summary>
        /// True if the scan contained a password protected or encrypted file, which can be a significant risk factor
        /// </summary>
        /// <value>True if the scan contained a password protected or encrypted file, which can be a significant risk factor</value>
        [DataMember(Name="ContainsPasswordProtectedFile", EmitDefaultValue=false)]
        public bool? ContainsPasswordProtectedFile { get; set; }

        /// <summary>
        /// True if the uploaded file is of a type that is not allowed based on the optional restrictFileTypes parameter, false otherwise; if restrictFileTypes is not set, this will always be false
        /// </summary>
        /// <value>True if the uploaded file is of a type that is not allowed based on the optional restrictFileTypes parameter, false otherwise; if restrictFileTypes is not set, this will always be false</value>
        [DataMember(Name="ContainsRestrictedFileFormat", EmitDefaultValue=false)]
        public bool? ContainsRestrictedFileFormat { get; set; }

        /// <summary>
        /// True if the uploaded file contains embedded Macros of other embedded threats within the document, which can be a significant risk factor
        /// </summary>
        /// <value>True if the uploaded file contains embedded Macros of other embedded threats within the document, which can be a significant risk factor</value>
        [DataMember(Name="ContainsMacros", EmitDefaultValue=false)]
        public bool? ContainsMacros { get; set; }

        /// <summary>
        /// True if the uploaded file contains embedded XML External Entity threats of other embedded threats within the document, which can be a significant risk factor
        /// </summary>
        /// <value>True if the uploaded file contains embedded XML External Entity threats of other embedded threats within the document, which can be a significant risk factor</value>
        [DataMember(Name="ContainsXmlExternalEntities", EmitDefaultValue=false)]
        public bool? ContainsXmlExternalEntities { get; set; }

        /// <summary>
        /// True if the uploaded file contains embedded Insecure Deserialization threats of other embedded threats within the document, which can be a significant risk factor
        /// </summary>
        /// <value>True if the uploaded file contains embedded Insecure Deserialization threats of other embedded threats within the document, which can be a significant risk factor</value>
        [DataMember(Name="ContainsInsecureDeserialization", EmitDefaultValue=false)]
        public bool? ContainsInsecureDeserialization { get; set; }

        /// <summary>
        /// True if the uploaded file contains HTML, which can be a significant risk factor
        /// </summary>
        /// <value>True if the uploaded file contains HTML, which can be a significant risk factor</value>
        [DataMember(Name="ContainsHtml", EmitDefaultValue=false)]
        public bool? ContainsHtml { get; set; }

        /// <summary>
        /// For file format verification-supported file formats, the contents-verified file format of the file.  Null indicates that the file format is not supported for contents verification.  If a Virus or Malware is found, this field will always be set to Null.
        /// </summary>
        /// <value>For file format verification-supported file formats, the contents-verified file format of the file.  Null indicates that the file format is not supported for contents verification.  If a Virus or Malware is found, this field will always be set to Null.</value>
        [DataMember(Name="VerifiedFileFormat", EmitDefaultValue=false)]
        public string VerifiedFileFormat { get; set; }

        /// <summary>
        /// Array of viruses found, if any
        /// </summary>
        /// <value>Array of viruses found, if any</value>
        [DataMember(Name="FoundViruses", EmitDefaultValue=false)]
        public List<VirusFound> FoundViruses { get; set; }

        /// <summary>
        /// Contains additional non-threat content verification information
        /// </summary>
        /// <value>Contains additional non-threat content verification information</value>
        [DataMember(Name="ContentInformation", EmitDefaultValue=false)]
        public AdditionalAdvancedScanInformation ContentInformation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VirusScanAdvancedResult {\n");
            sb.Append("  CleanResult: ").Append(CleanResult).Append("\n");
            sb.Append("  ContainsExecutable: ").Append(ContainsExecutable).Append("\n");
            sb.Append("  ContainsInvalidFile: ").Append(ContainsInvalidFile).Append("\n");
            sb.Append("  ContainsScript: ").Append(ContainsScript).Append("\n");
            sb.Append("  ContainsPasswordProtectedFile: ").Append(ContainsPasswordProtectedFile).Append("\n");
            sb.Append("  ContainsRestrictedFileFormat: ").Append(ContainsRestrictedFileFormat).Append("\n");
            sb.Append("  ContainsMacros: ").Append(ContainsMacros).Append("\n");
            sb.Append("  ContainsXmlExternalEntities: ").Append(ContainsXmlExternalEntities).Append("\n");
            sb.Append("  ContainsInsecureDeserialization: ").Append(ContainsInsecureDeserialization).Append("\n");
            sb.Append("  ContainsHtml: ").Append(ContainsHtml).Append("\n");
            sb.Append("  VerifiedFileFormat: ").Append(VerifiedFileFormat).Append("\n");
            sb.Append("  FoundViruses: ").Append(FoundViruses).Append("\n");
            sb.Append("  ContentInformation: ").Append(ContentInformation).Append("\n");
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
            return this.Equals(input as VirusScanAdvancedResult);
        }

        /// <summary>
        /// Returns true if VirusScanAdvancedResult instances are equal
        /// </summary>
        /// <param name="input">Instance of VirusScanAdvancedResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VirusScanAdvancedResult input)
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
                    this.ContainsExecutable == input.ContainsExecutable ||
                    (this.ContainsExecutable != null &&
                    this.ContainsExecutable.Equals(input.ContainsExecutable))
                ) && 
                (
                    this.ContainsInvalidFile == input.ContainsInvalidFile ||
                    (this.ContainsInvalidFile != null &&
                    this.ContainsInvalidFile.Equals(input.ContainsInvalidFile))
                ) && 
                (
                    this.ContainsScript == input.ContainsScript ||
                    (this.ContainsScript != null &&
                    this.ContainsScript.Equals(input.ContainsScript))
                ) && 
                (
                    this.ContainsPasswordProtectedFile == input.ContainsPasswordProtectedFile ||
                    (this.ContainsPasswordProtectedFile != null &&
                    this.ContainsPasswordProtectedFile.Equals(input.ContainsPasswordProtectedFile))
                ) && 
                (
                    this.ContainsRestrictedFileFormat == input.ContainsRestrictedFileFormat ||
                    (this.ContainsRestrictedFileFormat != null &&
                    this.ContainsRestrictedFileFormat.Equals(input.ContainsRestrictedFileFormat))
                ) && 
                (
                    this.ContainsMacros == input.ContainsMacros ||
                    (this.ContainsMacros != null &&
                    this.ContainsMacros.Equals(input.ContainsMacros))
                ) && 
                (
                    this.ContainsXmlExternalEntities == input.ContainsXmlExternalEntities ||
                    (this.ContainsXmlExternalEntities != null &&
                    this.ContainsXmlExternalEntities.Equals(input.ContainsXmlExternalEntities))
                ) && 
                (
                    this.ContainsInsecureDeserialization == input.ContainsInsecureDeserialization ||
                    (this.ContainsInsecureDeserialization != null &&
                    this.ContainsInsecureDeserialization.Equals(input.ContainsInsecureDeserialization))
                ) && 
                (
                    this.ContainsHtml == input.ContainsHtml ||
                    (this.ContainsHtml != null &&
                    this.ContainsHtml.Equals(input.ContainsHtml))
                ) && 
                (
                    this.VerifiedFileFormat == input.VerifiedFileFormat ||
                    (this.VerifiedFileFormat != null &&
                    this.VerifiedFileFormat.Equals(input.VerifiedFileFormat))
                ) && 
                (
                    this.FoundViruses == input.FoundViruses ||
                    this.FoundViruses != null &&
                    this.FoundViruses.SequenceEqual(input.FoundViruses)
                ) && 
                (
                    this.ContentInformation == input.ContentInformation ||
                    (this.ContentInformation != null &&
                    this.ContentInformation.Equals(input.ContentInformation))
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
                if (this.ContainsExecutable != null)
                    hashCode = hashCode * 59 + this.ContainsExecutable.GetHashCode();
                if (this.ContainsInvalidFile != null)
                    hashCode = hashCode * 59 + this.ContainsInvalidFile.GetHashCode();
                if (this.ContainsScript != null)
                    hashCode = hashCode * 59 + this.ContainsScript.GetHashCode();
                if (this.ContainsPasswordProtectedFile != null)
                    hashCode = hashCode * 59 + this.ContainsPasswordProtectedFile.GetHashCode();
                if (this.ContainsRestrictedFileFormat != null)
                    hashCode = hashCode * 59 + this.ContainsRestrictedFileFormat.GetHashCode();
                if (this.ContainsMacros != null)
                    hashCode = hashCode * 59 + this.ContainsMacros.GetHashCode();
                if (this.ContainsXmlExternalEntities != null)
                    hashCode = hashCode * 59 + this.ContainsXmlExternalEntities.GetHashCode();
                if (this.ContainsInsecureDeserialization != null)
                    hashCode = hashCode * 59 + this.ContainsInsecureDeserialization.GetHashCode();
                if (this.ContainsHtml != null)
                    hashCode = hashCode * 59 + this.ContainsHtml.GetHashCode();
                if (this.VerifiedFileFormat != null)
                    hashCode = hashCode * 59 + this.VerifiedFileFormat.GetHashCode();
                if (this.FoundViruses != null)
                    hashCode = hashCode * 59 + this.FoundViruses.GetHashCode();
                if (this.ContentInformation != null)
                    hashCode = hashCode * 59 + this.ContentInformation.GetHashCode();
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
