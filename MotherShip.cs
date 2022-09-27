using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherShip : MonoBehaviour
{
    Inventory inv;
    Inventory shipInv;
    Timer timer = new Timer(0.2f);
    // Start is called before the first frame update
    void Start()
    {
        inv = FindObjectOfType<GameManager>().GlobalInventory;
        timer.Start();
    }

    private void Update()
    {
        if (shipInv == null) return;
        if (!timer.IsAndRestart()) return;
        if (!shipInv.RemoveCow()) return;
        inv.AddCow();
    }
    private void OnTriggerEnter(Collider other)
    {
        other.TryGetComponent<Inventory>(out shipInv);
    }
    private void OnTriggerExit(Collider collision)
    {
        Debug.Log("Salir");
        shipInv = null;
    }
}
