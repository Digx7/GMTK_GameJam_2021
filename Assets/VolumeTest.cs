using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class VolumeTest : MonoBehaviour
{

    [SerializeField] private Volume v;
    [SerializeField] private Bloom b;
    [SerializeField ]private Vignette vg;
    // Start is called before the first frame update
    void Start()
    {
        v = GetComponent<Volume>();
        v.profile.TryGet(out b);
        v.profile.TryGet(out vg);
    }

    [ContextMenu("test")]
    private void Test()
    {
        b.scatter.value = 0.1f;
        vg.intensity.value = 0.5f;
    }

}
