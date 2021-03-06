﻿using ProtoBuf;
using VRage.ObjectBuilders;

namespace VRage.Game
{
    [ProtoContract]
    [MyObjectBuilderDefinition]
    public class MyObjectBuilder_WeatherComponent : MyObjectBuilder_SessionComponent
    {
        [ProtoMember]
        public bool WeatherEnabled;
    }
}
