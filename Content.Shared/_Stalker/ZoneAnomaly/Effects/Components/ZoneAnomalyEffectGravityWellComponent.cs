﻿using Content.Shared.Whitelist;
using Robust.Shared.Serialization;

namespace Content.Shared._Stalker.ZoneAnomaly.Effects.Components;

[RegisterComponent]
public sealed partial class ZoneAnomalyEffectGravityWellComponent : Component
{
    [DataField]
    public EntityWhitelist? Whitelist;

    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public float Distance = 3f;

    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public float Radial = 10f;

    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public ZoneAnomalyEffectGravityWellGradient Gradient = ZoneAnomalyEffectGravityWellGradient.Default;

    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public TimeSpan PeriodTime;

    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public TimeSpan Period = TimeSpan.FromSeconds(0.5);
}

[Serializable, NetSerializable]
public enum ZoneAnomalyEffectGravityWellGradient
{
    Default,
    Liner,
    ReversedLiner,
}
