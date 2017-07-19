using DeleteList.Model;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace DeleteList.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
    


        public Command DeletarCommand { get; }
        public ObservableCollection<Lista> Lista { get; }
        public Lista ItemSelecionado { get; set; }

        public MainViewModel()
        {
            Lista = new ObservableCollection<Lista>
            {
                new Lista("Pedro", "23"),
                new Lista("Clara", "24"),
                new Lista("Gustavo", "25"),
                new Lista("Luciano", "26")
            };


            
          
                          
            DeletarCommand = new Command(ExecuteDeletarCommand);
        }      

        void ExecuteDeletarCommand()
        {
            if(ItemSelecionado != null)
            {
                Lista.Remove(ItemSelecionado);
                
            }
        }
    }
}
