// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support
{

    public partial struct DeploymentResourceStatus :
        System.IEquatable<DeploymentResourceStatus>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.DeploymentResourceStatus Allocating = @"Allocating";

        public static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.DeploymentResourceStatus Compiling = @"Compiling";

        public static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.DeploymentResourceStatus Failed = @"Failed";

        public static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.DeploymentResourceStatus Running = @"Running";

        public static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.DeploymentResourceStatus Stopped = @"Stopped";

        public static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.DeploymentResourceStatus Unknown = @"Unknown";

        public static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.DeploymentResourceStatus Upgrading = @"Upgrading";

        /// <summary>the value for an instance of the <see cref="DeploymentResourceStatus" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to DeploymentResourceStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DeploymentResourceStatus" />.</param>
        internal static object CreateFrom(object value)
        {
            return new DeploymentResourceStatus(System.Convert.ToString(value));
        }

        /// <summary>Creates an instance of the <see cref="DeploymentResourceStatus" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private DeploymentResourceStatus(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Compares values of enum type DeploymentResourceStatus</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.DeploymentResourceStatus e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type DeploymentResourceStatus (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is DeploymentResourceStatus && Equals((DeploymentResourceStatus)obj);
        }

        /// <summary>Returns hashCode for enum DeploymentResourceStatus</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for DeploymentResourceStatus</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to DeploymentResourceStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DeploymentResourceStatus" />.</param>

        public static implicit operator DeploymentResourceStatus(string value)
        {
            return new DeploymentResourceStatus(value);
        }

        /// <summary>Implicit operator to convert DeploymentResourceStatus to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="DeploymentResourceStatus" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.DeploymentResourceStatus e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum DeploymentResourceStatus</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.DeploymentResourceStatus e1, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.DeploymentResourceStatus e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum DeploymentResourceStatus</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.DeploymentResourceStatus e1, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.DeploymentResourceStatus e2)
        {
            return e2.Equals(e1);
        }
    }
}