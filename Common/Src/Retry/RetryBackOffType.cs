/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

﻿namespace Oci.Common.Retry
{
    public class RetryBackOffType
    {
        private RetryBackOffType(string value)
        {
            Value = value;
        }

        public string Value { get; set; }

        public static RetryBackOffType BackoffFullJitterValue { get => new RetryBackOffType("full_jitter"); }

        public static RetryBackOffType BackoffEqualJitterValue { get => new RetryBackOffType("equal_jitter"); }

        public static RetryBackOffType BackoffFullJitterEqualOnThrottleValue { get => new RetryBackOffType("full_jitter_with_equal_on_throttle"); }

    }
}
