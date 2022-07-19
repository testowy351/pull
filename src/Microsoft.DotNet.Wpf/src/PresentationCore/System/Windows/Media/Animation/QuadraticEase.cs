// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

//

namespace System.Windows.Media.Animation
{
    /// <summary>
    ///     This class implements an easing function that gives a quadratic curve toward the destination
    /// </summary>
    public class QuadraticEase : EasingFunctionBase
    {
        protected override double EaseInCore(double normalizedTime)
        {
            return normalizedTime * normalizedTime;
        }

        protected override Freezable CreateInstanceCore()
        {
            return new QuadraticEase();
        }
    }
}
