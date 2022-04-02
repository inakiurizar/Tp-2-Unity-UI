using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContraseña : MonoBehaviour
{
    string contraseñaCorrecta;
    string contrasenaUsuario;
    public Text ingresoUsuario;
    public Text textoMsj;
    public GameObject cartelitoMsj;
    void Start()
    {
        contraseñaCorrecta = "12345";
        cartelitoMsj.SetActive(false);
    }

    void Update()
    {
        
    }

    public void validarContraseña()
    {
        contrasenaUsuario = ingresoUsuario.text;
        if (contrasenaUsuario == contraseñaCorrecta)
        {
            cartelitoMsj.SetActive(true);
            textoMsj.text = "Bienvenido";
            Debug.Log("Bienvenido");
        }
        else
        {
            cartelitoMsj.SetActive(true);
            textoMsj.text = "Contraseña incorrecta";
            Debug.Log("Contraseña incorrecta");
        }
    }
}
