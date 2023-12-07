using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI : MonoBehaviour
{
    public TMP_Text puntuacion;
    public Image[] vidas;
    public GameObject gameOver;
    void Update()
    {
        puntuacion.text = GameManager.instance.punt.ToString();

        for (int i = 0; i < vidas.Length; i++)
        {
            if (i < GameManager.instance.life)
            {
                vidas[i].color = Color.green;
            }
            else
            {
                vidas[i].color = Color.white * 0.5f;
            }
        }

        if(GameManager.instance.life <= 0)
        {
            gameOver.SetActive(true);
        }
    }
}
