using UnityEngine;

public class DropdownObjects : MonoBehaviour
{
    [SerializeField] PlayerShipSettings settings;
    [Tooltip("Cannon Angles")]
    [SerializeField] GameObject cannon0, cannon30, cannon75, cannon120;
    [Tooltip("Drones")]
    [SerializeField] GameObject droneAtk, droneHlr, droneMgt, droneRkt;
    void Start()
    {
        settings.myDroneType = DroneType.Attack;
        settings.bullet = BulletType.NORMAL;
        settings.secondaryCannon = SecondaryCannonType.Angle0;
        settings.mySpecial = SpecialType.BOMB;
    }
    public void HandleInputDrone(int input)
    {
        if (input == 0)
        {
            settings.myDroneType = DroneType.Attack;
        }
        if (input == 1)
        {
            settings.myDroneType = DroneType.Healer;
        }
        if (input == 2)
        {
            settings.myDroneType = DroneType.Magnetic;
        }
        if (input == 3)
        {
            settings.myDroneType = DroneType.Rocket;
        }
        switch (input)
        {
            case 0:
                droneAtk.SetActive(true);
                droneHlr.SetActive(false);
                droneMgt.SetActive(false);
                droneRkt.SetActive(false);
                break;
            case 1:
                droneAtk.SetActive(false);
                droneHlr.SetActive(true);
                droneMgt.SetActive(false);
                droneRkt.SetActive(false);
                break;
            case 2:
                droneAtk.SetActive(false);
                droneHlr.SetActive(false);
                droneMgt.SetActive(true);
                droneRkt.SetActive(false);
                break;
            case 3:
                droneAtk.SetActive(false);
                droneHlr.SetActive(false);
                droneMgt.SetActive(false);
                droneRkt.SetActive(true);
                break;

        }
    }
    public void HandleInputWeapon(int input)
    {
        if (input == 0)
        {
            settings.bullet = BulletType.NORMAL;
        }
        if (input == 1)
        {
            settings.bullet = BulletType.ROCKET;
        }
    }
    public void HandleInputSpecial(int input)
    {
        if (input == 0)
        {
            settings.mySpecial = SpecialType.BOMB;
        }
        if (input == 1)
        {
            settings.mySpecial = SpecialType.FIRE;
        }
        if (input == 2)
        {
            settings.mySpecial = SpecialType.LAZER;
        }
    }
    public void HandleInputCannonAngle(int input)
    {
        if (input == 0)
        {
            settings.secondaryCannon = SecondaryCannonType.Angle0;
        }
        if (input == 1)
        {
            settings.secondaryCannon = SecondaryCannonType.Angle30;
        }
        if (input == 2)
        {
            settings.secondaryCannon = SecondaryCannonType.Angle75;
        }
        if (input == 3)
        {
            settings.secondaryCannon = SecondaryCannonType.Angle120;
        }
        if (input == 4)
        {
            settings.secondaryCannon = SecondaryCannonType.none;
        }
        switch (input)
        {
            case 0:
                cannon0.SetActive(true);
                cannon30.SetActive(false);
                cannon75.SetActive(false);
                cannon120.SetActive(false);

                break;
            case 1:
                cannon0.SetActive(false);
                cannon30.SetActive(true);
                cannon75.SetActive(false);
                cannon120.SetActive(false);

                break;
            case 2:
                cannon0.SetActive(false);
                cannon30.SetActive(false);
                cannon75.SetActive(true);
                cannon120.SetActive(false);
                break;

            case 3:
                cannon0.SetActive(false);
                cannon30.SetActive(false);
                cannon75.SetActive(false);
                cannon120.SetActive(true);
                break;

            case 4:
                cannon0.SetActive(false);
                cannon30.SetActive(false);
                cannon75.SetActive(false);
                cannon120.SetActive(false);
                break;
        }

    }

}
