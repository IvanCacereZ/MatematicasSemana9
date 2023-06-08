using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SimulationManager : MonoBehaviour
{
    private bool IsActive = false;
    [SerializeField] private MRU myMRU;
    [SerializeField] private MRUV myMRUV;
    [SerializeField] private TextMeshProUGUI myTextMeshPro;

    private void FixedUpdate()
    {
        if (IsActive)
        {
            myTextMeshPro.text = "Simulacion iniciada";
            myMRU.movimientoMRU();
            myMRUV.movementMRUV();
        }
        else
        {
            myTextMeshPro.text = "Simulacion en pausa";
            myMRU.SetInicialPosition();
            myMRUV.SetInicialPosition();
        }
    }
    public void BotonActivate()
    {
        IsActive = !IsActive;
    }
}
