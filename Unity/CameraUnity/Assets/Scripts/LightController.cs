using UnityEngine;

public class LightController : MonoBehaviour
{
    public Light lightToControl;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            ToggleLight();
        }
    }

    void ToggleLight()
    {
        lightToControl.enabled = !lightToControl.enabled;
    }
}
