// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Redis.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Details of single instance of redis.
    /// </summary>
    public partial class RedisInstanceDetails
    {
        /// <summary>
        /// Initializes a new instance of the RedisInstanceDetails class.
        /// </summary>
        public RedisInstanceDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RedisInstanceDetails class.
        /// </summary>
        /// <param name="sslPort">Redis instance SSL port.</param>
        /// <param name="nonSslPort">If enableNonSslPort is true, provides
        /// Redis instance Non-SSL port.</param>
        /// <param name="zone">If the Cache uses availability zones, specifies
        /// availability zone where this instance is located.</param>
        /// <param name="shardId">If clustering is enabled, the Shard ID of
        /// Redis Instance</param>
        public RedisInstanceDetails(int? sslPort = default(int?), int? nonSslPort = default(int?), string zone = default(string), int? shardId = default(int?))
        {
            SslPort = sslPort;
            NonSslPort = nonSslPort;
            Zone = zone;
            ShardId = shardId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets redis instance SSL port.
        /// </summary>
        [JsonProperty(PropertyName = "sslPort")]
        public int? SslPort { get; private set; }

        /// <summary>
        /// Gets if enableNonSslPort is true, provides Redis instance Non-SSL
        /// port.
        /// </summary>
        [JsonProperty(PropertyName = "nonSslPort")]
        public int? NonSslPort { get; private set; }

        /// <summary>
        /// Gets if the Cache uses availability zones, specifies availability
        /// zone where this instance is located.
        /// </summary>
        [JsonProperty(PropertyName = "zone")]
        public string Zone { get; private set; }

        /// <summary>
        /// Gets if clustering is enabled, the Shard ID of Redis Instance
        /// </summary>
        [JsonProperty(PropertyName = "shardId")]
        public int? ShardId { get; private set; }

    }
}
