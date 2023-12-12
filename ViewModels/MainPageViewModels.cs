using MiChatGPTDani.Models;
using MiChatGPTDani.Services;
using MiChatGPTDani.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MiChatGPTDani.ViewModels;

public class MainPageViewModels : INotifyPropertyChanged
{
    private readonly IMensajeria mensajeria;

    public Consultas MiConsulta { get; set; }

    public Command EnviarCommand { get; set; }

    public event PropertyChangedEventHandler PropertyChanged;

    public MainPageViewModels(IMensajeria mensajeria)
    {
        MiConsulta = new Consultas();
        EnviarCommand = new Command(EnviarPregunta);
        this.mensajeria = mensajeria;
    }

    public void EnviarPregunta()
    {
        MiConsulta.Respuesta = mensajeria.Preguntame(MiConsulta.Pregunta);
    }
    public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

}
