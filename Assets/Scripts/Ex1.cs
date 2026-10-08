using UnityEngine;

public class Ex1 : MonoBehaviour
{
    public Character character = new Character(2);
    
    [ContextMenu("Damage")] 
        public void Damage()
    {
        character.Health--;
        Debug.Log("The Character takes 1 damage");
    }
    
    private void Update()
    {
        if (character.IsDead)
        {
            Debug.Log("The Character is Dead !");
        }
    }
}
    
  public class Character
  {
      public bool IsDead { get; private set; }
    
      private int _health;
    
      public int Health
      {
          get
          {
              return _health;
          }
          set
          {
              _health = value;
    
              if (_health <= 0)
              {
                        IsDead = true;
              }
          }
      }
    
      public Character(int health)
      {
          _health = health;
      }
}