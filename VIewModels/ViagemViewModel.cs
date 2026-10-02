using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ProjetoViagemOnboarding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoViagemOnboarding.VIewModels
{
    public partial class ViagemViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<ViagemItem> _itens;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsLastPosicao))]
        [NotifyPropertyChangedFor(nameof(ExibirBotao))]
        private int _posicao;

        public bool IsLastPosicao => Posicao == Itens.Count - 1;
        public bool ExibirBotao => !IsLastPosicao;
        public ViagemViewModel()
        {
            Itens = new List<ViagemItem>
            {
                new ViagemItem
                {
                    ImagemUrl = "component.png",
                    Titulo = "Explore Exotic Destinations",
                    Descricao = "Embark on a virtual journey through stunning destinations worldwide"
                 },

                 new ViagemItem
                {
                    ImagemUrl = "discovery.png",
                    Titulo = "Discover Local Gems",
                    Descricao = "Uncover hidden gems and local favorites recommended by fellow travelers."
                 },

                   new ViagemItem
                {
                    ImagemUrl = "train.png",
                    Titulo = "Plan Your Perfect Trip",
                    Descricao = "Create personalized itineraries tailored to your preferences and interests."
                 },

                     new ViagemItem
                {
                    ImagemUrl = "vacation.png",
                    Titulo = "Capture and Share Memories",
                    Descricao = "Preserve your travel memories with our in-app photo and journaling features."
                 },
            };
        }

        [RelayCommand]
        private void Proximo()
        {
            if (Posicao < Itens.Count - 1)
            {
                Posicao++;
            }
        }
    }
}
