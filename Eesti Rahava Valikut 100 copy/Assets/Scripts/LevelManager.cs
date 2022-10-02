using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
public static LevelManager Instance;

[SerializeField] private GameObject loaderCanves;
[SerializeField] private Image progressBar;
private float target;

    void Awake()
    {
        if(Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            
        } else {
            
            Destroy(gameObject);
        }
    }

 public async void LoadScene (string sceneName) {
    target = 0;
    progressBar.fillAmount = 0;

    var scene = SceneManager.LoadSceneAsync(sceneName);
    scene.allowSceneActivation = false;

    loaderCanves.SetActive(true);

    do {
        await Task.Delay(100);

        target = scene.progress;
    } while(scene.progress < 0.9f);

    await Task.Delay(1000);
    
    scene.allowSceneActivation = true;
    loaderCanves.SetActive(false);
    }

void Update() {
    
    progressBar.fillAmount = Mathf.MoveTowards(progressBar.fillAmount, target, 3 * Time.deltaTime);
}

}
