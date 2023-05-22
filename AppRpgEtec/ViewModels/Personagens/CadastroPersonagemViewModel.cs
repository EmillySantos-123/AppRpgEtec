using AppRpgEtec.Services.Personagns;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppRpgEtec.Models;

namespace AppRpgEtec.ViewModels.Personagens
{
    public class CadastroPersonagemViewModel : BaseViewModel
    {
        private PersonagemService pService;

        public CadastroPersonagemViewModel(){
            string token = Preferences.Get("UsuarioToken", string.Empty);
            pService= new PersonagemService(token);
        }
        private int id;
        private string nome;
        private int pontosVida;
        private int forca;
        private int defesa;
        private int inteligencia;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public int PontosVida { get => pontosVida; set => pontosVida = value; }
        public int Forca { get => forca; set => forca = value; }
        public int Defesa { get => defesa; set => defesa = value; }
        public int Inteligencia { get => inteligencia; set => inteligencia = value; }

        private ObservableCollection<TipoClasse> listaTiposClasse;
        public ObservableCollection<TipoClasse> ListaTiposClasse
        {
            get { return listaTiposClasse; }
            set
            {
                if (value != null)
                {
                    listaTiposClasse = value;
                    OnPropertyChanged();
                }
            }
        }


    }

}
