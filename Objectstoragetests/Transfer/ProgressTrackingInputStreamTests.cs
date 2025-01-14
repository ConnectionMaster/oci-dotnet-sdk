/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using Oci.Common;
using Xunit;

namespace Oci.ObjectstorageService.Transfer
{
    [ExcludeFromCodeCoverage]
    public class ProgressTrackingInputStreamTests : BaseTest
    {
        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void Verify()
        {
            var stream = StreamChunkCreatorTests.GenerateStreamFromString("aaaaaaaaaaaaaaa");
            var tracker = new ProgressTracker(OnProgress, stream.Length);
            var progressStream = new ProgressTrackingInputStream(stream, tracker);

            for(int i = 1; i <= 3; i++)
            {
                // read chunks of 5 bytes.
                progressStream.Read(new byte[5], 0, 5);
                Assert.Equal(5 * i, bytesReadReported);
            }

            progressStream.Position = 0;
            progressStream.Read(new byte[5], 0, 5);
            Assert.Equal(5 , bytesReadReported);
        }

        private void OnProgress(long bytesRead, long totalBytes)
        {
            bytesReadReported = bytesRead;
        }

        private long bytesReadReported = 0;
    }
}
