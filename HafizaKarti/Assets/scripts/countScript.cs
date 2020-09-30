using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countScript : MonoBehaviour
{
   public int count = 0;
    public GameObject[] gameObjects;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

        countla();
    }

   
    public void countla()
    {
        if (count == 3)
        {
            for (int i = 0; i < 20; i++)
            {

                gameObjects[i].SetActive(false);
                

            }
            count = 0;

        }
    }
}
