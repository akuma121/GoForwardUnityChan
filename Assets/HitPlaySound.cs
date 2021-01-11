using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPlaySound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public AudioClip sound;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag != "UnityChan2D")
        {
            GetComponent<AudioSource>().Play();
        }
    }
        // Update is called once per frame
        void Update()
    {
        
    }
}
