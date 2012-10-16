NLog.RavenDb
=================

This is NLog custom target projekt build to empower NLog to send logs directly to RavenDb. 

Quick start
-----------

To use NLog.RavenDb:

-	Reference NLog.RavenDb and all its dependencies to your project.

-	Configure your NLog.config file like this:

**NLog.config**

	<?xml version="1.0" encoding="utf-8" ?>

	<nlog xmlns="http://www.nlog-project.org/schemas/NLog.xsd"
      xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">

		<extensions>
			<add assembly="NLog.RavenDb"/>
		</extensions>
		<targets>
			<target xsi:type="RavenDb" name="raven" Host="http://localhost:8080" Database="Logs" />
		</targets>
		<rules>
			<logger name="*" writeTo="raven" />
		</rules>

	</nlog>

-	Use Nlog as you would always do.


Developers
----------

Mateusz Świetlicki
http://mateusz.swietlicki.net

Copyright and license
---------------------

Copyright 2012 Mateusz Świetlicki .NET

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this work except in compliance with the License.
You may obtain a copy of the License in the LICENSE file, or at:

   http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.