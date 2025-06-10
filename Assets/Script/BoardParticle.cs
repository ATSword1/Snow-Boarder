using UnityEngine;

public class BoardParticle : MonoBehaviour
{
    [SerializeField] ParticleSystem boardParticle;
    CapsuleCollider2D board;
    bool contract;
     void Start() {
        board = GetComponent<CapsuleCollider2D>();
    }
    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Ground"){
            boardParticle.Play();
        }
    }
    void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.tag == "Ground"){
            boardParticle.Stop();
        }
    }
}
