// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Software update configuration machine run model.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SoftwareUpdateConfigurationMachineRun
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SoftwareUpdateConfigurationMachineRun class.
        /// </summary>
        public SoftwareUpdateConfigurationMachineRun()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SoftwareUpdateConfigurationMachineRun class.
        /// </summary>
        /// <param name="name">Name of the software update configuration
        /// machine run</param>
        /// <param name="id">Resource Id of the software update configuration
        /// machine run</param>
        /// <param name="targetComputer">name of the updated computer</param>
        /// <param name="targetComputerType">type of the updated
        /// computer.</param>
        /// <param name="softwareUpdateConfiguration">software update
        /// configuration triggered this run</param>
        /// <param name="status">Status of the software update configuration
        /// machine run.</param>
        /// <param name="osType">Operating system target of the software update
        /// configuration triggered this run</param>
        /// <param name="correlationId">correlation id of the software update
        /// configuration machine run</param>
        /// <param name="sourceComputerId">source computer id of the software
        /// update configuration machine run</param>
        /// <param name="startTime">Start time of the software update
        /// configuration machine run.</param>
        /// <param name="endTime">End time of the software update configuration
        /// machine run.</param>
        /// <param name="configuredDuration">configured duration for the
        /// software update configuration run.</param>
        /// <param name="job">Job associated with the software update
        /// configuration machine run</param>
        /// <param name="creationTime">Creation time of theresource, which only
        /// appears in the response.</param>
        /// <param name="createdBy">createdBy property, which only appears in
        /// the response.</param>
        /// <param name="lastModifiedTime">Last time resource was modified,
        /// which only appears in the response.</param>
        /// <param name="lastModifiedBy">lastModifiedBy property, which only
        /// appears in the response.</param>
        public SoftwareUpdateConfigurationMachineRun(string name = default(string), string id = default(string), string targetComputer = default(string), string targetComputerType = default(string), UpdateConfigurationNavigation softwareUpdateConfiguration = default(UpdateConfigurationNavigation), string status = default(string), string osType = default(string), System.Guid? correlationId = default(System.Guid?), System.Guid? sourceComputerId = default(System.Guid?), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), string configuredDuration = default(string), JobNavigation job = default(JobNavigation), System.DateTime? creationTime = default(System.DateTime?), string createdBy = default(string), System.DateTime? lastModifiedTime = default(System.DateTime?), string lastModifiedBy = default(string))
        {
            Name = name;
            Id = id;
            TargetComputer = targetComputer;
            TargetComputerType = targetComputerType;
            SoftwareUpdateConfiguration = softwareUpdateConfiguration;
            Status = status;
            OsType = osType;
            CorrelationId = correlationId;
            SourceComputerId = sourceComputerId;
            StartTime = startTime;
            EndTime = endTime;
            ConfiguredDuration = configuredDuration;
            Job = job;
            CreationTime = creationTime;
            CreatedBy = createdBy;
            LastModifiedTime = lastModifiedTime;
            LastModifiedBy = lastModifiedBy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets name of the software update configuration machine run
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets resource Id of the software update configuration machine run
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets name of the updated computer
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetComputer")]
        public string TargetComputer { get; private set; }

        /// <summary>
        /// Gets type of the updated computer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetComputerType")]
        public string TargetComputerType { get; private set; }

        /// <summary>
        /// Gets or sets software update configuration triggered this run
        /// </summary>
        [JsonProperty(PropertyName = "properties.softwareUpdateConfiguration")]
        public UpdateConfigurationNavigation SoftwareUpdateConfiguration { get; set; }

        /// <summary>
        /// Gets status of the software update configuration machine run.
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets operating system target of the software update configuration
        /// triggered this run
        /// </summary>
        [JsonProperty(PropertyName = "properties.osType")]
        public string OsType { get; private set; }

        /// <summary>
        /// Gets correlation id of the software update configuration machine
        /// run
        /// </summary>
        [JsonProperty(PropertyName = "properties.correlationId")]
        public System.Guid? CorrelationId { get; private set; }

        /// <summary>
        /// Gets source computer id of the software update configuration
        /// machine run
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourceComputerId")]
        public System.Guid? SourceComputerId { get; private set; }

        /// <summary>
        /// Gets start time of the software update configuration machine run.
        /// </summary>
        [JsonProperty(PropertyName = "properties.startTime")]
        public System.DateTime? StartTime { get; private set; }

        /// <summary>
        /// Gets end time of the software update configuration machine run.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endTime")]
        public System.DateTime? EndTime { get; private set; }

        /// <summary>
        /// Gets configured duration for the software update configuration run.
        /// </summary>
        [JsonProperty(PropertyName = "properties.configuredDuration")]
        public string ConfiguredDuration { get; private set; }

        /// <summary>
        /// Gets or sets job associated with the software update configuration
        /// machine run
        /// </summary>
        [JsonProperty(PropertyName = "properties.job")]
        public JobNavigation Job { get; set; }

        /// <summary>
        /// Gets creation time of theresource, which only appears in the
        /// response.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationTime")]
        public System.DateTime? CreationTime { get; private set; }

        /// <summary>
        /// Gets createdBy property, which only appears in the response.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdBy")]
        public string CreatedBy { get; private set; }

        /// <summary>
        /// Gets last time resource was modified, which only appears in the
        /// response.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedTime")]
        public System.DateTime? LastModifiedTime { get; private set; }

        /// <summary>
        /// Gets lastModifiedBy property, which only appears in the response.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedBy")]
        public string LastModifiedBy { get; private set; }

    }
}
