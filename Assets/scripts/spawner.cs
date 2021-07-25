using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    // Start is called before the first frame update
    private float maxX = 2.6f;
    private float minX = -2.6f;

    public GameObject bombPrefab;
    void Start()
    {
        StartCoroutine(spawnBombs());
    }

    IEnumerator spawnBombs()
    {
        yield return new WaitForSeconds(Random.RandomRange(0f, 1f));
        Instantiate(bombPrefab, new Vector2(Random.Range(minX, maxX), transform.position.y), Quaternion.identity);

        StartCoroutine(spawnBombs());

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
