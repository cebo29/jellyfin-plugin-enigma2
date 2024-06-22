using MediaBrowser.Controller.Channels;
using MediaBrowser.Controller.LiveTv;
using MediaBrowser.Controller.Plugins;
using MediaBrowser.Controller;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;
using Jellyfin.Plugin.Enigma2.Helpers;

namespace Jellyfin.Plugin.Enigma2
{
    public class ServiceRegistrator : IPluginServiceRegistrator
    {
        /// <inheritdoc />
        public void RegisterServices(IServiceCollection serviceCollection, IServerApplicationHost applicationHost)
        {
            serviceCollection.AddSingleton<ILiveTvService, LiveTvService>();
            serviceCollection.AddSingleton<IChannel, RecordingsChannel>();
        }
    }
}
