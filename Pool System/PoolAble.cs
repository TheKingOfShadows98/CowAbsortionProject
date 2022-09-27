using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TK.Pool{ 
    public class PoolAble : MonoBehaviour, IPoolAble
    {
        public Pool parentPool;
        public GameObject GetGameObject() => gameObject;
        public virtual void Release()
        {
            throw new System.NotImplementedException();
        }

        public virtual void Restart()
        {
            throw new System.NotImplementedException();
        }

    }
}
