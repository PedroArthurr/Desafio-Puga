
using UnityEngine;

[CreateAssetMenu(fileName = "New PlayerShipSettings", menuName = ("PlayerShipSettings"))]
public class PlayerShipSettings : ScriptableObject
{
    public ShipType myType;
    public BulletType bullet;
    public DroneType myDroneType;
    public SpecialType mySpecial;
    public SecondaryCannonType secondaryCannon;
    
    [Range(1, 5)] public int healthLevel;
    [Range(1, 5)] public int attackLevel;
    [Range(1, 5)] public int speedLevel;
    
}
