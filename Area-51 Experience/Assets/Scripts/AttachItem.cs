using Leap.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CapsuleHand))]
public class AttachItem : MonoBehaviour
{

	private CapsuleHand hand;

	[SerializeField]
	private GameObject AttachedObjectPrefab;
	[SerializeField]
	private Quaternion rotationOffset;
	[SerializeField]
	private Vector3 positionOffset;
	private GameObject attachedObject;

	

	// Start is called before the first frame update
	void Start()
    {
		hand = GetComponent<CapsuleHand>();
		attachedObject = Instantiate(AttachedObjectPrefab, transform);
	}

    // Update is called once per frame
    void Update()
    {
        if(attachedObject != null) {
			Debug.Log(hand.GetLeapHand().PalmPosition.ToVector3());
			attachedObject.transform.position = hand.GetLeapHand().PalmPosition.ToVector3() + positionOffset;
			attachedObject.transform.rotation = hand.GetLeapHand().Rotation.ToQuaternion() * rotationOffset;
		}
    }
}
