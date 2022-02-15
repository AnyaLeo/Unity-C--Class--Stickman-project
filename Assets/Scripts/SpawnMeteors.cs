using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class SpawnMeteors : MonoBehaviour
{
    BoxCollider2D box;
    Bounds bounds;

    public GameObject meteorPrefab;
    public float spawnTime = 1f;
    float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        box = GetComponent<BoxCollider2D>();
        bounds = box.bounds;
        currentTime = 0f;
    }

    void SpawnRandomMeteor()
    {
        // get a random position for the meteor
        float xRand = Random.Range(bounds.min.x, bounds.max.x);
        float yRand = Random.Range(bounds.min.y, bounds.max.y);
        Vector2 position = new Vector2(xRand, yRand);

        // create a meteor at that random position
        GameObject newMeteor = Instantiate(meteorPrefab, position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = currentTime + Time.deltaTime;
        if (currentTime > spawnTime)
        {
            currentTime = 0f;
            SpawnRandomMeteor();
        }
    }
}
