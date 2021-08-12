using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]GameObject Player,Panel;
    public AudioSource audioSource;
    public AudioClip claps;
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        Panel = GameObject.Find("Panel");
        Panel.SetActive(false);
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
              audioSource.PlayOneShot(claps);
              Panel.SetActive(true);
            Destroy(Player);
         
            
        }
    }
}
