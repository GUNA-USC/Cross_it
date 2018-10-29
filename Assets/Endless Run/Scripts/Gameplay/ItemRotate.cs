/// <summary>
/// Item rotate.
/// this script use for rotate item
/// </summary>

using UnityEngine;
using System.Collections;

public class ItemRotate : MonoBehaviour {
	
	public void PlayCoin(){
		GetComponent<Animation>().Play("CoinAnimation");
	}	
	
	public void Reset(){
		GetComponent<Animation>().Stop();
	}
	
}
