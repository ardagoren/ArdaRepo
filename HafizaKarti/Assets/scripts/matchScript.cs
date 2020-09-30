using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class matchScript : MonoBehaviour
{
    public GameObject[] gameObjects;
    bool bath;
    bool cf;
    bool cloth;
    bool egg;
    bool fork;
    bool milk;
    bool shampoo;
    bool soap;
    bool tb;
    bool towel;
    bool bath1 = true;
    bool cf1=true;
    bool cloth1=true;
    bool egg1 = true;
    bool fork1 = true;
    bool milk1 = true;
    bool shampoo1 = true;
    bool soap1 = true;
    bool tb1 = true;
    bool towel1 = true;
    public countScript countScript;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 2; i++)
        {
            gameObjects[i].GetComponent<GameObject>();
        }

        
       
    }
  
    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        
        if (gameObjects[0].active == true && gameObjects[1].active == true)
        {
            
            bath = true;
            if (bath1)
            {
                countScript.count = 0;
            }
            bath1 = false;
        }
        if (bath && gameObjects[0].active == false && gameObjects[1].active == false)
        {
            
            gameObjects[0].SetActive(true);
            gameObjects[1].SetActive(true);
            
        }

        if (gameObjects[2].active == true && gameObjects[3].active == true)
        {
            cf = true;
            if (cf1)
            {
                countScript.count = 0;
            }
            cf1 = false;
        }
        if (cf && gameObjects[2].active == false && gameObjects[3].active == false)
        {
            gameObjects[2].SetActive(true);
            gameObjects[3].SetActive(true);
        }

        if (gameObjects[4].active == true && gameObjects[5].active == true)
        {
            cloth= true;
            if (cloth1)
            {
                countScript.count = 0;
            }
            cloth1 = false;
        }
        if (cloth && gameObjects[4].active == false && gameObjects[5].active == false)
        {
            gameObjects[4].SetActive(true);
            gameObjects[5].SetActive(true);
        }

        if (gameObjects[6].active == true && gameObjects[7].active == true)
        {
            egg = true;
            if (egg1)
            {
                countScript.count = 0;
            }
            egg1 = false;
        }
        if (egg && gameObjects[6].active == false && gameObjects[7].active == false)
        {
            gameObjects[6].SetActive(true);
            gameObjects[7].SetActive(true);
        }

        if (gameObjects[8].active == true && gameObjects[9].active == true)
        {
            fork = true;
            if (fork1)
            {
                countScript.count = 0;
            }
            fork1 = false;
        }
        if (fork && gameObjects[8].active == false && gameObjects[9].active == false)
        {
            gameObjects[8].SetActive(true);
            gameObjects[9].SetActive(true);
        }

        if (gameObjects[10].active == true && gameObjects[11].active == true)
        {
            milk = true;
            if (milk1)
            {
                countScript.count = 0;
            }
            milk1 = false;
        }
        if (milk && gameObjects[10].active == false && gameObjects[11].active == false)
        {
            gameObjects[10].SetActive(true);
            gameObjects[11].SetActive(true);
        }

        if (gameObjects[12].active == true && gameObjects[13].active == true)
        {
            shampoo = true;
            if (shampoo1)
            {
                countScript.count = 0;
            }
            shampoo1 = false;
        }
        if (shampoo && gameObjects[12].active == false && gameObjects[13].active == false)
        {
            gameObjects[12].SetActive(true);
            gameObjects[13].SetActive(true);
        }

        if (gameObjects[14].active == true && gameObjects[15].active == true)
        {
            soap = true;
            if (soap1)
            {
                countScript.count = 0;
            }
            soap1 = false;
        }
        if (soap && gameObjects[14].active == false && gameObjects[15].active == false)
        {
            gameObjects[14].SetActive(true);
            gameObjects[15].SetActive(true);
        }

        if (gameObjects[16].active == true && gameObjects[17].active == true)
        {
            tb = true;
            if (tb1)
            {
                countScript.count = 0;
            }
            tb1 = false;
        }
        if (tb && gameObjects[16].active == false && gameObjects[17].active == false)
        {
            gameObjects[16].SetActive(true);
            gameObjects[17].SetActive(true);
        }

        if (gameObjects[18].active == true && gameObjects[19].active == true)
        {
            towel = true;
            if (towel1)
            {
                countScript.count = 0;
            }
            towel1 = false;
        }
        if (towel && gameObjects[18].active == false && gameObjects[19].active == false)
        {
            gameObjects[18].SetActive(true);
            gameObjects[19].SetActive(true);
        }
    }
}
