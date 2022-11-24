using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> objects;
    public Camera arCamera;

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount >0)
        {
            Touch touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Began)
            {
                GameObject randomGO = objects[Random.Range(0, objects.Count)];
                Vector3 spawnPos = arCamera.ScreenToWorldPoint(new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, randomGO.transform.position.z));
                Instantiate(randomGO, spawnPos, randomGO.transform.rotation);
            }
        }
    }
}
