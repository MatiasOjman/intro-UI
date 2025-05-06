using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class saludoUiManager : MonoBehaviour
{ public TextMeshProUGUI txtSaludo;
    string nombreUsuario;
    public TMP_InputField inputNombre;
    // Start is called before the first frame update
    void Start()
    {
        txtSaludo.text = " ";
    }

    public void Saludar()
    {
        if (inputNombre.text == "")
        {
            txtSaludo.text = "usuario no ingresado";
            return;
        }
        else
        {
            
            txtSaludo.text = "hola" + inputNombre.text;
        }
    }
}
