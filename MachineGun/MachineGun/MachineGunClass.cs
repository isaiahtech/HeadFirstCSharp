using System;

public class MachineGunClass
{
	public const int MAGAZINE_SIZE = 16;

	private int bullets = 0;
	private int bulletsLoaded = 0;

	public int GetBulletsLoaded() { return bulletsLoaded; }

	public bool IsEmpty() { return bulletsLoaded == 0; }

	public int GetBullets() { return bullets; }

	public void SetBullets(int numberOfBullets)
    {
		if (numberOfBullets > 0)
			bullets = numberOfBullets;
		Reload();
    }

	public void Reload()
    {
		if (bullets > MAGAZINE_SIZE)
			bulletsLoaded = MAGAZINE_SIZE;
		else
			bulletsLoaded = bullets;
    }

	public bool Shoot()
    {
		if (bulletsLoaded == 0) return false;
		bulletsLoaded--;
		bullets--;
		return true;
    }
	
}
