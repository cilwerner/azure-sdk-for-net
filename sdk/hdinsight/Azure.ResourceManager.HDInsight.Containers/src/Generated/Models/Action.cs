// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> A string property that indicates the action to be performed on the Flink job. It can have one of the following enum values =&gt; NEW, UPDATE, STATELESS_UPDATE, STOP, START, CANCEL, SAVEPOINT, LIST_SAVEPOINT, or DELETE. </summary>
    public readonly partial struct Action : IEquatable<Action>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Action"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Action(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NEWValue = "NEW";
        private const string UpdateValue = "UPDATE";
        private const string StatelessUpdateValue = "STATELESS_UPDATE";
        private const string StopValue = "STOP";
        private const string StartValue = "START";
        private const string CancelValue = "CANCEL";
        private const string SavepointValue = "SAVEPOINT";
        private const string ListSavepointValue = "LIST_SAVEPOINT";
        private const string DeleteValue = "DELETE";

        /// <summary> NEW. </summary>
        public static Action NEW { get; } = new Action(NEWValue);
        /// <summary> UPDATE. </summary>
        public static Action Update { get; } = new Action(UpdateValue);
        /// <summary> STATELESS_UPDATE. </summary>
        public static Action StatelessUpdate { get; } = new Action(StatelessUpdateValue);
        /// <summary> STOP. </summary>
        public static Action Stop { get; } = new Action(StopValue);
        /// <summary> START. </summary>
        public static Action Start { get; } = new Action(StartValue);
        /// <summary> CANCEL. </summary>
        public static Action Cancel { get; } = new Action(CancelValue);
        /// <summary> SAVEPOINT. </summary>
        public static Action Savepoint { get; } = new Action(SavepointValue);
        /// <summary> LIST_SAVEPOINT. </summary>
        public static Action ListSavepoint { get; } = new Action(ListSavepointValue);
        /// <summary> DELETE. </summary>
        public static Action Delete { get; } = new Action(DeleteValue);
        /// <summary> Determines if two <see cref="Action"/> values are the same. </summary>
        public static bool operator ==(Action left, Action right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Action"/> values are not the same. </summary>
        public static bool operator !=(Action left, Action right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Action"/>. </summary>
        public static implicit operator Action(string value) => new Action(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Action other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Action other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
