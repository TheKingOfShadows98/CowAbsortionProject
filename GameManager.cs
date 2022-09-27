using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Timer timer = new Timer(10);
    [field: SerializeField] public Inventory GlobalInventory { get; private set; }
    [field: SerializeField] public Inventory Ovni { get; private set; }
    void Start()
    {

        DontDestroyOnLoad(gameObject);
        timer.Start(10);
    }

    // Update is called once per frame
    void Update()
    {
        int time = Mathf.FloorToInt(timer.TimeLeft);
        if(timer.IsEnd())
        Debug.LogWarning("ALTO");
    }
}
