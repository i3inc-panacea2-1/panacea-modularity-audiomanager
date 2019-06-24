using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.AudioManager
{
    public interface IAudioManagerPlugin: IPlugin
    {
        IAudioManager GetAudioManager();
    }
}
