using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController1 : MonoBehaviour
{
    public Text scoreValue;
    int score;

    // Start is called before the first frame update
    void Start()
    {    
    }

    // Update is called once per frame
    void Update()
    {
        scoreValue.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Food"))
        {
            SoundManager.PlaySFX("touch");
            Destroy(collision.gameObject);
            score++;

        }
    } 
}
