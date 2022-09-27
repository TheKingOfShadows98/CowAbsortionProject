using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TK.Pool
{

    public interface IPoolAble
    {
        public void Restart();
        public GameObject GetGameObject();
        public void Release();
    }
}
