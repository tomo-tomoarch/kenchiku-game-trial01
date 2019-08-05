using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiatetest : MonoBehaviour
{
    public GameObject original;
    public int j;
        
        // Start is called before the first frame update
    void Start()
    {
        int i;
        int k;
        int l;

        for (i = 0; i < j; i++)
        {
            k = Random.Range(1, j);
            l = Random.Range(1, j);

            Vector3 position = new Vector3(l, k, i);
            Instantiate(original, position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        
}
