using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Inventory : MonoBehaviour
{
    [SerializeField] TextMeshPro label;
    public int Cows { get; private set; }
    [SerializeField] bool maxIsLimit = false;
    [SerializeField] int maxCows;
    public bool IsFull() => Cows == maxCows;
    private void Start()
    {
        Display();
    }
    private void Display()
    {
        if(label)
        label.text = $"{Cows}/{maxCows}";
    }

    public bool AddCow() {
            if(maxIsLimit && Cows == maxCows) return false;
        Cows++;
        Display();
        return true;
    }
    public bool RemoveCow()
    {
        if (Cows <= 0) return false;
        Cows--;
        Display();
        return true;
    }
}
