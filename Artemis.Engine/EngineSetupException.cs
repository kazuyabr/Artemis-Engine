﻿#region Using Statements

using System;
using System.Runtime.Serialization;

#endregion

namespace Artemis.Engine
{
    /// <summary>
    /// An exception thrown when something goes wrong in the engine setup.
    /// </summary>
    [Serializable]
    public class EngineSetupException : Exception
    {
        public EngineSetupException() : base() { }
        public EngineSetupException(string msg) : base(msg) { }
        public EngineSetupException(string msg, Exception inner) : base(msg, inner) { }
        public EngineSetupException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
