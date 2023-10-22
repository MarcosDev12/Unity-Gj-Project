using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject itemPrefab;
    public float radius = 1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void SpawnObjectAtRandomPos()
    {
        Vector3 randomPos = Random.insideUnitCircle * radius;
        Instantiate(itemPrefab, randomPos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Backspace))
        {
            Debug.Log("ui");
            SpawnObjectAtRandomPos();
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;

        Gizmos.DrawWireSphere(this.transform.position, radius);
    }
}
