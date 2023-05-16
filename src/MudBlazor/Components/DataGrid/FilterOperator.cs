// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace MudBlazor
{
#nullable enable
    public static class FilterOperator
    {
        public static class String
        {
            public const string Contains = "contiene";
            public const string NotContains = "non contiene";
            public const string Equal = "uguale";
            public const string NotEqual = "non uguale";
            public const string StartsWith = "inizia con";
            public const string EndsWith = "finisce con";
            public const string Empty = "è vuoto";
            public const string NotEmpty = "non è vuoto";
        }

        public static class Number
        {
            public const string Equal = "=";
            public const string NotEqual = "!=";
            public const string GreaterThan = ">";
            public const string GreaterThanOrEqual = ">=";
            public const string LessThan = "<";
            public const string LessThanOrEqual = "<=";
            public const string Empty = "è vuoto";
            public const string NotEmpty = "non è vuoto";
        }

        public static class Enum
        {
            public const string Is = "è";
            public const string IsNot = "non è";
        }

        public static class Boolean
        {
            public const string Is = "è";
        }

        public static class DateTime
        {
            public const string Is = "è";
            public const string IsNot = "non è";
            public const string After = "è dopo";
            public const string OnOrAfter = "è il o dopo";
            public const string Before = "è prima";
            public const string OnOrBefore = "è il o prima";
            public const string Empty = "è vuoto";
            public const string NotEmpty = "non è vuoto";
        }

        public static class Guid
        {
            public const string Equal = "uguale";
            public const string NotEqual = "non uguale";
        }

        internal static string[] GetOperatorByDataType(Type type)
        {
            var fieldType = FieldType.Identify(type);
            return GetOperatorByDataType(fieldType);
        }

        internal static string[] GetOperatorByDataType(FieldType fieldType)
        {
            if (fieldType.IsString)
            {
                return new[]
                {
                    String.Contains,
                    String.NotContains,
                    String.Equal,
                    String.NotEqual,
                    String.StartsWith,
                    String.EndsWith,
                    String.Empty,
                    String.NotEmpty,
                };
            }
            if (fieldType.IsNumber)
            {
                return new[]
                {
                    Number.Equal,
                    Number.NotEqual,
                    Number.GreaterThan,
                    Number.GreaterThanOrEqual,
                    Number.LessThan,
                    Number.LessThanOrEqual,
                    Number.Empty,
                    Number.NotEmpty,
                };
            }
            if (fieldType.IsEnum)
            {
                return new[] {
                    Enum.Is,
                    Enum.IsNot,
                };
            }
            if (fieldType.IsBoolean)
            {
                return new[]
                {
                    Boolean.Is,
                };
            }
            if (fieldType.IsDateTime)
            {
                return new[]
                {
                    DateTime.Is,
                    DateTime.IsNot,
                    DateTime.After,
                    DateTime.OnOrAfter,
                    DateTime.Before,
                    DateTime.OnOrBefore,
                    DateTime.Empty,
                    DateTime.NotEmpty,
                };
            }
            if (fieldType.IsGuid)
            {
                return new[]
                {
                    Guid.Equal,
                    Guid.NotEqual,
                };
            }

            // default
            return Array.Empty<string>();
        }
    }
}
