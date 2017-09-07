// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An error encountered by the Batch service when scheduling a job.
    /// </summary>
    public partial class JobSchedulingError : IPropertyMetadata
    {
        private readonly Common.ErrorCategory category;
        private readonly string code;
        private readonly IReadOnlyList<NameValuePair> details;
        private readonly string message;

        #region Constructors

        internal JobSchedulingError(Models.JobSchedulingError protocolObject)
        {
            this.category = UtilitiesInternal.MapEnum<Models.ErrorCategory, Common.ErrorCategory>(protocolObject.Category);
            this.code = protocolObject.Code;
            this.details = NameValuePair.ConvertFromProtocolCollectionReadOnly(protocolObject.Details);
            this.message = protocolObject.Message;
        }

        #endregion Constructors

        #region JobSchedulingError

        /// <summary>
        /// Gets the category of the job scheduling error.
        /// </summary>
        public Common.ErrorCategory Category
        {
            get { return this.category; }
        }

        /// <summary>
        /// Gets a code for the job scheduling error. See <see cref="Common.JobSchedulingErrorCodes"/> for possible values.
        /// </summary>
        public string Code
        {
            get { return this.code; }
        }

        /// <summary>
        /// Gets a list of additional error details related to the scheduling error.
        /// </summary>
        public IReadOnlyList<NameValuePair> Details
        {
            get { return this.details; }
        }

        /// <summary>
        /// Gets a message describing the job scheduling error, intended to be suitable for display in a user interface.
        /// </summary>
        public string Message
        {
            get { return this.message; }
        }

        #endregion // JobSchedulingError

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata
    }
}