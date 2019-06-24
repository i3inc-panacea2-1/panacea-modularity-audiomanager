using Panacea.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.AudioManager
{
    public static class PanaceaServicesExtensions
    {
        public static bool TryGetAudioManager(this PanaceaServices core, out IAudioManager audio)
        {
            audio = core.PluginLoader.GetPlugins<IAudioManagerPlugin>()?.FirstOrDefault()?.GetAudioManager();
            return audio != null;
        }
    }
}
