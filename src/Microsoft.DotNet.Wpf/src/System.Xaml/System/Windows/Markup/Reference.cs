﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#nullable disable

using System.Xaml;

namespace System.Windows.Markup
{
    [ContentProperty("Name")]
    public class Reference : MarkupExtension
    {
        public Reference()
        {
        }

        public Reference(string name)
        {
            Name = name;
        }

        [ConstructorArgument("name")]
        public string Name { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            ArgumentNullException.ThrowIfNull(serviceProvider);
            if (serviceProvider.GetService(typeof(IXamlNameResolver)) is not IXamlNameResolver nameResolver)
            {
                throw new InvalidOperationException(SR.MissingNameResolver);
            }

            if (string.IsNullOrEmpty(Name))
            {
                throw new InvalidOperationException(SR.MustHaveName);
            }

            object obj = nameResolver.Resolve(Name);
            if (obj is null)
            {
                string[] names = new string[] { Name };
                obj = nameResolver.GetFixupToken(names, true);
            }

            return obj;
        }
    }
}
