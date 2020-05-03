using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CargaLVL : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Cargarlevel(string nomlvl)
    {
        SceneManager.LoadScene(nomlvl);
    }
}
