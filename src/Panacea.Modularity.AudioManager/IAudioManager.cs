using System.ComponentModel;

namespace Panacea.Modularity.AudioManager
{
    public interface IAudioManager:INotifyPropertyChanged
    {
        int SpeakersVolume { get; set; }

        int MicrophoneVolume { get; set; }
    }
}