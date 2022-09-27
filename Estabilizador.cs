using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estabilizador : MonoBehaviour
{
    [SerializeField] float height = 5;
    float maxDistanceDetector = 100;
    float speed = 3;
    [SerializeField] LayerMask groundMask;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit[] hits;
        hits = Physics.RaycastAll(new Ray(transform.position, Vector3.down), maxDistanceDetector, groundMask);
        if (hits.Length < 1) return;
        Vector3 position = new Vector3(transform.position.x, hits[0].point.y + height, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, position, speed * Time.deltaTime);
    }
}
