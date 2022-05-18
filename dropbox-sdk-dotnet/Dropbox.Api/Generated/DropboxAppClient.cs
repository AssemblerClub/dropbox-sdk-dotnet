// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api
{
    using sys = System;

    using Dropbox.Api.Stone;
    using Dropbox.Api.Auth.Routes;
    using Dropbox.Api.Check.Routes;
    using Dropbox.Api.Files.Routes;
    using Dropbox.Api.Sharing.Routes;

    public sealed partial class DropboxAppClient
    {
        /// <summary>
        /// <para>Gets the Auth routes.</para>
        /// </summary>
        public AuthAppRoutes Auth { get; private set; }

        /// <summary>
        /// <para>Gets the Check routes.</para>
        /// </summary>
        public CheckAppRoutes Check { get; private set; }

        /// <summary>
        /// <para>Gets the Files routes.</para>
        /// </summary>
        public FilesAppRoutes Files { get; private set; }

        /// <summary>
        /// <para>Gets the Sharing routes.</para>
        /// </summary>
        public SharingAppRoutes Sharing { get; private set; }

        /// <summary>
        /// <para>Initializes the routes.</para>
        /// </summary>
        /// <returns>The transport.</returns>
        internal override void InitializeRoutes(ITransport transport)
        {
            this.Auth = new AuthAppRoutes(transport);
            this.Check = new CheckAppRoutes(transport);
            this.Files = new FilesAppRoutes(transport);
            this.Sharing = new SharingAppRoutes(transport);
        }
    }
}
