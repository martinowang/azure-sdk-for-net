// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Recovery plan A2A failover input.
    /// </summary>
    [Newtonsoft.Json.JsonObject("A2A")]
    public partial class RecoveryPlanA2AFailoverInput : RecoveryPlanProviderSpecificFailoverInput
    {
        /// <summary>
        /// Initializes a new instance of the RecoveryPlanA2AFailoverInput
        /// class.
        /// </summary>
        public RecoveryPlanA2AFailoverInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RecoveryPlanA2AFailoverInput
        /// class.
        /// </summary>
        /// <param name="recoveryPointType">The recovery point type. Possible
        /// values include: 'Latest', 'LatestApplicationConsistent',
        /// 'LatestCrashConsistent', 'LatestProcessed'</param>
        /// <param name="cloudServiceCreationOption">A value indicating whether
        /// to use recovery cloud service for TFO or not.</param>
        /// <param name="multiVmSyncPointOption">A value indicating whether
        /// multi VM sync enabled VMs should use multi VM sync points for
        /// failover. Possible values include: 'UseMultiVmSyncRecoveryPoint',
        /// 'UsePerVmRecoveryPoint'</param>
        public RecoveryPlanA2AFailoverInput(A2ARpRecoveryPointType recoveryPointType, string cloudServiceCreationOption = default(string), MultiVmSyncPointOption? multiVmSyncPointOption = default(MultiVmSyncPointOption?))
        {
            RecoveryPointType = recoveryPointType;
            CloudServiceCreationOption = cloudServiceCreationOption;
            MultiVmSyncPointOption = multiVmSyncPointOption;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the recovery point type. Possible values include:
        /// 'Latest', 'LatestApplicationConsistent', 'LatestCrashConsistent',
        /// 'LatestProcessed'
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointType")]
        public A2ARpRecoveryPointType RecoveryPointType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use recovery cloud
        /// service for TFO or not.
        /// </summary>
        [JsonProperty(PropertyName = "cloudServiceCreationOption")]
        public string CloudServiceCreationOption { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether multi VM sync enabled VMs
        /// should use multi VM sync points for failover. Possible values
        /// include: 'UseMultiVmSyncRecoveryPoint', 'UsePerVmRecoveryPoint'
        /// </summary>
        [JsonProperty(PropertyName = "multiVmSyncPointOption")]
        public MultiVmSyncPointOption? MultiVmSyncPointOption { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
