using UnityEngine;
using System.Collections;
//OnGUIの部分は今回は削除
public class CameraController : MonoBehaviour {
	// 自信のTransform, 毎フレーム参照すると無駄なので保持する
	Transform m_transform;

	// 調整値
	readonly Quaternion _BASE_ROTATION = Quaternion.Euler(90, 0, 0);

	void Start()
	{
		// サポートするかの確認
		if (!SystemInfo.supportsGyroscope)
		{
			Destroy( this );
			return;
		}

		m_transform = transform;
	}

	void Update ()
		{
			// ジャイロの値を獲得する
			Quaternion gyro = Input.gyro.attitude;
		// 自信の回転をジャイロを元に調整して設定する
			m_transform.localRotation = _BASE_ROTATION * (new Quaternion(-gyro.x, -gyro.y, gyro.z, gyro.w));
}
}