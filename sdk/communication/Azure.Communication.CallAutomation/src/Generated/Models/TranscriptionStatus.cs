// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The TranscriptionStatus. </summary>
    public readonly partial struct TranscriptionStatus : IEquatable<TranscriptionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TranscriptionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TranscriptionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TranscriptionStartedValue = "transcriptionStarted";
        private const string TranscriptionFailedValue = "transcriptionFailed";
        private const string TranscriptionResumedValue = "transcriptionResumed";
        private const string TranscriptionLocaleUpdatedValue = "transcriptionLocaleUpdated";
        private const string TranscriptionStoppedValue = "transcriptionStopped";
        private const string UnspecifiedErrorValue = "unspecifiedError";

        /// <summary> transcriptionStarted. </summary>
        public static TranscriptionStatus TranscriptionStarted { get; } = new TranscriptionStatus(TranscriptionStartedValue);
        /// <summary> transcriptionFailed. </summary>
        public static TranscriptionStatus TranscriptionFailed { get; } = new TranscriptionStatus(TranscriptionFailedValue);
        /// <summary> transcriptionResumed. </summary>
        public static TranscriptionStatus TranscriptionResumed { get; } = new TranscriptionStatus(TranscriptionResumedValue);
        /// <summary> transcriptionLocaleUpdated. </summary>
        public static TranscriptionStatus TranscriptionLocaleUpdated { get; } = new TranscriptionStatus(TranscriptionLocaleUpdatedValue);
        /// <summary> transcriptionStopped. </summary>
        public static TranscriptionStatus TranscriptionStopped { get; } = new TranscriptionStatus(TranscriptionStoppedValue);
        /// <summary> unspecifiedError. </summary>
        public static TranscriptionStatus UnspecifiedError { get; } = new TranscriptionStatus(UnspecifiedErrorValue);
        /// <summary> Determines if two <see cref="TranscriptionStatus"/> values are the same. </summary>
        public static bool operator ==(TranscriptionStatus left, TranscriptionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TranscriptionStatus"/> values are not the same. </summary>
        public static bool operator !=(TranscriptionStatus left, TranscriptionStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TranscriptionStatus"/>. </summary>
        public static implicit operator TranscriptionStatus(string value) => new TranscriptionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TranscriptionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TranscriptionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
