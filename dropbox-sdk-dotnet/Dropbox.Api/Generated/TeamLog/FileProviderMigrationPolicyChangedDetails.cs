// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Changed File Provider Migration policy for team.</para>
    /// </summary>
    public class FileProviderMigrationPolicyChangedDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<FileProviderMigrationPolicyChangedDetails> Encoder = new FileProviderMigrationPolicyChangedDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<FileProviderMigrationPolicyChangedDetails> Decoder = new FileProviderMigrationPolicyChangedDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="FileProviderMigrationPolicyChangedDetails" /> class.</para>
        /// </summary>
        /// <param name="newValue">To.</param>
        /// <param name="previousValue">From.</param>
        public FileProviderMigrationPolicyChangedDetails(global::Dropbox.Api.TeamPolicies.FileProviderMigrationPolicyState newValue,
                                                         global::Dropbox.Api.TeamPolicies.FileProviderMigrationPolicyState previousValue)
        {
            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            if (previousValue == null)
            {
                throw new sys.ArgumentNullException("previousValue");
            }

            this.NewValue = newValue;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="FileProviderMigrationPolicyChangedDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public FileProviderMigrationPolicyChangedDetails()
        {
        }

        /// <summary>
        /// <para>To.</para>
        /// </summary>
        public global::Dropbox.Api.TeamPolicies.FileProviderMigrationPolicyState NewValue { get; protected set; }

        /// <summary>
        /// <para>From.</para>
        /// </summary>
        public global::Dropbox.Api.TeamPolicies.FileProviderMigrationPolicyState PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="FileProviderMigrationPolicyChangedDetails" />.</para>
        /// </summary>
        private class FileProviderMigrationPolicyChangedDetailsEncoder : enc.StructEncoder<FileProviderMigrationPolicyChangedDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(FileProviderMigrationPolicyChangedDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamPolicies.FileProviderMigrationPolicyState.Encoder);
                WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamPolicies.FileProviderMigrationPolicyState.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="FileProviderMigrationPolicyChangedDetails" />.</para>
        /// </summary>
        private class FileProviderMigrationPolicyChangedDetailsDecoder : enc.StructDecoder<FileProviderMigrationPolicyChangedDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="FileProviderMigrationPolicyChangedDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override FileProviderMigrationPolicyChangedDetails Create()
            {
                return new FileProviderMigrationPolicyChangedDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(FileProviderMigrationPolicyChangedDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamPolicies.FileProviderMigrationPolicyState.Decoder.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamPolicies.FileProviderMigrationPolicyState.Decoder.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}