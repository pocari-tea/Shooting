using Firebase;
using Firebase.Auth;
using Firebase.Extensions;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AuthManager : MonoBehaviour
{
    // 현재 앱을 실행하는 환경이 firebase를 구동할 수 있는 환경인지를 리턴하는 boolean property
    public bool IsFirebaseReady { get; private set; }
    // 현재 이미 로그인 과정이 진행중인지 표시하는 property
    public bool IsSignInOnProgress { get; private set; }

    public InputField emailField;
    public InputField passwordField;
    public Button signInBtn;

    public static FirebaseApp firebaseApp;
    public static FirebaseAuth firebaseAuth;

    public static FirebaseUser User;

    private void Start()
    {
        //클릭 못하게
        signInBtn.interactable = false;

        //firebase를 구동할 수 있는 환경인지 체크
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWithb (task =>
        {
            var result = task.Result;

            //구동 불가라면
            if (result != DependencyStatus.Available)
            {
                Debug.LogError(result.ToString());
                IsFirebaseReady = false;
            }
            else
            {
                IsFirebaseReady = true;

                //firebase앱의 전체적인 기능을 관리하는 오브젝트를 가져옴
                firebaseApp = FirebaseApp.DefaultInstance;
                firebaseAuth = FirebaseAuth.DefaultInstance;
                // firebaseAuth = FirebaseAuth.GetAuth(firebaseapp); 과 같다
            }

            signInBtn.interactable = IsFirebaseReady;
        });
    }

    public void SignIn()
    {

    }
}
