// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The requested link access level object</para>
    /// </summary>
    public class RequestedLinkAccessLevel
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<RequestedLinkAccessLevel> Encoder = new RequestedLinkAccessLevelEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<RequestedLinkAccessLevel> Decoder = new RequestedLinkAccessLevelDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RequestedLinkAccessLevel" />
        /// class.</para>
        /// </summary>
        public RequestedLinkAccessLevel()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Viewer</para>
        /// </summary>
        public bool IsViewer
        {
            get
            {
                return this is Viewer;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Viewer, or <c>null</c>.</para>
        /// </summary>
        public Viewer AsViewer
        {
            get
            {
                return this as Viewer;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Editor</para>
        /// </summary>
        public bool IsEditor
        {
            get
            {
                return this is Editor;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Editor, or <c>null</c>.</para>
        /// </summary>
        public Editor AsEditor
        {
            get
            {
                return this as Editor;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Max</para>
        /// </summary>
        public bool IsMax
        {
            get
            {
                return this is Max;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Max, or <c>null</c>.</para>
        /// </summary>
        public Max AsMax
        {
            get
            {
                return this as Max;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Default</para>
        /// </summary>
        public bool IsDefault
        {
            get
            {
                return this is Default;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Default, or <c>null</c>.</para>
        /// </summary>
        public Default AsDefault
        {
            get
            {
                return this as Default;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="RequestedLinkAccessLevel" />.</para>
        /// </summary>
        private class RequestedLinkAccessLevelEncoder : enc.StructEncoder<RequestedLinkAccessLevel>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(RequestedLinkAccessLevel value, enc.IJsonWriter writer)
            {
                if (value is Viewer)
                {
                    WriteProperty(".tag", "viewer", writer, enc.StringEncoder.Instance);
                    Viewer.Encoder.EncodeFields((Viewer)value, writer);
                    return;
                }
                if (value is Editor)
                {
                    WriteProperty(".tag", "editor", writer, enc.StringEncoder.Instance);
                    Editor.Encoder.EncodeFields((Editor)value, writer);
                    return;
                }
                if (value is Max)
                {
                    WriteProperty(".tag", "max", writer, enc.StringEncoder.Instance);
                    Max.Encoder.EncodeFields((Max)value, writer);
                    return;
                }
                if (value is Default)
                {
                    WriteProperty(".tag", "default", writer, enc.StringEncoder.Instance);
                    Default.Encoder.EncodeFields((Default)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="RequestedLinkAccessLevel" />.</para>
        /// </summary>
        private class RequestedLinkAccessLevelDecoder : enc.UnionDecoder<RequestedLinkAccessLevel>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="RequestedLinkAccessLevel"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override RequestedLinkAccessLevel Create()
            {
                return new RequestedLinkAccessLevel();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override RequestedLinkAccessLevel Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "viewer":
                        return Viewer.Decoder.DecodeFields(reader);
                    case "editor":
                        return Editor.Decoder.DecodeFields(reader);
                    case "max":
                        return Max.Decoder.DecodeFields(reader);
                    case "default":
                        return Default.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Users who use the link can view and comment on the content.</para>
        /// </summary>
        public sealed class Viewer : RequestedLinkAccessLevel
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Viewer> Encoder = new ViewerEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Viewer> Decoder = new ViewerDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Viewer" /> class.</para>
            /// </summary>
            private Viewer()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Viewer</para>
            /// </summary>
            public static readonly Viewer Instance = new Viewer();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Viewer" />.</para>
            /// </summary>
            private class ViewerEncoder : enc.StructEncoder<Viewer>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Viewer value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Viewer" />.</para>
            /// </summary>
            private class ViewerDecoder : enc.StructDecoder<Viewer>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Viewer" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Viewer Create()
                {
                    return Viewer.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>Users who use the link can edit, view and comment on the content. Note not
        /// all file types support edit links yet.</para>
        /// </summary>
        public sealed class Editor : RequestedLinkAccessLevel
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Editor> Encoder = new EditorEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Editor> Decoder = new EditorDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Editor" /> class.</para>
            /// </summary>
            private Editor()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Editor</para>
            /// </summary>
            public static readonly Editor Instance = new Editor();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Editor" />.</para>
            /// </summary>
            private class EditorEncoder : enc.StructEncoder<Editor>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Editor value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Editor" />.</para>
            /// </summary>
            private class EditorDecoder : enc.StructDecoder<Editor>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Editor" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Editor Create()
                {
                    return Editor.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>Request for the maximum access level you can set the link to.</para>
        /// </summary>
        public sealed class Max : RequestedLinkAccessLevel
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Max> Encoder = new MaxEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Max> Decoder = new MaxDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Max" /> class.</para>
            /// </summary>
            private Max()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Max</para>
            /// </summary>
            public static readonly Max Instance = new Max();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Max" />.</para>
            /// </summary>
            private class MaxEncoder : enc.StructEncoder<Max>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Max value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Max" />.</para>
            /// </summary>
            private class MaxDecoder : enc.StructDecoder<Max>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Max" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Max Create()
                {
                    return Max.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>Request for the default access level the user has set.</para>
        /// </summary>
        public sealed class Default : RequestedLinkAccessLevel
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Default> Encoder = new DefaultEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Default> Decoder = new DefaultDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Default" /> class.</para>
            /// </summary>
            private Default()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Default</para>
            /// </summary>
            public static readonly Default Instance = new Default();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Default" />.</para>
            /// </summary>
            private class DefaultEncoder : enc.StructEncoder<Default>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Default value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Default" />.</para>
            /// </summary>
            private class DefaultDecoder : enc.StructDecoder<Default>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Default" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Default Create()
                {
                    return Default.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : RequestedLinkAccessLevel
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}
