using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SceneController : SingletonBehaviour<SceneController>
{
    public TextMeshProUGUI message;
    private GameObject model;
    private float maxAngle = 30f;

    public void Start()
    {
        message.text = "Start application. Looking for marker...";
    }

    public void OnObjectSpawned(GameObject obj)
    {
        model = obj;
    }

    public void Update()
    {
        if (model == null)
        {
            return;
        }

        var vec = model.transform.position - Camera.main.transform.position;
        var angle = Mathf.Abs(Vector3.Angle(Camera.main.transform.forward, vec));
        if (angle > maxAngle)
        {
            message.text = "Marker is lost";
        }
        else
        {
            message.text = "Marker is found";
        }
    }
}
