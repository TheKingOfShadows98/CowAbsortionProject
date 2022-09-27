using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Timer
{
    [SerializeField]  private float timeEnd;
    public float Cd;
    public bool Active = false;

    [SerializeField] public float TimeLeft
    {
        get
        {
            if (!Active) return 0;
            return timeEnd - Time.time;
        }
        set { }

    }
    public bool IsEnd() {
        var val = Time.time >= timeEnd;
        if(val) Active = false;
        return val;
    }
    public bool IsAndRestart()
    {
        if (!Active) return false;
        bool valid = IsEnd();
        if (valid) Start();
        return valid;
    }
    public void Stop()
    {
        Active = false;
    }
    /// <summary>
    /// Start The Timer. <para></para>
    /// cd To defaultCd [Cd]
    /// </summary>
    /// <param name="cd"> cd = -1 To defaultCd [Cd]</param>
    public void Start(float cd = -1)
    {
        if (Active) return;
        Active = true;
        cd = cd < 0 ? Cd : cd;
        timeEnd = Time.time + cd;
    }
    public Timer(float defaultCd = 1)
    {
        Cd = defaultCd;
    }

}
