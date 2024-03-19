using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesMenager : MonoBehaviour
{
    public GameObject pipeModel;
    public Transform spawnPoint;
    public float interval;

    private float currentTime = 0;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime > interval)
        {
            CreatPipe();
            currentTime = 0f;
        }
        
    }

    void CreatPipe()
    {
        var pipeGameObjetc = Instantiate(pipeModel);
        var pipeTransform = pipeGameObjetc.GetComponent<Transform>();

        float y = Random.Range(-1.728f, 0.385f);

        pipeTransform.position = new Vector3(spawnPoint.position.x, y);
    }
}
