/*==============================================================================
Copyright (c) 2012-2013 QUALCOMM Austria Research Center GmbH.
All Rights Reserved.
==============================================================================*/
using UnityEngine;
using System.Collections;

/// <summary>
/// Splash screen manager.
/// 
/// Draws a SplashScreen with AutoRotation enabled
/// using a GUI Texture for different devices.
/// After 2 seconds of visibility it calls the
/// AboutScreen Scene.
/// </summary>
public class splash : MonoBehaviour
{
    #region PUBLIC_MEMBER_VARIABLES

    public GameObject MainMenu;

    public Texture PortraitTextureAndroid;
    public Texture LandscapeTextureAndroid;

	//menentukan n detik
    public float SecondsVisible = 0.5f;

    #endregion // PUBLIC_MEMBER_VARIABLES



    #region UNITY_MONOBEHAVIOUR_METHODS
    
    void Start ()
    {
		// Pada Unity 4 Android, yang pertama ~ 3.5sec tidak ada yang diberikan ...
        // on Unity 4 Android, the first ~3.5sec nothing is rendered...
        if ((Application.platform == RuntimePlatform.Android) && (int.Parse(Application.unityVersion.Substring(0, 1)) >= 4))
            SecondsVisible += 0.5f;
		// Membuka Halaman About Setelah N detik
        // Loads the About Scene after N seconds
        Invoke("LoadAboutScene", SecondsVisible);
    }

    void OnGUI()
    {
       // if (QCARRuntimeUtilities.IsLandscapeOrientation)
       // {
        //    GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), LandscapeTextureAndroid);
       // }
        //else
        //{
           GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), PortraitTextureAndroid);
        //}
    }

    #endregion // UNITY_MONOBEHAVIOUR_METHODS



    #region PRIVATE_METHODS

    /// <summary>
    /// Loads the about scene.
    /// </summary>
    private void LoadAboutScene()
    {
        //Application.LoadLevel("MainMenu");
        this.gameObject.SetActive(false);
        MainMenu.SetActive(true);
    }

    #endregion // PRIVATE_METHODS
}
