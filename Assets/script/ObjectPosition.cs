using UnityEngine;
using System.Collections;

public class ObjectPosition : MonoBehaviour {
	GoogleStaticMap mainMap;
	public GameObject PlayingCard_Revers;

	public float lat_d = 0.0f, lon_d = 0.0f;

	private GeoPoint pos;


	void Awake (){
		pos = new GeoPoint ();
		pos.setLatLon_deg (lat_d, lon_d);
	//	InvokeRepeating("Start", 2.0f, 2.0f);
	
	}
	void Start () {

		for (int x = 0; x < 5; x++) {
		//オブジェクトの座標
		float lat_d = Random.Range(-10.0f, 10.0f);
		float lon_d = Random.Range(-10.0f, 10.0f);

			//オブジェクトを生産
			Instantiate (PlayingCard_Revers, new Vector3 (lat_d, 0, lon_d), Quaternion.identity);
		}

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
