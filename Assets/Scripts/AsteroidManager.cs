using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidManager : MonoBehaviour
{
    public GameObject asteroide;
    public float limit_X = 10;
    public float limit_Y = 6;
    public int max = 2;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < max; i++)
        {
            Vector3 pos = new Vector3(Random.Range(-limit_X, limit_X), Random.Range(-limit_Y, limit_Y));
            GameObject temp = Instantiate(asteroide, pos, Quaternion.identity);
            temp.GetComponent<AsteroidController>().manager = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
