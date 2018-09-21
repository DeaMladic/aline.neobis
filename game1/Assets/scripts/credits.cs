using UnityEngine;
using UnityEngine.SceneManagement;


public class credits : MonoBehaviour {

	public void StartGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
