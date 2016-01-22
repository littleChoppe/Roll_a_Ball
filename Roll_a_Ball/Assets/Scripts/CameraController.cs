using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;

	//offset记录的是摄像机与物体的距离
	private Vector3 offset;
	// Use this for initialization
	void Start () 
	{
		//由于物体开始时在原点，所以摄像机与物体的距离与摄像机的坐标相等
		offset = transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () 
	{
		transform.position = player.transform.position + offset;
	}
}
