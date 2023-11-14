using UnityEngine;

[ExecuteAlways]
public class PrefabExecuteAlways : MonoBehaviour
{
    private static int counter = 0;

    [SerializeField]
    private int count = 0;

    protected void Awake()
    {
        counter++;
        count = counter;
        Debug.Log($"ExecuteAlways Awake {this.name}, counter {counter}, count {count}");
    }

    protected void Start()
    {
        Debug.Log($"ExecuteAlways Start {this.name}, counter {counter}, count {count}");
    }

    protected void OnEnable()
    {
        Debug.Log($"ExecuteAlways OnEnable {this.name}, counter {counter}, count {count}");
    }

    protected void OnDisable()
    {
        Debug.Log($"ExecuteAlways OnDisable {this.name}, counter {counter}, count {count}");
    }

    protected void OnDestroy()
    {
        Debug.Log($"ExecuteAlways OnDestroy {this.name}, counter {counter}, count {count}");
    }
}
