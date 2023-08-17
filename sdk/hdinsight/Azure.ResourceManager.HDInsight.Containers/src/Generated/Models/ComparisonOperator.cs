// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> The comparison operator. </summary>
    public readonly partial struct ComparisonOperator : IEquatable<ComparisonOperator>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ComparisonOperator"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ComparisonOperator(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GreaterThanValue = "greaterThan";
        private const string GreaterThanOrEqualValue = "greaterThanOrEqual";
        private const string LessThanValue = "lessThan";
        private const string LessThanOrEqualValue = "lessThanOrEqual";

        /// <summary> greaterThan. </summary>
        public static ComparisonOperator GreaterThan { get; } = new ComparisonOperator(GreaterThanValue);
        /// <summary> greaterThanOrEqual. </summary>
        public static ComparisonOperator GreaterThanOrEqual { get; } = new ComparisonOperator(GreaterThanOrEqualValue);
        /// <summary> lessThan. </summary>
        public static ComparisonOperator LessThan { get; } = new ComparisonOperator(LessThanValue);
        /// <summary> lessThanOrEqual. </summary>
        public static ComparisonOperator LessThanOrEqual { get; } = new ComparisonOperator(LessThanOrEqualValue);
        /// <summary> Determines if two <see cref="ComparisonOperator"/> values are the same. </summary>
        public static bool operator ==(ComparisonOperator left, ComparisonOperator right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ComparisonOperator"/> values are not the same. </summary>
        public static bool operator !=(ComparisonOperator left, ComparisonOperator right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ComparisonOperator"/>. </summary>
        public static implicit operator ComparisonOperator(string value) => new ComparisonOperator(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ComparisonOperator other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ComparisonOperator other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
