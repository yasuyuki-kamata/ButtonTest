using UnityEngine;
using System.Collections;

public class MoveSampleController : MonoBehaviour
{
	private Animator anim;
	private int param;

	void Start () {
		anim = GameObject.Find ("Button2").GetComponent<Animator> ();
		param = Animator.StringToHash ("isEnable");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			anim.SetBool(param,  !anim.GetBool(param));
		}
	}
}
