using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace XamarinJavaBindingsDemo.ViewModels
{
    public class MainPageViewModel
    {
        public string Title => "Xamarin Java Bindings Demo";
        public IAudioService _audioService;

        public ICommand Start { get; }
        public ICommand Stop { get; }

        public MainPageViewModel(IAudioService audioService)
        {
            _audioService = audioService;

            Start = new DelegateCommand(OnStart);
            Stop = new DelegateCommand(OnStop);
        }

        public void OnStart()
        {
            _audioService.Start();
        }

        public void OnStop()
        {
            _audioService.Pause();
        }
    }
}
