﻿//
// Copyright (c) 2018 deltaDNA Ltd. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

#if !UNITY_4_5 && !UNITY_4_6 && !UNITY_4_7
using NUnit.Framework;

namespace DeltaDNA {

    public class UtilsTest {

        [Test]
        public void MissingUrlSchemasGetFixed() 
        {
            Assert.That(Utils.FixURL("collectURL"), Is.EqualTo("https://collectURL"));
        }

        [Test]
        public void HttpUrlsGetChangedToHttps() 
        {
            Assert.That(Utils.FixURL("http://collectURL"), Is.EqualTo("https://collectURL"));
        }

        [Test]
        public void HttpsUrlsStayUntouched() 
        {
            Assert.That(Utils.FixURL("https://collectURL"), Is.EqualTo("https://collectURL"));
        }
    }
}
#endif
