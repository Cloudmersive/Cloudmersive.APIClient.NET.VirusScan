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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Cloudmersive.APIClient.NET.VirusScan.Client;
using Cloudmersive.APIClient.NET.VirusScan.Api;
using Cloudmersive.APIClient.NET.VirusScan.Model;

namespace Cloudmersive.APIClient.NET.VirusScan.Test
{
    /// <summary>
    ///  Class for testing ScanCloudStorageApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ScanCloudStorageApiTests
    {
        private ScanCloudStorageApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ScanCloudStorageApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ScanCloudStorageApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ScanCloudStorageApi
            //Assert.IsInstanceOfType(typeof(ScanCloudStorageApi), instance, "instance is a ScanCloudStorageApi");
        }

        
        /// <summary>
        /// Test ScanCloudStorageScanAwsS3File
        /// </summary>
        [Test]
        public void ScanCloudStorageScanAwsS3FileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accessKey = null;
            //string secretKey = null;
            //string bucketRegion = null;
            //string bucketName = null;
            //string keyName = null;
            //var response = instance.ScanCloudStorageScanAwsS3File(accessKey, secretKey, bucketRegion, bucketName, keyName);
            //Assert.IsInstanceOf<CloudStorageVirusScanResult> (response, "response is CloudStorageVirusScanResult");
        }
        
        /// <summary>
        /// Test ScanCloudStorageScanAwsS3FileAdvanced
        /// </summary>
        [Test]
        public void ScanCloudStorageScanAwsS3FileAdvancedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accessKey = null;
            //string secretKey = null;
            //string bucketRegion = null;
            //string bucketName = null;
            //string keyName = null;
            //bool? allowExecutables = null;
            //bool? allowInvalidFiles = null;
            //bool? allowScripts = null;
            //bool? allowPasswordProtectedFiles = null;
            //bool? allowMacros = null;
            //bool? allowXmlExternalEntities = null;
            //bool? allowInsecureDeserialization = null;
            //bool? allowHtml = null;
            //string restrictFileTypes = null;
            //var response = instance.ScanCloudStorageScanAwsS3FileAdvanced(accessKey, secretKey, bucketRegion, bucketName, keyName, allowExecutables, allowInvalidFiles, allowScripts, allowPasswordProtectedFiles, allowMacros, allowXmlExternalEntities, allowInsecureDeserialization, allowHtml, restrictFileTypes);
            //Assert.IsInstanceOf<CloudStorageAdvancedVirusScanResult> (response, "response is CloudStorageAdvancedVirusScanResult");
        }
        
        /// <summary>
        /// Test ScanCloudStorageScanAzureBlob
        /// </summary>
        [Test]
        public void ScanCloudStorageScanAzureBlobTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string connectionString = null;
            //string containerName = null;
            //string blobPath = null;
            //var response = instance.ScanCloudStorageScanAzureBlob(connectionString, containerName, blobPath);
            //Assert.IsInstanceOf<CloudStorageVirusScanResult> (response, "response is CloudStorageVirusScanResult");
        }
        
        /// <summary>
        /// Test ScanCloudStorageScanAzureBlobAdvanced
        /// </summary>
        [Test]
        public void ScanCloudStorageScanAzureBlobAdvancedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string connectionString = null;
            //string containerName = null;
            //string blobPath = null;
            //bool? allowExecutables = null;
            //bool? allowInvalidFiles = null;
            //bool? allowScripts = null;
            //bool? allowPasswordProtectedFiles = null;
            //bool? allowMacros = null;
            //bool? allowXmlExternalEntities = null;
            //bool? allowInsecureDeserialization = null;
            //bool? allowHtml = null;
            //string restrictFileTypes = null;
            //var response = instance.ScanCloudStorageScanAzureBlobAdvanced(connectionString, containerName, blobPath, allowExecutables, allowInvalidFiles, allowScripts, allowPasswordProtectedFiles, allowMacros, allowXmlExternalEntities, allowInsecureDeserialization, allowHtml, restrictFileTypes);
            //Assert.IsInstanceOf<CloudStorageAdvancedVirusScanResult> (response, "response is CloudStorageAdvancedVirusScanResult");
        }
        
        /// <summary>
        /// Test ScanCloudStorageScanGcpStorageFile
        /// </summary>
        [Test]
        public void ScanCloudStorageScanGcpStorageFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string bucketName = null;
            //string objectName = null;
            //System.IO.Stream jsonCredentialFile = null;
            //var response = instance.ScanCloudStorageScanGcpStorageFile(bucketName, objectName, jsonCredentialFile);
            //Assert.IsInstanceOf<CloudStorageVirusScanResult> (response, "response is CloudStorageVirusScanResult");
        }
        
        /// <summary>
        /// Test ScanCloudStorageScanGcpStorageFileAdvanced
        /// </summary>
        [Test]
        public void ScanCloudStorageScanGcpStorageFileAdvancedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string bucketName = null;
            //string objectName = null;
            //System.IO.Stream jsonCredentialFile = null;
            //bool? allowExecutables = null;
            //bool? allowInvalidFiles = null;
            //bool? allowScripts = null;
            //bool? allowPasswordProtectedFiles = null;
            //bool? allowMacros = null;
            //bool? allowXmlExternalEntities = null;
            //bool? allowInsecureDeserialization = null;
            //bool? allowHtml = null;
            //string restrictFileTypes = null;
            //var response = instance.ScanCloudStorageScanGcpStorageFileAdvanced(bucketName, objectName, jsonCredentialFile, allowExecutables, allowInvalidFiles, allowScripts, allowPasswordProtectedFiles, allowMacros, allowXmlExternalEntities, allowInsecureDeserialization, allowHtml, restrictFileTypes);
            //Assert.IsInstanceOf<CloudStorageAdvancedVirusScanResult> (response, "response is CloudStorageAdvancedVirusScanResult");
        }
        
        /// <summary>
        /// Test ScanCloudStorageScanSharePointOnlineFile
        /// </summary>
        [Test]
        public void ScanCloudStorageScanSharePointOnlineFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientID = null;
            //string clientSecret = null;
            //string sharepointDomainName = null;
            //string siteID = null;
            //string filePath = null;
            //string tenantID = null;
            //string itemID = null;
            //var response = instance.ScanCloudStorageScanSharePointOnlineFile(clientID, clientSecret, sharepointDomainName, siteID, filePath, tenantID, itemID);
            //Assert.IsInstanceOf<CloudStorageVirusScanResult> (response, "response is CloudStorageVirusScanResult");
        }
        
        /// <summary>
        /// Test ScanCloudStorageScanSharePointOnlineFileAdvanced
        /// </summary>
        [Test]
        public void ScanCloudStorageScanSharePointOnlineFileAdvancedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientID = null;
            //string clientSecret = null;
            //string sharepointDomainName = null;
            //string siteID = null;
            //string tenantID = null;
            //string filePath = null;
            //string itemID = null;
            //bool? allowExecutables = null;
            //bool? allowInvalidFiles = null;
            //bool? allowScripts = null;
            //bool? allowPasswordProtectedFiles = null;
            //bool? allowMacros = null;
            //bool? allowXmlExternalEntities = null;
            //bool? allowInsecureDeserialization = null;
            //bool? allowHtml = null;
            //string restrictFileTypes = null;
            //var response = instance.ScanCloudStorageScanSharePointOnlineFileAdvanced(clientID, clientSecret, sharepointDomainName, siteID, tenantID, filePath, itemID, allowExecutables, allowInvalidFiles, allowScripts, allowPasswordProtectedFiles, allowMacros, allowXmlExternalEntities, allowInsecureDeserialization, allowHtml, restrictFileTypes);
            //Assert.IsInstanceOf<CloudStorageAdvancedVirusScanResult> (response, "response is CloudStorageAdvancedVirusScanResult");
        }
        
    }

}
