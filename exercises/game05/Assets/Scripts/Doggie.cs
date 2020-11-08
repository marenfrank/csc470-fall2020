using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Doggie : MonoBehaviour
{

	GameManager gm;
	public string unitName;
	public int health = 100;

	public float speed = 2f;
	public float directionChangeInterval = 4f;
	public float maxHeadingChange = 30f;

	CharacterController controller;
	public Renderer rend;

	float spin;
	Vector3 targetRotation;

	public bool selected = false;
    void Start()
    {
		gm = GameObject.Find("SelectionManagerObject").GetComponent<GameManager>();
	}
    
	

void Awake()
	{
		controller = GetComponent<CharacterController>();

		// Set random initial rotation
		spin = Random.Range(0, 360);
		transform.eulerAngles = new Vector3(0, spin, 0);
		
		StartCoroutine(NewHeading());
	}

	void Update()
	{
		
		transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, targetRotation, Time.deltaTime * directionChangeInterval);
		var forward = transform.TransformDirection(Vector3.forward);
		controller.SimpleMove(forward * speed);

		
	}

	
	IEnumerator NewHeading()
	{
		while (true)
		{
			NewHeadingRoutine();
			yield return new WaitForSeconds(directionChangeInterval);
		}
	}

	
	void NewHeadingRoutine()
	{
		var floor = Mathf.Clamp(spin - maxHeadingChange, 0, 360);
		var ceil = Mathf.Clamp(spin + maxHeadingChange, 0, 360);
		spin = Random.Range(floor, ceil);
		targetRotation = new Vector3(0, spin, 0);
	}

	
}

