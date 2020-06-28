using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer volMixer;
    public Slider volSlider;
    public Dropdown resDrop;
    public Toggle fullScreenToggle;
    private int screenInt;
    Resolution[] resolutions;
    private bool isFullscreen = false;
    const string prefname = "optionvalue";
    const string resname = "resolutionoption";
    void Awake()
    {
        screenInt = PlayerPrefs.GetInt("togglestate");
        if (screenInt == 1)
        {
            isFullscreen = true;
            fullScreenToggle.isOn = true;
        }
        else
        {
            fullScreenToggle.isOn = false;
        }
    
        resDrop.onValueChanged.AddListener(new UnityAction<int>(index =>
        {
        PlayerPrefs.SetInt(resname, resDrop.value);
        PlayerPrefs.Save();
        }));
    }
    // Update is called once per frame
    void Start()
    {
        volSlider.value = PlayerPrefs.GetFloat("MVolume", 1f);
        volMixer.SetFloat("volume", PlayerPrefs.GetFloat("MVolume"));
        resolutions = Screen.resolutions;
        resDrop.ClearOptions();
        List<string> options = new List<string>();
        int currentresID = 0;
        for(int i=0;i<resolutions.Length;i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height + " " + resolutions[i].refreshRate + "Hz";
            options.Add(option);
            if (resolutions[i].width == Screen.currentResolution.width &&
               resolutions[i].height == Screen.currentResolution.height &&
               resolutions[i].refreshRate == Screen.currentResolution.refreshRate)
            {
                currentresID = i;
            }
        }
        resDrop.AddOptions(options);
        resDrop.value = PlayerPrefs.GetInt(resname, currentresID);
        resDrop.RefreshShownValue(); 
    }
    public void SetResolution(int resolutionID)
    {
        Resolution resolution = resolutions[resolutionID];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
    public void ChangeVol(float volume)
    {
        PlayerPrefs.SetFloat("MVolume", volume);
        if (volume == -35)
        {
            PlayerPrefs.SetFloat("MVolume", -80);
            volMixer.SetFloat("volume", PlayerPrefs.GetFloat("MVolume"));
        }
        
        else
        {
            volMixer.SetFloat("volume", PlayerPrefs.GetFloat("MVolume"));
        }
        PlayerPrefs.Save();
    }
    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
        if(isFullscreen==false)
        {
            PlayerPrefs.SetInt("togglestate", 0);
        }
        else
        {
            isFullscreen = false;
            PlayerPrefs.SetInt("togglestate", 1);
        }
    }
}
