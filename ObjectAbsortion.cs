using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TK.Pool;
public class ObjectAbsortion : MonoBehaviour
{
    [SerializeField] float process;
    [SerializeField] float maxProcess;
    [SerializeField] bool inAbsortion;
    [SerializeField] LayerMask TracktorTriggerName;
    [SerializeField] GameManager gameManager;
    PoolAble root;
    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        if (!TryGetComponent<PoolAble>(out root)) Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        Detection();
        Process();
    }
    private void OnEnable()
    {
        process = 0;
    }

    private void Process()
    {
        process = inAbsortion ? process + Time.deltaTime : process - Time.deltaTime * 2;
        process = process > maxProcess ? maxProcess : process < 0 ? 0 : process;
        if (process >= maxProcess)
        {
            gameManager.Ovni.AddCow();
            root.Release();
        }
        transform.localScale = Vector3.Lerp(transform.localScale, Vector3.one * ((maxProcess - process) / maxProcess), Time.deltaTime * 3);
    }

    private void Detection()
    {
        inAbsortion = Physics.CheckBox(transform.position, Vector3.one, Quaternion.identity, TracktorTriggerName);
        inAbsortion = inAbsortion && !gameManager.Ovni.IsFull();
    }
}
