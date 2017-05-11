using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
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