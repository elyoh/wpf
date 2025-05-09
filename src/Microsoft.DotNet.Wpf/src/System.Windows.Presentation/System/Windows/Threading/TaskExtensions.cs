// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Threading.Tasks;

namespace System.Windows.Threading
{
    public static class TaskExtensions
    {
        /// <summary>
        ///     Returns whether or not the Task is the representation of a DispatcherOperation.
        /// </summary>
        public static bool IsDispatcherOperationTask(this Task @this)
        {
            return @this.AsyncState is DispatcherOperationTaskMapping;
        }
        
        /// <summary>
        ///     Waits for the underlying DispatcherOperation to complete.
        /// </summary>
        public static DispatcherOperationStatus DispatcherOperationWait(this Task @this)
        {
            return DispatcherOperationWait(@this, TimeSpan.FromMilliseconds(-1));
        }

        /// <summary>
        ///     Waits for the underlying DispatcherOperation to complete.
        /// </summary>
        public static DispatcherOperationStatus DispatcherOperationWait(this Task @this, TimeSpan timeout)
        {
            var mapping = @this.AsyncState as DispatcherOperationTaskMapping;
            if(mapping != null)
            {
                // This task did come from a DispatcherOperation.
                return mapping.Operation.Wait(timeout);
            }
            else
            {
                // This task did not come from a DispatcherOperation.
                throw new NotSupportedException();
            }
        }
    }
}

