using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	public float speed;
	public Text countText;
	public Text winText;

	private Rigidbody rigibody;
	private int count;

	void Start()
	{
		rigibody = GetComponent<Rigidbody> ();
		count = 0;
		winText.text = "";
		SetText ();
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rigibody.AddForce (movement * speed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other)
	{
		//若接触到立方体就把立方体隐身
		if (other.gameObject.tag == "PickUps")
		{
			other.gameObject.SetActive (false);
			count++;
			SetText();
		}
	}

	void SetText()
	{
		countText.text = "Count:" + count.ToString ();
		if (count >= 31)
			winText.text = "You Win!";
	}
}
