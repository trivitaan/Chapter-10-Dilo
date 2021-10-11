using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip touchFood;
    static AudioSource AuSrc;
    // Start is called before the first frame update
    void Start()
    {
        touchFood = Resources.Load<AudioClip>("Touch");

        AuSrc = GetComponent<AudioSource>();        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySFX(string clip)
    {
        switch(clip)
        {
            case "touch":
                AuSrc.PlayOneShot(touchFood);
                break;
            default :
                break;
        }
    }
}
