using UnityEngine;
using UnityEngine.UI;

public class LightManager : MonoBehaviour
{
    public Light light; // Luce da gestire
    public GameObject menu; // Il menu da visualizzare/nascondere
    public Toggle lightToggle; // Toggle per accendere/spegnere la luce

    private void Start()
    {
        // Assicurati che il menu sia nascosto all'inizio
        menu.SetActive(false);

        // Imposta il toggle in base allo stato iniziale della luce
        lightToggle.isOn = light.enabled;
        lightToggle.onValueChanged.AddListener(ToggleLight);
    }

    private void Update()
    {
        // Controlla se il tasto 'L' è stato premuto
        if (Input.GetKeyDown(KeyCode.L))
        {
            // Alterna la visibilità del menu
            menu.SetActive(!menu.activeSelf);
        }
    }

    // Funzione per accendere/spegnere la luce
    public void ToggleLight(bool state)
    {
        light.enabled = state;
    }
}
