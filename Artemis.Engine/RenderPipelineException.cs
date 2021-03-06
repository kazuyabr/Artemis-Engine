﻿#region Using Statements

using System;
using System.Runtime.Serialization;

#endregion

namespace Artemis.Engine
{
    /// <summary>
    /// An exception thrown when something goes wrong in the RenderPipeline.
    /// </summary>
    [Serializable]
    public class RenderPipelineException : Exception
    {
        public RenderPipelineException() { }
        public RenderPipelineException(string message) : base(message) { }
        public RenderPipelineException(string message, Exception inner) : base(message, inner) { }
        public RenderPipelineException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
