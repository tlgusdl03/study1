using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    float timer = 0;
    public float timediff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer+=Time.deltaTime;
        if (timer > timediff)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = new Vector3(4, Random.Range(-0.37f,7.1f), 0);
            timer = 0;
            Destroy(newpipe, 10.0f);
        }
        
    }
}
