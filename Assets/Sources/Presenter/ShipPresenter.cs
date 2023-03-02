using UnityEngine;

public class ShipPresenter : Presenter
{
    private Root _init;

    public void Init(Root init) => _init = init;

    public void Deactivate() => gameObject.SetActive(false);

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            _init.Ship.DecreaseHealth(Asteroids.Model.Config.EnemyDamage);
        }
    }
}
