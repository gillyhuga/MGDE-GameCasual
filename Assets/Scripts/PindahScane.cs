using UnityEngine;
using UnityEngine.SceneManagement;

public class PindahScane : MonoBehaviour
{
 public void ChangeScene(string nama)
 {
  Application.LoadLevel(nama);
 }
}