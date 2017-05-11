using Android.App;
using Com.Github.Lassana.Recorder;
using static XamarinJavaBindingsDemo.Droid.Services.AudioService;

namespace XamarinJavaBindingsDemo.Droid.Services
{
    public class AudioService : IAudioService, IAudioServiceMetadata
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
            _recorder.Start(new OnStartListener(this));
        }

        public void Pause()
        {
            _recorder.Pause(new OnPauseListener(this));
        }

        internal interface IAudioServiceMetadata
        {
            //Timer RecordingTimer { get; }
            //bool IsRecording { get; set; }
        }
        private class OnPauseListener : Listener, AudioRecorder.IOnPauseListener
        {
            public OnPauseListener(IAudioServiceMetadata metadata)
                : base(metadata) { }

            public void OnException(Java.Lang.Exception p0)
            {
            }

            public void OnPaused(string activeFileName)
            {
                //Metadata.RecordingTimer.Stop();
                //Metadata.IsRecording = false;
            }
        }
        private class OnStartListener : Listener, AudioRecorder.IOnStartListener
        {
            public OnStartListener(IAudioServiceMetadata metadata)
                : base(metadata) { }

            public void OnException(Java.Lang.Exception p0)
            {
            }

            public void OnStarted()
            {
                //Metadata.RecordingTimer.Start();
                //Metadata.IsRecording = true;
            }
        }
        private abstract class Listener : Java.Lang.Object
        {
            protected IAudioServiceMetadata Metadata { get; }

            protected Listener(IAudioServiceMetadata metadata)
            {
                Metadata = metadata;
            }
        }
    }
}