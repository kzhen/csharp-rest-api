﻿using Newtonsoft.Json;

namespace MessageBird.Resources
{
    sealed class Hlr : Resource
    {
        public Hlr()
            : base("hlr")
        {
        }

        public Hlr(string id)
            : this()
        {
            Id = id;
        }

        public Hlr(Objects.Hlr hlr)
            : this()
        {
            Object = hlr;
        }

        private Objects.Hlr hlr;
        public override object Object
        {
            get
            {
                return hlr;
            }
            protected set
            {
                hlr = (Objects.Hlr)value;
                Id = hlr.Id;
            }
        }

        public override void Deserialize(string resource)
        {
            Object = JsonConvert.DeserializeObject<Objects.Hlr>(resource);
        }
    }
}
