
using Android.App;
using Com.Github.Lassana.Recorder;

namespace XamarinJavaBindingsDemo.Droid.Services
{
    public class AudioService
    {
        AudioRecorder _recorder;
        public AudioService()
        {
            _recorder = AudioRecorderBuilder.With(Application.Context)
                                            .FileName("AudioFile")
                                            .Config(AudioRecorder.MediaRecorderConfig.Default)
                                            .Loggable()
                                            .Build();
        }

        public void Start()
        {
            _recorder.Start(null);
        }

        public void Stop()
        {
            _recorder.Pause(null);
        }
    }
}