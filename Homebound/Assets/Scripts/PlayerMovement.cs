using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class PlayerMovement : MonoBehaviour
{

	[SerializeField]
	private int movementSpeed = 5;

	[SerializeField]
	private GameObject cameraHeadObject;


	public VRTK_ControllerEvents controllerEvents;



	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		Vector3 moveAmount = Time.deltaTime * ((controllerEvents.GetTouchpadAxis().x * movementSpeed * cameraHeadObject.transform.right) + (controllerEvents.GetTouchpadAxis().y * movementSpeed * cameraHeadObject.transform.forward));
		moveAmount.y = 0;
		transform.position += moveAmount;//Debug.Log();
	}
}
