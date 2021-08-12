using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableOrDisableWall : MonoBehaviour
{
    // Start is called before the first frame update
     [SerializeField]float timer;
     public GameObject wall;
    void Start()
    {
        timer = 0;
     
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
        if(timer < 1)
        {
          wall.SetActive(true);
        }
        if(timer >=1)
        {
            
          wall.SetActive(false);
            
        }

        if (timer >= 3)
        {
            timer = 0;
        }
        
    }
}
