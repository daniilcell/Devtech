using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

public class ImageTimer : MonoBehaviour
{
    public float MaxTime;
    public bool Tick;
    [SerializeField] private Image img;
    private float currentTime;
    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
        currentTime = MaxTime;
    }

    // Update is called once per frame
    void Update()
    {
        Tick = false;
        currentTime -= Time.deltaTime;
        
        if (currentTime <= 0)
            Tick = true;
            currentTime = MaxTime;
        img.fillAmount = currentTime / MaxTime;
    }
}
