using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TK.Pool;
public class Cow : PoolAble
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnEnable()
    {
        transform.rotation = Quaternion.Euler(Vector3.up * Random.Range(0, 360f));
    }
    public override void Restart()
    {
        transform.localScale = Vector3.one;
        
    }
    public override void Release()
    {
        gameObject.SetActive(false);
    }


}
