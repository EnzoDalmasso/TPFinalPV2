using System.Collections.Generic;
using UnityEngine;

public class ObjectCollector : MonoBehaviour
{
    public List<GameObject> collectibles;
    private int collectedCount;

    public int CollectedCount { get => collectedCount; }


    private void Awake()
    {
        collectibles = new List<GameObject>();
    }
    void Start()
    {
        collectedCount = 0;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        
        if (collider.gameObject.CompareTag("Coleccionable"))
        {
            collectedCount++;
            collectibles.Remove(collider.gameObject);
            Destroy(collider.gameObject);
            Debug.Log("Objetos coleccionados: " + collectedCount);
            
        }
        
    }
}