﻿using UnityEngine;
using System.Collections;
public class MiniMap : MonoBehaviour {
	GUITexture mapGuiTexture;
	private float intervalTime = 0.0f;
	private int width = 300;
	private int height = 200;
	private double longitude;
	private double latitude;
	private int zoom = 16;
	void Start () {
		mapGuiTexture = this.GetComponent<GUITexture> ();
		GetPos ();
		GetMap();
	}
	void Update(){
		//毎フレーム読んでると処理が重くなるので、3秒毎に更新
		intervalTime += Time.deltaTime;
		if (intervalTime >= 3.0f) {
			GetPos ();
			GetMap ();
			intervalTime = 0.0f;
		}
	}
	void GetPos () {
		
		StartCoroutine (GetGPS());
		longitude = Input.location.lastData.longitude;
		latitude = Input.location.lastData.latitude;
	}
	void GetMap () {

		StartCoroutine(GetStreetViewImage(latitude, longitude, zoom));
	}
	private IEnumerator GetGPS() {
		if (!Input.location.isEnabledByUser) {
			yield break;
		}
		Input.location.Start();
		int maxWait =  120;
		while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0) {
			yield return new WaitForSeconds(1);
			maxWait--;
		}
		if (maxWait < 1) {
			print("Timed out");
			yield break;
		}
		if (Input.location.status == LocationServiceStatus.Failed) {
			print("Unable to determine device location");
			yield break;
		} else {
			print("Location: " + 
				Input.location.lastData.latitude + " " + 
				Input.location.lastData.longitude + " " + 
				Input.location.lastData.altitude + " " + 
				Input.location.lastData.horizontalAccuracy + " " + 
				Input.location.lastData.timestamp);
		}
		Input.location.Stop();
	}
	private IEnumerator GetStreetViewImage(double latitude, double longitude, double zoom) {

		string url = "http://maps.googleapis.com/maps/api/staticmap?center=" + latitude + "," + longitude + "&zoom=" + zoom + "&size=" + width + "x" + height + "&markers=size:mid%7Ccolor:red%7C" + latitude + "," + longitude;
		WWW www = new WWW(url);
		yield return www;

		mapGuiTexture.texture = www.texture;

		mapGuiTexture.color = new Color (mapGuiTexture.color.r, mapGuiTexture.color.g, mapGuiTexture.color.b, 0.4f);
	}
}