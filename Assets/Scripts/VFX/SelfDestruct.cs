using UnityEngine;

public sealed class SelfDestruct : MonoBehaviour {
	private float selfdestruct_in = 1.2f; 

	private void Start () {
		if ( selfdestruct_in != 0){ 
			Destroy (gameObject, selfdestruct_in);
		}
	}
}