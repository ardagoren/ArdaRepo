using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objeScript :MonoBehaviour
{
    public countScript countScript;
    public bool tik;
    public matchScript matchScript;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject == null)
        {
            Debug.Log("null");
        }
    }

    [System.Obsolete]
    private void OnMouseDown()
    {
        
        
        if (gameObject.active == true)
        {
            gameObject.SetActive(false);


            for (int i = 0; i < 20; i++)
            {
                countScript.gameObjects[i].SetActive(false);
            }
            countScript.count = 0;
        }

        

    }
}
