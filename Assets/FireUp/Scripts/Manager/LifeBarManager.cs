using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace FireUp.Scripts.Manager
{
    public class LifeBarManager : MonoBehaviour
    {
        [SerializeField]
        private Image _healthBar;

        [SerializeField] private PlayerHealthManagerScript _playerHealthManagerScript;
        
        void Update()
        {
            SetupHealthBar();
        }

        void SetupHealthBar()
        {
            float newHealth = _playerHealthManagerScript.GetLifePlayer()/100;

            _healthBar.fillAmount = newHealth;
        }
    }
}
