using UnityEngine;

public class SceneFading : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LevelFade(int levelIndex) {
        animator.SetTrigger("FadeOut");
    }
}
