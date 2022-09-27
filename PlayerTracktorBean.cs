using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTracktorBean : MonoBehaviour
{
    [SerializeField] string input;
    bool Active;
    [SerializeField] GameObject target;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Active = Input.GetButton(input);
        if (Active) Debug.Log("A");
        target.SetActive(Active);
    }
}
