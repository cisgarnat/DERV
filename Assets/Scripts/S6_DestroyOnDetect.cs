using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class S6_DestroyOnDetect : MonoBehaviour
{
    public int contador;
    [SerializeField] TextMeshProUGUI texto;
    [SerializeField] GameObject puerta;

    // Start is called before the first frame update
    void Start()
    {
        contador = 6;
    }
    private void OnCollisionEnter(Collision other)
    {
        GameObject obj = other.gameObject;
        if (obj.CompareTag("TypeEnemy")) { 
            Destroy(obj);
            contador--;
            texto.text = contador.ToString();
            if(contador <= 0)
            {
                Destroy(puerta);
                texto.text = "La puerta se abrio";
            }
            
        }

    }
}
