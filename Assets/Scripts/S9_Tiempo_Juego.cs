using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class S9_Tiempo_Juego : MonoBehaviour
{
    [SerializeField] SceneChange auxiliar;
    [SerializeField] S6_DestroyOnDetect acceso_Score;
    int contador_segundos;
    [SerializeField] TextMeshProUGUI Texto_Tiempo;

    // Start is called before the first frame update
    void Start()
    {
        contador_segundos = 20;
        Texto_Tiempo.text = contador_segundos--.ToString();
        StartCoroutine("corrutinaTiempo");
    }

    IEnumerator corrutinaTiempo()
    {
        while (contador_segundos>=0)
        {
            Texto_Tiempo.text = contador_segundos--.ToString();
            yield return new WaitForSeconds(0.25f);
        }
        Debug.Log("El juego termino");
        int score = acceso_Score.contador;
        auxiliar.cambioEscena(2,score);



    }
}
