using UnityEngine;

public class ShowPanel : MonoBehaviour
{
    public GameObject infoPanel;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            infoPanel.SetActive(!infoPanel.activeSelf);
        }
    }
}
