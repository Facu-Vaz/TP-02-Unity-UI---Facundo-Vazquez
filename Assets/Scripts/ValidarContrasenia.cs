using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContrasenia : MonoBehaviour
{
    string contraseniaCorrecta;
    string contraseniaUsuario;
    public Text ingresoUsuario;
    public Text textoMensaje;
    public GameObject panelMensaje;

    // Start is called before the first frame update
    void Start()
    {
        contraseniaCorrecta = "12345";
        panelMensaje.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }   

    public void validarContrasenia()
    {
        contraseniaUsuario = ingresoUsuario.text;
        if (contraseniaUsuario == contraseniaCorrecta)
        {
            panelMensaje.SetActive(true);
            textoMensaje.text = "Bienvenido";
        }
        else
        {
            panelMensaje.SetActive(true);
            textoMensaje.text = "Contraseña incorrecta";
        }
    }
}
