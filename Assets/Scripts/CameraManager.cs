using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{

    public GameObject[] camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1)) {
            camera[0].SetActive(true);
            camera[1].SetActive(false);
            camera[2].SetActive(false);
        }

                if (Input.GetKeyDown(KeyCode.W)) {
            camera[0].SetActive(false);
            camera[1].SetActive(true);
            camera[2].SetActive(false);
        }

                if (Input.GetKeyDown(KeyCode.F3)) {
            camera[0].SetActive(false);
            camera[1].SetActive(false);
            camera[2].SetActive(true);
        }
    }
}
