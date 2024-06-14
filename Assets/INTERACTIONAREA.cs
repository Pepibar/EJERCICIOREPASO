using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//detectar cuano el area entra en contacto con un alimento
// si lo hace destruye el alimento 
// y suma a una variable el valor del itema 
// y muestra el valor de esa variable en el txtscore de la escena

public class INTERACTIONAREA : MonoBehaviour

{
    public Text txtScore;
    public int score;
    public int maxscore;
    // Start is called before the first frame update
    void Start()
    {
        txtScore.text = "0";
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("contacto");
        AlimentoScript alimento;
        alimento = collision.gameObject.GetComponent<AlimentoScript>();
        score += alimento.valorAlimentario;
        if(score < maxscore)
        {
        txtScore.text = score.ToString();
        Destroy(collision.gameObject);
        }
       
    }
}

