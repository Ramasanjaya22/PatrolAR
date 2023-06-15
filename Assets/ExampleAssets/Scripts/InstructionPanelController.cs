using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionPanelController : MonoBehaviour
{
    public GameObject instructionPanel;
    public GameObject leanController;

    public void OnClickUnderstand()
    {
        // Hancurkan panel instruksi
        Destroy(instructionPanel);

        // Aktifkan gameobject "leanController"
        leanController.SetActive(true);
    }
}
