using UnityEngine;
using System.Collections;
public class WebCam : MonoBehaviour {
	public int Width = 1920;
	public int Height = 1080;
	public int FPS = 20;
	void Start () {
		WebCamDevice[] devices = WebCamTexture.devices;
		WebCamTexture webcamTexture = new WebCamTexture(devices[0].name, Width, Height, FPS);
		GetComponent<Renderer> ().material.mainTexture = webcamTexture;
		webcamTexture.Play();
	}
}