using UnityEngine;

// !! IMPORTANT !!
// Make sure your Animator component is set to Update Mode -> Animate Physics
// This will keep animations in sync with stop motion effec that runs on FixedUpdate with physics


public class FakeStopMotion : MonoBehaviour
{
    public Animator Animator;
    public int FPS = 8;
    private float _time;

    void FixedUpdate()
    {
        _time += Time.fixedDeltaTime;
        var updateTime = 1f / FPS;
        Animator.speed = 0;

        if (_time > updateTime)
        {
            _time -= updateTime;
            Animator.speed = 60f / FPS;
        }
    }
}