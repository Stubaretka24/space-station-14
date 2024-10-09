namespace Content.Shared.Weapons.Ranged.Events;

/// <summary>
/// Raised on a damageable that was hit by hitscan weapon
/// </summary>
public sealed class GotHitByHitscanEvent : EntityEventArgs
{
    public EntityUid WeaponUsed;
    public EntityUid UsedOn;

    public GotHitByHitscanEvent(EntityUid WeaponUsed, EntityUid UsedOn)
    {
        this.WeaponUsed = WeaponUsed;
        this.UsedOn = UsedOn;
    }
}
