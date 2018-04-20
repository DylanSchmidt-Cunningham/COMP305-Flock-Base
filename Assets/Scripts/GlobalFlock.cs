using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalFlock : MonoBehaviour {

    public GameObject boidPrefab;
    public static int skySize = 5;

    public static int numBoids = 30;
    public static GameObject[] allBoids = new GameObject[numBoids];

	// Use this for initialization
	void Start () {
		for(int i = 0; i < numBoids; i++)
        {
            Vector3 pos = new Vector3(Random.Range(-skySize, skySize),
                                      Random.Range(-skySize, skySize),
                                      0);
            allBoids[i] = (GameObject)Instantiate(boidPrefab, pos, Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
