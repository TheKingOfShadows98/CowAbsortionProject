using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCC : MonoBehaviour
{
    [SerializeField] int index;

    public void ChangeScene()
    {
        SceneManager.LoadScene(index);
    }
}
