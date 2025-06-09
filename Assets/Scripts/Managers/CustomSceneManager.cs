using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CustomSceneManager : MonoBehaviour
{
    public static CustomSceneManager Instance;

    [Header("Parametri di default per metodi UI")]
    public GameObject defaultLoadingScreen;
    public int defaultDelaySeconds = 2;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // --------------------------
    // METODI PRINCIPALI
    // --------------------------

    /// Cambio scena immediato
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    /// Cambio scena con delay
    public void ChangeSceneDelay(string sceneName, int delaySeconds)
    {
        StartCoroutine(ChangeSceneWithDelay(sceneName, delaySeconds));
    }

    private IEnumerator ChangeSceneWithDelay(string sceneName, int delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
    }

    /// Caricamento async con loading screen
    public void LoadSceneAsync(string sceneName, GameObject loadingScreen)
    {
        StartCoroutine(LoadSceneAsyncRoutine(sceneName, loadingScreen));
    }

    private IEnumerator LoadSceneAsyncRoutine(string sceneName, GameObject loadingScreen)
    {
        loadingScreen?.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);
        asyncLoad.allowSceneActivation = false;

        while (asyncLoad.progress < 0.9f)
        {
            yield return null;
        }

        yield return null; // Attendi 1 frame extra
        asyncLoad.allowSceneActivation = true;
    }

    /// Async con tempo minimo di caricamento
    public void LoadSceneAsyncDelay(string sceneName, GameObject loadingScreen, int delayMinSeconds)
    {
        StartCoroutine(LoadSceneAsyncWithMinDelay(sceneName, loadingScreen, delayMinSeconds));
    }

    private IEnumerator LoadSceneAsyncWithMinDelay(string sceneName, GameObject loadingScreen, int delayMin)
    {
        loadingScreen?.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);
        asyncLoad.allowSceneActivation = false;

        float timer = 0f;

        while (asyncLoad.progress < 0.9f)
        {
            timer += Time.deltaTime;
            yield return null;
        }

        while (timer < delayMin)
        {
            timer += Time.deltaTime;
            yield return null;
        }

        asyncLoad.allowSceneActivation = true;
    }

    // --------------------------
    // METODI WRAPPER PER UI
    // --------------------------

    /// Cambio scena da UI
    public void ChangeScene_UI(string sceneName)
    {
        ChangeScene(sceneName);
    }

    /// Cambio scena con delay da UI
    public void ChangeSceneDelay_UI(string sceneName)
    {
        ChangeSceneDelay(sceneName, defaultDelaySeconds);
    }

    /// Async con loading screen da UI
    public void LoadSceneAsync_UI(string sceneName)
    {
        LoadSceneAsync(sceneName, defaultLoadingScreen);
    }

    /// Async con delay minimo da UI
    public void LoadSceneAsyncDelay_UI(string sceneName)
    {
        LoadSceneAsyncDelay(sceneName, defaultLoadingScreen, defaultDelaySeconds);
    }
}
