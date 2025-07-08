
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime;
using Unity.VisualScripting;
using UnityEditor.Rendering.Universal.ShaderGUI;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.OpenXR.Input;

public class GestoreCanvasTesti : MonoBehaviour
{
    public GameObject CanvasTesti;      
    public Text testoVisualizzato;
    public TMP_Text TestoText;

    void Start()
    {
        CanvasTesti.SetActive(false);   // Nasconde il canvas all'avvio
    }

    public void MostraTesto(int numeroBottone)
    {
        CanvasTesti.SetActive(true);

        switch (numeroBottone)
        {
            case 1:
                TestoText.text = "F1 Oltre la pista e la realtà La Formula 1 ha ufficialmente avuto inizio nel 1950, ma le corse automobilistiche di Gran Premio esistevano già dagli anni '20 e '30. Il termine \"Formula\" si riferisce a un insieme di regole che tutte le auto partecipanti devono rispettare. Il primo campionato mondiale di Formula 1 iniziò il 13 maggio 1950 con il Gran Premio di Gran Bretagna a Silverstone, vinto da Giuseppe \"Nino\" Farina su Alfa Romeo. Farina vinse anche il primo titolo mondiale della storia.Nel corso di questi 75 anni di storia, la Formula 1 nei vari decenni ha subito varie modifiche regolamentari che hanno aumentato la sicurezza, lo spettacolo, ma anche prodotto domini che hanno lasciato segni indelebili nella storia e nello sviluppo delle macchine successive. In questa Mostra vedremo le vetture più dominanti di ogni decennio, partendo dal periodo di Fangio fino alla dominante Rb19 di Max Verstappen.\"Anni 50Alfa Romeo 158- 159 \"Alfetta\"(1950 - 1951)\"Motore: 1.5 L sovralimentatoPotenza: fino a 425 CV(per la 159 nel 1951)Piloti: Nino Farina(1950), Juan Manuel Fangio(1951)Caratteristiche: Inizialmente sviluppata nel 1938, ma ancora incredibilmente competitiva nel 1950 e 1951.Era una bestia meccanica, con un motore potente, leggera e maneggevole. \"Anni 60La Lotus 49 è una vettura di Formula 1 progettata da Colin Chapman e costruita dalla Lotus negli anni \'60. Ecco alcune caratteristiche principali:- Motore: Ford Cosworth DFV, 3 litri, 8 cilindri- Telaio: Monoscocca in alluminio- Design: Innovativo e leggero, con un focus sulla aerodinamica e sulla riduzione del peso-Prestazioni: Velocità e manovrabilità eccezionali, grazie al motore potente e al telaio leggeroLa Lotus 49 è stata una vettura molto competitiva e ha ottenuto diverse vittorie in Formula 1, contribuendo a consolidare la reputazione della Lotus come una delle scuderie più innovative e veloci dell'epoca.Anni 70La Ferrari 312 TLa Ferrari 312 T è una vettura di Formula 1 progettata dalla Ferrari e utilizzata negli anni '70. Ecco alcune caratteristiche principali:- Motore: Ferrari 3 litri, 12 cilindri -Potenza: Circa 450 CV- Telaio: Monoscocca in alluminio- Prestazioni: Velocità e potenza eccezionali, grazie al motore 12 cilindriLa Ferrari 312 è stata una vettura molto competitiva negli anni '70 e ha ottenuto diverse vittorie in Formula 1, contribuendo a consolidare la reputazione della Ferrari come una delle scuderie più prestigiose e veloci del mondo. Guidata da piloti come Niki Lauda e Clay Regazzoni, la 312 ha lasciato un'impronta indelebile nella storia della F1.Corse 15Vittorie 9Pole 10";
                break;
            case 2:
                TestoText.text = "Testo del bottone 2.";
                break;
            case 3:
                TestoText.text = "Testo del bottone 3.";
                break;
            case 4:
                TestoText.text = "Testo del bottone 4.";
                break;
            default:
                TestoText.text = "";
                break;
        }
    }
}

