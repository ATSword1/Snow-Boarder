using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] ParticleSystem finishEffect;
    [SerializeField] float delaySecond = 1f;
    [SerializeField] AudioClip finishSFX;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            finishEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(finishSFX);
            Invoke("ReloadScene",delaySecond);
        }
    }
    void ReloadScene(){
        SceneManager.LoadScene(0);
    }
}
