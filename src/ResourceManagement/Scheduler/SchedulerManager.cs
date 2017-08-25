﻿// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

using System;
using System.Linq;
using Microsoft.Azure.Management.ResourceManager.Fluent.Authentication;
using Microsoft.Azure.Management.ResourceManager.Fluent.Core;

namespace Microsoft.Azure.Management.Scheduler.Fluent
{
    public class SchedulerManager : Manager<ISchedulerManagementClient>, ISchedulerManager, IBeta
    {
        #region ctrs
        private SchedulerManager(RestClient restClient, string subscriptionId) :
            base(restClient, subscriptionId, new SchedulerManagementClient(new Uri(restClient.BaseUri),
                restClient.Credentials,
                restClient.RootHttpHandler,
                restClient.Handlers.ToArray())
            {
                SubscriptionId = subscriptionId
            })
        {
        }
        #endregion
        #region SchedulerManager builder
        /// <summary>
        /// Creates an instance of SchedulerManager that exposes storage resource management API entry points.
        /// </summary>
        /// <param name="credentials">the credentials to use</param>
        /// <param name="subscriptionId">the subscription UUID</param>
        /// <returns>the RelayManager</returns>
        public static ISchedulerManager Authenticate(AzureCredentials credentials, string subscriptionId)
        {
            return Authenticate(RestClient.Configure()
                    .WithEnvironment(credentials.Environment)
                    .WithCredentials(credentials)
                    .WithDelegatingHandler(new ProviderRegistrationDelegatingHandler(credentials))
                    .Build(), subscriptionId);
        }
        /// <summary>
        /// Creates an instance of SchedulerManager that exposes storage resource management API entry points.
        /// </summary>
        /// <param name="restClient">the RestClient to be used for API calls.</param>
        /// <param name="subscriptionId">the subscription UUID</param>
        /// <returns>the SchedulerManager</returns>
        public static ISchedulerManager Authenticate(RestClient restClient, string subscriptionId)
        {
            return new SchedulerManager(restClient, subscriptionId);
        }
        /// <summary>
        /// Get a Configurable instance that can be used to create SchedulerManager with optional configuration.
        /// </summary>
        /// <returns>the instance allowing configurations</returns>
        public static IConfigurable Configure()
        {
            return new Configurable();
        }
        #endregion
        #region IConfigurable and it's implementation
        /// <summary>
        /// The inteface allowing configurations to be set.
        /// </summary>
        public interface IConfigurable : IAzureConfigurable<IConfigurable>
        {
            ISchedulerManager Authenticate(AzureCredentials credentials, string subscriptionId);
        }
        protected class Configurable :
            AzureConfigurable<IConfigurable>,
            IConfigurable
        {
            /// <summary>
            /// Creates an instance of RelayManager that exposes Scheduler management API entry points.
            /// </summary>
            /// <param name="credentials">credentials the credentials to use</param>
            /// <param name="subscriptionId">The subscription UUID</param>
            /// <returns>the interface exposing Scheduler management API entry points that work in a subscription</returns>
            public ISchedulerManager Authenticate(AzureCredentials credentials, string subscriptionId)
            {
                return new SchedulerManager(BuildRestClient(credentials), subscriptionId);
            }
        }
        #endregion
    }
    /// <summary>
    /// Entry point to Azure Scheduler resource management.
    /// </summary>
    public interface ISchedulerManager : IManager<ISchedulerManagementClient>
    {
    }
}