using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] string horizontal;
    [SerializeField] string vertical;
    [SerializeField] float speed;


    // Update is called once per frame
    void Update()
    {
        Vector3 dir = new Vector3(Input.GetAxis(horizontal),0, Input.GetAxis(vertical));
        dir *= speed * Time.deltaTime;
        Vector3 position = transform.position;
        position += dir;
        transform.position = position;
    }
}
