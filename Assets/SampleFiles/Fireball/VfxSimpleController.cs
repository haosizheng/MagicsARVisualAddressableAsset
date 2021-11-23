using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class VfxSimpleController : MonoBehaviour
{
    VisualEffect vfx;

    public float reinitTime;
    float lastTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        vfx = GetComponent<VisualEffect>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastTime > reinitTime)
        {
            vfx.Reinit();
            lastTime = Time.time;
        }
        else
        {
            //do nothing
        }
    }
}
