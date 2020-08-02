using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Sample_WPF_App_dotNET_Framework.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private string titolo;

        public string Titolo
        {
            get
            {
                Console.WriteLine("get");
                return titolo;
            }
            set
            {
                Console.WriteLine("set");
                titolo = value;
                NotifyPropertyChanged();
            }
        }
        public MainWindowViewModel()
        {
            Titolo = "QUESTO *é UN TUTOLO DI PROVfffefesfewsA DIOCAZZpooooO";
        }
    }
}
