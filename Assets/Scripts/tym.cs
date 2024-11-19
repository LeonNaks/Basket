using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tym : MonoBehaviour
{
    int Mang = 3;
    GameObject[] listHealth;
    public Text StatusGame;

    // Start is called before the first frame update
    void Start()
    {
        listHealth = GameObject.FindGameObjectsWithTag("health");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Mang <= 0)
        {
            StatusGame.text = "GAMEOVER";
            StatusGame.gameObject.SetActive(true);
            StatusGame.color = Color.black;
            Time.timeScale = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Mang--;
        Destroy(collision.gameObject);
        truMang();
    }

    private void truMang()
    {
        for (int i = 0; i < listHealth.Length; i++)
        {
            if(i >= Mang)
            {
                listHealth[i].SetActive(false);
            }
        }
    }
}
