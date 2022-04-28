namespace DeathRecap {
    public enum Opcodes : ushort {
        StatusEffectList = 0xd2,
        StatusEffectList2 = 0x182,
        StatusEffectList3 = 0x299,
        BossStatusEffectList = 0x2b4,
        Ability1 = 0x398,
        Ability8 = 0x359,
        Ability16 = 0x260,
        Ability24 = 0x209,
        Ability32 = 0x39f,
        ActorCast = 0x163,
        EffectResult = 0x309,
        EffectResultBasic = 0xa8,
        ActorControl = 0x16f,
        ActorControlSelf = 0x3ae,
        ActorControlTarget = 0x1b2,
        UpdateHpMpTp = 0x28b,
        PlayerSpawn = 0x18f,
        NpcSpawn = 0x2b1,
        NpcSpawn2 = 0x83,
        ActorMove = 0x397,
        ActorSetPos = 0x317,
        ActorGauge = 0x2a7,
        PresetWaymark = 0x68,
        Waymark = 0x28f,
        SystemLogMessage = 0x1ad,
    }
}
