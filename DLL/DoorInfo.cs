﻿/*
  GameSrv: A BBS Door Game Server
  Copyright (C) 2002-2013  Rick Parrish, R&M Software

  This file is part of GameSrv.

  GameSrv is free software: you can redistribute it and/or modify
  it under the terms of the GNU General Public License as published by
  the Free Software Foundation, either version 3 of the License, or
  any later version.

  GameSrv is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.

  You should have received a copy of the GNU General Public License
  along with GameSrv.  If not, see <http://www.gnu.org/licenses/>.
*/
using RandM.RMLib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace RandM.GameSrv
{
    public class DoorInfo : ConfigHelper
    {
        public string Command { get; set; }
        public int ForceQuitDelay { get; set; }
        public string Name { get; set; }
        public bool Native { get; set; }
        public string Parameters { get; set; }
        public ProcessWindowStyle WindowStyle { get; set; }

        public DoorInfo(string door)
            : base(ConfigSaveLocation.Relative, StringUtils.PathCombine("doors", door.ToLower() + ".ini"))
        {
            Command = "";
            ForceQuitDelay = 5;
            Name = "";
            Native = true;
            Parameters = "";
            WindowStyle = ProcessWindowStyle.Minimized;

            Load("DOOR");
        }
    }
}