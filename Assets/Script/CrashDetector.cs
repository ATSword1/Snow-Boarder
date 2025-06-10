using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] float delaySecond = 1f;
    [SerializeField] AudioClip crashSFX;
    bool hasCrash = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Ground"){
            FindFirstObjectByType<PlayerController>().DisableControl();
            if(!hasCrash)
            {
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            hasCrash = true;
            Invoke("ReloadScene",delaySecond);
            }
        }
    }
    void ReloadScene(){
        SceneManager.LoadScene(0);
    }
}
