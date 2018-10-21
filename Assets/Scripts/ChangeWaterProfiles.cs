using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class ChangeWaterProfiles : MonoBehaviour {

    public PostProcessingProfile normal, underwater;

    private PostProcessingBehaviour cameraImage;

	// Use this for initialization
	void Start () {
        cameraImage = FindObjectOfType<PostProcessingBehaviour>();
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            cameraImage.profile = underwater;
            Debug.Log("Underwater");
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            cameraImage.profile = normal;
        }
    }
}
