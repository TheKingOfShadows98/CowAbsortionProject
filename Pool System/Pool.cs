using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


namespace TK.Pool
{
    public class Pool : MonoBehaviour
    {
        IPoolAble prefab;
        List<GameObject> instances = new List<GameObject>();
        List<GameObject> availables = new List<GameObject>();

        int initialPool;


        private void Start()
        {
            StartPool();
        }

        void StartPool()
        {
            for (int i = 0; i < initialPool; i++)
            {
                CreateObject();
            }
        }

        GameObject CreateObject()
        {
            GameObject obj = Instantiate(prefab.GetGameObject());
            obj.SetActive(false);
            instances.Add(obj);
            availables.Add(obj);
            return obj;
        }

        public GameObject GetObject()
        {
            GameObject obj;
            if (availables.Count < 1)
                availables = instances.Where(x => !x.activeInHierarchy).ToList();
            if (availables.Count < 1) obj = CreateObject();
            else
            {
                obj = availables[0];
                availables.RemoveAt(0);
            }
            obj.GetComponent<IPoolAble>().Restart();
            return obj;
        }

        public void ReleaseObject(IPoolAble item)
        {
            GameObject obj = item.GetGameObject();
            item.Release();
            obj.SetActive(false);
        }
        public void ReleaseAllObject()
        {
            instances.ForEach(x =>
            {
                x.GetComponent<IPoolAble>().Release();
                x.SetActive(false);
            });
        }
    }
}