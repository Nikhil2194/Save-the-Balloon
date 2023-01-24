using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeSpawner : MonoBehaviour
{
    public float maxTime = 1f;
    public float timer =0;
    public GameObject Spike;
    public float height;
   
    void Start()
    {
        
    }

    
    void Update()
    {
        if(timer>maxTime)
        {
            GameObject newSpike = Instantiate(Spike);
            newSpike.transform.position = transform.position + new Vector3(Random.Range(2,4.9f), Random.Range(-height, height), 0);
            Destroy(newSpike, 15f);
            timer = 0;
        
        }
        timer += Time.deltaTime;
       
        //if (timer < maxTime)
        //{
        //    timer += 1;
        //}
    }


    public void MainMenu()
    {
        SceneManager.LoadScene("Start");     
    }
}
