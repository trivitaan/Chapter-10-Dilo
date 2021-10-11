using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject box;
    private Vector2 screen;
    public float respawnTime = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        screen = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width - 70, Screen.height -70));
        StartCoroutine(spawnBox());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Spawn()
    {
        GameObject x = Instantiate(box) as GameObject;
        x.transform.position = new Vector2(Random.Range(-screen.x, screen.x), Random.Range(-screen.y, screen.y));
    }

    IEnumerator spawnBox()
    {
        while(true){
            yield return new WaitForSeconds(respawnTime);
            Spawn();
        }
    }
}
