﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// ------------------------------------------------------------

using Microsoft.OpenApi.Commons;

namespace Microsoft.OpenApi.Models
{
    public enum ReferenceType
    {
        /// <summary>
        /// Unknown.
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Schema item.
        /// </summary>
        [Display("schemas")]
        Schema,

        /// <summary>
        /// Responses item.
        /// </summary>
        [Display("responses")]
        Response,

        /// <summary>
        /// Parameters item.
        /// </summary>
        [Display("parameters")]
        Parameter,

        /// <summary>
        /// Examples item.
        /// </summary>
        [Display("examples")]
        Example,

        /// <summary>
        /// RequestBodies item.
        /// </summary>
        [Display("requestBodies")]
        RequestBody,

        /// <summary>
        /// Headers item.
        /// </summary>
        [Display("headers")]
        Header,

        /// <summary>
        /// SecuritySchemes item.
        /// </summary>
        [Display("securitySchemes")]
        SecurityScheme,

        /// <summary>
        /// Links item.
        /// </summary>
        [Display("links")]
        Link,

        /// <summary>
        /// Callbacks item.
        /// </summary>
        [Display("callbacks")]
        Callback,

        /// <summary>
        /// Tags item.
        /// </summary>
        [Display("tags")]
        Tags
    }
}
