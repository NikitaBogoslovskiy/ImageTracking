using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public void Awake()
    {
        SceneController.instance.OnObjectSpawned(gameObject);
    }
}
