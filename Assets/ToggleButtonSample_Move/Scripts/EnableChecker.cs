using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class EnableChecker : MonoBehaviour
{
	private Animator anim;
	private Text text;

	void Start () {
		anim = GameObject.Find ("Button2").GetComponent<Animator>();
		text = GetComponent<Text> ();
	}

	void Update () {
		ApplyText ();
	}

	public void ApplyText () {
		text.text = anim.GetBool ("isEnable").ToString();
	}
}
