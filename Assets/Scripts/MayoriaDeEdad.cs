using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MayoriaDeEdad : MonoBehaviour
{
    public int edadUsuario;
    public Text myText;

    // Start is called before the first frame update
    void Start()
    {
       if (edadUsuario >= 18)
       {
            myText.text = "Es mayor de edad";
       }
       else
       {
            myText.text = "No es mayor de edad";
       }
    }
}
