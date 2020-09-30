using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardScript : MonoBehaviour
{
    public new GameObject gameObject;
    public countScript countScript;
 
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [System.Obsolete]
    public void OnMouseDown()
    {
        if (!gameObject.active == true)
        {
            gameObject.SetActive(true);            
            countScript.count++;
            
        }
      

    }
}
