using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputField : MonoBehaviour
{
    public InputField inputField;

    private void Start()
    {
        // Registra un método para manejar el evento de cambio de texto del Input Field
        
    }

    private void OnInputFieldValueChanged(string value)
    {
        // Aquí puedes realizar acciones en respuesta al cambio de texto en el Input Field
        Debug.Log("Texto actual en el Input Field: " + value);
    }
}
