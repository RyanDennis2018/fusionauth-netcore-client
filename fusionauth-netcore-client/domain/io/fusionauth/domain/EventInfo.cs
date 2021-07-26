/*
 * Copyright (c) 2018, FusionAuth, All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
 * either express or implied. See the License for the specific
 * language governing permissions and limitations under the License.
 */


using System.Collections.Generic;
using System;

namespace io.fusionauth.domain {

  /**
   * Information about a user event (login, register, etc) that helps identify the source of the event (location, device type, OS, etc).
   *
   * @author Brian Pontarelli
   */
  public class EventInfo {

    public string deviceDescription;

    public string deviceName;

    public string deviceType;

    public DateTimeOffset? instant;

    public string ipAddress;

    public Location location;

    public string os;

    public string userAgent;

    public EventInfo with(Action<EventInfo> action) {
      action(this);
      return this;
    }
  }
}