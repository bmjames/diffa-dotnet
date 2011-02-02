﻿//
//  Copyright (C) 2011 LShift Ltd.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//         http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Net.LShift.Diffa.Participants
{
    public class EntityVersion : IDigest
    {
        public EntityVersion(string id, IList<String> attributes, DateTime lastUpdated, string digest)
        {
            ID = id;
            Attributes = attributes;
            LastUpdated = lastUpdated;
            Digest = digest;
        }

        public string ID { get; private set; }

        public IList<string> Attributes { get; private set; }

        public DateTime LastUpdated { get; private set; }

        public string Digest { get; private set; }

        public JObject ToJObject()
        {
            throw new NotImplementedException();
        }
    }
}
