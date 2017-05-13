using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyObject : MonoBehaviour {
	GoogleStaticMap mainMap;

	public float lat_d = 0.0f, lon_d = 0.0f;

	private GeoPoint pos;


	void Awake (){
		pos = new GeoPoint ();
		pos.setLatLon_deg (lat_d, lon_d);
		InvokeRepeating("Start", 2.0f, 2.0f);
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void setPositionOnMap () {
		Vector2 tempPosition = GameManager.Instance.getMainMapMap ().getPositionOnMap (this.pos);
		transform.position = new Vector3 (tempPosition.x, transform.position.y, tempPosition.y);
	}

	public void setPositionOnMap (GeoPoint pos) {
		this.pos = pos;
		setPositionOnMap ();
	}

}


