// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Windows.Markup;
using System.Xaml.Replacements;
using TypeListConverter = System.Xaml.Replacements.TypeListConverter;

namespace System.Xaml.Schema
{
    internal class BuiltInValueConverter<TConverterBase> : XamlValueConverter<TConverterBase>
        where TConverterBase : class
    {
        private Func<TConverterBase> _factory;

        internal BuiltInValueConverter(Type converterType, Func<TConverterBase> factory)
            :base(converterType, null)
        {
            _factory = factory;
        }

        internal override bool IsPublic => true;

        protected override TConverterBase CreateInstance()
        {
            return _factory.Invoke();
        }
    }

    internal static class BuiltInValueConverter
    {
        private static XamlValueConverter<TypeConverter> s_String;
        private static XamlValueConverter<TypeConverter> s_Object;
        private static XamlValueConverter<TypeConverter> s_Int32;
        private static XamlValueConverter<TypeConverter> s_Int16;
        private static XamlValueConverter<TypeConverter> s_Int64;
        private static XamlValueConverter<TypeConverter> s_UInt32;
        private static XamlValueConverter<TypeConverter> s_UInt16;
        private static XamlValueConverter<TypeConverter> s_UInt64;
        private static XamlValueConverter<TypeConverter> s_Boolean;
        private static XamlValueConverter<TypeConverter> s_Double;
        private static XamlValueConverter<TypeConverter> s_Single;
        private static XamlValueConverter<TypeConverter> s_Byte;
        private static XamlValueConverter<TypeConverter> s_SByte;
        private static XamlValueConverter<TypeConverter> s_Char;
        private static XamlValueConverter<TypeConverter> s_Decimal;
        private static XamlValueConverter<TypeConverter> s_TimeSpan;
        private static XamlValueConverter<TypeConverter> s_Guid;
        private static XamlValueConverter<TypeConverter> s_Type;
        private static XamlValueConverter<TypeConverter> s_TypeList;
        private static XamlValueConverter<TypeConverter> s_DateTime;
        private static XamlValueConverter<TypeConverter> s_DateTimeOffset;
        private static XamlValueConverter<TypeConverter> s_CultureInfo;
        private static XamlValueConverter<ValueSerializer> s_StringSerializer;
        private static XamlValueConverter<TypeConverter> s_Delegate;
        private static XamlValueConverter<TypeConverter> s_Uri;

        internal static XamlValueConverter<TypeConverter> Int32
        {
            get
            {
                if (ReferenceEquals(s_Int32, null))
                {
                    s_Int32 = new BuiltInValueConverter<TypeConverter>(typeof(Int32Converter), () => new Int32Converter());
                }
                return s_Int32;
            }
        }

        internal static XamlValueConverter<TypeConverter> String
        {
            get
            {
                if (ReferenceEquals(s_String, null))
                {
                    s_String = new BuiltInValueConverter<TypeConverter>(typeof(StringConverter), () => new StringConverter());
                }
                return s_String;
            }
        }

        internal static XamlValueConverter<TypeConverter> Object
        {
            get
            {
                if (ReferenceEquals(s_Object, null))
                {
                    s_Object = new XamlValueConverter<TypeConverter>(null, XamlLanguage.Object);
                }
                return s_Object;
            }
        }

        internal static XamlValueConverter<TypeConverter> Event
        {
            get
            {
                if (ReferenceEquals(s_Delegate, null))
                {
                    s_Delegate = new BuiltInValueConverter<TypeConverter>(typeof(EventConverter), () => new EventConverter());
                }
                return s_Delegate;
            }
        }

        internal static XamlValueConverter<TypeConverter> GetTypeConverter(Type targetType)
        {
            if (typeof(string) == targetType)
            {
                return String;
            }
            if (typeof(object) == targetType)
            {
                return Object;
            }
            if (typeof(Int32) == targetType)
            {
                return Int32;
            }
            if (typeof(Int16) == targetType)
            {
                if (ReferenceEquals(s_Int16, null))
                {
                    s_Int16 = new BuiltInValueConverter<TypeConverter>(typeof(Int16Converter), () => new Int16Converter());
                }
                return s_Int16;
            }
            if (typeof(Int64) == targetType)
            {
                if (ReferenceEquals(s_Int64, null))
                {
                    s_Int64 = new BuiltInValueConverter<TypeConverter>(typeof(Int64Converter), () => new Int64Converter());
                }
                return s_Int64;
            }
            if (typeof(UInt32) == targetType)
            {
                if (ReferenceEquals(s_UInt32, null))
                {
                    s_UInt32 = new BuiltInValueConverter<TypeConverter>(typeof(UInt32Converter), () => new UInt32Converter());
                }
                return s_UInt32;
            }
            if (typeof(UInt16) == targetType)
            {
                if (ReferenceEquals(s_UInt16, null))
                {
                    s_UInt16 = new BuiltInValueConverter<TypeConverter>(typeof(UInt16Converter), () => new UInt16Converter());
                }
                return s_UInt16;
            }
            if (typeof(UInt64) == targetType)
            {
                if (ReferenceEquals(s_UInt64, null))
                {
                    s_UInt64 = new BuiltInValueConverter<TypeConverter>(typeof(UInt64Converter), () => new UInt64Converter());
                }
                return s_UInt64;
            }
            if (typeof(Boolean) == targetType)
            {
                if (ReferenceEquals(s_Boolean, null))
                {
                    s_Boolean = new BuiltInValueConverter<TypeConverter>(typeof(BooleanConverter), () => new BooleanConverter());
                }
                return s_Boolean;
            }
            if (typeof(Double) == targetType)
            {
                if (ReferenceEquals(s_Double, null))
                {
                    s_Double = new BuiltInValueConverter<TypeConverter>(typeof(DoubleConverter), () => new DoubleConverter());
                }
                return s_Double;
            }
            if (typeof(Single) == targetType)
            {
                if (ReferenceEquals(s_Single, null))
                {
                    s_Single = new BuiltInValueConverter<TypeConverter>(typeof(SingleConverter), () => new SingleConverter());
                }
                return s_Single;
            }
            if (typeof(Byte) == targetType)
            {
                if (ReferenceEquals(s_Byte, null))
                {
                    s_Byte = new BuiltInValueConverter<TypeConverter>(typeof(ByteConverter), () => new ByteConverter());
                }
                return s_Byte;
            }
            if (typeof(SByte) == targetType)
            {
                if (ReferenceEquals(s_SByte, null))
                {
                    s_SByte = new BuiltInValueConverter<TypeConverter>(typeof(SByteConverter), () => new SByteConverter());
                }
                return s_SByte;
            }
            if (typeof(Char) == targetType)
            {
                if (ReferenceEquals(s_Char, null))
                {
                    s_Char = new BuiltInValueConverter<TypeConverter>(typeof(CharConverter), () => new CharConverter());
                }
                return s_Char;
            }
            if (typeof(Decimal) == targetType)
            {
                if (ReferenceEquals(s_Decimal, null))
                {
                    s_Decimal = new BuiltInValueConverter<TypeConverter>(typeof(DecimalConverter), () => new DecimalConverter());
                }
                return s_Decimal;
            }
            if (typeof(TimeSpan) == targetType)
            {
                if (ReferenceEquals(s_TimeSpan, null))
                {
                    s_TimeSpan = new BuiltInValueConverter<TypeConverter>(typeof(TimeSpanConverter), () => new TimeSpanConverter());
                }
                return s_TimeSpan;
            }
            if (typeof(Guid) == targetType)
            {
                if (ReferenceEquals(s_Guid, null))
                {
                    s_Guid = new BuiltInValueConverter<TypeConverter>(typeof(GuidConverter), () => new GuidConverter());
                }
                return s_Guid;
            }
            if (typeof(Type).IsAssignableFrom(targetType))
            {
                if (ReferenceEquals(s_Type, null))
                {
                    s_Type = new BuiltInValueConverter<TypeConverter>(typeof(TypeTypeConverter), () => new TypeTypeConverter());
                }
                return s_Type;
            }
            if (typeof(Type[]).IsAssignableFrom(targetType))
            {
                if (ReferenceEquals(s_TypeList, null))
                {
                    s_TypeList = new BuiltInValueConverter<TypeConverter>(typeof(TypeListConverter), () => new TypeListConverter());
                }
                return s_TypeList;
            }
            if (typeof(DateTime) == targetType)
            {
                if (ReferenceEquals(s_DateTime, null))
                {
                    s_DateTime = new BuiltInValueConverter<TypeConverter>(typeof(DateTimeConverter2), () => new DateTimeConverter2());
                }
                return s_DateTime;
            }
            if (typeof(DateTimeOffset) == targetType)
            {
                if (ReferenceEquals(s_DateTimeOffset, null))
                {
                    s_DateTimeOffset = new BuiltInValueConverter<TypeConverter>(typeof(DateTimeOffsetConverter2), () => new DateTimeOffsetConverter2());
                }
                return s_DateTimeOffset;
            }
            if (typeof(CultureInfo).IsAssignableFrom(targetType))
            {
                if (ReferenceEquals(s_CultureInfo, null))
                {
                    s_CultureInfo = new BuiltInValueConverter<TypeConverter>(typeof(CultureInfoConverter), () => new CultureInfoConverter());
                }
                return s_CultureInfo;
            }
            if (typeof(Delegate).IsAssignableFrom(targetType))
            {
                if (ReferenceEquals(s_Delegate, null))
                {
                    s_Delegate = new BuiltInValueConverter<TypeConverter>(typeof(EventConverter), () => new EventConverter());
                }
                return s_Delegate;
            }
            if (typeof(Uri).IsAssignableFrom(targetType))
            {
                if(ReferenceEquals(s_Uri, null))
                {
                    TypeConverter stdConverter = null;
                    try
                    {
                        stdConverter = TypeDescriptor.GetConverter(typeof(Uri));
                        // The TypeConverter for Uri, if one is found, should be capable of converting from { String, Uri }
                        // and converting to { String, Uri, System.ComponentModel.Design.Serialization.InstanceDescriptor }
                        if (stdConverter == null ||
                            !stdConverter.CanConvertFrom(typeof(string)) || !stdConverter.CanConvertFrom(typeof(Uri)) ||
                            !stdConverter.CanConvertTo(typeof(string)) || !stdConverter.CanConvertTo(typeof(Uri)) || !stdConverter.CanConvertTo(typeof(InstanceDescriptor)))
                        {
                            stdConverter = null;
                        }
                    }
                    catch (NotSupportedException)
                    {
                    }

                    if (stdConverter == null)
                    {
                        s_Uri = new BuiltInValueConverter<TypeConverter>(typeof(TypeUriConverter), () => new TypeUriConverter());
                    }
                    else
                    {
                        // There is a built-in TypeConverter available. Very likely, System.UriTypeConverter, but this was not naturally
                        // discovered. this is probably due to the fact that System.Uri does not have [TypeConverterAttribute(typeof(UriConverter))]
                        // in the .NET Core codebase. 
                        // Since a default converter was discovered, just use that instead of our own (very nearly equivalent) implementation.
                        s_Uri = new BuiltInValueConverter<TypeConverter>(stdConverter.GetType(), () => TypeDescriptor.GetConverter(typeof(Uri)));
                    }
                }
                return s_Uri;
            }
            return null;
        }

        internal static XamlValueConverter<ValueSerializer> GetValueSerializer(Type targetType)
        {
            if (typeof(string) == targetType)
            {
                if (ReferenceEquals(s_StringSerializer, null))
                {
                    // Once StringSerializer is TypeForwarded to S.X, this can be made more efficient
                    ValueSerializer stringSerializer = ValueSerializer.GetSerializerFor(typeof(string));
                    s_StringSerializer = new BuiltInValueConverter<ValueSerializer>(stringSerializer.GetType(), () => stringSerializer);
                }
                return s_StringSerializer;
            }
            return null;
        }
    }
}
