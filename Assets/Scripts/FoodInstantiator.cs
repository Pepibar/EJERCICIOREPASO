using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
public class FoodInstantiator : MonoBehaviour
{
    public GameObject[] alimentos;
    public Transform clonePoint;
    public float interval;
    public RandomPlacement lugarRndm;
    public int maxclones;
    public int clonecount;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(CloneFood),0,interval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CloneFood()
    {
        if (clonecount<maxclones)
        {
       clonecount++;
        lugarRndm.SetRandomPosition();
        GameObject prefab = alimentos[Random.Range(0,alimentos.Length)];
        Instantiate(prefab, clonePoint.position, clonePoint.rotation);
        }
 
    }
}
