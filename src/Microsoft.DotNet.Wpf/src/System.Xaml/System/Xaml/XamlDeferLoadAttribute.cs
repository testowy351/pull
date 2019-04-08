﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Windows.Markup
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public sealed class XamlDeferLoadAttribute : Attribute
    {
        public XamlDeferLoadAttribute(Type loaderType, Type contentType)
        {
            if (loaderType == null)
            {
                throw new ArgumentNullException(nameof(loaderType));
            }
            if (contentType == null)
            {
                throw new ArgumentNullException(nameof(contentType));
            }
            LoaderTypeName = loaderType.AssemblyQualifiedName;
            ContentTypeName = contentType.AssemblyQualifiedName;
            LoaderType = loaderType;
            ContentType = contentType;
        }

        public XamlDeferLoadAttribute(string loaderType, string contentType)
        {
            if (loaderType == null)
            {
                throw new ArgumentNullException(nameof(loaderType));
            }
            if (contentType == null)
            {
                throw new ArgumentNullException(nameof(contentType));
            }
            LoaderTypeName = loaderType;
            ContentTypeName = contentType;
        }

        public string LoaderTypeName { get; }

        public string ContentTypeName { get; }

        public Type LoaderType { get; private set; }

        public Type ContentType { get; private set; }
    }
}
